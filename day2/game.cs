using System;



    class GameFlow
    {
        public static void StartGame()
        {
            Console.WriteLine("Game Begins!\n");

            for (int enemy = 1; enemy <= 10; enemy++)
            {
                if (enemy == 4)
                {
                    Console.WriteLine("Enemy 4 is invisible... Skipping!");
                    continue;
                }

                Console.WriteLine("Player killed E" + enemy);
            }

            Console.WriteLine("\n Game End!");
        }
    }

