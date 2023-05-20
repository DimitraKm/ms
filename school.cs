using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms
{
    internal class school
    {

        private string name;
        private int age;
        public string person
        {
            get { return name; }
            set { name = value; }
        }
        
       public school(string name, int age)
       {
          this.name = name;
           this.age = age;

          
       }
        public void search(string name, int age)
        {
            if (name == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            if (name == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            if (name == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            if (name == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
        }

    }
}
