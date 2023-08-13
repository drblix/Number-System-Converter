namespace NumberSystemConverter
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
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromComboBox
            // 
            this.fromComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            this.fromComboBox.Location = new System.Drawing.Point(61, 21);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(121, 24);
            this.fromComboBox.TabIndex = 0;
            this.fromComboBox.Text = "Number System";
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBox_SelectedIndexChanged);
            // 
            // fromTextBox
            // 
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextBox.Location = new System.Drawing.Point(17, 51);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(207, 22);
            this.fromTextBox.TabIndex = 2;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromComboBox);
            this.fromGroupBox.Controls.Add(this.fromTextBox);
            this.fromGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromGroupBox.Location = new System.Drawing.Point(24, 12);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(239, 92);
            this.fromGroupBox.TabIndex = 3;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.copyButton);
            this.toGroupBox.Controls.Add(this.toComboBox);
            this.toGroupBox.Controls.Add(this.toTextBox);
            this.toGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toGroupBox.Location = new System.Drawing.Point(24, 139);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(239, 111);
            this.toGroupBox.TabIndex = 4;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // copyButton
            // 
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyButton.Location = new System.Drawing.Point(78, 79);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // toComboBox
            // 
            this.toComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal" });
            this.toComboBox.Location = new System.Drawing.Point(61, 21);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(121, 24);
            this.toComboBox.TabIndex = 0;
            this.toComboBox.Text = "Number System";
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBox_SelectedIndexChanged);
            // 
            // toTextBox
            // 
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextBox.Location = new System.Drawing.Point(17, 51);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(207, 22);
            this.toTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Location = new System.Drawing.Point(94, 113);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(92, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 258);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.fromGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Number System Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.fromGroupBox.PerformLayout();
            this.toGroupBox.ResumeLayout(false);
            this.toGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button convertButton;

        private System.Windows.Forms.Button copyButton;

        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.TextBox toTextBox;

        private System.Windows.Forms.GroupBox fromGroupBox;

        private System.Windows.Forms.TextBox fromTextBox;

        private System.Windows.Forms.ComboBox fromComboBox;

        #endregion
    }
}