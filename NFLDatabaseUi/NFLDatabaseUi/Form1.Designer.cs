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
            this.param2ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // param1ComboBox
            // 
            this.param1ComboBox.FormattingEnabled = true;
            this.param1ComboBox.Location = new System.Drawing.Point(560, 44);
            this.param1ComboBox.Name = "param1ComboBox";
            this.param1ComboBox.Size = new System.Drawing.Size(186, 24);
            this.param1ComboBox.TabIndex = 0;
            this.param1ComboBox.Text = "First Parameter";
            this.param1ComboBox.Visible = false;
            this.param1ComboBox.SelectedIndexChanged += new System.EventHandler(this.param1ComboBox_SelectedIndexChanged);
            // 
            // queryType
            // 
            this.queryType.FormattingEnabled = true;
            this.queryType.Items.AddRange(new object[] {
            "Players with over 500 rushing yards",
            "Players, Coaches, and Front Office members of a Team",
            "Ranking of Teams by Wins",
            "Ranking of Coaches by Experience",
            "Non-Quarterback Players with more than 15 touchdowns",
            "All Players on a given Team",
            "All Games in which a Team scored over 40 points",
            "All Games of a given Team",
            "All Games in which the Home Team rushed over 200 yards",
            "All Team Owners and GMs",
            "All Coaches with less than 2 years of Experience",
            "All Cornerbacks, ordered by number of interceptions"});
            this.queryType.Location = new System.Drawing.Point(33, 44);
            this.queryType.Name = "queryType";
            this.queryType.Size = new System.Drawing.Size(470, 24);
            this.queryType.TabIndex = 1;
            this.queryType.Text = "Select Query";
            this.queryType.SelectedIndexChanged += new System.EventHandler(this.queryType_SelectedIndexChanged);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(809, 39);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(151, 45);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Find Information";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 317);
            this.dataGridView1.TabIndex = 3;
            // 
            // param2ComboBox
            // 
            this.param2ComboBox.FormattingEnabled = true;
            this.param2ComboBox.Location = new System.Drawing.Point(560, 114);
            this.param2ComboBox.Name = "param2ComboBox";
            this.param2ComboBox.Size = new System.Drawing.Size(186, 24);
            this.param2ComboBox.TabIndex = 4;
            this.param2ComboBox.Text = "Second Parameter";
            this.param2ComboBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 547);
            this.Controls.Add(this.param2ComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.queryType);
            this.Controls.Add(this.param1ComboBox);
            this.Name = "Form1";
            this.Text = "NFL Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox param1ComboBox;
        private System.Windows.Forms.ComboBox queryType;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox param2ComboBox;
    }
}

