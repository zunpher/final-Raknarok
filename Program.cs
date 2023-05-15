using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter amount of city: ");
        int numberOfCity = int.Parse(Console.ReadLine());

        int[] city = new int[numberOfCity];

        for (int i = 0; i < numberOfCity; i++)
        {
            Console.Write("Enter city name: ");
            string cityName = Console.ReadLine();

            Console.Write("Enter the number of cities in contact with this city: ");
            int numberOfContact = int.Parse(Console.ReadLine());

            int[] contactIDs = new int[numberOfContact];
            for (int j = 0; j < numberOfContact; j++)
            {
                Console.Write("Enter the ID of city in contact: ");
                int contactID = int.Parse(Console.ReadLine());
            }

            if (contactIDs[0] != contactIDs[1]) {
                    Console.WriteLine("Invalid ID");
                }
        }
    }
}
