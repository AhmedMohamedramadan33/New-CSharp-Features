namespace c_newfeature
{
    public struct Rectangle
    {  public int x; 
        public int y; 
        public readonly int getarea()
        {       
                return x * y;
        }

    
    }
   record person(int id,string name);
    internal class Program
    {
        public static (int,string,double) getdata()
        {
            return (1, "ahmed", 1.55);
        }
        static void Main(string[] args)
        {
            //                  ( inline out variable )  c#7

            //Console.WriteLine("enter number of lap");
            //int.TryParse(Console.ReadLine(), out int result);
            //Console.WriteLine(result);
            //-----------------------------------------------

            //                   (  tuple  )   c#7

            //var ob1 = new Tuple<int, string, DateTime, double, int,int,int>(1, "ahmed", DateTime.Now, 1.55, 5,6,2);
            //Console.WriteLine(ob1.Item1);
            //var ob2 = Tuple.Create(1, "mohamed", 1.55);
            //Console.WriteLine(ob2.Item2);
            //var ob3 = (id:1,name: "ss",w: 1.66);
            //Console.WriteLine(ob3.id);
            //var data = getdata();
            //Console.WriteLine(data.Item1);
            //------------------------------------------------------------------

            //                  (local method)   c#7

            //int print()
            //{
            //   return 1;
            //}
            //Console.WriteLine( print());

            //----------------------------------------------------------------------

            //                       (pattern matching)   c#7

            //int x = 5;
            //if (x is int newint)
            //    Console.WriteLine(newint);

            //-----------------------------------------------------------------------

            //                      (Readonly Struct Members)   c#8

            //Rectangle m = new Rectangle() { y = 5, x = 6 };
            //Console.WriteLine(m.getarea());
            // prevent change the value of property throw it;

            //-----------------------------------------------------------------------

            //                    (Top Level Statement)      C#9

            // hide structure of code from developper but it still in back;

            //-------------------------------------------------------------------------
            //                                  (record) c#9

            //var p1 = new person(1, "ahmed");
            //var p2 = new person(2, "ahmed");
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.Equals(p2));

           //-------------------------------------------------------------------------------
           //                    (file scope namespace)
    //       namespace  ahmed;
    //    class a
    //{

    //}
    //class b
    //{

    //}

    //---------------------------------------------------------------------------

            










        }
    }
}
