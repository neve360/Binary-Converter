
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.reset = new System.Windows.Forms.Button();
            this.divisioni = new System.Windows.Forms.TextBox();
            this.tabella = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n_dec = new System.Windows.Forms.TextBox();
            this.buttonswit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(206, 270);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 19;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // divisioni
            // 
            this.divisioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.divisioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divisioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisioni.Location = new System.Drawing.Point(356, 12);
            this.divisioni.Multiline = true;
            this.divisioni.Name = "divisioni";
            this.divisioni.Size = new System.Drawing.Size(100, 440);
            this.divisioni.TabIndex = 18;
            this.divisioni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.divisioni.TextChanged += new System.EventHandler(this.divisioni_TextChanged_1);
            // 
            // tabella
            // 
            this.tabella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.tabella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabella.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabella.Location = new System.Drawing.Point(473, 12);
            this.tabella.Multiline = true;
            this.tabella.Name = "tabella";
            this.tabella.ReadOnly = true;
            this.tabella.Size = new System.Drawing.Size(54, 440);
            this.tabella.TabIndex = 17;
            this.tabella.TextChanged += new System.EventHandler(this.tabella_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(106, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Numero decimale";
            // 
            // n_dec
            // 
            this.n_dec.Location = new System.Drawing.Point(106, 163);
            this.n_dec.Name = "n_dec";
            this.n_dec.Size = new System.Drawing.Size(175, 20);
            this.n_dec.TabIndex = 15;
            this.n_dec.TextChanged += new System.EventHandler(this.n_dec_TextChanged);
            // 
            // buttonswit
            // 
            this.buttonswit.Location = new System.Drawing.Point(109, 270);
            this.buttonswit.Name = "buttonswit";
            this.buttonswit.Size = new System.Drawing.Size(75, 23);
            this.buttonswit.TabIndex = 14;
            this.buttonswit.Text = "Converti";
            this.buttonswit.UseVisualStyleBackColor = true;
            this.buttonswit.Click += new System.EventHandler(this.buttonswit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(106, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Risultato (Binario)";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(109, 228);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(175, 20);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "0";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(78, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Decimale a Binario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.outline_loop_black_24dp2;
            this.pictureBox2.Location = new System.Drawing.Point(21, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 430);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(690, 533);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.divisioni);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_dec);
            this.Controls.Add(this.buttonswit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox divisioni;
        private System.Windows.Forms.TextBox tabella;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_dec;
        private System.Windows.Forms.Button buttonswit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}