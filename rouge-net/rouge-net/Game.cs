using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rouge_net
{
    internal class Game
    {
        private Role AskRole()
        {
            Role choice = Role.Criminal;
            while (true)
            {
                Console.WriteLine("Select role for your character:");
                Console.WriteLine($"1: {Role.Criminal.ToString()}");
                Console.WriteLine($"2: {Role.Rouge.ToString()}");
                Console.WriteLine($"3: {Role.Cook.ToString()}");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    choice = Role.Criminal;
                }
                else if (answer == "2")
                {
                    choice = Role.Rouge;
                }
                else if (answer == "3")
                {
                    choice = Role.Cook;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                    continue;
                }

                return choice;
            }
        }
        private string AskName()
        {
            string nameAnswer;
            while (true)
            {
                Console.Write("Enter your name: ");
                nameAnswer = Console.ReadLine();

                if (String.IsNullOrEmpty(nameAnswer))
                {
                    Console.WriteLine("Name cannot be empty!");
                    continue;
                }

                bool nameOk = true;
                for (int i = 0; i < nameAnswer.Length; i++)
                {
                    char letter = nameAnswer[i];
                    if (Char.IsLetter(letter) == false)
                    {
                        nameOk = false;
                        break;
                    }
                }
                if (nameOk == false)
                {
                    Console.WriteLine("Name can only contain letters!");
                    continue;
                }

                return nameAnswer;
            }
        }
        private Species AskSpecies()
        {
            Species choice = Species.Maegu;
            while (true)
            {
                Console.WriteLine("Select species for your character:");
                Console.WriteLine($"1: {Species.Maegu.ToString()}");
                Console.WriteLine($"2: {Species.Woosa.ToString()}");
                Console.WriteLine($"3: {Species.Nova.ToString()}");
                Console.WriteLine($"4: {Species.Berserker.ToString()}");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    choice = Species.Maegu;
                }
                else if (answer == "2")
                {
                    choice = Species.Woosa;
                }
                else if (answer == "3")
                {
                    choice = Species.Nova;
                }
                else if (answer == "4")
                {
                    choice = Species.Berserker;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }

                return choice;
            }
        }
        void Run()
        {
            PlayerCharacter player = new PlayerCharacter();
            player.name = AskName();
            player.species = AskSpecies();
            player.role = AskRole();
        }
    }
}