using ConsoleApp35.characters;
using ConsoleApp35.Enemies;
using ConsoleApp35.Weapons;
using Microsoft.VisualBasic;
using System;
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

            Weapon weapon = null;
            Player character = null;
            weapon = WeaponSelect();

            switch (characterChoise)
            {
                case "2":
                    character = new Spearman();
                    character.Weapon = weapon;
                    break;

                case "1":
                    character = new Warrior();
                    character.Weapon = weapon;
                    break;

                case "q":
                    Console.WriteLine("\n|Сохранение игровых данных не предусмотренно...\n\n");
                    break;
            }
            return character;
        }
        static Weapon WeaponSelect()
        {
            Weapon weapon = null;
            Console.WriteLine("\n|Выберите оружие из доступных:" +
                "\n|3 - Меч" +
                "\n|2 - Копьё" +
                "\n|1 - Кулаки\n");
            var input = Console.ReadLine();
            switch (input)
            {
                case "3":
                    weapon = new Sword();
                    break;
                case "2":
                    weapon = new Spear();
                    break;
                case "1":
                    weapon = null;
                    break;

            }
            return weapon;
        }

        static Enemy EnemySelect()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            Enemy enemy = null;
            switch (value)
            {

                case 1:
                    enemy = new Goblin();
                    break;

                case 2:
                    enemy = new Skeleton();
                    break;
            }
            return enemy;
        }

        static void Main(string[] args)
        {
            string input = null;
            Player character = null;
            Enemy enemy = null;
            do
            {
                character = SelectCharacter();
                if (character == null)
                {
                    Console.WriteLine("Персонаж не выбран. Завершение игры.");
                    break;
                }

                Console.WriteLine($"\n|здоровье персонажа: {character.Health}хп");
                if (character.Health <= 0)
                {
                    Console.WriteLine("данный персонаж мертв\n :(\n");
                    continue;
                }
                if (enemy == null)
                {
                    enemy = EnemySelect();
                }

                Console.WriteLine($"|Текущий Персонаж: {character.Name}");
                Console.Write($"|вы встретили {enemy.Name}, он настроен враждебно\n\n");
                Console.WriteLine("Доступные команды:\n" +
                 "\n|1 - атаковать..." +
                 "\n|q - покинуть игру...\n");
                input = Console.ReadLine();
                Console.WriteLine($"\n|Текущий Персонаж: {character.Name}");

                Console.Write($"\n|{enemy.Name} ");
                enemy.BaseAttack();
                character.Health -= enemy.Damage;

                switch (input)
                {
                    case "1":
                        Console.Write($"\n|{character.Name} ");
                        character.attack();
                        enemy.Health -= character.FullDamage;
                        Console.WriteLine($"{enemy.Health} оставшееся здоровье: {enemy.Health}хп\n");
                        if (enemy.Health <= 0)
                        {
                            Console.WriteLine($"{enemy.Name} is dead\n :)\n");
                            enemy = null;
                            continue;
                        }
                        break;

                    case "0":
                        Console.Clear();
                        break;

                    case "q":
                        Console.WriteLine("\n|Сохранение игровых данных не предусмотренно...");
                        break;
                }

                if (character.Health <= 0)
                {
                    Console.WriteLine("Персонаж погиб. Выберите нового персонажа.");
                }

            } while (input != "q");
        }

    }
}
    
