using c4learning.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c4learning.basics
{
    public  class Basics : ILeasson
    {
        public string Name => "C# Basics";

        public string Description => "Reference vs Value objects, basics type usage";

        public void RunAll()
        {
            System.Console.WriteLine(Name);
            var metods = this.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach(var method in metods)
            {
                if(method.Name == nameof(RunAll))
                { continue; }  
                
                method.Invoke(this, null);
            }

            System.Console.WriteLine($"{Description}\n");
            
        }

        public void ReferenceVsValue()
        {
            Point p1 = new Point();
            p1.X = 3; p1.Y = -5;
            Point p2 = p1;
            p2.X = 1; p2.Y = -1;
            Console.WriteLine($"P1: {p1.X}, {p1.Y}");
            Console.WriteLine($"P2: {p2.X}, {p2.Y}");

            Person anne = new Person();
            anne.Name = "Anne"; anne.Age = 16;
            Person bob = anne;
            bob.Name = "Bob"; bob.Age = 18;
            Console.WriteLine($"Anne: {anne.Name}, {anne.Age}");
            Console.WriteLine($"Bob: {bob.Name}, {bob.Age}");
        }

        public void NullValuesReference()
        {
            Point p = new Point();
            p.X = 3; p.Y = -5;
            //  p = null;  error
        }

        public void NumericLiterals()
        {
            int i = 1000;
            long hex = 0x4F_00_00_00;
            int million = 1_000_000;
            int binary = 0b0000_1001_0101_1010;
            double d = 1.034;
            float x = 1.234f;
            double scientific = 1.4e-3;
            decimal money = 16.99M;
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types#integer-literals
        }

        public void ImplicitvsExplicitConversion()
        {
          int i = 1000;

          long l = i;

          short s = (short)i;

        }

        public void BoolType()
        {
            bool t = true;
            bool f = false;
            bool equal = (1 == 2);
            bool s1 = t && f || !equal;
            bool s2 = t & f | !equal;
            // & vs &&  bit vs logical
            // | vs ||
        }

    }
}
