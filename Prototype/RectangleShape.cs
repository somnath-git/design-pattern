using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class RectangleShape : ICloneableShape
    {
        public int Width { get; set; }

        public int Height { get; set; }
        public ICloneableShape Clone()
        {
            var rectangle = new RectangleShape() { Height = Height, Width = Width };
            return rectangle;
        }
    }
}
