using ConsoleApp35.characters;
using ConsoleApp35.Weapons;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ConsoleApp35
{
    internal class Program
    {
        static Player SelectCharacter()
        {
            var characterChoise = "";
            Console.WriteLine("Выберите персонажа:" +
            "\n|2 - Копейщик" +
            "\n|1 - Воин" +
            "\n|q - покинуть игру...\n");
            characterChoise = Console.ReadLine();
            Player character = null;
            Weapon weapon = null;
            switch (characterChoise)
            {
                case "2":
                    character = new Spearman();
                    weapon = new Spear();
                    character.Weapon = weapon;
                    break;

                case "1":
                    character = new Warrior();
                    weapon = new Sword();
                    character.Weapon = weapon;
                    break;

                case "q":
                    Console.WriteLine("\n|Сохранение игровых данных не предусмотренно...\n\n");
                    break;
            }
            return character;
        }

        static void Main(string[] args)
        {
            string input = "NULL";

            do
            {
                var character = SelectCharacter();
                if (character.Health == 0)
                {
                    Console.WriteLine("This character is dead\n :(\n");
                    character = SelectCharacter();
                }
                Console.WriteLine($"\n|Текущий Персонаж: {character.Name}");
                Console.WriteLine("Доступные команды:\n" +
                 "\n|1 - атаковать..." +
                 "\n|q - покинуть игру...\n");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write($"\n|{character.Name} ");
                        character.attack();
                        break;
                    case "0":
                        Console.Clear();
                        break;
                    case "q":
                        Console.WriteLine("\n|Сохранение игровых данных не предусмотренно...");
                        break;
                }


            }
            while (input != "q");

            
        }
    }
}
    
