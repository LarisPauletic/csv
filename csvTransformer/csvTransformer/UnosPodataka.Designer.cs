namespace csvTransformer
{
    partial class UnosPodataka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosPodataka));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxIme = new System.Windows.Forms.TextBox();
            this.txtBxMail = new System.Windows.Forms.TextBox();
            this.txtBxPrez = new System.Windows.Forms.TextBox();
            this.cmBxRaz = new System.Windows.Forms.ComboBox();
            this.btnUnos1 = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Razred";
            // 
            // txtBxIme
            // 
            this.txtBxIme.Location = new System.Drawing.Point(48, 58);
            this.txtBxIme.Name = "txtBxIme";
            this.txtBxIme.Size = new System.Drawing.Size(364, 22);
            this.txtBxIme.TabIndex = 4;
            // 
            // txtBxMail
            // 
            this.txtBxMail.Location = new System.Drawing.Point(48, 155);
            this.txtBxMail.Name = "txtBxMail";
            this.txtBxMail.Size = new System.Drawing.Size(364, 22);
            this.txtBxMail.TabIndex = 5;
            // 
            // txtBxPrez
            // 
            this.txtBxPrez.Location = new System.Drawing.Point(48, 103);
            this.txtBxPrez.Name = "txtBxPrez";
            this.txtBxPrez.Size = new System.Drawing.Size(364, 22);
            this.txtBxPrez.TabIndex = 6;
            // 
            // cmBxRaz
            // 
            this.cmBxRaz.FormattingEnabled = true;
            this.cmBxRaz.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d",
            "2.a",
            "2.b",
            "2.c",
            "2.d",
            "3.a",
            "3.b",
            "3.c",
            "3.d",
            "4.a",
            "4.b",
            "4.c",
            "4.d"});
            this.cmBxRaz.Location = new System.Drawing.Point(48, 203);
            this.cmBxRaz.Name = "cmBxRaz";
            this.cmBxRaz.Size = new System.Drawing.Size(364, 24);
            this.cmBxRaz.TabIndex = 7;
            // 
            // btnUnos1
            // 
            this.btnUnos1.Location = new System.Drawing.Point(48, 233);
            this.btnUnos1.Name = "btnUnos1";
            this.btnUnos1.Size = new System.Drawing.Size(364, 53);
            this.btnUnos1.TabIndex = 8;
            this.btnUnos1.Text = "Unos";
            this.btnUnos1.UseVisualStyleBackColor = true;
            this.btnUnos1.Click += new System.EventHandler(this.btnUnos1_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(48, 292);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(364, 59);
            this.btnZavrsi.TabIndex = 9;
            this.btnZavrsi.Text = "Zavrsi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // UnosPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnUnos1);
            this.Controls.Add(this.cmBxRaz);
            this.Controls.Add(this.txtBxPrez);
            this.Controls.Add(this.txtBxMail);
            this.Controls.Add(this.txtBxIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosPodataka";
            this.Text = "UnosPodataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxIme;
        private System.Windows.Forms.TextBox txtBxMail;
        private System.Windows.Forms.TextBox txtBxPrez;
        private System.Windows.Forms.ComboBox cmBxRaz;
        private System.Windows.Forms.Button btnUnos1;
        private System.Windows.Forms.Button btnZavrsi;
    }
}