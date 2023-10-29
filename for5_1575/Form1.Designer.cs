namespace for5_1575
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBaslangic = new TextBox();
            txtBitis = new TextBox();
            txtDegisim = new TextBox();
            btnEkle = new Button();
            lbSayi = new ListBox();
            SuspendLayout();
            // 
            // txtBaslangic
            // 
            txtBaslangic.Location = new Point(16, 13);
            txtBaslangic.Name = "txtBaslangic";
            txtBaslangic.Size = new Size(125, 27);
            txtBaslangic.TabIndex = 0;
            // 
            // txtBitis
            // 
            txtBitis.Location = new Point(16, 56);
            txtBitis.Name = "txtBitis";
            txtBitis.Size = new Size(125, 27);
            txtBitis.TabIndex = 1;
            // 
            // txtDegisim
            // 
            txtDegisim.Location = new Point(16, 99);
            txtDegisim.Name = "txtDegisim";
            txtDegisim.Size = new Size(125, 27);
            txtDegisim.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SpringGreen;
            btnEkle.Location = new Point(16, 162);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 35);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lbSayi
            // 
            lbSayi.FormattingEnabled = true;
            lbSayi.ItemHeight = 20;
            lbSayi.Location = new Point(162, 13);
            lbSayi.Name = "lbSayi";
            lbSayi.Size = new Size(150, 264);
            lbSayi.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(327, 308);
            Controls.Add(lbSayi);
            Controls.Add(btnEkle);
            Controls.Add(txtDegisim);
            Controls.Add(txtBitis);
            Controls.Add(txtBaslangic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private TextBox txtDegisim;
        private Button btnEkle;
        private ListBox lbSayi;
    }
}