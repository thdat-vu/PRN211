using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datvt.Geometric.Shape.V2_
{
    internal abstract class Shape
    {
       

        public Shape(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }    
        public string Description { get; set; }

        public abstract double Area { get; } //= 30;

        
    }
}
