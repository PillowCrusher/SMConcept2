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
        private List<Rating> ratings;

        public Graphs(string name)
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox1.Items.Add(CategoryType.Inzet);
            listBox1.Items.Add(CategoryType.Onderzoek);
            listBox1.Items.Add(CategoryType.Samenwerken);
            listBox1.Items.Add(CategoryType.Concepten);
            listBox1.Items.Add(CategoryType.Programmeren);
            databaseConnection = new DatabaseConnection();
            this.name = name;
            setupChart();
        }

        public void setupChart()
        {
            chart1.Series.Clear();
            ratings =
                databaseConnection.sendRatingQuery("SELECT * FROM SMRatings WHERE Name = '" + name + "'");
            ratings.Sort();
            List<CategoryType> selectedTypes = new List<CategoryType>();
            selectedTypes.Add(CategoryType.Null);
            fillChart(selectedTypes);
        }


        public void fillChart(List<CategoryType> types)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea1");
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 1;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            int count = 0;
            double avg = 0;
            List<Rating> selectedRatings = new List<Rating>();
            foreach (CategoryType categoryType in types)
            {
                selectedRatings.Clear();
                if (categoryType != CategoryType.Null)
                {
                    foreach (Rating rating in ratings)
                    {
                        if (rating.getCategoryType() == categoryType)
                        {
                            selectedRatings.Add(rating);
                        }
                    }
                }
                else
                {
                    selectedRatings = ratings;
                }
                var weekRating = selectedRatings
                    .Select(p => new
                    {
                        Rating = p,
                        Year
                            = p.GetDateTime().Year,
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
                if (categoryType.ToString() == "Null")
                {
                    chart1.Series.Add("Gescoorde waardes algemeen");
                    chart1.Series["Gescoorde waardes algemeen"].BorderWidth = 6;
                    chart1.Series["Gescoorde waardes algemeen"].ChartType = SeriesChartType.Line;
                }
                else
                {
                    chart1.Series.Add(categoryType.ToString());
                    chart1.Series[categoryType.ToString()].BorderWidth = 6;
                    chart1.Series[categoryType.ToString()].ChartType = SeriesChartType.Line;
                }

                foreach (var groupedRating in weekRating)
                {
                    foreach (var weekGroup in groupedRating.WeekGroup)
                    {
                        avg += weekGroup.Rating.getRating();
                        count++;
                    }
                    if (categoryType.ToString() == "Null")
                    {
                        avg = avg/count;
                        chart1.Series["Gescoorde waardes algemeen"].Points.AddXY(groupedRating.CalendarWeek,avg);
                    }
                    else
                    {
                        avg = avg / count;
                        chart1.Series[categoryType.ToString()].Points.AddXY(groupedRating.CalendarWeek, avg);
                    }
                    count = 0;
                    avg = 0;
                }

            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CategoryType> selectedTypes = new List<CategoryType>();
            foreach (object selectedItem in listBox1.SelectedItems)
            {
                if ((CategoryType)selectedItem == CategoryType.Inzet)
                {
                    selectedTypes.Add(CategoryType.Inzet);
                }
                if ((CategoryType)selectedItem == CategoryType.Onderzoek)
                {
                    selectedTypes.Add(CategoryType.Onderzoek);
                }
                if ((CategoryType)selectedItem == CategoryType.Programmeren)
                {
                    selectedTypes.Add(CategoryType.Programmeren);
                }
                if ((CategoryType)selectedItem == CategoryType.Samenwerken)
                {
                    selectedTypes.Add(CategoryType.Samenwerken);
                }
                if ((CategoryType)selectedItem == CategoryType.Concepten)
                {
                    selectedTypes.Add(CategoryType.Concepten);
                }
            }
            selectedTypes.Add(CategoryType.Null);
            fillChart(selectedTypes);
            this.Invalidate();
            chart1.Invalidate();
        }
    }
}
