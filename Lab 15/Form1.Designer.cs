namespace Lab_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bCount = new System.Windows.Forms.Button();
            this.tBH = new System.Windows.Forms.TextBox();
            this.tBR = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCount
            // 
            this.bCount.Location = new System.Drawing.Point(108, 145);
            this.bCount.Name = "bCount";
            this.bCount.Size = new System.Drawing.Size(75, 23);
            this.bCount.TabIndex = 0;
            this.bCount.Text = "Count";
            this.bCount.UseVisualStyleBackColor = true;
            this.bCount.Click += new System.EventHandler(this.bCount_Click_1);
            // 
            // tBH
            // 
            this.tBH.Location = new System.Drawing.Point(96, 28);
            this.tBH.Name = "tBH";
            this.tBH.Size = new System.Drawing.Size(100, 22);
            this.tBH.TabIndex = 2;
            // 
            // tBR
            // 
            this.tBR.Location = new System.Drawing.Point(96, 87);
            this.tBR.Name = "tBR";
            this.tBR.Size = new System.Drawing.Size(100, 22);
            this.tBR.TabIndex = 3;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(93, 206);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(0, 16);
            this.lResult.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "h = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "r = ";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(279, 255);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tBR);
            this.Controls.Add(this.tBH);
            this.Controls.Add(this.bCount);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCount;
        private System.Windows.Forms.TextBox tBH;
        private System.Windows.Forms.TextBox tBR;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

