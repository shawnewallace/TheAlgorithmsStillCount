using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Algorithms.Mvc.Models;

namespace Algorithms.Mvc.Controllers
{
    public class FibonacciController : Controller
    {
        //
        // GET: /Fibonacci/

        public ActionResult Index()
        {
            var model = new FibonacciViewModel { NumToCalculate = 50, CallIteratively = true};
            model = DoCalculations(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult Calculate(FibonacciViewModel fib)
        {
            fib = DoCalculations(fib);

            return View("Index", fib);
        }

        internal FibonacciViewModel DoCalculations(FibonacciViewModel fib)
        {
            var sw = new Stopwatch();
            var calculator = new Fib();
            fib.Results.Clear();

            int startCalulationsAt = fib.ShowShortList ? fib.NumToCalculate - 10 : 0;

            for (int i = startCalulationsAt; i <= fib.NumToCalculate; i++ )
            {
                var newResult = new FibonacciViewResult {Num = i, Value = calculator.CalculateIteratively(i)};
                double value = 0;

                if (fib.CallIteratively)
                {
                    sw.Reset();
                    sw.Start();
                    value = calculator.CalculateIteratively(i);
                    sw.Stop();
                    newResult.IterativelyTicks = sw.ElapsedTicks;
                    newResult.IterativeAccuracy = true;
                }

                if(fib.CallO1)
                {
                    sw.Reset();
                    sw.Start();
                    value = calculator.Calculate(i);
                    sw.Stop();
                    newResult.BigO1Ticks = sw.ElapsedTicks;
                    newResult.BigO1Accuracy = (value == newResult.Value);
                }

                if(fib.CallRecursively)
                {
                    sw.Reset();
                    sw.Start();
                    calculator.CalculateRecursively(i);
                    sw.Stop();
                    newResult.RecursivelyTicks = sw.ElapsedTicks;
                    newResult.RecursiveAccuracy = true;
                }

                fib.Results.Add(newResult);
            }

            return fib;
        }
    }
}
