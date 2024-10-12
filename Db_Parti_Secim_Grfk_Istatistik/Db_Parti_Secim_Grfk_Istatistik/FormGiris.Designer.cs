namespace Db_Parti_Secim_Grfk_Istatistik
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtilcead = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOY = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // txtilcead
            // 
            this.txtilcead.Location = new System.Drawing.Point(93, 28);
            this.txtilcead.Name = "txtilcead";
            this.txtilcead.Size = new System.Drawing.Size(211, 29);
            this.txtilcead.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(93, 68);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(211, 29);
            this.txtA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(93, 103);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(211, 29);
            this.txtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(93, 208);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(211, 29);
            this.txtE.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "E PARTİ:";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(93, 173);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(211, 29);
            this.txtD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(93, 138);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(211, 29);
            this.txtC.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "C PARTİ:";
            // 
            // btnOY
            // 
            this.btnOY.Location = new System.Drawing.Point(93, 243);
            this.btnOY.Name = "btnOY";
            this.btnOY.Size = new System.Drawing.Size(211, 35);
            this.btnOY.TabIndex = 12;
            this.btnOY.Text = "OY GİRİŞİ YAP";
            this.btnOY.UseVisualStyleBackColor = true;
            this.btnOY.Click += new System.EventHandler(this.btnOY_Click);
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(93, 284);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(103, 35);
            this.btnGrafik.TabIndex = 13;
            this.btnGrafik.Text = "GRAFİKLER";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(201, 284);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(103, 35);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnGrafik);
            this.groupBox1.Controls.Add(this.btnOY);
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtilcead);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 331);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Tabanlı Oy Giriş Sistemi";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(362, 347);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Tabanlı Giriş Sistemi";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilcead;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOY;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

