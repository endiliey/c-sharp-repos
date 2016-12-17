using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

           }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
