namespace VariableScope_Adam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Scope

            string name = "Dylan";

            Console.WriteLine("name!"); // Print Dylan

        }
        if(true)
        { // 
         // Declared my ifScope variable INSIDE of my if code block
         string ifScope = "Declared In our if";
        }
    
    }
}

