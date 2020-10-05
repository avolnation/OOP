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
        public int[] arr;
        private int i = 0;
	public B(int a,int b,int d):base(a,b)
        {   
		    this.d = d;
            arr = new int[a];
            c2 = c2;
            i = 0;
            while(i < a){
                arr[i] = i * temp;
                i++;
            }
        }
        /* B class construct*/
        public B(int d)
        {
            this.d = d;
        }
	    public int c2{
            set{while(i < a){
                temp = a+b+d;
                i++;}}
            get {return temp;}
        }
    }
    public class Programm
    {
        static void Main()
    {
        B obj_b = new B(3,4,5);
        
        foreach(int i in obj_b.arr)
        {
            System.Console.WriteLine($"{i}");
        }        
    }
    }
