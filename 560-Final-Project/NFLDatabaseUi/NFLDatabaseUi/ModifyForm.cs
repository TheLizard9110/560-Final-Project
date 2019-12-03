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
    public partial class ModifyForm : Form
    {

        string connectionString = @"Data Source=mssql.cs.ksu.edu; Initial Catalog = denavarro6;User ID=denavarro6;Password=Navarro1;";
        string newValue;
        string columnName;

        public ModifyForm()
        {
            InitializeComponent();
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex == 2)
            {
                columnName = "GameId";
                populateComboBox($"SELECT t.GameId FROM dbo.Game t", comboBoxName);
                //comboBoxName.Text = "Select a Game ID";
            }
            else
            {
                columnName = "Name";
                populateComboBox($"SELECT t.[Name] FROM dbo.{comboBoxTable.SelectedItem.ToString()} t", comboBoxName);
                //comboBoxName.Text = $"Select a {comboBoxTable.SelectedItem.ToString()} name";
            }
            //comboBoxField.Items.RemoveAt(0);
            comboBoxName.Visible = true;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnName = "COLUMN_NAME";
            populateComboBox($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{comboBoxTable.SelectedItem.ToString()}'", comboBoxField);
            //comboBoxField.Items.RemoveAt(0);
            comboBoxField.Visible = true;
        }

        private void comboBoxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnName = comboBoxField.SelectedItem.ToString();
            if (comboBoxTable.SelectedIndex == 2)
            {
                populateCurrentValue($"SELECT {comboBoxField.SelectedItem.ToString()} FROM dbo.Game WHERE GameId = {comboBoxName.SelectedItem.ToString()}");
            }
            else
            {
                populateCurrentValue($"SELECT {comboBoxField.SelectedItem.ToString()} FROM dbo.{comboBoxTable.SelectedItem.ToString()} WHERE [Name] = N'{comboBoxName.SelectedItem.ToString()}'");
            }
            textBoxNewValue.Visible = true;
            labelNewValue.Visible = true;
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex == 2)
            {
                updateTable($"UPDATE dbo.Game SET {comboBoxField.SelectedItem.ToString()} = {newValue} WHERE GameId = {comboBoxName.SelectedItem.ToString()}");
            }
            else
            {
                updateTable($"UPDATE dbo.{comboBoxTable.SelectedItem.ToString()} SET {comboBoxField.SelectedItem.ToString()} = {newValue} WHERE [Name] = N'{comboBoxName.SelectedItem.ToString()}'");
            }
            MessageBox.Show("Database Successfully Updated");
            this.Close();
        }

        private void textBoxNewValue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewValue.Text.Equals(""))
            {
                ButtonModify.Enabled = false;
            }
            else
            {
                int val;
                if (int.TryParse(textBoxNewValue.Text, out val))
                {
                    newValue = val.ToString();
                }
                else
                {
                    newValue = $"N'{textBoxNewValue.Text}'";
                }
                ButtonModify.Enabled = true;
            }
        }


        private void populateComboBox(string query, ComboBox comboBox)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //string query = //dummymethod
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //MessageBox.Show("connected");
                List<string> list = new List<string>();
                foreach (DataRow row in dtbl.Rows)
                {
                    list.Add(row[columnName].ToString());
                }
                comboBox.DataSource = list;
                sqlCon.Close();
            }
        }

        private void populateCurrentValue(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //string query = //dummymethod
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //MessageBox.Show("connected");
                List<string> list = new List<string>();
                foreach (DataRow row in dtbl.Rows)
                {
                    list.Add(row[columnName].ToString());
                }
                labelCurrentVal.Text = "Current Value: " + list[0];
                labelCurrentVal.Visible = true;
                sqlCon.Close();
            }
        }

        private void updateTable(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                //string query = //dummymethod
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //MessageBox.Show("connected");
                sqlCon.Close();
            }
        }
    }
}
