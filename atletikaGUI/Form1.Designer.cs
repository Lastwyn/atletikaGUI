
namespace atletikaGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_aranykeres = new System.Windows.Forms.Button();
            this.listBox1_kiiratas = new System.Windows.Forms.ListBox();
            this.btn_keres = new System.Windows.Forms.Button();
            this.neve = new System.Windows.Forms.Label();
            this.eredmenye = new System.Windows.Forms.Label();
            this.nemzete = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1_versenyszam = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Válassza ki a versenyszámot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Válassza ki az érmes helyezést:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(349, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Versenyző adatai:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "neve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "eredménye:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "nemzete:";
            // 
            // btn_aranykeres
            // 
            this.btn_aranykeres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_aranykeres.Location = new System.Drawing.Point(59, 554);
            this.btn_aranykeres.Name = "btn_aranykeres";
            this.btn_aranykeres.Size = new System.Drawing.Size(198, 34);
            this.btn_aranykeres.TabIndex = 7;
            this.btn_aranykeres.Text = "aranyos - nemzetek";
            this.btn_aranykeres.UseVisualStyleBackColor = false;
            this.btn_aranykeres.Click += new System.EventHandler(this.btn_aranykeres_Click);
            // 
            // listBox1_kiiratas
            // 
            this.listBox1_kiiratas.FormattingEnabled = true;
            this.listBox1_kiiratas.ItemHeight = 18;
            this.listBox1_kiiratas.Location = new System.Drawing.Point(28, 58);
            this.listBox1_kiiratas.Name = "listBox1_kiiratas";
            this.listBox1_kiiratas.Size = new System.Drawing.Size(265, 454);
            this.listBox1_kiiratas.TabIndex = 8;
            this.listBox1_kiiratas.SelectedIndexChanged += new System.EventHandler(this.listBox1_kiiratas_SelectedIndexChanged);
            // 
            // btn_keres
            // 
            this.btn_keres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_keres.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_keres.Location = new System.Drawing.Point(394, 371);
            this.btn_keres.Name = "btn_keres";
            this.btn_keres.Size = new System.Drawing.Size(156, 32);
            this.btn_keres.TabIndex = 9;
            this.btn_keres.Text = "keresés";
            this.btn_keres.UseVisualStyleBackColor = false;
            // 
            // neve
            // 
            this.neve.AutoSize = true;
            this.neve.Location = new System.Drawing.Point(452, 473);
            this.neve.Name = "neve";
            this.neve.Size = new System.Drawing.Size(0, 18);
            this.neve.TabIndex = 10;
            // 
            // eredmenye
            // 
            this.eredmenye.AutoSize = true;
            this.eredmenye.Location = new System.Drawing.Point(452, 519);
            this.eredmenye.Name = "eredmenye";
            this.eredmenye.Size = new System.Drawing.Size(0, 18);
            this.eredmenye.TabIndex = 11;
            // 
            // nemzete
            // 
            this.nemzete.AutoSize = true;
            this.nemzete.Location = new System.Drawing.Point(452, 566);
            this.nemzete.Name = "nemzete";
            this.nemzete.Size = new System.Drawing.Size(0, 18);
            this.nemzete.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(334, 236);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 27);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1_versenyszam
            // 
            this.listBox1_versenyszam.FormattingEnabled = true;
            this.listBox1_versenyszam.ItemHeight = 18;
            this.listBox1_versenyszam.Location = new System.Drawing.Point(334, 67);
            this.listBox1_versenyszam.Name = "listBox1_versenyszam";
            this.listBox1_versenyszam.Size = new System.Drawing.Size(250, 94);
            this.listBox1_versenyszam.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.listBox1_versenyszam);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.nemzete);
            this.Controls.Add(this.eredmenye);
            this.Controls.Add(this.neve);
            this.Controls.Add(this.btn_keres);
            this.Controls.Add(this.listBox1_kiiratas);
            this.Controls.Add(this.btn_aranykeres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Férfiak eredménye a 2017-es atlétikai VB-n";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_aranykeres;
        private System.Windows.Forms.ListBox listBox1_kiiratas;
        private System.Windows.Forms.Button btn_keres;
        private System.Windows.Forms.Label neve;
        private System.Windows.Forms.Label eredmenye;
        private System.Windows.Forms.Label nemzete;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1_versenyszam;
    }
}

