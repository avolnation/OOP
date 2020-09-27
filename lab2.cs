using System;


    public class A{
        
        private int a;
        private int b;
        
        public A(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public int get_a
        {
            get{return a;}
        }
        
        public int get_b
        {
            get{return b;}
        }
        public int c
        {
            get{return a*=b;}
        }

        public int c1
        {
            get{return a+b;}
        }
        
    }

    public class B:A{

        private int d;

        public B(int a,int b,int d):base(a,b)
        {
            this.d = d;
        }
		
        public int get_d
        {
            get{return d;}
        }
        /*public int c2{
            get {return a+b+d; 
                while(d = 10){
                d++;
            }
            }
        }*/

    }

    public class Programm
    {
        static void Main()
        {
            B obj_b = new B(2,3,10); 
            Console.WriteLine(obj_b.get_a);
            Console.WriteLine(obj_b.get_b);
            Console.WriteLine(obj_b.get_d);
            A obj_a = new A(5,6);
            Console.WriteLine(obj_a.get_a);
            Console.WriteLine(obj_a.get_b);
            
       }
    }
