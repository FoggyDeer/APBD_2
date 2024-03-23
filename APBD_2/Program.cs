// See https://aka.ms/new-console-template for more information

using APBD_2.Classes;

public class program
{
    static string input;
    static List<Container> containers = new();
    static List<ContainerShip> ships = new();
    public static void main(string[] args)
    {
        while ((input = Console.ReadLine()) != "exit")
        {
            Console.WriteLine("Lista kontenerowców:");
            if (ships.Count == 0)
                Console.WriteLine("Brak");
            else
            {
                for (int i = 0; i < 0; i++)
                {
                    Console.WriteLine($"{i}.{ships[i]}");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Lista kontenerów:");
            if (containers.Count == 0)
                Console.WriteLine("Brak");
            else
            {
                for (int i = 0; i < 0; i++)
                {
                    Console.WriteLine($"{i}.{containers[i]}");
                }
            }

            Console.WriteLine("Możliwe akcje:");
            if (ships.Count == 0)
            {
                Console.WriteLine("1. Dodaj kontenerowiec");
                input = Console.ReadLine();
                if (int.Parse(input) == 1)
                {
                    ships.Add(CreateShip());
                }
            }
            else
            {
                Console.WriteLine("1. Dodaj kontenerowiec\n2. Usun kontenerowiec\n3. Dodaj kontener");
                input = Console.ReadLine();
                if (int.Parse(input) == 1)
                {
                    ships.Add(CreateShip());
                } 
                else if (int.Parse(input) == 2)
                {
                    ships.RemoveAt(SelectShip());
                }
                else if (int.Parse(input) == 3)
                {
                    int index = SelectShip();
                    
                }
            }
        }
    }

    public static ContainerShip CreateShip()
    {
        double maxSpeed;
        int maxContainerCount;
        double maxContainersWeight;
        Console.WriteLine("Enter data:");
        Console.Write("Max speed: ");
        maxSpeed = double.Parse(Console.ReadLine());
        Console.Write("Max container count: ");
        maxContainerCount = int.Parse(Console.ReadLine());
        Console.Write("Max containers weight: ");
        maxContainersWeight = double.Parse(Console.ReadLine());
        return new ContainerShip(maxSpeed, maxContainerCount, maxContainersWeight);
    }

    public static int SelectShip()
    {
        ShowShips();
        return int.Parse(Console.ReadLine());
    }

    public static void ShowShips()
    {
        for (int i = 0; i < ships.Count; i++)
        {
            Console.WriteLine($"{i}.{ships[i]}");
        }
    }

    public static void CreateContainer()
    {
        Console.WriteLine("Wybierz typ:");
        Console.WriteLine("1.L | 2.G | 3.C");
        switch (Console.ReadLine()[0])
        {
            case 'L':
                double Mass, Height, TareWeight, Depth, MaxLoadWeight;
                ContainerType type = ContainerType.L;
                Console.WriteLine("Enter data:");
                Console.Write("Height: ");
                Height = int.Parse(Console.ReadLine());
                Console.Write("Tare weight: ");
                TareWeight = double.Parse(Console.ReadLine());
                Console.Write("Depth: ");
                Depth = double.Parse(Console.ReadLine());
                Console.Write("MaxLoadWeight: ");
                MaxLoadWeight = double.Parse(Console.ReadLine());
                containers.Add(new Container(Height, TareWeight, Depth, MaxLoadWeight, type));
                break;
        }
    }
}
