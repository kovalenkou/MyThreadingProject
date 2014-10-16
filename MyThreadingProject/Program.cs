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
        public bool? Next()
        {
            int res = 0;
            Thread.Sleep(200);
            res = new Random().Next(0, 3);
            switch (res)
            {
                case 0:
                    return false;
                    //break;
                case 1:
                    return true;
                    //break;
                case 2:
                    return null;
                default:
                    break;
            }
            return null;

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            bool? flag;
            Queue<bool?> q = new Queue<bool?>();
            do
            {
                Thread t1 = new Thread(() => Console.WriteLine("Hello"));
                t1.Start();
                Thread t2 = new Thread(() => Console.WriteLine(new Test().Next()));
                t2.Start();
                flag = new Test().Next();
                //Thread t3 = new Thread();
                //Thread t4 = new Thread();

                Console.WriteLine(flag);

            } while (flag != null);
            if (flag != null)
            {
                q.Enqueue(flag);
            }
            foreach (bool? f in q)
                Console.WriteLine(f);

        }
    }
}
