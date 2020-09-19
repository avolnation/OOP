using System;

    class A{
        private int a = 10;
        private int b = 5;
            public int multiply
            {
                get{return a*=b;}
            }
            public int assume
            {
                get{return a+b;}
            }
    }

        public class Programm
        {
             static void Main(){
                 A Obj = new A();
                 System.Console.WriteLine(Obj.multiply);
                 System.Console.WriteLine(Obj.assume);
             }
        }
