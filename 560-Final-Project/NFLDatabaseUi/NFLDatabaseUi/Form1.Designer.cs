namespace NFLDatabaseUi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.param1ComboBox = new System.Windows.Forms.ComboBox();
            this.queryType = new System.Windows.Forms.ComboBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxYards = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxOrder = new System.Windows.Forms.ComboBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // param1ComboBox
            // 
            this.param1ComboBox.FormattingEnabled = true;
            this.param1ComboBox.Location = new System.Drawing.Point(872, 69);
            this.param1ComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.param1ComboBox.Name = "param1ComboBox";
            this.param1ComboBox.Size = new System.Drawing.Size(277, 33);
            this.param1ComboBox.TabIndex = 0;
            this.param1ComboBox.Text = "First Parameter";
            this.param1ComboBox.Visible = false;
            // 
            // queryType
            // 
            this.queryType.FormattingEnabled = true;
            this.queryType.Items.AddRange(new object[] {
            "Players with over a given number of rushing yards",
            "Players, Coaches, and Front Office members of a Team",
            "Ranking of Teams by Points",
            "Ranking of Coaches by Experience",
            "Players of a Selected Position with more than a given number of touchdowns",
            "All Players on a given Team",
            "All Games in which a Team scored over a given number of points",
            "All Games of a given Team",
            "All Games in which the Home Team rushed over a given number of yards",
            "All Owners who are also GMs",
            "All Coaches with less than a given amount of Experience",
            "All players of a position, ranked by points scored"});
            this.queryType.Location = new System.Drawing.Point(50, 69);
            this.queryType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryType.Name = "queryType";
            this.queryType.Size = new System.Drawing.Size(751, 33);
            this.queryType.TabIndex = 1;
            this.queryType.Text = "Select Query";
            this.queryType.SelectedIndexChanged += new System.EventHandler(this.queryType_SelectedIndexChanged);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(1214, 61);
            this.queryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(226, 70);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Find Information";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 363);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1536, 473);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxYards
            // 
            this.textBoxYards.Location = new System.Drawing.Point(50, 178);
            this.textBoxYards.Name = "textBoxYards";
            this.textBoxYards.Size = new System.Drawing.Size(337, 31);
            this.textBoxYards.TabIndex = 5;
            this.textBoxYards.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ComboBoxOrder
            // 
            this.ComboBoxOrder.FormattingEnabled = true;
            this.ComboBoxOrder.Items.AddRange(new object[] {
            "Name",
            "Position",
            "Touchdowns",
            "Tackles",
            "Interceptions",
            "Passing Yards",
            "Rushing Yards",
            "Receiving Yards",
            "Sacks",
            "Pro Bowl Selected"});
            this.ComboBoxOrder.Location = new System.Drawing.Point(872, 176);
            this.ComboBoxOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxOrder.Name = "ComboBoxOrder";
            this.ComboBoxOrder.Size = new System.Drawing.Size(277, 33);
            this.ComboBoxOrder.TabIndex = 7;
            this.ComboBoxOrder.Text = "Order By";
            this.ComboBoxOrder.Visible = false;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(1214, 158);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(226, 70);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "Modify Information";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(1214, 252);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(226, 70);
            this.buttonInsert.TabIndex = 9;
            this.buttonInsert.Text = "Insert Information";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 855);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.ComboBoxOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYards);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.queryType);
            this.Controls.Add(this.param1ComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "NFL Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox param1ComboBox;
        private System.Windows.Forms.ComboBox queryType;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxYards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxOrder;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonInsert;
    }
}

