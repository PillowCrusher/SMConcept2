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
using Newtonsoft.Json;

namespace SMProofOfConcept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "" || tb_Password.Text == "")
            {
                MessageBox.Show("Everything needs to be filled in");
                return;
            }

            string query = "SELECT * FROM SMLogin WHERE Username = '";
            query += tb_Username.Text + "' AND Password = '";
            query += tb_Password.Text + "'";

            DatabaseConnection dbCon = new DatabaseConnection();
            string jsonString = dbCon.sendQuery(query);
            DatabaseLogin[] dbLogin = JsonConvert.DeserializeObject<DatabaseLogin[]>(jsonString);

            if(dbLogin.Count() == 1)
            {
                //Login succesfull     
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

    }

    public class DatabaseLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
