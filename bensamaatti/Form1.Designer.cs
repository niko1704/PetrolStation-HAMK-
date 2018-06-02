namespace bensamaatti
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
            this.label1 = new System.Windows.Forms.Label();
            this.valitseMittari = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saldoMaara = new System.Windows.Forms.Label();
            this.e95 = new System.Windows.Forms.CheckBox();
            this.e98 = new System.Windows.Forms.CheckBox();
            this.diesel = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "NESTE Iisalmi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // valitseMittari
            // 
            this.valitseMittari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valitseMittari.CheckOnClick = true;
            this.valitseMittari.FormattingEnabled = true;
            this.valitseMittari.Items.AddRange(new object[] {
            "Mittari 1",
            "Mittari 2",
            "Mittari 3",
            "Mittari 4"});
            this.valitseMittari.Location = new System.Drawing.Point(153, 157);
            this.valitseMittari.Name = "valitseMittari";
            this.valitseMittari.Size = new System.Drawing.Size(266, 87);
            this.valitseMittari.TabIndex = 1;
            this.valitseMittari.ThreeDCheckBoxes = true;
            this.valitseMittari.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valitse mittari:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valitse polttoaine:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(153, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "STOP/KUITTI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "litraa";
            // 
            // saldoMaara
            // 
            this.saldoMaara.AutoSize = true;
            this.saldoMaara.Location = new System.Drawing.Point(204, 100);
            this.saldoMaara.Name = "saldoMaara";
            this.saldoMaara.Size = new System.Drawing.Size(0, 17);
            this.saldoMaara.TabIndex = 11;
            // 
            // e95
            // 
            this.e95.AutoSize = true;
            this.e95.Enabled = false;
            this.e95.Location = new System.Drawing.Point(148, 295);
            this.e95.Name = "e95";
            this.e95.Size = new System.Drawing.Size(110, 21);
            this.e95.TabIndex = 12;
            this.e95.Text = "E95  1.49 €/l";
            this.e95.UseVisualStyleBackColor = true;
            this.e95.CheckedChanged += new System.EventHandler(this.e95_CheckedChanged);
            // 
            // e98
            // 
            this.e98.AutoSize = true;
            this.e98.Enabled = false;
            this.e98.Location = new System.Drawing.Point(148, 322);
            this.e98.Name = "e98";
            this.e98.Size = new System.Drawing.Size(110, 21);
            this.e98.TabIndex = 12;
            this.e98.Text = "E98  1.55 €/l";
            this.e98.UseVisualStyleBackColor = true;
            this.e98.CheckedChanged += new System.EventHandler(this.e98_CheckedChanged);
            // 
            // diesel
            // 
            this.diesel.AutoSize = true;
            this.diesel.Enabled = false;
            this.diesel.Location = new System.Drawing.Point(264, 295);
            this.diesel.Name = "diesel";
            this.diesel.Size = new System.Drawing.Size(124, 21);
            this.diesel.TabIndex = 12;
            this.diesel.Text = "Diesel  1.19 €/l";
            this.diesel.UseVisualStyleBackColor = true;
            this.diesel.CheckedChanged += new System.EventHandler(this.diesel_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "€ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 526);
            this.Controls.Add(this.diesel);
            this.Controls.Add(this.e98);
            this.Controls.Add(this.e95);
            this.Controls.Add(this.saldoMaara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valitseMittari);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Neste Iisalmi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox valitseMittari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label saldoMaara;
        private System.Windows.Forms.CheckBox e95;
        private System.Windows.Forms.CheckBox e98;
        private System.Windows.Forms.CheckBox diesel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

