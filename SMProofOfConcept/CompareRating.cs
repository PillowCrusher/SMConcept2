using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMProofOfConcept.Classes.Logic;
using SMProofOfConcept.Classes.Model;

namespace SMProofOfConcept
{
    public partial class CompareRating : Form
    {
        private RatingLogic ratingLogic;
        private string name;
        private double inzet;
        private double samenwerken;
        private double programmeren;
        private double concepting;
        private double onderzoeken;
        public CompareRating(string name, double inzet, double samenwerken, double programmeren, double concepting, double onderzoeken)
        {
            InitializeComponent();
            this.name = name;
            this.inzet = inzet;
            this.samenwerken = samenwerken;
            this.programmeren = programmeren;
            this.concepting = concepting;
            this.onderzoeken = onderzoeken;
            ratingLogic = new RatingLogic();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            PaintRating(pb_Rating, ratingLogic.getRating(name), 20);
            PaintRating(pb_Inzet, ratingLogic.getRating(name, CategoryType.Inzet), 10);
            PaintRating(pb_Samenwerking, ratingLogic.getRating(name, CategoryType.Samenwerken), 10);
            PaintRating(pb_Programmeren, ratingLogic.getRating(name, CategoryType.Programmeren), 10);
            PaintRating(pb_Concepting, ratingLogic.getRating(name, CategoryType.Concepten), 10);
            PaintRating(pb_Onderzoeken, ratingLogic.getRating(name, CategoryType.Onderzoek), 10);

            PaintRating(pb_Zelf_Rating, GetAverage().ToString("F"), 20);
            PaintRating(pb_Zelf_Inzet, inzet.ToString(), 10);
            PaintRating(pb_Zelf_Samenwerking, samenwerken.ToString(), 10);
            PaintRating(pb_Zelf_Programmeren, programmeren.ToString(), 10);
            PaintRating(pb_Zelf_Concepting, concepting.ToString(), 10);
            PaintRating(pb_Zelf_Onderzoeken, onderzoeken.ToString(), 10);
        }

        private double GetAverage()
        {
            double result = inzet + samenwerken + programmeren + concepting + onderzoeken;
            result = result / 5;
            return result;
        }

        private void PaintRating(PictureBox pb, string text, int fontSize)
        {
            pb.Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                Font newFont = new Font(Font.FontFamily.Name, fontSize);

                SizeF textSize = e.Graphics.MeasureString(text, newFont);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pb.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pb.Height / 2) - (textSize.Height / 2);

                e.Graphics.DrawString(text, newFont, Brushes.Black, locationToDraw);
            });
        }
    }
}
