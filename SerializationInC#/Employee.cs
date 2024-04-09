using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationInC_
{
    [Serializable]
    internal class Employee
    {
        public int Id;
        public string Name;

        public Employee(int id, string name)
        {
                this.Id = id;
                this.Name = name;
        }
    }
}
