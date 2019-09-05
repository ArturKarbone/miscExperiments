using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static System.Console;

namespace miscExperiments
{
    public class NamedParameters
    {
        [Fact]
        public void Experiment()
        {
            //todo: write a blog post about string interpolation/String.Format syntactic sugar
            string Calculate(int a, int b = 20, int c = 30)
            => $"{a} + {b} + {c} = {a + b + c}";

            WriteLine(Calculate(10, c: 150));

            //only during eveluation
            var calcs = BuildCalculations();

            BuildCalculations()
                .ToList()
                .ForEach(x => WriteLine(x));
            //ForEach(Console.WriteLine);

            ReadLine();

            IEnumerable<string> BuildCalculations()
            {
                //todo: write a blog post about named parameters syntactic sugar
                yield return Calculate(10, 20, 30);
                yield return Calculate(c: 10, b: 20, a: 30);
                yield return Calculate(10, c: 20, b: 30);
                yield return Calculate(10, c: 50);
            }
        }
    }
}
