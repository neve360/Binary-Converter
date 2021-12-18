
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.n_dec = new System.Windows.Forms.TextBox();
            this.buttonswit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.divisioni = new System.Windows.Forms.TextBox();
            this.tabella = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.outline_loop_black_24dp2;
            this.pictureBox2.Location = new System.Drawing.Point(40, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(116, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Decimal To Octal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(247, 244);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 33;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(147, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Numero decimale";
            // 
            // n_dec
            // 
            this.n_dec.Location = new System.Drawing.Point(147, 137);
            this.n_dec.Name = "n_dec";
            this.n_dec.Size = new System.Drawing.Size(175, 20);
            this.n_dec.TabIndex = 31;
            this.n_dec.TextChanged += new System.EventHandler(this.n_dec_TextChanged);
            // 
            // buttonswit
            // 
            this.buttonswit.Location = new System.Drawing.Point(150, 244);
            this.buttonswit.Name = "buttonswit";
            this.buttonswit.Size = new System.Drawing.Size(75, 23);
            this.buttonswit.TabIndex = 30;
            this.buttonswit.Text = "Converti";
            this.buttonswit.UseVisualStyleBackColor = true;
            this.buttonswit.Click += new System.EventHandler(this.buttonswit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(147, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Risultato (Ottale)";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(150, 202);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(175, 20);
            this.txtResult.TabIndex = 28;
            this.txtResult.Text = "0";
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(556, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 360);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // divisioni
            // 
            this.divisioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.divisioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.divisioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisioni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.divisioni.Location = new System.Drawing.Point(450, 43);
            this.divisioni.Multiline = true;
            this.divisioni.Name = "divisioni";
            this.divisioni.Size = new System.Drawing.Size(100, 440);
            this.divisioni.TabIndex = 68;
            this.divisioni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabella
            // 
            this.tabella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.tabella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabella.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tabella.Location = new System.Drawing.Point(567, 43);
            this.tabella.Multiline = true;
            this.tabella.Name = "tabella";
            this.tabella.ReadOnly = true;
            this.tabella.Size = new System.Drawing.Size(54, 440);
            this.tabella.TabIndex = 67;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(690, 533);
            this.Controls.Add(this.divisioni);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_dec);
            this.Controls.Add(this.buttonswit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_dec;
        private System.Windows.Forms.Button buttonswit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox divisioni;
        private System.Windows.Forms.TextBox tabella;
    }
}