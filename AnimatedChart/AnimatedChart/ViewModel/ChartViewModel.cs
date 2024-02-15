using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedChart
{
    public class ChartViewModel
    {
        public ObservableCollection<ChartDataModel> Data1 { get; set; }
        public ObservableCollection<ChartDataModel> Data2 { get; set; }

        public ChartViewModel() 
        {
            Data1 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Jan", 51),
                new ChartDataModel("Feb", 81),
                new ChartDataModel("Mar", 45),
                new ChartDataModel("Apr", 33),
                new ChartDataModel("May", 61),           
#if WINDOWS || MACCATALYST
                new ChartDataModel("Jun", 81),
                new ChartDataModel("Jul", 45),
                new ChartDataModel("Aug", 33),
                new ChartDataModel("Sep", 60)
#endif
           };


            Data2 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Jan", 81),
                new ChartDataModel("Feb", 41),
                new ChartDataModel("Mar", 55),
                new ChartDataModel("Apr", 73),
                new ChartDataModel("May", 31),           
#if WINDOWS || MACCATALYST
                new ChartDataModel("Jun", 41),
                new ChartDataModel("Jul", 65),
                new ChartDataModel("Aug", 63),
                new ChartDataModel("Sep", 40)
#endif
           };
        }
    }
}