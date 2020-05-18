using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

/*
    It's New Year's Day and everyone's in line for the Wonderland rollercoaster ride! There are a number of people queued up,
    and each person wears a sticker indicating their initial position in the queue. Initial positions increment by  from  at 
    the front of the line to  at the back.
*/
namespace newYearChaos2._0
{
    class Program
    {
        static void minimumBribes(int[] q)
        {


        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }
    }
}
