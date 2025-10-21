using System;
using System.Collections.Generic;

namespace Course.Entitites
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }
        
        public Department(string name)
        {
            Name = name;
        }
    }
}