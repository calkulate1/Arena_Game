using ConsoleApp35.Weapons;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace ConsoleApp35
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Player character = new Player();
//            var weapon = new Sword();
            var weapon = new Spear();
            character.Weapon = weapon;
            string input = "NULL";

            Console.WriteLine($"Персонаж: {character.Name}");
            Console.WriteLine("Доступные команды:\n" +
               "\n|2 - вывести данное меню снова" +
               "\n|1 - атаковать..." +
               "\n|0 - покинуть игру...\n");
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "1": 
                        Console.Write($"\n{character.Name} ");
                        character.attack(); break;
                    case "2":
                        Console.WriteLine("\nДоступные команды:\n" +
               "\n2 - вывести данное меню снова..." +
               "\n1 - атаковать..." +
               "\n0 - покинуть игру...\n"); break;
                }
                Console.WriteLine("Введите следующую команду...\n");
            }
            while (input != "0");
        }
    }
}
    
