using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    internal class Cylinder
    {
        const float pi = 3.14f;

        public string Count(string hString, string rString) 
        {
            string result;

            float h = float.Parse(hString);
            float r = float.Parse(rString);

            float s = 2 * pi * h;
            float v = pi * r * r * h;

            result = "S = " + s + " V = " + v;
            Console.WriteLine(result);
            return result;
        }

    }
}
