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
    public partial class Profile : Form
    {
        private string profileName;
        private RatingLogic ratingLogic;
        public Profile(string profileName)
        {
            InitializeComponent();
            this.profileName = profileName;
            lb_Naam.Text = profileName;
            ratingLogic = new RatingLogic();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            PaintRating(pb_Rating, ratingLogic.getRating(profileName), 30);
            PaintRating(pb_Inzet, ratingLogic.getRating(profileName, CategoryType.Inzet), 15);
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
