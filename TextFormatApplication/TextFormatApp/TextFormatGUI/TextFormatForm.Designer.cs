namespace TextFormatGUI
{
    partial class TextFormatForm
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.startLinelbl = new System.Windows.Forms.Label();
            this.endLineLbl = new System.Windows.Forms.Label();
            this.startLineTxtBox = new System.Windows.Forms.TextBox();
            this.endLineTxtBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.lineCountLbl = new System.Windows.Forms.Label();
            this.lineCountValueLbl = new System.Windows.Forms.Label();
            this.capitalizeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBoxInput.Location = new System.Drawing.Point(24, 30);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(633, 521);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "Enter your text here........";
            this.richTextBoxInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxInput_MouseClick);
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            // 
            // startLinelbl
            // 
            this.startLinelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startLinelbl.AutoSize = true;
            this.startLinelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLinelbl.Location = new System.Drawing.Point(42, 153);
            this.startLinelbl.Name = "startLinelbl";
            this.startLinelbl.Size = new System.Drawing.Size(141, 16);
            this.startLinelbl.TabIndex = 1;
            this.startLinelbl.Text = "Start each line with:";
            // 
            // endLineLbl
            // 
            this.endLineLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endLineLbl.AutoSize = true;
            this.endLineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLineLbl.Location = new System.Drawing.Point(43, 194);
            this.endLineLbl.Name = "endLineLbl";
            this.endLineLbl.Size = new System.Drawing.Size(136, 16);
            this.endLineLbl.TabIndex = 2;
            this.endLineLbl.Text = "End each line with:";
            // 
            // startLineTxtBox
            // 
            this.startLineTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startLineTxtBox.Location = new System.Drawing.Point(189, 150);
            this.startLineTxtBox.Name = "startLineTxtBox";
            this.startLineTxtBox.Size = new System.Drawing.Size(100, 22);
            this.startLineTxtBox.TabIndex = 3;
            // 
            // endLineTxtBox
            // 
            this.endLineTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endLineTxtBox.Location = new System.Drawing.Point(188, 191);
            this.endLineTxtBox.Name = "endLineTxtBox";
            this.endLineTxtBox.Size = new System.Drawing.Size(100, 22);
            this.endLineTxtBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editButton.BackColor = System.Drawing.Color.DimGray;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.editButton.Location = new System.Drawing.Point(186, 348);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 36);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearButton.BackColor = System.Drawing.Color.DimGray;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.clearButton.Location = new System.Drawing.Point(87, 348);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // lineCountLbl
            // 
            this.lineCountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineCountLbl.AutoSize = true;
            this.lineCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCountLbl.Location = new System.Drawing.Point(43, 103);
            this.lineCountLbl.Name = "lineCountLbl";
            this.lineCountLbl.Size = new System.Drawing.Size(89, 16);
            this.lineCountLbl.TabIndex = 8;
            this.lineCountLbl.Text = "Total Lines:";
            // 
            // lineCountValueLbl
            // 
            this.lineCountValueLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineCountValueLbl.AutoSize = true;
            this.lineCountValueLbl.Location = new System.Drawing.Point(186, 103);
            this.lineCountValueLbl.Name = "lineCountValueLbl";
            this.lineCountValueLbl.Size = new System.Drawing.Size(65, 16);
            this.lineCountValueLbl.TabIndex = 9;
            this.lineCountValueLbl.Text = "No Input";
            // 
            // capitalizeBtn
            // 
            this.capitalizeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.capitalizeBtn.BackColor = System.Drawing.Color.DimGray;
            this.capitalizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalizeBtn.ForeColor = System.Drawing.Color.GreenYellow;
            this.capitalizeBtn.Location = new System.Drawing.Point(186, 231);
            this.capitalizeBtn.Name = "capitalizeBtn";
            this.capitalizeBtn.Size = new System.Drawing.Size(100, 31);
            this.capitalizeBtn.TabIndex = 10;
            this.capitalizeBtn.Text = "Capitalize";
            this.capitalizeBtn.UseVisualStyleBackColor = false;
            this.capitalizeBtn.Click += new System.EventHandler(this.capitalizeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.capitalizeBtn);
            this.groupBox1.Controls.Add(this.startLinelbl);
            this.groupBox1.Controls.Add(this.lineCountValueLbl);
            this.groupBox1.Controls.Add(this.endLineLbl);
            this.groupBox1.Controls.Add(this.lineCountLbl);
            this.groupBox1.Controls.Add(this.startLineTxtBox);
            this.groupBox1.Controls.Add(this.endLineTxtBox);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(675, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 521);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // TextFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(996, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "TextFormatForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Text Format Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Label startLinelbl;
        private System.Windows.Forms.Label endLineLbl;
        private System.Windows.Forms.TextBox startLineTxtBox;
        private System.Windows.Forms.TextBox endLineTxtBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label lineCountLbl;
        private System.Windows.Forms.Label lineCountValueLbl;
        private System.Windows.Forms.Button capitalizeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

