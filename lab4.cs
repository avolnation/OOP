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
       
        private int k = 0;

        private string[] names = new string[3]{"Anna","Maxim","Alex"};

        public string this[int index,int ind1]{
            get{return names[index];}
        }
        
        public int this[int ind]
        {
            get{return arr[ind];}
            set{arr[ind] = value;}
        }
	public B(int a,int b,int d):base(a,b)
        {   
		    this.d = d;
            arr = new int[a];
            for(int i=0;i<arr.Length;i++){
                arr[i] = i * c2;
            }
        }
        /* B class construct*/
        public B(int d)
        {
            this.d = d;
        }
        
	    public int c2{
            get{
                int i = 0;
                while(i < a){
                temp = a+b+d;
                i++;
            }
            return temp;
            }
        }
    }
    public class C<T>
    {
        public static string idk = "We wish you a merry christmas!";                       
        
        public T var = default(T);

        public void Write(){
            Console.WriteLine(idk);
        }

    }
    public class Programm
    {
        static void Main()
    {
        B obj_b = new B(3,4,5);
    
        for(int i=0;i<obj_b.a;i++){
            Console.WriteLine(obj_b[i] + " " + obj_b[i,2]);
           
        }
        
            C<int> intObj = new C<int>();
        
            C<string> strObj = new C<string>();
        
                intObj.var = 712345;
                strObj.var = "Weeeelcome";


            Console.WriteLine("int static idk:");
                intObj.Write();
            Console.WriteLine("string static idk:");
                strObj.Write();
            
            C<int>.idk = "And the happy New Year!";
            
            Console.WriteLine("new int static idk:");
                intObj.Write();
            }
    }
