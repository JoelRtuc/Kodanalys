using System;

namespace Kodanalys
{
    class program
    {
        static string[] allUsers = new string[10];
        static int amountOfUsers = 0;

        static void Main(string[] args)
        {
            bool programHalted = true;
            while (programHalted)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        string user = Console.ReadLine();
                        if (amountOfUsers < 10)
                        {
                            allUsers[amountOfUsers] = user;
                            amountOfUsers++;
                        }
                        else
                        {
                            Console.WriteLine("Listan är full!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Användare:");
                        for (int i = 0; i < amountOfUsers; i++)
                        {
                            Console.WriteLine(allUsers[i]);
                        }
                        break;

                    case "3":
                        Console.Write("Ange namn att ta bort: ");
                        string userToRemove = Console.ReadLine();
                        int userCount = -1;
                        for (int i = 0; i < amountOfUsers; i++)
                        {
                            if (allUsers[i] == userToRemove)
                            {
                                userCount = i;
                                break;
                            }
                        }

                        if (userCount != -1)
                        {
                            for (int i = userCount; i < amountOfUsers - 1; i++)
                            {
                                allUsers[i] = allUsers[i + 1];
                            }
                            amountOfUsers--;
                        }
                        else
                        {
                            Console.WriteLine("Användaren hittades inte.");
                        }
                        break;

                    case "4":
                        Console.Write("Ange namn att söka: ");
                        string searchedUser = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < amountOfUsers; i++)
                        {
                            if (allUsers[i] == searchedUser)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            Console.WriteLine("Användaren finns i listan.");
                        }
                        else
                        {
                            Console.WriteLine("Användaren hittades inte.");
                        }
                        break;

                    case "5":
                        programHalted = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
