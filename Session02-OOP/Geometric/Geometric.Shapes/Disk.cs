using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Shapes
{
    internal class Disk : Shape
    {
        public double Radius { get; set; }

        //expression body
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
        //{ Chỉ dòng expression body với hàm, property

        //    //return Math.PI * Radius * Radius;
        //    return Math.PI * Math.Pow(Radius , 2);
        //}
    }
}
