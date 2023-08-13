using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    public class Class1s
    {
        delegate void MyDelegate();

        public Class1s()
        {
            MyDelegate myDelegate = Show;
            myDelegate += Show2;

            Delegate[] arrDel = myDelegate.GetInvocationList();

            //foreach (var item in arrDel)
            //{
            //    item.DynamicInvoke();
            //}

        }
        void Show()
        {

            try
            {
            Console.WriteLine("Show");
                throw new Exception("error");

            }
            catch { 
            Console.WriteLine("error");

            }
        }
        void Show2()
        {
            Console.WriteLine("Show 2");
            throw new Exception("error");

        }
        void Show(string str)
        {

        }
        public void test()
        {

        }

    }
}
