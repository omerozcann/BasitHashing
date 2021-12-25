namespace basithashing
{
    partial class basitHashFrm
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
            this.kelimelerlst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hashkodlst = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kelimeyuklebtn = new System.Windows.Forms.Button();
            this.hashuretbtn = new System.Windows.Forms.Button();
            this.indekslebtn = new System.Windows.Forms.Button();
            this.modgosterbtn = new System.Windows.Forms.Button();
            this.modlst = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.indekslst = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aranantxt = new System.Windows.Forms.TextBox();
            this.arabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kelimelerlst
            // 
            this.kelimelerlst.FormattingEnabled = true;
            this.kelimelerlst.Location = new System.Drawing.Point(12, 38);
            this.kelimelerlst.Name = "kelimelerlst";
            this.kelimelerlst.Size = new System.Drawing.Size(120, 498);
            this.kelimelerlst.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelimeler";
            // 
            // hashkodlst
            // 
            this.hashkodlst.FormattingEnabled = true;
            this.hashkodlst.Location = new System.Drawing.Point(151, 38);
            this.hashkodlst.Name = "hashkodlst";
            this.hashkodlst.Size = new System.Drawing.Size(120, 498);
            this.hashkodlst.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hash Kodları";
            // 
            // kelimeyuklebtn
            // 
            this.kelimeyuklebtn.Location = new System.Drawing.Point(602, 41);
            this.kelimeyuklebtn.Name = "kelimeyuklebtn";
            this.kelimeyuklebtn.Size = new System.Drawing.Size(90, 23);
            this.kelimeyuklebtn.TabIndex = 4;
            this.kelimeyuklebtn.Text = "Kelimeleri Yükle";
            this.kelimeyuklebtn.UseVisualStyleBackColor = true;
            this.kelimeyuklebtn.Click += new System.EventHandler(this.kelimeyuklebtn_Click);
            // 
            // hashuretbtn
            // 
            this.hashuretbtn.Location = new System.Drawing.Point(602, 70);
            this.hashuretbtn.Name = "hashuretbtn";
            this.hashuretbtn.Size = new System.Drawing.Size(90, 23);
            this.hashuretbtn.TabIndex = 5;
            this.hashuretbtn.Text = "Hash Üret";
            this.hashuretbtn.UseVisualStyleBackColor = true;
            this.hashuretbtn.Click += new System.EventHandler(this.hashuretbtn_Click);
            // 
            // indekslebtn
            // 
            this.indekslebtn.Location = new System.Drawing.Point(602, 128);
            this.indekslebtn.Name = "indekslebtn";
            this.indekslebtn.Size = new System.Drawing.Size(90, 23);
            this.indekslebtn.TabIndex = 6;
            this.indekslebtn.Text = "İndeksle";
            this.indekslebtn.UseVisualStyleBackColor = true;
            this.indekslebtn.Click += new System.EventHandler(this.indekslebtn_Click);
            // 
            // modgosterbtn
            // 
            this.modgosterbtn.Location = new System.Drawing.Point(602, 99);
            this.modgosterbtn.Name = "modgosterbtn";
            this.modgosterbtn.Size = new System.Drawing.Size(90, 23);
            this.modgosterbtn.TabIndex = 7;
            this.modgosterbtn.Text = "Modları Göster";
            this.modgosterbtn.UseVisualStyleBackColor = true;
            this.modgosterbtn.Click += new System.EventHandler(this.modgosterbtn_Click);
            // 
            // modlst
            // 
            this.modlst.FormattingEnabled = true;
            this.modlst.Location = new System.Drawing.Point(294, 38);
            this.modlst.Name = "modlst";
            this.modlst.Size = new System.Drawing.Size(120, 498);
            this.modlst.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modlar";
            // 
            // indekslst
            // 
            this.indekslst.FormattingEnabled = true;
            this.indekslst.Location = new System.Drawing.Point(431, 38);
            this.indekslst.Name = "indekslst";
            this.indekslst.Size = new System.Drawing.Size(120, 498);
            this.indekslst.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "İndekslenmiş Veri";
            // 
            // aranantxt
            // 
            this.aranantxt.Location = new System.Drawing.Point(592, 204);
            this.aranantxt.Name = "aranantxt";
            this.aranantxt.Size = new System.Drawing.Size(100, 20);
            this.aranantxt.TabIndex = 12;
            // 
            // arabtn
            // 
            this.arabtn.Location = new System.Drawing.Point(602, 230);
            this.arabtn.Name = "arabtn";
            this.arabtn.Size = new System.Drawing.Size(75, 23);
            this.arabtn.TabIndex = 13;
            this.arabtn.Text = "Ara";
            this.arabtn.UseVisualStyleBackColor = true;
            this.arabtn.Click += new System.EventHandler(this.arabtn_Click);
            // 
            // basitHashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 550);
            this.Controls.Add(this.arabtn);
            this.Controls.Add(this.aranantxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.indekslst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modlst);
            this.Controls.Add(this.modgosterbtn);
            this.Controls.Add(this.indekslebtn);
            this.Controls.Add(this.hashuretbtn);
            this.Controls.Add(this.kelimeyuklebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hashkodlst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kelimelerlst);
            this.Name = "basitHashFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basit Hashing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kelimelerlst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox hashkodlst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kelimeyuklebtn;
        private System.Windows.Forms.Button hashuretbtn;
        private System.Windows.Forms.Button indekslebtn;
        private System.Windows.Forms.Button modgosterbtn;
        private System.Windows.Forms.ListBox modlst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox indekslst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aranantxt;
        private System.Windows.Forms.Button arabtn;
    }
}

