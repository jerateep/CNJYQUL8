using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ChkDup
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            List<string> Keyword = new List<string>();
            #region สำหรับรับค่าจาก keyboard
            //Console.Write("Please input array size :");
            //int LoopInput = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < LoopInput; i++)
            //{
            //    Console.Write("Please input Array[{0}] :", i);
            //    myList.Add(Console.ReadLine());
            //}
            #endregion
            myList.Add("x1,10");
            myList.Add("x2,20");
            myList.Add("x1,30");
            myList.Add("x4,40");
            myList.Add("x5,50");
            myList.Add("x2,60");
            myList.Add("x1,70");
            myList.Add("x3,80");
            myList.Add("x3,80");
            myList.Add("x3,90");
            myList.Add("x2,100");
            myList.Add("x4,110");
            Console.WriteLine("--Start--");
            foreach (string print in myList)
            {
                Console.WriteLine(print);
            }
            Console.WriteLine("--Result--");
            foreach (string i in myList)
            {
                var sp = i.Split(",").FirstOrDefault();
                if (!Keyword.Contains(sp))
                {
                    Keyword.Add(sp);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
