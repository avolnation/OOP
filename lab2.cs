using System;


    public class A{
        public int a;
        public int b;
	public A()
	{
	}
        /* A class constructor*/
        public A(int a,int b)
        {
            this.a = a;
            this.b = b;
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

        public int d;
        private int temp = 0;
	public B(int a,int b,int d):base(a,b)
        {   
		this.d = d;
        }
        /* B class construct*/
        public B(int d)
        {
            this.d = d;
        }
	    public int c2{
            set{while(temp == 0)
                temp = a+b+d;}
            get {return temp;}
        }
    }
    public class Programm
    {
        static void Main()
        {
            B obj_b = new B(2,3,10);
            obj_b.c2 = obj_b.c2;
            Console.WriteLine("value of property c2 from class B is: " + obj_b.c2);
            //writing in console values of fields
            Console.WriteLine("value of field a from class B is: " + obj_b.a);
            Console.WriteLine("value of field b from class B is: " + obj_b.b);
            Console.WriteLine("value of field d from class B is: " + obj_b.d);
            A obj_a = new A(5,6);
            Console.WriteLine("value of field a from class A is: " + obj_a.a);
            Console.WriteLine("value of field b from class A is: " + obj_a.b);
            B obj_b1 = new B(8);
            Console.WriteLine("value of field d from class B is: " + obj_b1.d);
       }
}
