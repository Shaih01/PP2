using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6ex3akshabaevbymyself
{
    public class Game
    {
        public bool isAlive;
        List<Gameobject> g_objects;
        public Snake snake;
        public Food food;
        public Wall wall;
        public int score;
        public int level = 1;
        public Game()
        {
            g_objects = new List<Gameobject>();
            snake = new Snake(20, 10, '*', ConsoleColor.White);
            food = new Food(0, 0, 'o', ConsoleColor.Cyan);
            wall = new Wall('#', ConsoleColor.Green);
            wall.LoadLevel();
            while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                food.Generate();

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);

            isAlive = true;
        }

        public void Start()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("        Welcome to Snake");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                Draw();
                Console.SetCursorPosition(15, 25);
                Console.Write("Score: {0}. Current level:{1}", score, level);
                keyInfo = Console.ReadKey();
                if (snake.IsCollisionWithObject(food))
                {
                    score += 10;
                    snake.body.Add(new Point(0, 0));
                    while(food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                    {
                        food.Generate();
                    }
                    if(snake.body.Count % 3 == 0)
                    {
                        wall.NextLevel();
                        if(level < 3)
                            level++;
                    }
                }
                if(snake.IsCollisionWithObject(wall))
                {
                    isAlive = false;
                }
                snake.Move(keyInfo);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("WASTED");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Your Score: {0}", score);
            Console.WriteLine("Press ESC to quit game");

        }
        public void Draw()
        {
            Console.Clear();
            foreach(Gameobject g in g_objects)
            {
                g.Draw(level);
            }
        }
    }
}
