namespace Program2
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
            this.incomeLbl = new System.Windows.Forms.Label();
            this.incomeText = new System.Windows.Forms.TextBox();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.seperateButton = new System.Windows.Forms.RadioButton();
            this.headButton = new System.Windows.Forms.RadioButton();
            this.jointButton = new System.Windows.Forms.RadioButton();
            this.singleButton = new System.Windows.Forms.RadioButton();
            this.marginalLbl = new System.Windows.Forms.Label();
            this.marginText = new System.Windows.Forms.TextBox();
            this.taxLbl = new System.Windows.Forms.Label();
            this.dueTaxText = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(13, 13);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(73, 13);
            this.incomeLbl.TabIndex = 0;
            this.incomeLbl.Text = "Enter Income:";
            // 
            // incomeText
            // 
            this.incomeText.Location = new System.Drawing.Point(93, 13);
            this.incomeText.Name = "incomeText";
            this.incomeText.Size = new System.Drawing.Size(100, 20);
            this.incomeText.TabIndex = 1;
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.seperateButton);
            this.radioGroup.Controls.Add(this.headButton);
            this.radioGroup.Controls.Add(this.jointButton);
            this.radioGroup.Controls.Add(this.singleButton);
            this.radioGroup.Location = new System.Drawing.Point(16, 58);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(177, 149);
            this.radioGroup.TabIndex = 2;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Filing Status";
            // 
            // seperateButton
            // 
            this.seperateButton.AutoSize = true;
            this.seperateButton.Location = new System.Drawing.Point(6, 106);
            this.seperateButton.Name = "seperateButton";
            this.seperateButton.Size = new System.Drawing.Size(135, 17);
            this.seperateButton.TabIndex = 3;
            this.seperateButton.TabStop = true;
            this.seperateButton.Text = "Married filing seperatley";
            this.seperateButton.UseVisualStyleBackColor = true;
            // 
            // headButton
            // 
            this.headButton.AutoSize = true;
            this.headButton.Location = new System.Drawing.Point(6, 82);
            this.headButton.Name = "headButton";
            this.headButton.Size = new System.Drawing.Size(115, 17);
            this.headButton.TabIndex = 2;
            this.headButton.TabStop = true;
            this.headButton.Text = "Head of household";
            this.headButton.UseVisualStyleBackColor = true;
            // 
            // jointButton
            // 
            this.jointButton.AutoSize = true;
            this.jointButton.Location = new System.Drawing.Point(6, 58);
            this.jointButton.Name = "jointButton";
            this.jointButton.Size = new System.Drawing.Size(113, 17);
            this.jointButton.TabIndex = 1;
            this.jointButton.TabStop = true;
            this.jointButton.Text = "Married filing jointly";
            this.jointButton.UseVisualStyleBackColor = true;
            // 
            // singleButton
            // 
            this.singleButton.AutoSize = true;
            this.singleButton.Checked = true;
            this.singleButton.Location = new System.Drawing.Point(6, 34);
            this.singleButton.Name = "singleButton";
            this.singleButton.Size = new System.Drawing.Size(54, 17);
            this.singleButton.TabIndex = 0;
            this.singleButton.TabStop = true;
            this.singleButton.Text = "Single";
            this.singleButton.UseVisualStyleBackColor = true;
            // 
            // marginalLbl
            // 
            this.marginalLbl.AutoSize = true;
            this.marginalLbl.Location = new System.Drawing.Point(19, 277);
            this.marginalLbl.Name = "marginalLbl";
            this.marginalLbl.Size = new System.Drawing.Size(97, 13);
            this.marginalLbl.TabIndex = 3;
            this.marginalLbl.Text = "Marginal Tax Rate:";
            // 
            // marginText
            // 
            this.marginText.Location = new System.Drawing.Point(122, 274);
            this.marginText.Name = "marginText";
            this.marginText.Size = new System.Drawing.Size(100, 20);
            this.marginText.TabIndex = 4;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(19, 306);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(49, 13);
            this.taxLbl.TabIndex = 5;
            this.taxLbl.Text = "Tax due:";
            // 
            // dueTaxText
            // 
            this.dueTaxText.Location = new System.Drawing.Point(122, 306);
            this.dueTaxText.Name = "dueTaxText";
            this.dueTaxText.Size = new System.Drawing.Size(100, 20);
            this.dueTaxText.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(93, 230);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 343);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.dueTaxText);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.marginText);
            this.Controls.Add(this.marginalLbl);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.incomeText);
            this.Controls.Add(this.incomeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.TextBox incomeText;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton seperateButton;
        private System.Windows.Forms.RadioButton headButton;
        private System.Windows.Forms.RadioButton jointButton;
        private System.Windows.Forms.RadioButton singleButton;
        private System.Windows.Forms.Label marginalLbl;
        private System.Windows.Forms.TextBox marginText;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.TextBox dueTaxText;
        private System.Windows.Forms.Button calcButton;
    }
}

