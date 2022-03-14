
namespace Praktikum4
{
    partial class Form2
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
            this.buttonPrevData = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrevData
            // 
            this.buttonPrevData.Location = new System.Drawing.Point(101, 124);
            this.buttonPrevData.Name = "buttonPrevData";
            this.buttonPrevData.Size = new System.Drawing.Size(81, 23);
            this.buttonPrevData.TabIndex = 15;
            this.buttonPrevData.Text = "Prev Data";
            this.buttonPrevData.UseVisualStyleBackColor = true;
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(20, 124);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(75, 23);
            this.buttonKembali.TabIndex = 14;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Location = new System.Drawing.Point(64, 82);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.Size = new System.Drawing.Size(350, 22);
            this.textBoxTelp.TabIndex = 13;
            this.textBoxTelp.Text = "<data kosong>";
            this.textBoxTelp.TextChanged += new System.EventHandler(this.textBoxTelp_TextChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(79, 53);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(335, 22);
            this.textBoxAlamat.TabIndex = 12;
            this.textBoxAlamat.Text = "<data kosong>";
            this.textBoxAlamat.TextChanged += new System.EventHandler(this.textBoxAlamat_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(73, 24);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(341, 22);
            this.textBoxNama.TabIndex = 11;
            this.textBoxNama.Text = "<data kosong>";
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alamat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama:";
            // 
            // buttonNextData
            // 
            this.buttonNextData.Location = new System.Drawing.Point(188, 124);
            this.buttonNextData.Name = "buttonNextData";
            this.buttonNextData.Size = new System.Drawing.Size(78, 23);
            this.buttonNextData.TabIndex = 16;
            this.buttonNextData.Text = "Next Data";
            this.buttonNextData.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNextData);
            this.Controls.Add(this.buttonPrevData);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevData;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.TextBox textBoxTelp;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNextData;
    }
}