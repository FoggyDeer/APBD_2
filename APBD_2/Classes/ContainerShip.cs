using APBD_2.Exceptions;

namespace APBD_2.Classes;

public class ContainerShip
{
    public static readonly List<Container> Containers = new();
    public double MaxSpeed { get; }
    public double MaxContainerCount { get; }
    public double MaxContainersWeight { get; }
    private double _currentWeight = 0;

    ContainerShip(double maxSpeed, int maxContainerCount, double maxContainersWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxContainersWeight = maxContainersWeight;
    }

    public void AddContainer(Container container)
    {

        if (MaxContainerCount <= Containers.Count)
            throw new OverfillException("Max containers count limit exceeded!");
        if(MaxContainersWeight <= _currentWeight + container.Mass)
            throw new OverfillException("Max containers weight limit exceeded!");
        Containers.Add(container);
        _currentWeight += container.Mass;
    }
    
    public void AddContainers(List<Container> containers)
    {
        foreach(Container con in containers)
        {
            AddContainer(con);
        }
    }

    public void RemoveContainer(int id)
    {
        Containers.RemoveAt(id);
    }

    public void ReplaceContainer(Container container, int replacedContainerId)
    {
        Containers.RemoveAt(replacedContainerId);
        Containers.Insert(replacedContainerId, container);
    }

    public void MoveContainer(ContainerShip ship, int containerId)
    {
        try
        {
            ship.AddContainer(Containers[containerId]);
            Containers.RemoveAt(containerId);
        }
        catch (OverfillException exception)
        {
            Console.WriteLine(exception.StackTrace);
        }
    }

    public override string ToString()
    {
        string result = $"Max Speed: {MaxSpeed},\nMax Container Count: {MaxContainerCount}\nMax Containers Weight: {MaxContainersWeight}\n";
        Containers.ForEach(i => result += ($"{i}\n"));
        return result;
    }
}