using ConsoleApp35.characters;
using ConsoleApp35.Enemies;
using ConsoleApp35.Weapons;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp35
{
    internal class Program
    {
        static Player SelectCharacter()
        {
            var CharacterInput = "";
            Console.WriteLine("Выберите персонажа:" +
            "\n|2 - Копейщик" +
            "\n|1 - Воин" +
            "\n|q - покинуть игру...\n");
            CharacterInput = Console.ReadLine();

            Weapon weapon = null;
            Player character = null;
            switch (CharacterInput)
            {
                case "2":
                    character = new Spearman();
                    weapon = WeaponSelect();
                    character.Weapon = weapon;
                    break;

                case "1":
                    character = new Warrior();
                    weapon = WeaponSelect();
                    character.Weapon = weapon;
                    break;

                case "q":
                    Console.WriteLine("\n|Сохранение игровых данных не предусмотренно...\n\n");
                    Environment.Exit(0);
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

        static int EndDamage(Enemy enemy)
        {

            Random rnd = new Random();
            int value = rnd.Next(1, 4);
            if (value == 1)
            {
                enemy.Damage += (enemy.Damage / 2);
            }
            else if (value == 2)
            {
                enemy.Damage -= (enemy.Damage / 2);
            }
            else
            {
                enemy.Damage += 0;
            }
            return enemy.Damage;
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
            Player previous = character;
            Weapon weapon = null;

            do
            {
                if (character == null)
                {
                    character = SelectCharacter();
                    //if (previous == character)
                    //{
                    //    Console.WriteLine("|данный персонаж мертв, выберите пока что другого");                 не работает
                    //    character = SelectCharacter();
                    //    continue;
                    //}
                    //Console.WriteLine(character);
                    continue;
                }

                Console.WriteLine($"\n|здоровье персонажа: {character.Health}хп");
                if (character.Health <= 0)
                {
                    Console.WriteLine("|данный персонаж мертв\n :(\n");
                    previous = character;
                    Console.WriteLine(previous);
                    character = null;
                    continue;
                }
                if (enemy == null)
                {
                    enemy = EnemySelect();
                }

                Console.WriteLine($"|Текущий Персонаж: {character.Name}");
                Console.Write($"|вы встретили {enemy.Name}a, он настроен враждебно\n\n");
                Console.WriteLine("Доступные команды:\n" +
                 "\n|1 - атаковать..." +
                 "\n|2 - сменить оружие..." +
                 "\n|3 - сменить персоажа..." +
                 "\n|q - покинуть игру...\n");
                input = Console.ReadLine();
                Console.WriteLine($"\n|Текущий Персонаж: {character.Name}");
                Console.Write($"\n|{enemy.Name} ");
                enemy.Damage = EndDamage(enemy);
                enemy.BaseAttack();
                character.Health -= enemy.Damage;

                switch (input)
                {
                    case "1":
                        Console.Write($"\n|{character.Name} ");
                        character.attack();
                        enemy.Health -= character.FullDamage;
                        if (enemy.Health < 0)
                        {
                            enemy.Health = 0;
                        }
                        Console.WriteLine($"|оставшееся здоровье противника: {enemy.Health}хп\n");
                        if (enemy.Health <= 0)
                        {
                            Console.WriteLine($"{enemy.Name} is dead\n :)\n");
                            enemy = null;
                            continue;
                        }
                        break;

                    case "2":
                        character.Weapon = WeaponSelect();
                        break;

                    case "3":
                        character = SelectCharacter();
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
    
