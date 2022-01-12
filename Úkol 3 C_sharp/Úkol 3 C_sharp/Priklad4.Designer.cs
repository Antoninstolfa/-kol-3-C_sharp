namespace Úkol_3_C_sharp
{
    partial class Priklad4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.soucet = new System.Windows.Forms.RadioButton();
            this.soucin = new System.Windows.Forms.RadioButton();
            this.prumer = new System.Windows.Forms.RadioButton();
            this.vypocet = new System.Windows.Forms.Button();
            this.zpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "zadejte 4 cisla:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(238, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // soucet
            // 
            this.soucet.AutoSize = true;
            this.soucet.Location = new System.Drawing.Point(26, 93);
            this.soucet.Name = "soucet";
            this.soucet.Size = new System.Drawing.Size(59, 17);
            this.soucet.TabIndex = 5;
            this.soucet.TabStop = true;
            this.soucet.Text = "Součet";
            this.soucet.UseVisualStyleBackColor = true;
            // 
            // soucin
            // 
            this.soucin.AutoSize = true;
            this.soucin.Location = new System.Drawing.Point(26, 116);
            this.soucin.Name = "soucin";
            this.soucin.Size = new System.Drawing.Size(58, 17);
            this.soucin.TabIndex = 6;
            this.soucin.TabStop = true;
            this.soucin.Text = "Součin";
            this.soucin.UseVisualStyleBackColor = true;
            // 
            // prumer
            // 
            this.prumer.AutoSize = true;
            this.prumer.Location = new System.Drawing.Point(26, 139);
            this.prumer.Name = "prumer";
            this.prumer.Size = new System.Drawing.Size(58, 17);
            this.prumer.TabIndex = 7;
            this.prumer.TabStop = true;
            this.prumer.Text = "Průměr";
            this.prumer.UseVisualStyleBackColor = true;
            // 
            // vypocet
            // 
            this.vypocet.Location = new System.Drawing.Point(25, 162);
            this.vypocet.Name = "vypocet";
            this.vypocet.Size = new System.Drawing.Size(75, 23);
            this.vypocet.TabIndex = 8;
            this.vypocet.Text = "Vypočítat";
            this.vypocet.UseVisualStyleBackColor = true;
            this.vypocet.Click += new System.EventHandler(this.vypocet_Click);
            // 
            // zpet
            // 
            this.zpet.Location = new System.Drawing.Point(25, 227);
            this.zpet.Name = "zpet";
            this.zpet.Size = new System.Drawing.Size(75, 23);
            this.zpet.TabIndex = 9;
            this.zpet.Text = "Zpět";
            this.zpet.UseVisualStyleBackColor = true;
            this.zpet.Click += new System.EventHandler(this.zpet_Click);
            // 
            // Priklad4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 282);
            this.Controls.Add(this.zpet);
            this.Controls.Add(this.vypocet);
            this.Controls.Add(this.prumer);
            this.Controls.Add(this.soucin);
            this.Controls.Add(this.soucet);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Priklad4";
            this.Text = "Priklad4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton soucet;
        private System.Windows.Forms.RadioButton soucin;
        private System.Windows.Forms.RadioButton prumer;
        private System.Windows.Forms.Button vypocet;
        private System.Windows.Forms.Button zpet;
    }
}