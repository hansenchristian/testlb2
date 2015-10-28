namespace _8Ball_Anwendung
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
            this.hit = new System.Windows.Forms.Button();
            this.elmBalls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.touchedBalls = new System.Windows.Forms.TextBox();
            this.lb_ansage = new System.Windows.Forms.Label();
            this.cb_ansage = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lb_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hit
            // 
            this.hit.Location = new System.Drawing.Point(266, 206);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(99, 31);
            this.hit.TabIndex = 0;
            this.hit.Text = "Stoß";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // elmBalls
            // 
            this.elmBalls.Location = new System.Drawing.Point(265, 85);
            this.elmBalls.Name = "elmBalls";
            this.elmBalls.Size = new System.Drawing.Size(100, 20);
            this.elmBalls.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versenkte Bälle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anzahl der Bälle die die Bande berührt haben:";
            // 
            // touchedBalls
            // 
            this.touchedBalls.Location = new System.Drawing.Point(265, 33);
            this.touchedBalls.Name = "touchedBalls";
            this.touchedBalls.Size = new System.Drawing.Size(100, 20);
            this.touchedBalls.TabIndex = 6;
            // 
            // lb_ansage
            // 
            this.lb_ansage.AutoSize = true;
            this.lb_ansage.Location = new System.Drawing.Point(42, 148);
            this.lb_ansage.Name = "lb_ansage";
            this.lb_ansage.Size = new System.Drawing.Size(46, 13);
            this.lb_ansage.TabIndex = 7;
            this.lb_ansage.Text = "Ansage:";
            this.lb_ansage.Visible = false;
            // 
            // cb_ansage
            // 
            this.cb_ansage.FormattingEnabled = true;
            this.cb_ansage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_ansage.Location = new System.Drawing.Point(265, 139);
            this.cb_ansage.Name = "cb_ansage";
            this.cb_ansage.Size = new System.Drawing.Size(100, 21);
            this.cb_ansage.TabIndex = 8;
            this.cb_ansage.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 261);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(323, 178);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(112, 206);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(13, 13);
            this.lb_count.TabIndex = 10;
            this.lb_count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spielzüge:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cb_ansage);
            this.Controls.Add(this.lb_ansage);
            this.Controls.Add(this.touchedBalls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elmBalls);
            this.Controls.Add(this.hit);
            this.Name = "Form1";
            this.Text = "8 Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.TextBox elmBalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox touchedBalls;
        private System.Windows.Forms.Label lb_ansage;
        private System.Windows.Forms.ComboBox cb_ansage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label3;
    }
}

