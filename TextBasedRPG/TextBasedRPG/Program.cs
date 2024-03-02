using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPG
{
    internal class Program
    {
        static int playerHealth = 100;
        static int enemyHealth = 50;
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text-Based RPG!");

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine($"Player Health: {playerHealth} | Enemy Health: {enemyHealth}");
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Attack();
                        break;
                    case 2:
                        Heal();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! The enemy attacks you, Try again.");
                        break;
                }

                if (enemyHealth > 0)
                    EnemyTurn();
            }

            if (playerHealth > 0)
                Console.WriteLine("Congratulations! You defeated the enemy!");
            else
                Console.WriteLine("Game Over! You were defeated by the enemy!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void Attack()
        {
            int damage = random.Next(5, 11);
            enemyHealth -= damage;
            Console.WriteLine($"You attacked the enemy and dealt {damage} damage!");
        }

        static void Heal()
        {
            int healing = random.Next(10, 21);
            playerHealth += healing;
            Console.WriteLine($"You healed yourself and gained {healing} health!");
        }

        static void EnemyTurn()
        {
            int damage = random.Next(8, 15);
            playerHealth -= damage;
            Console.WriteLine($"The enemy attacked you and dealt {damage} damage!");
        }

    }
}
