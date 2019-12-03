using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFLDatabaseUi
{
    public partial class Form1 : Form
    {
        private int queryId;
        private string param1;

        private string[] teams = { "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills",
            "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys",
            "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts",
            "Jacksonville Jaguars", "Kansas City Chiefs", "Los Angeles Chargers", "Los Angeles Rams",
            "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints",
            "New York Giants", "New York Jets", "Oakland Raiders", "Philadelphia Eagles",
            "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers",
            "Tennessee Titans", "Washington Redskins" };

        public Form1()
        {
            InitializeComponent();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            //execute_query(queryId, param1);
            //display results in dataGridView1
        }

        private void queryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryId = queryType.SelectedIndex;
            if (queryId == 1 || queryId == 5 || queryId == 7)
            {
                param1ComboBox.Items.Clear();
                foreach (string s in teams)
                {
                    param1ComboBox.Items.Add(s);
                }
                param1ComboBox.Text = "Select a Team";
                param1ComboBox.Visible = true;
            }
            else
            {
                param1ComboBox.Visible = false;
            }
        }

        private void param1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            param1 = param1ComboBox.SelectedItem.ToString();
        }
    }
}