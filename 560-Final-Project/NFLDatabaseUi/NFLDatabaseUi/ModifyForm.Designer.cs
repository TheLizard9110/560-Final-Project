namespace NFLDatabaseUi
{
    partial class ModifyForm
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
            this.ButtonModify = new System.Windows.Forms.Button();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxField = new System.Windows.Forms.ComboBox();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonModify
            // 
            this.ButtonModify.Enabled = false;
            this.ButtonModify.Location = new System.Drawing.Point(130, 530);
            this.ButtonModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(226, 97);
            this.ButtonModify.TabIndex = 0;
            this.ButtonModify.Text = "Modify";
            this.ButtonModify.UseVisualStyleBackColor = true;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Team",
            "Players",
            "Game",
            "Coach",
            "FrontOffice"});
            this.comboBoxTable.Location = new System.Drawing.Point(78, 20);
            this.comboBoxTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(328, 33);
            this.comboBoxTable.TabIndex = 1;
            this.comboBoxTable.Text = "Choose a Table";
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(78, 109);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(328, 33);
            this.comboBoxName.TabIndex = 2;
            this.comboBoxName.Text = "Choose a ...";
            this.comboBoxName.Visible = false;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // comboBoxField
            // 
            this.comboBoxField.FormattingEnabled = true;
            this.comboBoxField.Location = new System.Drawing.Point(78, 203);
            this.comboBoxField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxField.Name = "comboBoxField";
            this.comboBoxField.Size = new System.Drawing.Size(328, 33);
            this.comboBoxField.TabIndex = 3;
            this.comboBoxField.Text = "Choose a Field";
            this.comboBoxField.Visible = false;
            this.comboBoxField.SelectedIndexChanged += new System.EventHandler(this.comboBoxField_SelectedIndexChanged);
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Location = new System.Drawing.Point(78, 458);
            this.textBoxNewValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(328, 31);
            this.textBoxNewValue.TabIndex = 4;
            this.textBoxNewValue.Visible = false;
            this.textBoxNewValue.TextChanged += new System.EventHandler(this.textBoxNewValue_TextChanged);
            // 
            // labelNewValue
            // 
            this.labelNewValue.AutoSize = true;
            this.labelNewValue.Location = new System.Drawing.Point(74, 427);
            this.labelNewValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(172, 25);
            this.labelNewValue.TabIndex = 5;
            this.labelNewValue.Text = "Enter New Value";
            this.labelNewValue.Visible = false;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 645);
            this.Controls.Add(this.labelNewValue);
            this.Controls.Add(this.textBoxNewValue);
            this.Controls.Add(this.comboBoxField);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.ButtonModify);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxField;
        private System.Windows.Forms.TextBox textBoxNewValue;
        private System.Windows.Forms.Label labelNewValue;
    }
}