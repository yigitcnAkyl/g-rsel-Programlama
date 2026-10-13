namespace formapphafta3v._2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ogrenciRadio = new System.Windows.Forms.RadioButton();
            this.kamuRadio = new System.Windows.Forms.RadioButton();
            this.pizzaCheck = new System.Windows.Forms.CheckBox();
            this.hamburgerCheck = new System.Windows.Forms.CheckBox();
            this.makarnaCheck = new System.Windows.Forms.CheckBox();
            this.kebapCheck = new System.Windows.Forms.CheckBox();
            this.ayranCheck = new System.Windows.Forms.CheckBox();
            this.kolaCheck = new System.Windows.Forms.CheckBox();
            this.fantaCheck = new System.Windows.Forms.CheckBox();
            this.salgamCheck = new System.Windows.Forms.CheckBox();
            this.onaylaButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kebapCheck);
            this.groupBox1.Controls.Add(this.makarnaCheck);
            this.groupBox1.Controls.Add(this.hamburgerCheck);
            this.groupBox1.Controls.Add(this.pizzaCheck);
            this.groupBox1.Location = new System.Drawing.Point(50, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salgamCheck);
            this.groupBox2.Controls.Add(this.fantaCheck);
            this.groupBox2.Controls.Add(this.kolaCheck);
            this.groupBox2.Controls.Add(this.ayranCheck);
            this.groupBox2.Location = new System.Drawing.Point(412, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İçicek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kamuRadio);
            this.groupBox3.Controls.Add(this.ogrenciRadio);
            this.groupBox3.Location = new System.Drawing.Point(59, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İndirim Tutarı";
            // 
            // ogrenciRadio
            // 
            this.ogrenciRadio.AutoSize = true;
            this.ogrenciRadio.Location = new System.Drawing.Point(6, 33);
            this.ogrenciRadio.Name = "ogrenciRadio";
            this.ogrenciRadio.Size = new System.Drawing.Size(154, 20);
            this.ogrenciRadio.TabIndex = 0;
            this.ogrenciRadio.TabStop = true;
            this.ogrenciRadio.Text = "Öğrenci İndirimi(%25)";
            this.ogrenciRadio.UseVisualStyleBackColor = true;
            // 
            // kamuRadio
            // 
            this.kamuRadio.AutoSize = true;
            this.kamuRadio.Location = new System.Drawing.Point(7, 69);
            this.kamuRadio.Name = "kamuRadio";
            this.kamuRadio.Size = new System.Drawing.Size(141, 20);
            this.kamuRadio.TabIndex = 1;
            this.kamuRadio.TabStop = true;
            this.kamuRadio.Text = "Kamu İndirimi(%20)";
            this.kamuRadio.UseVisualStyleBackColor = true;
            // 
            // pizzaCheck
            // 
            this.pizzaCheck.AutoSize = true;
            this.pizzaCheck.Location = new System.Drawing.Point(9, 44);
            this.pizzaCheck.Name = "pizzaCheck";
            this.pizzaCheck.Size = new System.Drawing.Size(109, 20);
            this.pizzaCheck.TabIndex = 0;
            this.pizzaCheck.Text = "Pizza (300TL)";
            this.pizzaCheck.UseVisualStyleBackColor = true;
            // 
            // hamburgerCheck
            // 
            this.hamburgerCheck.AutoSize = true;
            this.hamburgerCheck.Location = new System.Drawing.Point(9, 82);
            this.hamburgerCheck.Name = "hamburgerCheck";
            this.hamburgerCheck.Size = new System.Drawing.Size(145, 20);
            this.hamburgerCheck.TabIndex = 1;
            this.hamburgerCheck.Text = "Hamburger (300TL)";
            this.hamburgerCheck.UseVisualStyleBackColor = true;
            // 
            // makarnaCheck
            // 
            this.makarnaCheck.AutoSize = true;
            this.makarnaCheck.Location = new System.Drawing.Point(9, 119);
            this.makarnaCheck.Name = "makarnaCheck";
            this.makarnaCheck.Size = new System.Drawing.Size(127, 20);
            this.makarnaCheck.TabIndex = 2;
            this.makarnaCheck.Text = "Makarna(150TL)";
            this.makarnaCheck.UseVisualStyleBackColor = true;
            // 
            // kebapCheck
            // 
            this.kebapCheck.AutoSize = true;
            this.kebapCheck.Location = new System.Drawing.Point(9, 157);
            this.kebapCheck.Name = "kebapCheck";
            this.kebapCheck.Size = new System.Drawing.Size(114, 20);
            this.kebapCheck.TabIndex = 3;
            this.kebapCheck.Text = "Kebap(450TL)";
            this.kebapCheck.UseVisualStyleBackColor = true;
            // 
            // ayranCheck
            // 
            this.ayranCheck.AutoSize = true;
            this.ayranCheck.Location = new System.Drawing.Point(8, 44);
            this.ayranCheck.Name = "ayranCheck";
            this.ayranCheck.Size = new System.Drawing.Size(102, 20);
            this.ayranCheck.TabIndex = 0;
            this.ayranCheck.Text = "Ayran(50TL)";
            this.ayranCheck.UseVisualStyleBackColor = true;
            // 
            // kolaCheck
            // 
            this.kolaCheck.AutoSize = true;
            this.kolaCheck.Location = new System.Drawing.Point(6, 82);
            this.kolaCheck.Name = "kolaCheck";
            this.kolaCheck.Size = new System.Drawing.Size(94, 20);
            this.kolaCheck.TabIndex = 1;
            this.kolaCheck.Text = "Kola(75TL)";
            this.kolaCheck.UseVisualStyleBackColor = true;
            // 
            // fantaCheck
            // 
            this.fantaCheck.AutoSize = true;
            this.fantaCheck.Location = new System.Drawing.Point(6, 119);
            this.fantaCheck.Name = "fantaCheck";
            this.fantaCheck.Size = new System.Drawing.Size(101, 20);
            this.fantaCheck.TabIndex = 2;
            this.fantaCheck.Text = "Fanta(75TL)";
            this.fantaCheck.UseVisualStyleBackColor = true;
            // 
            // salgamCheck
            // 
            this.salgamCheck.AutoSize = true;
            this.salgamCheck.Location = new System.Drawing.Point(6, 157);
            this.salgamCheck.Name = "salgamCheck";
            this.salgamCheck.Size = new System.Drawing.Size(114, 20);
            this.salgamCheck.TabIndex = 3;
            this.salgamCheck.Text = "Şalgam(60TL)";
            this.salgamCheck.UseVisualStyleBackColor = true;
            // 
            // onaylaButon
            // 
            this.onaylaButon.Location = new System.Drawing.Point(466, 325);
            this.onaylaButon.Name = "onaylaButon";
            this.onaylaButon.Size = new System.Drawing.Size(166, 71);
            this.onaylaButon.TabIndex = 3;
            this.onaylaButon.Text = "Siparişi Tamamla";
            this.onaylaButon.UseVisualStyleBackColor = true;
            this.onaylaButon.Click += new System.EventHandler(this.onaylaButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onaylaButon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton kamuRadio;
        private System.Windows.Forms.RadioButton ogrenciRadio;
        private System.Windows.Forms.CheckBox kebapCheck;
        private System.Windows.Forms.CheckBox makarnaCheck;
        private System.Windows.Forms.CheckBox hamburgerCheck;
        private System.Windows.Forms.CheckBox pizzaCheck;
        private System.Windows.Forms.CheckBox fantaCheck;
        private System.Windows.Forms.CheckBox kolaCheck;
        private System.Windows.Forms.CheckBox ayranCheck;
        private System.Windows.Forms.CheckBox salgamCheck;
        private System.Windows.Forms.Button onaylaButon;
        private System.Windows.Forms.Label label1;
    }
}

