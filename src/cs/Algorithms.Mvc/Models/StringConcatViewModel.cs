using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Algorithms.Mvc.Models
{
    public class StringConcatViewModel
    {
        public int NumToConcat { get; set; }

        public long StringBuilderTicks { get; set; }
        public long ConcatTicks { get; set; }
        public long StringFormatTicks { get; set; }
        public long StringBuilderMultipleTicks { get; set; }
        public long ConcatMultipleTicks { get; set; }
        public long StringFormatMultipleTicks { get; set; }
    }
}