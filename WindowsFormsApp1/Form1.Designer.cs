
namespace WindowsFormsApp1
{
    partial class initial_screen
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initial_screen));
            this.controlpanel = new System.Windows.Forms.Panel();
            this.panel_converter = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dectott = new System.Windows.Forms.Button();
            this.dectobin = new System.Windows.Forms.Button();
            this.select_convertor = new System.Windows.Forms.Button();
            this.pannellolaterale = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formpanelchild = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.controlpanel.SuspendLayout();
            this.panel_converter.SuspendLayout();
            this.pannellolaterale.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formpanelchild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // controlpanel
            // 
            this.controlpanel.Controls.Add(this.panel_converter);
            this.controlpanel.Controls.Add(this.select_convertor);
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlpanel.Location = new System.Drawing.Point(0, 100);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(227, 336);
            this.controlpanel.TabIndex = 0;
            // 
            // panel_converter
            // 
            this.panel_converter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.panel_converter.Controls.Add(this.button3);
            this.panel_converter.Controls.Add(this.button2);
            this.panel_converter.Controls.Add(this.dectott);
            this.panel_converter.Controls.Add(this.dectobin);
            this.panel_converter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_converter.Location = new System.Drawing.Point(0, 55);
            this.panel_converter.Name = "panel_converter";
            this.panel_converter.Size = new System.Drawing.Size(227, 163);
            this.panel_converter.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decimal To Octal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dectott
            // 
            this.dectott.Dock = System.Windows.Forms.DockStyle.Top;
            this.dectott.FlatAppearance.BorderSize = 0;
            this.dectott.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dectott.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dectott.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dectott.Location = new System.Drawing.Point(0, 40);
            this.dectott.Name = "dectott";
            this.dectott.Size = new System.Drawing.Size(227, 41);
            this.dectott.TabIndex = 2;
            this.dectott.Text = "Binary To Decimal";
            this.dectott.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dectott.UseVisualStyleBackColor = true;
            this.dectott.Click += new System.EventHandler(this.dectott_Click);
            // 
            // dectobin
            // 
            this.dectobin.Dock = System.Windows.Forms.DockStyle.Top;
            this.dectobin.FlatAppearance.BorderSize = 0;
            this.dectobin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dectobin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dectobin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dectobin.Location = new System.Drawing.Point(0, 0);
            this.dectobin.Name = "dectobin";
            this.dectobin.Size = new System.Drawing.Size(227, 40);
            this.dectobin.TabIndex = 1;
            this.dectobin.Text = "Decimal To Binary";
            this.dectobin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dectobin.UseVisualStyleBackColor = true;
            this.dectobin.Click += new System.EventHandler(this.dectobin_Click);
            // 
            // select_convertor
            // 
            this.select_convertor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.select_convertor.Dock = System.Windows.Forms.DockStyle.Top;
            this.select_convertor.FlatAppearance.BorderSize = 0;
            this.select_convertor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_convertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_convertor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.select_convertor.Image = global::WindowsFormsApp1.Properties.Resources.outline_loop_black_24dp1;
            this.select_convertor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.select_convertor.Location = new System.Drawing.Point(0, 0);
            this.select_convertor.Name = "select_convertor";
            this.select_convertor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.select_convertor.Size = new System.Drawing.Size(227, 55);
            this.select_convertor.TabIndex = 2;
            this.select_convertor.Text = "Converitori";
            this.select_convertor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.select_convertor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.select_convertor.UseVisualStyleBackColor = false;
            this.select_convertor.Click += new System.EventHandler(this.select_convertor_Click);
            // 
            // pannellolaterale
            // 
            this.pannellolaterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.pannellolaterale.Controls.Add(this.button1);
            this.pannellolaterale.Controls.Add(this.controlpanel);
            this.pannellolaterale.Controls.Add(this.panel2);
            this.pannellolaterale.Dock = System.Windows.Forms.DockStyle.Left;
            this.pannellolaterale.Location = new System.Drawing.Point(0, 0);
            this.pannellolaterale.Name = "pannellolaterale";
            this.pannellolaterale.Size = new System.Drawing.Size(227, 533);
            this.pannellolaterale.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.outline_logout_white_24dp;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 476);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(227, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._782d8a4346ab154282ec2e8dbb826e00;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formpanelchild
            // 
            this.formpanelchild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.formpanelchild.Controls.Add(this.pictureBox2);
            this.formpanelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formpanelchild.Location = new System.Drawing.Point(227, 0);
            this.formpanelchild.Name = "formpanelchild";
            this.formpanelchild.Size = new System.Drawing.Size(690, 533);
            this.formpanelchild.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Senza_titolo_1;
            this.pictureBox2.Location = new System.Drawing.Point(221, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Octal To Decimal";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // initial_screen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(917, 533);
            this.Controls.Add(this.formpanelchild);
            this.Controls.Add(this.pannellolaterale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "initial_screen";
            this.Text = "Binary Converter";
            this.Load += new System.EventHandler(this.initial_screen_Load);
            this.controlpanel.ResumeLayout(false);
            this.panel_converter.ResumeLayout(false);
            this.pannellolaterale.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formpanelchild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.Panel panel_converter;
        private System.Windows.Forms.Button dectott;
        private System.Windows.Forms.Button dectobin;
        private System.Windows.Forms.Button select_convertor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pannellolaterale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel formpanelchild;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

