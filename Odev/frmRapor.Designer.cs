namespace Odev
{
    partial class frmRapor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSonOdeme = new System.Windows.Forms.CheckBox();
            this.cbToplamOdeme = new System.Windows.Forms.CheckBox();
            this.cbKalanBorc = new System.Windows.Forms.CheckBox();
            this.cbToplamBorc = new System.Windows.Forms.CheckBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnRaporla);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAPORLAMALAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 152);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.cbSonOdeme);
            this.panel1.Controls.Add(this.cbToplamOdeme);
            this.panel1.Controls.Add(this.cbKalanBorc);
            this.panel1.Controls.Add(this.cbToplamBorc);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 135);
            this.panel1.TabIndex = 5;
            // 
            // cbSonOdeme
            // 
            this.cbSonOdeme.AutoSize = true;
            this.cbSonOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSonOdeme.Location = new System.Drawing.Point(20, 101);
            this.cbSonOdeme.Name = "cbSonOdeme";
            this.cbSonOdeme.Size = new System.Drawing.Size(106, 24);
            this.cbSonOdeme.TabIndex = 3;
            this.cbSonOdeme.Text = "checkBox4";
            this.cbSonOdeme.UseVisualStyleBackColor = true;
            this.cbSonOdeme.CheckedChanged += new System.EventHandler(this.cbSonOdeme_CheckedChanged);
            // 
            // cbToplamOdeme
            // 
            this.cbToplamOdeme.AutoSize = true;
            this.cbToplamOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbToplamOdeme.Location = new System.Drawing.Point(20, 71);
            this.cbToplamOdeme.Name = "cbToplamOdeme";
            this.cbToplamOdeme.Size = new System.Drawing.Size(106, 24);
            this.cbToplamOdeme.TabIndex = 2;
            this.cbToplamOdeme.Text = "checkBox3";
            this.cbToplamOdeme.UseVisualStyleBackColor = true;
            this.cbToplamOdeme.CheckedChanged += new System.EventHandler(this.cbToplamOdeme_CheckedChanged);
            // 
            // cbKalanBorc
            // 
            this.cbKalanBorc.AutoSize = true;
            this.cbKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKalanBorc.Location = new System.Drawing.Point(20, 41);
            this.cbKalanBorc.Name = "cbKalanBorc";
            this.cbKalanBorc.Size = new System.Drawing.Size(106, 24);
            this.cbKalanBorc.TabIndex = 1;
            this.cbKalanBorc.Text = "checkBox2";
            this.cbKalanBorc.UseVisualStyleBackColor = true;
            this.cbKalanBorc.CheckedChanged += new System.EventHandler(this.cbKalanBorc_CheckedChanged);
            // 
            // cbToplamBorc
            // 
            this.cbToplamBorc.AutoSize = true;
            this.cbToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbToplamBorc.Location = new System.Drawing.Point(20, 11);
            this.cbToplamBorc.Name = "cbToplamBorc";
            this.cbToplamBorc.Size = new System.Drawing.Size(106, 24);
            this.cbToplamBorc.TabIndex = 0;
            this.cbToplamBorc.Text = "checkBox1";
            this.cbToplamBorc.UseVisualStyleBackColor = true;
            this.cbToplamBorc.CheckedChanged += new System.EventHandler(this.cbToplamBorc_CheckedChanged);
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(846, 226);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(249, 74);
            this.btnRaporla.TabIndex = 4;
            this.btnRaporla.Text = "RAPORLA";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(846, 155);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(249, 31);
            this.dtpBitis.TabIndex = 3;
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dtpBitis_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(917, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(846, 69);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(249, 31);
            this.dtpBaslangic.TabIndex = 1;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(890, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1142, 343);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama Ekranı";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckBox cbSonOdeme;
        public System.Windows.Forms.CheckBox cbToplamOdeme;
        public System.Windows.Forms.CheckBox cbKalanBorc;
        public System.Windows.Forms.CheckBox cbToplamBorc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}