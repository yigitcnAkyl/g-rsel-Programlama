namespace GörselProgramlamaForm1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SucukCheck = new System.Windows.Forms.CheckBox();
            this.KasarCheck = new System.Windows.Forms.CheckBox();
            this.BiberCheck = new System.Windows.Forms.CheckBox();
            this.MantarCheck = new System.Windows.Forms.CheckBox();
            this.MisirCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // SucukCheck
            // 
            this.SucukCheck.AutoSize = true;
            this.SucukCheck.Location = new System.Drawing.Point(28, 184);
            this.SucukCheck.Name = "SucukCheck";
            this.SucukCheck.Size = new System.Drawing.Size(66, 20);
            this.SucukCheck.TabIndex = 4;
            this.SucukCheck.Text = "Sucuk";
            this.SucukCheck.UseVisualStyleBackColor = true;
            
            // 
            // KasarCheck
            // 
            this.KasarCheck.AutoSize = true;
            this.KasarCheck.Location = new System.Drawing.Point(28, 210);
            this.KasarCheck.Name = "KasarCheck";
            this.KasarCheck.Size = new System.Drawing.Size(64, 20);
            this.KasarCheck.TabIndex = 5;
            this.KasarCheck.Text = "Kaşar";
            this.KasarCheck.UseVisualStyleBackColor = true;
            
            // 
            // BiberCheck
            // 
            this.BiberCheck.AutoSize = true;
            this.BiberCheck.Location = new System.Drawing.Point(28, 236);
            this.BiberCheck.Name = "BiberCheck";
            this.BiberCheck.Size = new System.Drawing.Size(61, 20);
            this.BiberCheck.TabIndex = 6;
            this.BiberCheck.Text = "Biber";
            this.BiberCheck.UseVisualStyleBackColor = true;
            // 
            // MantarCheck
            // 
            this.MantarCheck.AutoSize = true;
            this.MantarCheck.Location = new System.Drawing.Point(28, 288);
            this.MantarCheck.Name = "MantarCheck";
            this.MantarCheck.Size = new System.Drawing.Size(70, 20);
            this.MantarCheck.TabIndex = 7;
            this.MantarCheck.Text = "Mantar";
            this.MantarCheck.UseVisualStyleBackColor = true;
            // 
            // MisirCheck
            // 
            this.MisirCheck.AutoSize = true;
            this.MisirCheck.Location = new System.Drawing.Point(28, 262);
            this.MisirCheck.Name = "MisirCheck";
            this.MisirCheck.Size = new System.Drawing.Size(57, 20);
            this.MisirCheck.TabIndex = 8;
            this.MisirCheck.Text = "Mısır";
            this.MisirCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pizza Sipariş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GörselProgramlamaForm1.Properties.Resources.pngtree_cheesy_pizza_slice_being_lifted_from_freshly_baked_pie_showcasing_gooey_image_17203271;
            this.ClientSize = new System.Drawing.Size(933, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MisirCheck);
            this.Controls.Add(this.MantarCheck);
            this.Controls.Add(this.BiberCheck);
            this.Controls.Add(this.KasarCheck);
            this.Controls.Add(this.SucukCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox SucukCheck;
        private System.Windows.Forms.CheckBox KasarCheck;
        private System.Windows.Forms.CheckBox BiberCheck;
        private System.Windows.Forms.CheckBox MantarCheck;
        private System.Windows.Forms.CheckBox MisirCheck;
        private System.Windows.Forms.Label label2;
    }
}