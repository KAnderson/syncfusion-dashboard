using Newtonsoft.Json;
using Syncfusion.EJ2.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CircularGaugePointer> pointerCollections = new List<CircularGaugePointer>();
            CircularGaugePointer pointerNeedle = new CircularGaugePointer();
            pointerNeedle.Value = 0.64;
            pointerNeedle.Radius = "80%";
            pointerNeedle.PointerWidth = 5;
            pointerNeedle.NeedleEndWidth = 2;
            pointerNeedle.Cap = new CircularGaugeCap
            {
                Radius = 8,
                Border = new CircularGaugeBorder
                {
                    Width = 2
                }
            };
            pointerCollections.Add(pointerNeedle);

           

            ViewBag.Pointers = pointerCollections;

            List<CircularGaugeRange> rangeCollections = new List<CircularGaugeRange>();
            CircularGaugeRange poorRange = new CircularGaugeRange();
            poorRange.Start = 0;
            poorRange.End = 0.5;
            poorRange.Color = "#F03E3E";
            poorRange.Radius = "90%";
            poorRange.StartWidth = "40";
            poorRange.EndWidth = "40";
            poorRange.LegendText = "Poor";
            rangeCollections.Add(poorRange);


            CircularGaugeRange goodRange = new CircularGaugeRange();
            goodRange.Start = 0.5;
            goodRange.End = 1;
            goodRange.Color = "#FFDD00";
            goodRange.Radius = "90%";
            goodRange.StartWidth = "40";
            goodRange.EndWidth = "40";
            goodRange.LegendText = "Good";
            rangeCollections.Add(goodRange);

            CircularGaugeRange excellentRange = new CircularGaugeRange();
            excellentRange.Start = 1;
            excellentRange.End = 2;
            excellentRange.Color = "#30B32D";
            excellentRange.Radius = "90%";
            excellentRange.StartWidth = "40";
            excellentRange.EndWidth = "40";
            excellentRange.LegendText = "Excellent";
            rangeCollections.Add(excellentRange);

            ViewBag.Ranges = rangeCollections;

            List<CircularGaugeAnnotation> annotations = new List<CircularGaugeAnnotation>();
            CircularGaugeAnnotation pointerAnnotationValue = new CircularGaugeAnnotation();
            pointerAnnotationValue.Content = "<div style='font-size:16px;margin-top: 15px;font-family:inherit'>0.64</div>";
            pointerAnnotationValue.Angle = 0;
            pointerAnnotationValue.Radius = "-10%";
            pointerAnnotationValue.ZIndex = "1";
            annotations.Add(pointerAnnotationValue);

            ViewBag.Annotations = annotations;

            ViewBag.labelFont = new CircularGaugeFont
            {
                Size = "12px",
                Opacity = 1,
                FontFamily = "inherit"
            };
            List<LineData> LineChartData = new List<LineData>
            {
                new LineData {
                    x = "Jan",
                    y = 37,
                },
                new LineData {
                    x = "Feb",
                    y = 23,
                },
                new LineData {
                    x = "Mar",
                    y = 18,
                }
            };
            ViewBag.lineSource = LineChartData;
            List<LineData> LineChartData1 = new List<LineData>
            {
                new LineData {
                    x = "Jan",
                    y = 46,
                },
                new LineData {
                    x = "Feb",
                    y = 27,
                },
                new LineData {
                    x = "Mar",
                    y = 26,
                }
            };
            ViewBag.lineSource1 = LineChartData1;
            List<LineData> LineChartData2 = new List<LineData>
            {
                new LineData {
                    x = "Jan",
                    y = 38,
                },
                new LineData {
                    x = "Feb",
                    y = 17,
                },
                new LineData {
                    x = "Mar",
                    y = 26,
                }
            };
            ViewBag.lineSource2 = LineChartData2;
            ViewBag.pallets = new string[] { "#00bdae", "#357cd2", "#e56691" };
            List<SplineData> SplineChartData1 = new List<SplineData>
            {
                new SplineData { x =  new DateTime(2002, 1, 1), y =  2.2 }, new SplineData { x =  new DateTime(2003, 1, 1), y =  3.4 },
                new SplineData { x =  new DateTime(2004, 1, 1), y =  2.8 }, new SplineData { x =  new DateTime(2005, 1, 1), y =  1.6 },
                new SplineData { x =  new DateTime(2006, 1, 1), y =  2.3 }, new SplineData { x =  new DateTime(2007, 1, 1), y =  2.5 },
                new SplineData { x =  new DateTime(2008, 1, 1), y =  2.9 }, new SplineData { x =  new DateTime(2009, 1, 1), y =  3.8 },
                new SplineData { x =  new DateTime(2010, 1, 1), y =  1.4 }, new SplineData { x = new DateTime(2011, 1, 1), y =  3.1 }
            };
            ViewBag.splineSource1 = SplineChartData1;
            List<SplineData> SplineChartData2 = new List<SplineData>
            {
                new SplineData { x =  new DateTime(2002, 1, 1), y =  2 }, new SplineData { x =  new DateTime(2003, 1, 1), y =  1.7 },
                new SplineData { x =  new DateTime(2004, 1, 1), y =  1.8 }, new SplineData { x =  new DateTime(2005, 1, 1), y =  2.1 },
                new SplineData { x =  new DateTime(2006, 1, 1), y =  2.3 }, new SplineData { x =  new DateTime(2007, 1, 1), y =  1.7 },
                new SplineData { x =  new DateTime(2008, 1, 1), y =  1.5 }, new SplineData { x =  new DateTime(2009, 1, 1), y =  2.8 },
                new SplineData { x =  new DateTime(2010, 1, 1), y =  1.5 }, new SplineData { x = new DateTime(2011, 1, 1), y =  2.3 }
            };
            ViewBag.splineSource2 = SplineChartData2;
            List<SplineAreaChartData> chartData = new List<SplineAreaChartData>
            {
                new SplineAreaChartData { xValue = new DateTime(2002, 01, 01), yValue = 2.2, yValue1 = 2, yValue2 = 0.8  },
                new SplineAreaChartData { xValue = new DateTime(2003, 01, 01), yValue = 3.4, yValue1 = 1.7, yValue2 = 1.3 },
                new SplineAreaChartData { xValue = new DateTime(2004, 01, 01), yValue = 2.8, yValue1 = 1.8, yValue2 = 1.1 },
                new SplineAreaChartData { xValue = new DateTime(2005, 01, 01), yValue = 1.6, yValue1 = 2.1, yValue2 = 1.6 },
                new SplineAreaChartData { xValue = new DateTime(2006, 01, 01), yValue = 2.3, yValue1 = 2.3, yValue2 = 2 },
                new SplineAreaChartData { xValue = new DateTime(2007, 01, 01), yValue = 2.5, yValue1 = 1.7, yValue2 = 1.7 },
                new SplineAreaChartData { xValue = new DateTime(2008, 01, 01), yValue = 2.9, yValue1 = 1.5, yValue2 = 2.3 },
                new SplineAreaChartData { xValue = new DateTime(2009, 01, 01), yValue = 3.8, yValue1 = 2.8, yValue2 = 2.7 },
                new SplineAreaChartData { xValue = new DateTime(2010, 01, 01), yValue = 1.4, yValue1 = 1.5, yValue2 = 1.1 },
                new SplineAreaChartData { xValue = new DateTime(2011, 01, 01), yValue = 3.1, yValue1 = 2.3, yValue2 = 2.3 },
            };
            ViewBag.dataSource = chartData;

            List<PieData> pieData = new List<PieData>
            {
                new PieData { x = "Argentina", y = 505370, text = "505370" },
                new PieData { x = "Belgium", y = 551500, text = "551500" },
                new PieData { x = "Cuba", y = 312685, text = "312685" },
                new PieData { x = "Dominican Republic", y = 350000, text = "350000" },
                new PieData { x = "Egypt", y = 301000, text = "301000" },
                new PieData { x = "Kazakhstan", y = 300000, text = "300000" },
                new PieData { x = "Somalia", y = 357022, text = "357022" },

            };
            ViewBag.pieDataSource = pieData;

            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class spacingModel
        {
            public double[] cellSpacing { get; set; }

        }
        public class SplineAreaChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }
        public class PieData
        {
            public string x;
            public double y;
            public string text;
        }

        public class LineData
        {
            public string x;
            public double y;
        }

        public class SplineData
        {
            public DateTime x;
            public double y;
        }


    }
}