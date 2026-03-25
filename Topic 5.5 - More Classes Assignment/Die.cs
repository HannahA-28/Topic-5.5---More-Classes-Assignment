using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5___More_Classes_Assignment
{
    public class Die
    {
        private Random _generator;
        private int _roll;
        private ConsoleColor _color;

        // Constructor
        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _color = ConsoleColor.Gray;
        }

        public int Roll
        {
            get { return _roll; }
            //set { _roll = value; }
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }


        public void RollDie()
        {
            _roll = _generator.Next(1, 7);
        }



        public void DrawRoll()
        {
            Console.ForegroundColor = _color;
            if (_roll == 1)
            {
                Console.WriteLine("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
            }
            else if (Roll == 3)
            {
                Console.WriteLine("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----\r\n");
            }
            else if (Roll == 4)
            {
                Console.WriteLine("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----\r\n");
            }
            else if (Roll == 5)
            {
                Console.WriteLine("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----\r\n");
            }
            else
            {
                Console.WriteLine("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
            }


            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
