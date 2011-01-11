using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Algorithms.Mvc.Models;

namespace Algorithms.Mvc.Controllers
{
    public class StringConcatController : Controller
    {
        //
        // GET: /StringConcat/

        public ActionResult Index()
        {
            var model = new StringConcatViewModel { NumToConcat = 50 };
            model = DoConcat(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult Combine(StringConcatViewModel model)
        {
            model = DoConcat(model);

            return View("Index", model);
        }

        private StringConcatViewModel DoConcat(StringConcatViewModel model)
        {
            var sw = new Stopwatch();

            sw.Reset();
            sw.Start();
            ConcatMultipleStringsUsingFormat(model.NumToConcat);
            sw.Stop();
            model.StringFormatMultipleTicks = sw.ElapsedTicks;

            sw.Reset();
            sw.Start();
            ConcatMultipleStringsUsingOperator(model.NumToConcat);
            sw.Stop();
            model.ConcatMultipleTicks = sw.ElapsedTicks;

            sw.Reset();
            sw.Start();
            ConcatMultipleStringsUsingStringBuilder(model.NumToConcat);
            sw.Stop();
            model.StringBuilderMultipleTicks = sw.ElapsedTicks;

            sw.Reset();
            sw.Start();
            ConcatTwoStringsUsingOperator();
            sw.Stop();
            model.ConcatTicks = sw.ElapsedTicks;

            sw.Reset();
            sw.Start();
            ConcatTwoStringsUsingFormat();
            sw.Stop();
            model.StringFormatTicks = sw.ElapsedTicks;

            sw.Reset();
            sw.Start();
            ConcatTwoStringsUsingStringBuilder();
            sw.Stop();
            model.StringBuilderTicks = sw.ElapsedTicks;

            return model;
        }

        private static void ConcatMultipleStringsUsingFormat(int howMany)
        {
            string result;
         
            result = "Initial - ";
            for (int i = 0; i < howMany; i++)
            {
                result = string.Format("{0}{1}", result, i.ToString());
            }
        }

        private static void ConcatMultipleStringsUsingOperator(int howMany)
        {
            string result;
            result = "Initial - ";
            for (int i = 0; i < howMany; i++)
            {
                result += i.ToString();
            }
        }

        private static void ConcatMultipleStringsUsingStringBuilder(int howMany)
        {
            StringBuilder sb;
            string result;
            sb = new StringBuilder("Initial - ");
            for (int i = 0; i < howMany; i++)
            {
                sb.Append(i.ToString());
            }
            result = sb.ToString();
        }

        private static void ConcatTwoStringsUsingFormat()
        {
            string result;
            result = "";
            result = String.Format("{0}{1}", "Initial", " - Appended");
        }

        private static void ConcatTwoStringsUsingOperator()
        {
            string result;
            result = "";
            result = "Initial" + " - Appended";
        }

        private static void ConcatTwoStringsUsingStringBuilder()
        {
            string result;
            var sb = new StringBuilder("Initial");
            sb.Append(" - Appended");
            result = sb.ToString();
        }
    }
}
