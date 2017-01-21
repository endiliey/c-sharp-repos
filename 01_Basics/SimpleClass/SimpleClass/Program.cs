using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.firstName = "Endi";
            person.lastName = "Lie";
            person.Introduce();
        }
    }

   
}
