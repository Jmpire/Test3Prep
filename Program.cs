using System;
using System.Collections.Generic;
using System.Text;

namespace Test3Prep
{
    class Program
    {
        class Queue
        {
            // Attributes
            public Queue<int> ages;

            public Queue()
            {
                ages = new Queue<int>();
            }
            // Adding
            public void Add(int x)
            {
                ages.Enqueue(x);
            }
            // Removing
            public int Remove()
            {
                int first = ages.Dequeue();
                return first;
            }
            // Viewing
            public void View()
            {
                foreach (int age in ages)
                {
                    Console.Write(age + " ");
                }
            }
            // isEmpty
            public bool isEmpty()
            {
                return ages.Count > 0;
            }
        }
        class List {
            List<int> positions;

            public List()
            {
                positions = new List<int>();
            }

            // Return new list with odd elements
            public List<int> Copy()
            {
                List<int> odds = new List<int>();
                foreach (int pos in positions)
                {
                    if (pos % 2 != 0)
                    {
                        odds.Add(pos);
                    }
                }
                return odds;
            }
            // Add
            public void Add(int y)
            {
                positions.Add(y);
            }
            // Count how many times an element occurs in a list
            public int Count(int x)
            {
                int count = 0;
                if (positions.Contains(x))
                {
                    foreach (int pos in positions)
                    {
                        if (pos == x)
                        {
                            count++;
                        }
                    }
                    return count;
                }
                else
                {
                    throw new Exception("Number is not in our list");
                }
            }
            // Get the average of the elements that less or equal to a given parameter
            public double Average(int value)
            {
                int sum = 0;
                int count = 0;
                foreach(int pos in positions)
                {
                    if(pos <= value)
                    {
                        sum += pos; // sum = sum + pos
                        count++;
                    }
                }
                return sum / count;
            }
        }
        static void Stacks()
        {
            /* Stacks
            LIFO Last In, First Out
            Peek() Element at the top without removing it
            Pop() Element at the top and removes it
            Push() Add a new element
            Clear() removes all elements
            Contains()
            ToArray()
             */
            Stack<int> nums = new Stack<int>();
            // Add the elements
            for (int x = 1; x < 6; x++)
            {
                nums.Push(x);
            }
            Console.WriteLine("Number to be removed: " + nums.Pop());
            // View elements
            Console.WriteLine("Stack: ");
            foreach (int number in nums)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nTop element: " + nums.Peek());

            // Stack of strings
            Stack<string> names = new Stack<string>();
            names.Push("A");
            names.Push("B");
            names.Push("C");
            names.Push("D");
            foreach (string name in names)
            {
                Console.Write(names + " ");
            }
        }
        static void Queues()
        {
            /* Queues
             * FIFO
             * Enqueue Add a new element
             * Dequeue removes the element at the beginning and returns it
             * Peek() 
             * ToArray()
            */

            Queue<int> ages = new Queue<int>();
            ages.Enqueue(10);
            ages.Enqueue(20);
            ages.Enqueue(14);

            Console.WriteLine("Queue: ");
            Console.WriteLine(ages.Dequeue());
            foreach (int age in ages)
            {
                Console.Write(age + " ");
            }
        }
        static void LinkedList()
        {
            LinkedList<double> prices = new LinkedList<double>();
            prices.AddLast(35.65);
            prices.AddLast(12.99);
            prices.AddLast(56.0);

            prices.Remove(35.65);
            prices.RemoveFirst();
            prices.RemoveLast();

        }
        static void Main(string[] args)
        {
            List l = new List();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);

            Console.WriteLine(String.Join(",", l.Copy()));
            Console.WriteLine(l.Count(2));
            Console.WriteLine("Average: " + l.Average(3));


            // Print out the elements
            // Queue/Stack should maintain it's original state

            Stack<int> nums = new Stack<int>();
            nums.Push(1);
            nums.Push(2);
            nums.Push(3);

            Stack<int> aux = new Stack<int>();
            // View top element, remove it and push it to secondary stack
            while (nums.Count != 0)
            {
                int top = nums.Pop();
                Console.Write(top + " ");

                aux.Push(top); // Add element
            }
            // Move from 2nd stack to original stack
            while (aux.Count != 0)
            {
                nums.Push(aux.Pop());
            }

            // Same question but for queues
            Queue<string> names = new Queue<string>();
            names.Enqueue("A");
            names.Enqueue("B");
            names.Enqueue("C");

            Queue<string> aux2 = new Queue<string>();
            while (names.Count != 0)
            {
                string name = names.Dequeue();
                Console.Write(name + " ");
                aux2.Enqueue(name);
            }
            while (aux2.Count != 0)
            {
                names.Enqueue(aux2.Dequeue());
            }
        }
    }
}
