using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NFLDatabaseUi
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=mssql.cs.ksu.edu; Initial Catalog = denavarro6;User ID=denavarro6;Password=Navarro1;";
        private int queryId;

        private string[] teams = { "Arizona Cardinals", "Atlanta Falcons", "Baltimore Ravens", "Buffalo Bills",
            "Carolina Panthers", "Chicago Bears", "Cincinnati Bengals", "Cleveland Browns", "Dallas Cowboys",
            "Denver Broncos", "Detroit Lions", "Green Bay Packers", "Houston Texans", "Indianapolis Colts",
            "Jacksonville Jaguars", "Kansas City Chiefs", "Los Angeles Chargers", "Los Angeles Rams",
            "Miami Dolphins", "Minnesota Vikings", "New England Patriots", "New Orleans Saints",
            "New York Giants", "New York Jets", "Oakland Raiders", "Philadelphia Eagles",
            "Pittsburgh Steelers", "San Francisco 49ers", "Seattle Seahawks", "Tampa Bay Buccaneers",
            "Tennessee Titans", "Washington Redskins" };

        private string[] positions = { "C", "CB", "DE", "DT", "FB", "FS", "G", "K", "LB", "P", "QB", "RB", "S", "T", "TE", "WR" };


        public Form1()
        {
            InitializeComponent();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            int teamid = param1ComboBox.SelectedIndex + 1;
            string position = param1ComboBox.Text;
            int yards = 0;
            int.TryParse(textBoxYards.Text, out yards);
            switch (queryType.SelectedIndex)
            {
                case 0:
                    populateTable($"DECLARE @RushingYards INT  = {yards}; SELECT p.Name, p.RushingYards, t.[Name] AS TeamName FROM dbo.Players p INNER JOIN dbo.Team t ON t.TeamId = p.TeamId WHERE p.RushingYards > @RushingYards ORDER BY p.RushingYards DESC");
                    break;
                case 1:
                    populateTable($"DECLARE @team INT = {teamid}; WITH GmName(TeamId, GMName) AS(SELECT t.TeamId, f.[Name] FROM dbo.Team t INNER JOIN dbo.FrontOffice f ON t.TeamId = f.TeamId WHERE f.Job = 'GM' OR f.Job = 'Owner/GM'), OwnerName(TeamId, OwnerName) AS(SELECT t.TeamId, f.[Name] FROM dbo.Team t INNER JOIN dbo.FrontOffice f ON t.TeamId = f.TeamId WHERE f.Job = 'Owner' OR f.Job = 'Owner/GM') SELECT p.[Name] AS Players, p.PositionalUnit, c.[Name] AS Coach, gm.[GMName] AS GM, o.OwnerName AS Owner FROM dbo.Team t INNER JOIN dbo.Players p ON p.TeamId = t.TeamId INNER JOIN dbo.Coach c ON t.TeamId = c.TeamId INNER JOIN GmName gm ON t.TeamId = gm.TeamId INNER JOIN OwnerName o ON t.TeamId = o.TeamId WHERE t.TeamId = @team");
                    break;
                case 2:
                    populateTable("WITH HomePointsCte(TeamId, TotalPoints) AS (SELECT t.TeamId, SUM(g.HomeScore) AS TotalPoints FROM dbo.Team t INNER JOIN dbo.Game g ON t.TeamId = g.HomeTeamId GROUP BY t.TeamId), AwayPointsCte(TeamId, TotalPoints) AS(SELECT t.TeamId, SUM(g.AwayScore) AS TotalPoints FROM dbo.Team t INNER JOIN dbo.Game g ON t.TeamId = g.AwayTeamId GROUP BY t.TeamId) SELECT RANK() OVER(ORDER BY(h.TotalPoints + a.TotalPoints) DESC) AS[Rank], t.[Name], (h.TotalPoints + a.TotalPoints) AS TotalPointsScored FROM dbo.Team t INNER JOIN HomePointsCte h ON t.TeamId = h.TeamId INNER JOIN AwayPointsCte a ON t.TeamId = a.TeamId ORDER BY TotalPointsScored DESC");
                    break;
                case 3:
                    populateTable("SELECT c.[Name], RANK() OVER (ORDER BY c.Experience DESC) AS [ExpereinceRank], t.[Name] AS TeamName FROM dbo.Team t INNER JOIN dbo.Coach c ON c.TeamId = t.TeamId ORDER BY c.Experience DESC");
                    break;
                case 4:
                    populateTable($"DECLARE @touchdown INT = {yards} DECLARE @position NVARCHAR(4) = N'{position}' SELECT * FROM dbo.Players p WHERE p.Touchdowns > @touchdown AND p.PositionalUnit = @position SELECT * FROM dbo.Players p WHERE p.Touchdowns > @touchdown");
                    break;
                case 5:
                    populateTable($"DECLARE @teamid INT = {teamid} SELECT * FROM dbo.Players p WHERE p.TeamId = @teamid");
                    break;
                case 6:
                    populateTable($"DECLARE @score INT = {yards} SELECT * FROM dbo.Game g WHERE g.HomeScore > @score OR g.AwayScore > @score");
                    break;
                case 7:
                    populateTable($"DECLARE @teamid INT = {teamid} SELECT * FROM dbo.Game g WHERE g.AwayTeamId = @teamid OR g.HomeTeamId = @teamid");
                    break;
                case 8:
                    populateTable($"DECLARE @rushingyards INT = {yards} SELECT * FROM dbo.Game g WHERE g.HomeRushingYards > @rushingyards");
                    break;
                case 9:
                    populateTable("DECLARE @job NVARCHAR(16) = 'Owner/GM' SELECT f.Name FROM dbo.FrontOffice f WHERE f.Job = @job");
                    break;
                case 10:
                    populateTable($"DECLARE @expYears INT = {yards} SELECT * FROM dbo.Coach c WHERE c.Experience < @expYears");
                    break;
                case 11:
                    populateTable($"DECLARE @positionunit NVARCHAR(4)= N'{position}' SELECT p.Name, p.Touchdowns, (SELECT t.Name FROM dbo.Team t WHERE t.TeamId = p.TeamId) AS Team FROM dbo.Players p WHERE p.PositionalUnit = @positionunit ORDER by p.Points DESC");
                    break;
            }
            //execute_query(queryId, param1);
            //display results in dataGridView1
        }

        private void populateTable(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //string query = //dummymethod
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //MessageBox.Show("connected");
                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
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
            else if (queryId == 4 || queryId == 11)
            {
                param1ComboBox.Items.Clear();
                foreach (string s in positions)
                {
                    param1ComboBox.Items.Add(s);
                }
                param1ComboBox.Text = "Select a Position";
                param1ComboBox.Visible = true;
            }
            else
            {
                param1ComboBox.Visible = false;
            }

            if (queryId == 0 || queryId == 8)
            {
                label1.Text = "Enter amount of yards";
                textBoxYards.Visible = true;
                label1.Visible = true;
            }
            else if (queryId == 4)
            {
                label1.Text = "Enter amount of touchdowns";
                textBoxYards.Visible = true;
                label1.Visible = true;
            }
            else if (queryId == 6)
            {
                label1.Text = "Enter score";
                textBoxYards.Visible = true;
                label1.Visible = true;
            }
            else if (queryId == 10)
            {
                label1.Text = "Enter amount of years";
                textBoxYards.Visible = true;
                label1.Visible = true;
            }
            else
            {
                textBoxYards.Visible = false;
                label1.Visible = false;
            }
        }

        private void param1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}