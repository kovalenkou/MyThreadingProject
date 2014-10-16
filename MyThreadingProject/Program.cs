using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThreadingProject
{
    class Test
    {
        public static void Next(object num)
        {
            int n = (int)num;
            Console.WriteLine("Поток № {0} запущен", n);
            //Thread.Sleep(1000);
            int res = 0;
            bool? flag;
            Queue<bool?> q = new Queue<bool?>();
            do
            {
                res = new Random().Next(0, 500);
                res %= 11;
                switch (res)
                {
                    case 1:
                        {
                            flag = false;
                            break;
                        }
                    case 3:
                        {
                            flag = true;
                            break;
                        }
                    default:
                        {
                            flag = null;
                            break;
                        }
                }
                if (flag != null)
                {
                    q.Enqueue(flag);
                }
            } while (flag != null);
            Console.WriteLine("++++++++++++++");
            foreach (bool? f in q)
                Console.WriteLine(f);
            Console.WriteLine("---------------");
            Console.WriteLine("Завершен поток № {0}", n);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Thread t = new Thread(Test.Next);
                    t.Start(i as object);
                    //Thread t = new Thread(() => Test.Next(i));
                    //t.Start();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
