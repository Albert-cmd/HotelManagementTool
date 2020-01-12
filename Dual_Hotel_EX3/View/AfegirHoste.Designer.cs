namespace Dual_Hotel_EX3.View
{
    partial class AfegirHoste
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
            this.afegirClientB = new System.Windows.Forms.Button();
            this.nomCompletLabel = new System.Windows.Forms.Label();
            this.nomCompletInput = new System.Windows.Forms.TextBox();
            this.afegirHosteLabel = new System.Windows.Forms.Label();
            this.DNIPassaportLabel = new System.Windows.Forms.Label();
            this.DNIPassaportInput = new System.Windows.Forms.TextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.TextBox();
            this.nacionalitatLabel = new System.Windows.Forms.Label();
            this.nacionalitatInput = new System.Windows.Forms.TextBox();
            this.adrecaLabel = new System.Windows.Forms.Label();
            this.adrecaInput = new System.Windows.Forms.TextBox();
            this.codiPostalLabel = new System.Windows.Forms.Label();
            this.codiPostalInput = new System.Windows.Forms.TextBox();
            this.poblacioLabel = new System.Windows.Forms.Label();
            this.poblacioInput = new System.Windows.Forms.TextBox();
            this.dniErrorLabel = new System.Windows.Forms.Label();
            this.nomErrorLabel = new System.Windows.Forms.Label();
            this.hostesRegistratsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hostesRegistratsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // afegirClientB
            // 
            this.afegirClientB.Enabled = false;
            this.afegirClientB.Location = new System.Drawing.Point(177, 393);
            this.afegirClientB.Name = "afegirClientB";
            this.afegirClientB.Size = new System.Drawing.Size(75, 23);
            this.afegirClientB.TabIndex = 7;
            this.afegirClientB.Text = "Afegir";
            this.afegirClientB.UseVisualStyleBackColor = true;
            this.afegirClientB.Click += new System.EventHandler(this.afegirClientB_Click);
            // 
            // nomCompletLabel
            // 
            this.nomCompletLabel.AutoSize = true;
            this.nomCompletLabel.Location = new System.Drawing.Point(22, 48);
            this.nomCompletLabel.Name = "nomCompletLabel";
            this.nomCompletLabel.Size = new System.Drawing.Size(72, 13);
            this.nomCompletLabel.TabIndex = 6;
            this.nomCompletLabel.Text = "Nom complet:";
            this.nomCompletLabel.Click += new System.EventHandler(this.NomLabel_Click);
            // 
            // nomCompletInput
            // 
            this.nomCompletInput.Location = new System.Drawing.Point(25, 64);
            this.nomCompletInput.Name = "nomCompletInput";
            this.nomCompletInput.Size = new System.Drawing.Size(227, 20);
            this.nomCompletInput.TabIndex = 5;
            // 
            // afegirHosteLabel
            // 
            this.afegirHosteLabel.AutoSize = true;
            this.afegirHosteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirHosteLabel.Location = new System.Drawing.Point(21, 18);
            this.afegirHosteLabel.Name = "afegirHosteLabel";
            this.afegirHosteLabel.Size = new System.Drawing.Size(107, 20);
            this.afegirHosteLabel.TabIndex = 4;
            this.afegirHosteLabel.Text = "Afegir hoste";
            this.afegirHosteLabel.Click += new System.EventHandler(this.AfegirClientLabel_Click);
            // 
            // DNIPassaportLabel
            // 
            this.DNIPassaportLabel.AutoSize = true;
            this.DNIPassaportLabel.Location = new System.Drawing.Point(22, 98);
            this.DNIPassaportLabel.Name = "DNIPassaportLabel";
            this.DNIPassaportLabel.Size = new System.Drawing.Size(90, 13);
            this.DNIPassaportLabel.TabIndex = 10;
            this.DNIPassaportLabel.Text = "DNI / Passaport: ";
            // 
            // DNIPassaportInput
            // 
            this.DNIPassaportInput.Location = new System.Drawing.Point(25, 114);
            this.DNIPassaportInput.Name = "DNIPassaportInput";
            this.DNIPassaportInput.Size = new System.Drawing.Size(227, 20);
            this.DNIPassaportInput.TabIndex = 9;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(22, 147);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(106, 13);
            this.telefonLabel.TabIndex = 12;
            this.telefonLabel.Text = "Telèfon de contacte:";
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(25, 163);
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(227, 20);
            this.telefonInput.TabIndex = 11;
            this.telefonInput.TextChanged += new System.EventHandler(this.TelefonInput_TextChanged);
            // 
            // nacionalitatLabel
            // 
            this.nacionalitatLabel.AutoSize = true;
            this.nacionalitatLabel.Location = new System.Drawing.Point(22, 193);
            this.nacionalitatLabel.Name = "nacionalitatLabel";
            this.nacionalitatLabel.Size = new System.Drawing.Size(66, 13);
            this.nacionalitatLabel.TabIndex = 14;
            this.nacionalitatLabel.Text = "Nacionalitat:";
            // 
            // nacionalitatInput
            // 
            this.nacionalitatInput.Location = new System.Drawing.Point(25, 209);
            this.nacionalitatInput.Name = "nacionalitatInput";
            this.nacionalitatInput.Size = new System.Drawing.Size(227, 20);
            this.nacionalitatInput.TabIndex = 13;
            // 
            // adrecaLabel
            // 
            this.adrecaLabel.AutoSize = true;
            this.adrecaLabel.Location = new System.Drawing.Point(22, 243);
            this.adrecaLabel.Name = "adrecaLabel";
            this.adrecaLabel.Size = new System.Drawing.Size(44, 13);
            this.adrecaLabel.TabIndex = 16;
            this.adrecaLabel.Text = "Adreça:";
            // 
            // adrecaInput
            // 
            this.adrecaInput.Location = new System.Drawing.Point(25, 259);
            this.adrecaInput.Name = "adrecaInput";
            this.adrecaInput.Size = new System.Drawing.Size(227, 20);
            this.adrecaInput.TabIndex = 15;
            // 
            // codiPostalLabel
            // 
            this.codiPostalLabel.AutoSize = true;
            this.codiPostalLabel.Location = new System.Drawing.Point(22, 292);
            this.codiPostalLabel.Name = "codiPostalLabel";
            this.codiPostalLabel.Size = new System.Drawing.Size(62, 13);
            this.codiPostalLabel.TabIndex = 18;
            this.codiPostalLabel.Text = "Codi postal:";
            // 
            // codiPostalInput
            // 
            this.codiPostalInput.Location = new System.Drawing.Point(25, 308);
            this.codiPostalInput.Name = "codiPostalInput";
            this.codiPostalInput.Size = new System.Drawing.Size(227, 20);
            this.codiPostalInput.TabIndex = 17;
            this.codiPostalInput.TextChanged += new System.EventHandler(this.CodiPostalInput_TextChanged);
            // 
            // poblacioLabel
            // 
            this.poblacioLabel.AutoSize = true;
            this.poblacioLabel.Location = new System.Drawing.Point(21, 342);
            this.poblacioLabel.Name = "poblacioLabel";
            this.poblacioLabel.Size = new System.Drawing.Size(51, 13);
            this.poblacioLabel.TabIndex = 20;
            this.poblacioLabel.Text = "Població:";
            // 
            // poblacioInput
            // 
            this.poblacioInput.Location = new System.Drawing.Point(24, 358);
            this.poblacioInput.Name = "poblacioInput";
            this.poblacioInput.Size = new System.Drawing.Size(227, 20);
            this.poblacioInput.TabIndex = 19;
            // 
            // dniErrorLabel
            // 
            this.dniErrorLabel.AutoSize = true;
            this.dniErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.dniErrorLabel.Location = new System.Drawing.Point(189, 98);
            this.dniErrorLabel.Name = "dniErrorLabel";
            this.dniErrorLabel.Size = new System.Drawing.Size(63, 13);
            this.dniErrorLabel.TabIndex = 21;
            this.dniErrorLabel.Text = "DNI Repetit";
            this.dniErrorLabel.Visible = false;
            // 
            // nomErrorLabel
            // 
            this.nomErrorLabel.AutoSize = true;
            this.nomErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nomErrorLabel.Location = new System.Drawing.Point(151, 48);
            this.nomErrorLabel.Name = "nomErrorLabel";
            this.nomErrorLabel.Size = new System.Drawing.Size(101, 13);
            this.nomErrorLabel.TabIndex = 22;
            this.nomErrorLabel.Text = "Nom complet repetit";
            this.nomErrorLabel.Visible = false;
            // 
            // hostesRegistratsDGV
            // 
            this.hostesRegistratsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostesRegistratsDGV.Location = new System.Drawing.Point(316, 64);
            this.hostesRegistratsDGV.Name = "hostesRegistratsDGV";
            this.hostesRegistratsDGV.Size = new System.Drawing.Size(603, 314);
            this.hostesRegistratsDGV.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hostes registrats a la base de dades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(530, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Filtre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(666, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 29;
            // 
            // AfegirHoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 483);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostesRegistratsDGV);
            this.Controls.Add(this.nomErrorLabel);
            this.Controls.Add(this.dniErrorLabel);
            this.Controls.Add(this.poblacioLabel);
            this.Controls.Add(this.poblacioInput);
            this.Controls.Add(this.codiPostalLabel);
            this.Controls.Add(this.codiPostalInput);
            this.Controls.Add(this.adrecaLabel);
            this.Controls.Add(this.adrecaInput);
            this.Controls.Add(this.nacionalitatLabel);
            this.Controls.Add(this.nacionalitatInput);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.DNIPassaportLabel);
            this.Controls.Add(this.DNIPassaportInput);
            this.Controls.Add(this.afegirClientB);
            this.Controls.Add(this.nomCompletLabel);
            this.Controls.Add(this.nomCompletInput);
            this.Controls.Add(this.afegirHosteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AfegirHoste";
            this.Text = "AfegirHoste";
            ((System.ComponentModel.ISupportInitialize)(this.hostesRegistratsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomCompletLabel;
        private System.Windows.Forms.Label afegirHosteLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label nacionalitatLabel;
        private System.Windows.Forms.Label adrecaLabel;
        private System.Windows.Forms.Label codiPostalLabel;
        private System.Windows.Forms.Label poblacioLabel;
        public System.Windows.Forms.TextBox DNIPassaportInput;
        private System.Windows.Forms.Label DNIPassaportLabel;
        public System.Windows.Forms.Label dniErrorLabel;
        public System.Windows.Forms.TextBox nomCompletInput;
        public System.Windows.Forms.Label nomErrorLabel;
        public System.Windows.Forms.TextBox telefonInput;
        public System.Windows.Forms.TextBox nacionalitatInput;
        public System.Windows.Forms.TextBox adrecaInput;
        public System.Windows.Forms.TextBox codiPostalInput;
        public System.Windows.Forms.TextBox poblacioInput;
        public System.Windows.Forms.Button afegirClientB;
        private System.Windows.Forms.DataGridView hostesRegistratsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}