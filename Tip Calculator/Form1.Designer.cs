namespace Tip_Calculator
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBill = new System.Windows.Forms.Label();
            this.lTipPerc = new System.Windows.Forms.Label();
            this.lPeopleCount = new System.Windows.Forms.Label();
            this.butCalTip = new System.Windows.Forms.Button();
            this.lTipPerPers = new System.Windows.Forms.Label();
            this.lTotPerPers = new System.Windows.Forms.Label();
            this.lTipAmt = new System.Windows.Forms.Label();
            this.lTotTip = new System.Windows.Forms.Label();
            this.tipEntry = new System.Windows.Forms.NumericUpDown();
            this.peopleCountEntry = new System.Windows.Forms.NumericUpDown();
            this.verticalLine = new System.Windows.Forms.Label();
            this.enteredAmt = new System.Windows.Forms.MaskedTextBox();
            this.butReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleCountEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // lBill
            // 
            this.lBill.AutoSize = true;
            this.lBill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lBill.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBill.Location = new System.Drawing.Point(139, 9);
            this.lBill.Name = "lBill";
            this.lBill.Size = new System.Drawing.Size(110, 25);
            this.lBill.TabIndex = 0;
            this.lBill.Text = "Bill Amount";
            // 
            // lTipPerc
            // 
            this.lTipPerc.AutoSize = true;
            this.lTipPerc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTipPerc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTipPerc.Location = new System.Drawing.Point(139, 108);
            this.lTipPerc.Name = "lTipPerc";
            this.lTipPerc.Size = new System.Drawing.Size(59, 25);
            this.lTipPerc.TabIndex = 0;
            this.lTipPerc.Text = "Tip %";
            // 
            // lPeopleCount
            // 
            this.lPeopleCount.AutoSize = true;
            this.lPeopleCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lPeopleCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPeopleCount.Location = new System.Drawing.Point(139, 214);
            this.lPeopleCount.Name = "lPeopleCount";
            this.lPeopleCount.Size = new System.Drawing.Size(165, 25);
            this.lPeopleCount.TabIndex = 0;
            this.lPeopleCount.Text = "Number of People";
            // 
            // butCalTip
            // 
            this.butCalTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butCalTip.Location = new System.Drawing.Point(139, 335);
            this.butCalTip.Name = "butCalTip";
            this.butCalTip.Size = new System.Drawing.Size(88, 27);
            this.butCalTip.TabIndex = 3;
            this.butCalTip.Text = "Calculate";
            this.butCalTip.UseVisualStyleBackColor = true;
            this.butCalTip.Click += new System.EventHandler(this.butCalTip_Click);
            // 
            // lTipPerPers
            // 
            this.lTipPerPers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTipPerPers.AutoSize = true;
            this.lTipPerPers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTipPerPers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTipPerPers.Location = new System.Drawing.Point(485, 39);
            this.lTipPerPers.Name = "lTipPerPers";
            this.lTipPerPers.Size = new System.Drawing.Size(103, 50);
            this.lTipPerPers.TabIndex = 0;
            this.lTipPerPers.Text = "Tip\r\nper person";
            this.lTipPerPers.Visible = false;
            // 
            // lTotPerPers
            // 
            this.lTotPerPers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotPerPers.AutoSize = true;
            this.lTotPerPers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTotPerPers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lTotPerPers.Location = new System.Drawing.Point(485, 214);
            this.lTotPerPers.Name = "lTotPerPers";
            this.lTotPerPers.Size = new System.Drawing.Size(103, 50);
            this.lTotPerPers.TabIndex = 0;
            this.lTotPerPers.Text = "Total\r\nper person";
            this.lTotPerPers.Visible = false;
            // 
            // lTipAmt
            // 
            this.lTipAmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTipAmt.AutoSize = true;
            this.lTipAmt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTipAmt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTipAmt.Location = new System.Drawing.Point(858, 52);
            this.lTipAmt.Name = "lTipAmt";
            this.lTipAmt.Size = new System.Drawing.Size(0, 37);
            this.lTipAmt.TabIndex = 0;
            // 
            // lTotTip
            // 
            this.lTotTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotTip.AutoSize = true;
            this.lTotTip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTotTip.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTotTip.Location = new System.Drawing.Point(858, 204);
            this.lTotTip.Name = "lTotTip";
            this.lTotTip.Size = new System.Drawing.Size(0, 37);
            this.lTotTip.TabIndex = 0;
            // 
            // tipEntry
            // 
            this.tipEntry.DecimalPlaces = 2;
            this.tipEntry.Location = new System.Drawing.Point(149, 146);
            this.tipEntry.Name = "tipEntry";
            this.tipEntry.Size = new System.Drawing.Size(120, 23);
            this.tipEntry.TabIndex = 2;
            this.tipEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // peopleCountEntry
            // 
            this.peopleCountEntry.Location = new System.Drawing.Point(149, 252);
            this.peopleCountEntry.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.peopleCountEntry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.peopleCountEntry.Name = "peopleCountEntry";
            this.peopleCountEntry.Size = new System.Drawing.Size(120, 23);
            this.peopleCountEntry.TabIndex = 3;
            this.peopleCountEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peopleCountEntry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // verticalLine
            // 
            this.verticalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.verticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verticalLine.Location = new System.Drawing.Point(388, -2);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(2, 602);
            this.verticalLine.TabIndex = 8;
            // 
            // enteredAmt
            // 
            this.enteredAmt.Culture = new System.Globalization.CultureInfo("en-001");
            this.enteredAmt.Location = new System.Drawing.Point(149, 44);
            this.enteredAmt.Name = "enteredAmt";
            this.enteredAmt.Size = new System.Drawing.Size(100, 23);
            this.enteredAmt.TabIndex = 1;
            this.enteredAmt.Text = "0.00";
            this.enteredAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enteredAmt_KeyPress);
            this.enteredAmt.Click += enteredAmt_Click;
            // 
            // butReset
            // 
            this.butReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butReset.Location = new System.Drawing.Point(243, 335);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(88, 27);
            this.butReset.TabIndex = 3;
            this.butReset.Text = "Reset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1058, 591);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.enteredAmt);
            this.Controls.Add(this.verticalLine);
            this.Controls.Add(this.peopleCountEntry);
            this.Controls.Add(this.tipEntry);
            this.Controls.Add(this.lTotTip);
            this.Controls.Add(this.lTipAmt);
            this.Controls.Add(this.lTotPerPers);
            this.Controls.Add(this.lTipPerPers);
            this.Controls.Add(this.butCalTip);
            this.Controls.Add(this.lPeopleCount);
            this.Controls.Add(this.lTipPerc);
            this.Controls.Add(this.lBill);
            this.Name = "MainPage";
            this.Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.tipEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleCountEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBill;
        private System.Windows.Forms.Label lTipPerc;
        private System.Windows.Forms.Label lPeopleCount;
        private System.Windows.Forms.Button butCalTip;
        private System.Windows.Forms.Label lTipPerPers;
        private System.Windows.Forms.Label lTotPerPers;
        private System.Windows.Forms.Label lTipAmt;
        private System.Windows.Forms.Label lTotTip;
        private System.Windows.Forms.NumericUpDown tipEntry;
        private System.Windows.Forms.NumericUpDown peopleCountEntry;
        private System.Windows.Forms.Label verticalLine;
        private System.Windows.Forms.MaskedTextBox enteredAmt;
        private System.Windows.Forms.Button butReset;
    }
}

