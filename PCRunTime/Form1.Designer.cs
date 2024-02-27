namespace PCRunTime
{
    partial class MainWindow
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelCompany = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelTimeTotal = new System.Windows.Forms.Label();
            this.LabelTimeToday = new System.Windows.Forms.Label();
            this.LabelTimeCurrent = new System.Windows.Forms.Label();
            this.ButtonSaveQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.Lime;
            this.LabelTitle.Location = new System.Drawing.Point(125, 31);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(113, 20);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "PC Run Time";
            // 
            // LabelCompany
            // 
            this.LabelCompany.AutoSize = true;
            this.LabelCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCompany.ForeColor = System.Drawing.Color.Lime;
            this.LabelCompany.Location = new System.Drawing.Point(0, 249);
            this.LabelCompany.Name = "LabelCompany";
            this.LabelCompany.Size = new System.Drawing.Size(24, 9);
            this.LabelCompany.TabIndex = 1;
            this.LabelCompany.Text = "comp";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.Color.Lime;
            this.LabelVersion.Location = new System.Drawing.Point(0, 237);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelVersion.Size = new System.Drawing.Size(11, 9);
            this.LabelVersion.TabIndex = 2;
            this.LabelVersion.Text = "v.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(73, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(73, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Today Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(73, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Time:";
            // 
            // LabelTimeTotal
            // 
            this.LabelTimeTotal.AutoSize = true;
            this.LabelTimeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeTotal.ForeColor = System.Drawing.Color.Lime;
            this.LabelTimeTotal.Location = new System.Drawing.Point(214, 187);
            this.LabelTimeTotal.Name = "LabelTimeTotal";
            this.LabelTimeTotal.Size = new System.Drawing.Size(61, 13);
            this.LabelTimeTotal.TabIndex = 8;
            this.LabelTimeTotal.Text = "00 : 00 : 00";
            // 
            // LabelTimeToday
            // 
            this.LabelTimeToday.AutoSize = true;
            this.LabelTimeToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeToday.ForeColor = System.Drawing.Color.Lime;
            this.LabelTimeToday.Location = new System.Drawing.Point(214, 137);
            this.LabelTimeToday.Name = "LabelTimeToday";
            this.LabelTimeToday.Size = new System.Drawing.Size(61, 13);
            this.LabelTimeToday.TabIndex = 7;
            this.LabelTimeToday.Text = "00 : 00 : 00";
            // 
            // LabelTimeCurrent
            // 
            this.LabelTimeCurrent.AutoSize = true;
            this.LabelTimeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeCurrent.ForeColor = System.Drawing.Color.Lime;
            this.LabelTimeCurrent.Location = new System.Drawing.Point(214, 87);
            this.LabelTimeCurrent.Name = "LabelTimeCurrent";
            this.LabelTimeCurrent.Size = new System.Drawing.Size(61, 13);
            this.LabelTimeCurrent.TabIndex = 6;
            this.LabelTimeCurrent.Text = "00 : 00 : 00";
            // 
            // ButtonSaveQuit
            // 
            this.ButtonSaveQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSaveQuit.ForeColor = System.Drawing.Color.Lime;
            this.ButtonSaveQuit.Location = new System.Drawing.Point(120, 215);
            this.ButtonSaveQuit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveQuit.Name = "ButtonSaveQuit";
            this.ButtonSaveQuit.Size = new System.Drawing.Size(100, 20);
            this.ButtonSaveQuit.TabIndex = 9;
            this.ButtonSaveQuit.Text = "Save and Quit";
            this.ButtonSaveQuit.UseVisualStyleBackColor = true;
            this.ButtonSaveQuit.Click += new System.EventHandler(this.ButtonSaveQuit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(383, 259);
            this.Controls.Add(this.ButtonSaveQuit);
            this.Controls.Add(this.LabelTimeTotal);
            this.Controls.Add(this.LabelTimeToday);
            this.Controls.Add(this.LabelTimeCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelCompany);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(399, 298);
            this.MinimumSize = new System.Drawing.Size(399, 298);
            this.Name = "MainWindow";
            this.Text = "PCRunTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelCompany;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelTimeTotal;
        private System.Windows.Forms.Label LabelTimeToday;
        private System.Windows.Forms.Label LabelTimeCurrent;
        private System.Windows.Forms.Button ButtonSaveQuit;
    }
}

