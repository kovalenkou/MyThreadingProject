using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace MyThreadingProject
//{
    //class Test
    //{
    //    public static void Next(object num)
    //    {
    //        int n = (int)num;
    //        Console.WriteLine("Поток № {0} запущен", n);
    //        //Thread.Sleep(1000);
    //        int res = 0;
    //        bool? flag;
    //        Queue<bool?> q = new Queue<bool?>();
    //        do
    //        {
    //            res = new Random().Next(0, 500);
    //            res %= 11;
    //            switch (res)
    //            {
    //                case 1:
    //                    {
    //                        flag = false;
    //                        break;
    //                    }
    //                case 3:
    //                    {
    //                        flag = true;
    //                        break;
    //                    }
    //                default:
    //                    {
    //                        flag = null;
    //                        break;
    //                    }
    //            }
    //            if (flag != null)
    //            {
    //                q.Enqueue(flag);
    //            }
    //        } while (flag != null);
    //        Console.WriteLine("++++++++++++++");
    //        foreach (bool? f in q)
    //            Console.WriteLine(f);
    //        Console.WriteLine("---------------");
    //        Console.WriteLine("Завершен поток № {0}", n);
    //    }

    //    public static void HCFunk(object num)
    //    {
    //        int n = (int)num;
    //        for (int i = 0; i < 5; i++)
    //        {
    //            //Console.WriteLine("Поток № {0} запущен", n);

    //            Console.WriteLine("Поток № {0} вернул HashCode {1}", n, Thread.CurrentThread.GetHashCode().ToString());
    //            //Thread.Sleep(0);
    //            //Console.WriteLine("Завершен поток № {0}", n);
    //        }
    //    }

    //    static double res = 25.0;
    //    static double muneric = 5.0;
    //    static double pownum = 1.0;

    //    public static void Num()
    //    {
    //        Thread.Sleep(500);
    //        muneric = new Random().Next(1, 10);
    //        return;
    //    }

    //    public static void Pow()
    //    {
    //        Thread.Sleep(500);
    //        pownum = new Random().Next(1, 5);
    //        return;
    //    }

    //    public static void Result()
    //    {
    //        res = Math.Pow(muneric, pownum);
    //        Console.WriteLine("результат: {0}", res);
    //    }

    //    public static object locker = new object();

    //    public static void Go()
    //    {
    //        lock (locker)
    //        {
 
    //            Console.WriteLine(res / muneric);
    //            Thread.Sleep(1000);
    //        }
    //    }

    //}
    
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
//--- проверка на LOCK
            //new Thread(Test.Go).Start();
            //new Thread(Test.Go).Start();

//--- проверка на JOIN
            //Console.WriteLine("Вычислим произведение сумм:");
            //Thread t2 = new Thread(Test.Num);
            //Thread t3 = new Thread(Test.Pow);
            //t2.Start();
            //t2.Join();
            //t3.Start();
            //t3.Join();
            //Test.Result();

//--- проверка на Priority
            //Thread t1 = new Thread(Test.HCFunk);
            //t1.Priority = ThreadPriority.Lowest;
            //Thread t2 = new Thread(Test.HCFunk);
            //t2.Priority = ThreadPriority.Highest;
            //Thread t3 = new Thread(Test.HCFunk);
            //t3.Priority = ThreadPriority.Normal;
            //t1.Start(1);
            //t2.Start(2);
            //t3.Start(3);

//--- проверка на HashCode
            //for (int i = 0; i < 3; i++)
            //{
            //    try
            //    {

            //        Console.WriteLine(t1.GetHashCode().ToString());
            //        Thread.Sleep(0);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

//--- задание от 15.10.2014
            //for (int i = 0; i < 5; i++)
            //{
            //    try
            //    {
            //        Thread t = new Thread(Test.Next);
            //        t.Start(i as object);
            //        //Thread t = new Thread(() => Test.Next(i));
            //        //t.Start();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}




//        }
//    }
//}
