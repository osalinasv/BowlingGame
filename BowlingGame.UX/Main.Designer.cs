
namespace BowlingGame.UX
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected System.Drawing.Color GreenAccentColor =
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));

        protected System.Drawing.Color YellowAccentColor =
            System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(182)))), ((int)(((byte)(61)))));


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
            this.BtnRoll = new System.Windows.Forms.Button();
            this.InpPins = new System.Windows.Forms.NumericUpDown();
            this.LblScoreTitle = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.LbxEvents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.InpPins)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRoll
            // 
            this.BtnRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));
            this.BtnRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoll.ForeColor = System.Drawing.Color.Black;
            this.BtnRoll.Location = new System.Drawing.Point(108, 12);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(294, 58);
            this.BtnRoll.TabIndex = 1;
            this.BtnRoll.Text = "Register Roll";
            this.BtnRoll.UseVisualStyleBackColor = false;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // InpPins
            // 
            this.InpPins.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpPins.Location = new System.Drawing.Point(12, 12);
            this.InpPins.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.InpPins.MaximumSize = new System.Drawing.Size(90, 0);
            this.InpPins.Name = "InpPins";
            this.InpPins.Size = new System.Drawing.Size(90, 58);
            this.InpPins.TabIndex = 0;
            this.InpPins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblScoreTitle
            // 
            this.LblScoreTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblScoreTitle.AutoSize = true;
            this.LblScoreTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScoreTitle.Location = new System.Drawing.Point(178, 94);
            this.LblScoreTitle.Name = "LblScoreTitle";
            this.LblScoreTitle.Size = new System.Drawing.Size(60, 24);
            this.LblScoreTitle.TabIndex = 2;
            this.LblScoreTitle.Text = "Score:";
            this.LblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblScore
            // 
            this.LblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));
            this.LblScore.Location = new System.Drawing.Point(185, 120);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(43, 51);
            this.LblScore.TabIndex = 2;
            this.LblScore.Text = "0";
            this.LblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbxEvents
            // 
            this.LbxEvents.BackColor = System.Drawing.Color.White;
            this.LbxEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbxEvents.FormattingEnabled = true;
            this.LbxEvents.ItemHeight = 16;
            this.LbxEvents.Location = new System.Drawing.Point(12, 206);
            this.LbxEvents.Name = "LbxEvents";
            this.LbxEvents.Size = new System.Drawing.Size(390, 128);
            this.LbxEvents.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(414, 351);
            this.Controls.Add(this.LbxEvents);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblScoreTitle);
            this.Controls.Add(this.InpPins);
            this.Controls.Add(this.BtnRoll);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Bowling Game";
            ((System.ComponentModel.ISupportInitialize)(this.InpPins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.NumericUpDown InpPins;
        private System.Windows.Forms.Label LblScoreTitle;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.ListBox LbxEvents;
    }
}

