using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMProofOfConcept.Classes.Database;
using SMProofOfConcept.Classes.Logic;
using SMProofOfConcept.Classes.Model;

namespace SMProofOfConcept
{
    public partial class Graphs : Form
    {
        private DatabaseConnection databaseConnection;

        public Graphs(string name)
        {
            InitializeComponent();
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            databaseConnection = new DatabaseConnection();
            List<Rating> ratings = databaseConnection.sendRatingQuery("SELECT * FROM SMRatings WHERE Name = '" + name + "'");
            ratings.Sort();

        }

        public void fillChart(List<string> categoryList)
        {
            chart1.Series.Clear();
            if (categoryList.Count == 0)
            {
                
            }
        }
    }
}
