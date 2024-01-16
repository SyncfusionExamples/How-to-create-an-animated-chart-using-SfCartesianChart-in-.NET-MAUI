using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimatedChart
{
    public class ChartDataModel
    {
        public string? Month { get; set; }
        public double Value { get; set; }

        public ChartDataModel(string month, double value)
        {
            Month = month;
            Value = value;
        }
    }
}
