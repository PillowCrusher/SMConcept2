using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SMProofOfConcept.Classes.Database;
using SMProofOfConcept.Classes.Logic;
using SMProofOfConcept.Classes.Model;

namespace SMProofOfConcept
{
    public partial class Graphs : Form
    {
        private DatabaseConnection databaseConnection;
        private string name;

        public Graphs(string name)
        {
            InitializeComponent();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            databaseConnection = new DatabaseConnection();
            this.name = name;
            fillChart();
        }

        public void fillChart()
        {
            chart1.Series.Clear();

            List<Rating> ratings =
                databaseConnection.sendRatingQuery("SELECT * FROM SMRatings WHERE Name = '" + name + "'");
            ratings.Sort();
            var weekRating = ratings
                .Select(p => new
                {
                    Rating = p,
                    Year = p.GetDateTime().Year,
                    Week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear
                        (p.GetDateTime(), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                })
                .GroupBy(x => new {x.Year, x.Week})
                .Select((g, i) => new
                {
                    WeekGroup = g,
                    WeekNum = i + 1,
                    Year = g.Key.Year,
                    CalendarWeek = g.Key.Week
                });

            chart1.Series.Clear();
            chart1.Series.Add("Gescoorde waardes algemeen");
            chart1.Series["Gescoorde waardes algemeen"].ChartType = SeriesChartType.Spline;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 1;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            foreach (var groupedRating in weekRating)
            {
                chart1.Series["Gescoorde waardes algemeen"].BorderWidth = 10;
                double avgRating = 0;
                int count = 0;
                foreach (var selectedRating in groupedRating.WeekGroup)
                {
                    avgRating += selectedRating.Rating.getRating();
                    count++;
                }
                if (avgRating != 0)
                {
                    avgRating = avgRating/count;
                    chart1.Series["Gescoorde waardes algemeen"].Points.AddXY(
                        groupedRating.CalendarWeek.ToString(),
                        avgRating);
                }
            }
        }



        public void fillChart(List<string> categoryList)
        {
            chart1.Series.Clear();

            List<Rating> ratings =
                databaseConnection.sendRatingQuery("SELECT * FROM SMRatings WHERE Name = '" + name + "'");
            ratings.Sort();
            var weekRating = ratings
                .Select(p => new
                {
                    Rating = p,
                    Year = p.GetDateTime().Year,
                    Week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear
                        (p.GetDateTime(), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                })
                .GroupBy(x => new { x.Year, x.Week })
                .Select((g, i) => new
                {
                    WeekGroup = g,
                    WeekNum = i + 1,
                    Year = g.Key.Year,
                    CalendarWeek = g.Key.Week
                });

            chart1.Series.Clear();
            chart1.Series.Add("Gescoorde waardes algemeen");
            chart1.Series["Gescoorde waardes algemeen"].ChartType = SeriesChartType.Spline;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 1;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            foreach (var groupedRating in weekRating)
            {
                chart1.Series["Gescoorde waardes algemeen"].BorderWidth = 10;
                double avgRating = 0;
                int count = 0;
                foreach (var selectedRating in groupedRating.WeekGroup)
                {
                    avgRating += selectedRating.Rating.getRating();
                    count++;
                }
                if (avgRating != 0)
                {
                    avgRating = avgRating / count;
                    chart1.Series["Gescoorde waardes algemeen"].Points.AddXY(
                        groupedRating.CalendarWeek.ToString(),
                        avgRating);
                }
            }
        }
    }
}
