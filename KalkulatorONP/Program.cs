using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorONP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator ONP");
            Console.ReadLine();
        }

        internal class Node
        {
            public Node(int value)
            {
                this.value = value;
                operatorType = null;
            }
            public Node(char op)
            {
                operatorType = op;
                value = null;
            }

            private char? operatorType;
            public int? value;

        }

        public int calculate(List<Node> list)
        {
            Stack<Node> stack = new Stack<Node>();
            foreach (var node in list)
            {

            }

            return 0;
        }

        public List<Node> infixToPostfix(string infix)
        {
            return new List<Node>();
        }
    }
}
