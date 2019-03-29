using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6ex3akshabaevbymyself
{
    public class Gameobject
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Gameobject(int x, int y, char sign, ConsoleColor color)
        {
            //body = new List<Point>();
            //Point p = new Point(x, y);
            //body.Add(p);

            body = new List<Point>
            {
                new Point(x, y)
            };
            this.sign = sign;
            this.color = color;
        }

        public void Draw(int level)
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                //for (int i = 0; i < level; i++)
            }
        }
        public bool IsCollisionWithObject(Gameobject obj)
        {
            foreach (Point p in obj.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;
        }
    }
}
