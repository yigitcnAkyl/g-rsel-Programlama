namespace görselprogramlama_3hafta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gorselProgramlama = new System.Windows.Forms.CheckBox();
            this.yalinProgramlama = new System.Windows.Forms.CheckBox();
            this.fonksiyonelProgramlama = new System.Windows.Forms.CheckBox();
            this.ingilizce = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.onaylaButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.onaylaButon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ingilizce);
            this.groupBox1.Controls.Add(this.fonksiyonelProgramlama);
            this.groupBox1.Controls.Add(this.yalinProgramlama);
            this.groupBox1.Controls.Add(this.gorselProgramlama);
            this.groupBox1.Location = new System.Drawing.Point(200, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçmeli dersler";
            // 
            // gorselProgramlama
            // 
            this.gorselProgramlama.AutoSize = true;
            this.gorselProgramlama.Location = new System.Drawing.Point(18, 99);
            this.gorselProgramlama.Name = "gorselProgramlama";
            this.gorselProgramlama.Size = new System.Drawing.Size(206, 20);
            this.gorselProgramlama.TabIndex = 0;
            this.gorselProgramlama.Text = "Görsel Programlama (4 Kredi)";
            this.gorselProgramlama.UseVisualStyleBackColor = true;
            // 
            // yalinProgramlama
            // 
            this.yalinProgramlama.AutoSize = true;
            this.yalinProgramlama.Location = new System.Drawing.Point(18, 126);
            this.yalinProgramlama.Name = "yalinProgramlama";
            this.yalinProgramlama.Size = new System.Drawing.Size(196, 20);
            this.yalinProgramlama.TabIndex = 1;
            this.yalinProgramlama.Text = "Yalın Programlama (3 Kredi)";
            this.yalinProgramlama.UseVisualStyleBackColor = true;
            // 
            // fonksiyonelProgramlama
            // 
            this.fonksiyonelProgramlama.AutoSize = true;
            this.fonksiyonelProgramlama.Location = new System.Drawing.Point(18, 153);
            this.fonksiyonelProgramlama.Name = "fonksiyonelProgramlama";
            this.fonksiyonelProgramlama.Size = new System.Drawing.Size(239, 20);
            this.fonksiyonelProgramlama.TabIndex = 2;
            this.fonksiyonelProgramlama.Text = "Fonksiyonel Programlama (4 Kredi)";
            this.fonksiyonelProgramlama.UseVisualStyleBackColor = true;
            // 
            // ingilizce
            // 
            this.ingilizce.AutoSize = true;
            this.ingilizce.Location = new System.Drawing.Point(18, 180);
            this.ingilizce.Name = "ingilizce";
            this.ingilizce.Size = new System.Drawing.Size(129, 20);
            this.ingilizce.TabIndex = 3;
            this.ingilizce.Text = "İngilizce (2 Kredi)";
            this.ingilizce.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seçmeli ders seçiminizi yapınız";
            // 
            // onaylaButon
            // 
            this.onaylaButon.Location = new System.Drawing.Point(275, 229);
            this.onaylaButon.Name = "onaylaButon";
            this.onaylaButon.Size = new System.Drawing.Size(143, 49);
            this.onaylaButon.TabIndex = 5;
            this.onaylaButon.Text = "Onayla";
            this.onaylaButon.UseVisualStyleBackColor = true;
            this.onaylaButon.Click += new System.EventHandler(this.onaylaButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button onaylaButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ingilizce;
        private System.Windows.Forms.CheckBox fonksiyonelProgramlama;
        private System.Windows.Forms.CheckBox yalinProgramlama;
        private System.Windows.Forms.CheckBox gorselProgramlama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

