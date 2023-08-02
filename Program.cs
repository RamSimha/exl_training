namespace ConsoleAppDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here is a sample LINQ demo

            var words = new string[] { "flower", "elephant", "sugar", "tree", "waffer" };
            
            // what is var : var is a keyword in c# that automatically determines the datatype
            // of object. using var u donot have to specify datatype of object explicity
            // u can use var for ALL objects.

            // here is a linq quary syntax

            // from < variable > in <collection> select <variable>

            //var result = from element in words select element;

            // let us print all elements using foreach loop

            //foreach ( var item in result )
            //{
            //    Console.WriteLine(item);
            //}

            //  filtering 

            /*var result = from element in words where element.Contains("a") select element;

            foreach ( var element in result ) 
            { 
                Console.WriteLine(element); 
            }*/

            var result = words.Where( element => element.Contains("a") );

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

        }
    }
}