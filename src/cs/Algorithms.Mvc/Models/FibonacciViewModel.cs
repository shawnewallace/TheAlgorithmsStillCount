using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Algorithms.Mvc.Models
{
    public class FibonacciViewResult
    {
        public bool IterativeAccuracy { get; set; }
        public bool RecursiveAccuracy { get; set; }
        public bool BigO1Accuracy { get; set; }

        public long IterativelyTicks { get; set; }
        public long RecursivelyTicks { get; set; }
        public long BigO1Ticks { get; set; } 
        public int Num { get; set; }
        public double Value { get; set; }
    }

    public class FibonacciViewModel
    {
        public bool CallIteratively { get; set; }
        public bool CallRecursively { get; set; }
        public bool CallO1 { get; set; }
        public bool ShowShortList { get; set; }
        public int NumToCalculate { get; set; }

        private List<FibonacciViewResult> _results;
        public List<FibonacciViewResult> Results
        {
            get { return _results ?? (_results = new List<FibonacciViewResult>()); }
            set { _results = value; }
        }
    }
}