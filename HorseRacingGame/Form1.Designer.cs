namespace HorseRacingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pbxHorse1 = new System.Windows.Forms.PictureBox();
            this.pbxHorse2 = new System.Windows.Forms.PictureBox();
            this.pbxHorse3 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1191, 31);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1191, 31);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1191, 31);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1191, 31);
            this.label4.TabIndex = 3;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(1183, -2);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(39, 501);
            this.lblFinish.TabIndex = 4;
            // 
            // pbxHorse1
            // 
            this.pbxHorse1.Image = ((System.Drawing.Image)(resources.GetObject("pbxHorse1.Image")));
            this.pbxHorse1.Location = new System.Drawing.Point(2, 32);
            this.pbxHorse1.Name = "pbxHorse1";
            this.pbxHorse1.Size = new System.Drawing.Size(123, 111);
            this.pbxHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHorse1.TabIndex = 5;
            this.pbxHorse1.TabStop = false;
            // 
            // pbxHorse2
            // 
            this.pbxHorse2.Image = ((System.Drawing.Image)(resources.GetObject("pbxHorse2.Image")));
            this.pbxHorse2.Location = new System.Drawing.Point(2, 180);
            this.pbxHorse2.Name = "pbxHorse2";
            this.pbxHorse2.Size = new System.Drawing.Size(123, 116);
            this.pbxHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHorse2.TabIndex = 6;
            this.pbxHorse2.TabStop = false;
            // 
            // pbxHorse3
            // 
            this.pbxHorse3.Image = ((System.Drawing.Image)(resources.GetObject("pbxHorse3.Image")));
            this.pbxHorse3.Location = new System.Drawing.Point(2, 333);
            this.pbxHorse3.Name = "pbxHorse3";
            this.pbxHorse3.Size = new System.Drawing.Size(123, 132);
            this.pbxHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHorse3.TabIndex = 7;
            this.pbxHorse3.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 546);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 46);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(245, 534);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(873, 58);
            this.lblResult.TabIndex = 9;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1318, 698);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbxHorse3);
            this.Controls.Add(this.pbxHorse2);
            this.Controls.Add(this.pbxHorse1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHorse3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.PictureBox pbxHorse1;
        private System.Windows.Forms.PictureBox pbxHorse2;
        private System.Windows.Forms.PictureBox pbxHorse3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblResult;
    }
}

