using System;

    class A{
        private int a;
        private int b;
            public A(int a,int b){
                this.a = a;
                this.b = b;
            }
            public int multiply
            {
                get{return a*=b;}
            }
            public int assume
            {
                get{return a+b;}
            }
    }
    class B:A{
        private int d;
        public int c2 
        {
            get{while(d=0) return a+b+d;}
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
