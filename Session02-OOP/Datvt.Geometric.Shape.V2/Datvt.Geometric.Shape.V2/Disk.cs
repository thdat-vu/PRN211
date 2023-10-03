using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datvt.Geometric.Shape.V2_
{
    internal class Disk : Shape
    {
        public Disk(double radius,string name, string description) : base(name, description)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area => Math.PI * Math.Pow(Radius,2);
    }
}
