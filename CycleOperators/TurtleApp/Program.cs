using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.X = 100;
            Turtle.Speed = 8;

            int n = 3;
            //for (int i = 0; i < n; i++)
            //{
            //    Turtle.Move(100);
            //    Turtle.TurnRight();
            //    Turtle.Move(50);
            //    Turtle.TurnRight();
            //    Turtle.Move(100);
            //    Turtle.TurnLeft();
            //    Turtle.Move(50);
            //    Turtle.TurnLeft();
            //}

            //int w = 200;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Turtle.Move(w);
            //        Turtle.TurnRight();
            //    }

            //    w -= 50;
            //    Turtle.X += 25;
            //    Turtle.Y -= 25;
            //}

            Turtle.TurnRight();

            while (true)
            {
                while (Turtle.X < GraphicsWindow.Width)
                    Turtle.Move(100);

                Turtle.TurnRight();
                Turtle.TurnRight();

                while (Turtle.X > 0)
                    Turtle.Move(100);

                Turtle.TurnRight();
                Turtle.TurnRight();
            }
        }
    }
}
