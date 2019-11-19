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
            this.param1ComboBox.Location = new System.Drawing.Point(160, 44);
            this.param1ComboBox.Name = "param1ComboBox";
            this.param1ComboBox.Size = new System.Drawing.Size(145, 24);
            this.param1ComboBox.TabIndex = 0;
            this.param1ComboBox.Text = "First Parameter";
            // 
            // queryType
            // 
            this.queryType.FormattingEnabled = true;
            this.queryType.Location = new System.Drawing.Point(33, 44);
            this.queryType.Name = "queryType";
            this.queryType.Size = new System.Drawing.Size(121, 24);
            this.queryType.TabIndex = 1;
            this.queryType.Text = "Select Query";
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(176, 114);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(119, 32);
            this.queryButton.TabIndex = 2;
            this.queryButton.Text = "Find Information";
            this.queryButton.UseVisualStyleBackColor = true;
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
            this.param2ComboBox.Location = new System.Drawing.Point(311, 44);
            this.param2ComboBox.Name = "param2ComboBox";
            this.param2ComboBox.Size = new System.Drawing.Size(145, 24);
            this.param2ComboBox.TabIndex = 4;
            this.param2ComboBox.Text = "Second Parameter";
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

