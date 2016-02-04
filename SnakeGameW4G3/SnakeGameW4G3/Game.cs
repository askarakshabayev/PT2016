using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameW4G3
{
    public class Game
    {
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public bool GameOver = false;

        public Game()
        {
            Init();
            Play();
        }

        public void Init()
        {
            food.SetNewPosition();
        }

        public void Play()
        {
            while (!GameOver)
            {
                Draw();
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);

                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);

                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);

                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);

                if (button.Key == ConsoleKey.F5)
                    wall.LoadLevel(2);
                GameOver = snake.CollistionWithWall();
            }
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Game Over!!!!");
            Console.ReadKey();
        }
        public void Draw()
        {
            Console.Clear();
            food.Draw();
            snake.Draw();
            wall.Draw();
        }
    }
}
