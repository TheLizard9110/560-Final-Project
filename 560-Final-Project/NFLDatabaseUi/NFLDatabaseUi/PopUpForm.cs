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
    public partial class PopUpForm : Form
    {
        private string[] teams = { "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills",
            "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys",
            "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts",
            "Jacksonville Jaguars", "Kansas City Chiefs", "Los Angeles Chargers", "Los Angeles Rams",
            "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints",
            "New York Giants", "New York Jets", "Oakland Raiders", "Philadelphia Eagles",
            "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers",
            "Tennessee Titans", "Washington Redskins" };

        public string insert;

        public PopUpForm()
        {
            InitializeComponent();
            foreach (string s in teams)
            {
                comboBox2.Items.Add(s);
            }
            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    ActivateLabels("Team");
                    break;
                case 1:
                    ActivateLabels("Player");
                    break;
                case 2:
                    ActivateLabels("FrontOffice");
                    break;
                case 3:
                    ActivateLabels("Coach");
                    break;
                default:
                    break;
            }
            
        }

        private void ActivateLabels(string str)
        {
            if(str =="Team")
            {
                label2.Visible = true;
                label2.Text = "Enter Team Name";
                textBox1.Visible = true;
                label3.Visible = true;
                label3.Text = "City team is based in";
                textBox2.Visible = true;
                comboBox2.Visible = false;
                label4.Visible = false;
                textBox3.Visible = false;
                label5.Visible = false;
                textBox4.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                textBox7.Visible = false;
                label9.Visible = false;
                textBox8.Visible = false;
                label10.Visible = false;
                textBox9.Visible = false;
                label11.Visible = false;
                textBox10.Visible = false;
                label12.Visible = false;
                textBox11.Visible = false;
                label13.Visible = false;
                checkBox1.Visible = false;
                button1.Enabled = true;
            }
            if(str == "Player")
            {
                label2.Visible = true;
                label2.Text = "Enter Player Name";
                textBox1.Visible = true;
                label3.Visible = true;
                label3.Text = "Enter Team";
                comboBox2.Visible = true;
                textBox2.Visible = false;
                label4.Visible = true;
                label4.Text = "Enter Touchdowns Scored";
                textBox3.Visible = true;
                label5.Visible = true;
                label5.Text = "Enter Total Tackles";
                textBox4.Visible = true;
                label6.Visible = true;
                label6.Text = "Enter Total Points Scored";
                textBox5.Visible = true;
                label7.Visible = true;
                label7.Text = "Enter Interceptions";
                textBox6.Visible = true;
                label8.Visible = true;
                label8.Text = "Enter Position";
                textBox7.Visible = true;
                label9.Visible = true;
                label9.Text = "Enter Passing Yards";
                textBox8.Visible = true;
                label10.Visible = true;
                label10.Text = "Enter Rushing Yards";
                textBox9.Visible = true;
                label11.Visible = true;
                label11.Text = "Enter Recieving Yards";
                textBox10.Visible = true;
                label12.Visible = true;
                label12.Text = "Enter Sacks";
                textBox11.Visible = true;
                label13.Visible = true;
                label13.Text = "Specify if Player Played in Pro Bowl";
                checkBox1.Visible = true;
                button1.Enabled = true;

            }
            if(str == "FrontOffice")
            {
                label2.Visible = true;
                label2.Text = "Enter Name";
                textBox1.Visible = true;
                label3.Visible = true;
                label3.Text = "Enter Team";
                comboBox2.Visible = true;
                textBox2.Visible = false;
                label4.Visible = true;
                label4.Text = "Enter Position Held(Owner, GM, or Owner/GM)";
                textBox3.Visible = true;
                label5.Visible = false;
                textBox4.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                textBox7.Visible = false;
                label9.Visible = false;
                textBox8.Visible = false;
                label10.Visible = false;
                textBox9.Visible = false;
                label11.Visible = false;
                textBox10.Visible = false;
                label12.Visible = false;
                textBox11.Visible = false;
                label13.Visible = false;
                checkBox1.Visible = false;
                button1.Enabled = true;
            }
            if(str == "Coach")
            {
                label2.Visible = true;
                label2.Text = "Enter Name";
                textBox2.Visible = true;
                label3.Visible = true;
                label3.Text = "Enter Team";
                comboBox2.Visible = true;
                textBox2.Visible = false;
                label4.Visible = true;
                label4.Text = "Enter Head Coaching Experience";
                label5.Visible = false;
                textBox4.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                textBox6.Visible = false;
                label8.Visible = false;
                textBox7.Visible = false;
                label9.Visible = false;
                textBox8.Visible = false;
                label10.Visible = false;
                textBox9.Visible = false;
                label11.Visible = false;
                textBox10.Visible = false;
                label12.Visible = false;
                textBox11.Visible = false;
                label13.Visible = false;
                checkBox1.Visible = false;
                button1.Enabled = true;
            }
            
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    string _TeamName = textBox1.Text;
                    string city = textBox2.Text;
                    insert = ($"INSERT dbo.Team(TeamId,Name,City)VALUES((SELECT MAX(t.TeamId) FROM dbo.Team t) + 1,{_TeamName},{city})");
                    break;
                case 1:
                    string Name = textBox1.Text;
                    string TeamName = comboBox2.SelectedItem.ToString();
                    int touchdowns;
                    int tackles;
                    int Points;
                    int Interceptions;
                    int PositionalUnit;
                    int PassingYards;
                    int RushingYards;
                    int RecievingYards;
                    int Sacks;
                    int playProBowl;
                    int.TryParse(textBox3.Text, out touchdowns);
                    int.TryParse(textBox4.Text, out tackles);
                    int.TryParse(textBox5.Text, out Points);
                    int.TryParse(textBox6.Text, out Interceptions);
                    int.TryParse(textBox7.Text, out PositionalUnit);
                    int.TryParse(textBox8.Text, out PassingYards);
                    int.TryParse(textBox9.Text, out RushingYards);
                    int.TryParse(textBox10.Text, out RecievingYards);
                    int.TryParse(textBox3.Text, out Sacks);
                    if (checkBox1.Checked == true)
                        playProBowl = 1;
                    else
                        playProBowl = 0;
                    insert = ($"INSERT dbo.Players(PlayerId,TeamId, Touchdowns, Tackles, Points, Interceptions, Name, PositionalUnit,PassingYards,RushingYards,RecievingYards,Sacks,PlayedinProBowl)VALUES((SELECT MAX(p.PlayerId) FROM dbo.Players p) + 1,(SELECT t.TeamId FROM dbo.Team t WHERE {TeamName} = t.Name),{touchdowns},{tackles},{Points},{Interceptions},{Name},{PositionalUnit},{PassingYards},{RushingYards},{Sacks},{playProBowl})");
                    break;
                case 2:
                    string _name = textBox1.Text;
                    string _TeamName_ = comboBox2.SelectedItem.ToString();
                    string position = textBox3.Text;
                    if (position != "GM" && position != "Owner" && position != "Owner/GM")
                        MessageBox.Show("Invalid position for front office member.");
                    else
                        insert = ($"INSERT dbo.FrontOffice(TeamId,MemberId,Name,Job)VALUES((SELECT t.TeamId FROM dbo.Team t WHERE {_TeamName_} = t.Name),(SELECT MAX(f.MemberId) FROM dbo.FrontOffice f) + 1,{_name},{position})");

                    break;
                case 3:
                    string namer = textBox1.Text;
                    string teamer = comboBox2.SelectedText;
                    int.TryParse(textBox3.Text, out int exp);
                    insert = ($"INSERT dbo.Coach(CoachId,TeamId,Name,Job,Experience)VALUES((SELECT MAX(c.CoachId) FROM dbo.Coach c) + 1,(SELECT t.TeamId FROM dbo.Team t WHERE {teamer} = t.Name),{namer},'HC',{exp})");
                    break;
            }
            
        }
    }
}
