namespace Dual_Hotel_EX3.View
{
    partial class AfegirReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.SeleccionaHosteInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServeisList = new System.Windows.Forms.DataGridView();
            this.importBaseInput = new System.Windows.Forms.TextBox();
            this.IVAInput = new System.Windows.Forms.TextBox();
            this.importTotalInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IVALabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ConfirmaReserva = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SeleccionaTipusInput = new System.Windows.Forms.ComboBox();
            this.tipusHabitacioLabel = new System.Windows.Forms.Label();
            this.temporadaLabel = new System.Windows.Forms.Label();
            this.temporadaInput = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.quantitatInput = new System.Windows.Forms.TextBox();
            this.DataIniciInput = new System.Windows.Forms.DateTimePicker();
            this.DataFinalInput = new System.Windows.Forms.DateTimePicker();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ServeisList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afegeix una reserva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeleccionaHosteInput
            // 
            this.SeleccionaHosteInput.FormattingEnabled = true;
            this.SeleccionaHosteInput.Location = new System.Drawing.Point(61, 56);
            this.SeleccionaHosteInput.Name = "SeleccionaHosteInput";
            this.SeleccionaHosteInput.Size = new System.Drawing.Size(184, 21);
            this.SeleccionaHosteInput.TabIndex = 1;
            this.SeleccionaHosteInput.SelectedIndexChanged += new System.EventHandler(this.SeleccionaHoste_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hoste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serveis Extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Inici";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Import Reserva";
            // 
            // ServeisList
            // 
            this.ServeisList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServeisList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom});
            this.ServeisList.Location = new System.Drawing.Point(61, 151);
            this.ServeisList.Name = "ServeisList";
            this.ServeisList.Size = new System.Drawing.Size(184, 143);
            this.ServeisList.TabIndex = 10;
            // 
            // importBaseInput
            // 
            this.importBaseInput.Location = new System.Drawing.Point(281, 110);
            this.importBaseInput.Name = "importBaseInput";
            this.importBaseInput.ReadOnly = true;
            this.importBaseInput.Size = new System.Drawing.Size(110, 20);
            this.importBaseInput.TabIndex = 11;
            this.importBaseInput.Text = "0.00";
            this.importBaseInput.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // IVAInput
            // 
            this.IVAInput.Location = new System.Drawing.Point(281, 172);
            this.IVAInput.Name = "IVAInput";
            this.IVAInput.ReadOnly = true;
            this.IVAInput.Size = new System.Drawing.Size(110, 20);
            this.IVAInput.TabIndex = 12;
            this.IVAInput.Text = "0.00";
            this.IVAInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // importTotalInput
            // 
            this.importTotalInput.Location = new System.Drawing.Point(281, 234);
            this.importTotalInput.Name = "importTotalInput";
            this.importTotalInput.ReadOnly = true;
            this.importTotalInput.Size = new System.Drawing.Size(110, 20);
            this.importTotalInput.TabIndex = 13;
            this.importTotalInput.Text = "0.00";
            this.importTotalInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Import Base ";
            // 
            // IVALabel
            // 
            this.IVALabel.AutoSize = true;
            this.IVALabel.Location = new System.Drawing.Point(278, 156);
            this.IVALabel.Name = "IVALabel";
            this.IVALabel.Size = new System.Drawing.Size(24, 13);
            this.IVALabel.TabIndex = 15;
            this.IVALabel.Text = "IVA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Import Total";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ConfirmaReserva
            // 
            this.ConfirmaReserva.Location = new System.Drawing.Point(375, 387);
            this.ConfirmaReserva.Name = "ConfirmaReserva";
            this.ConfirmaReserva.Size = new System.Drawing.Size(163, 22);
            this.ConfirmaReserva.TabIndex = 17;
            this.ConfirmaReserva.Text = "Confirma Reserva";
            this.ConfirmaReserva.UseVisualStyleBackColor = true;
            this.ConfirmaReserva.Click += new System.EventHandler(this.ConfirmaReserva_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(278, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "ERROR EN LES DADES";
            // 
            // SeleccionaTipusInput
            // 
            this.SeleccionaTipusInput.FormattingEnabled = true;
            this.SeleccionaTipusInput.Location = new System.Drawing.Point(61, 107);
            this.SeleccionaTipusInput.Name = "SeleccionaTipusInput";
            this.SeleccionaTipusInput.Size = new System.Drawing.Size(133, 21);
            this.SeleccionaTipusInput.TabIndex = 19;
            // 
            // tipusHabitacioLabel
            // 
            this.tipusHabitacioLabel.AutoSize = true;
            this.tipusHabitacioLabel.Location = new System.Drawing.Point(58, 91);
            this.tipusHabitacioLabel.Name = "tipusHabitacioLabel";
            this.tipusHabitacioLabel.Size = new System.Drawing.Size(87, 13);
            this.tipusHabitacioLabel.TabIndex = 20;
            this.tipusHabitacioLabel.Text = "Tipus d\'habitació";
            this.tipusHabitacioLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // temporadaLabel
            // 
            this.temporadaLabel.AutoSize = true;
            this.temporadaLabel.Location = new System.Drawing.Point(278, 275);
            this.temporadaLabel.Name = "temporadaLabel";
            this.temporadaLabel.Size = new System.Drawing.Size(61, 13);
            this.temporadaLabel.TabIndex = 22;
            this.temporadaLabel.Text = "Temporada";
            // 
            // temporadaInput
            // 
            this.temporadaInput.Location = new System.Drawing.Point(281, 291);
            this.temporadaInput.Name = "temporadaInput";
            this.temporadaInput.ReadOnly = true;
            this.temporadaInput.Size = new System.Drawing.Size(110, 20);
            this.temporadaInput.TabIndex = 21;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(197, 91);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(51, 13);
            this.qtyLabel.TabIndex = 23;
            this.qtyLabel.Text = "Persones";
            // 
            // quantitatInput
            // 
            this.quantitatInput.Location = new System.Drawing.Point(200, 108);
            this.quantitatInput.Name = "quantitatInput";
            this.quantitatInput.Size = new System.Drawing.Size(45, 20);
            this.quantitatInput.TabIndex = 24;
            // 
            // DataIniciInput
            // 
            this.DataIniciInput.Location = new System.Drawing.Point(61, 314);
            this.DataIniciInput.Name = "DataIniciInput";
            this.DataIniciInput.Size = new System.Drawing.Size(186, 20);
            this.DataIniciInput.TabIndex = 25;
            // 
            // DataFinalInput
            // 
            this.DataFinalInput.Location = new System.Drawing.Point(61, 360);
            this.DataFinalInput.Name = "DataFinalInput";
            this.DataFinalInput.Size = new System.Drawing.Size(184, 20);
            this.DataFinalInput.TabIndex = 26;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // AfegirReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 421);
            this.Controls.Add(this.DataFinalInput);
            this.Controls.Add(this.DataIniciInput);
            this.Controls.Add(this.quantitatInput);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.temporadaLabel);
            this.Controls.Add(this.temporadaInput);
            this.Controls.Add(this.tipusHabitacioLabel);
            this.Controls.Add(this.SeleccionaTipusInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ConfirmaReserva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IVALabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.importTotalInput);
            this.Controls.Add(this.IVAInput);
            this.Controls.Add(this.importBaseInput);
            this.Controls.Add(this.ServeisList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeleccionaHosteInput);
            this.Controls.Add(this.label1);
            this.Name = "AfegirReserva";
            this.Text = "AfegirReserva";
            this.Load += new System.EventHandler(this.AfegirReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServeisList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label IVALabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ConfirmaReserva;
        private System.Windows.Forms.Label tipusHabitacioLabel;
        private System.Windows.Forms.Label temporadaLabel;
        private System.Windows.Forms.Label qtyLabel;
        public System.Windows.Forms.ComboBox SeleccionaHosteInput;
        public System.Windows.Forms.ComboBox SeleccionaTipusInput;
        public System.Windows.Forms.TextBox quantitatInput;
        public System.Windows.Forms.DataGridView ServeisList;
        public System.Windows.Forms.TextBox importBaseInput;
        public System.Windows.Forms.TextBox IVAInput;
        public System.Windows.Forms.TextBox importTotalInput;
        public System.Windows.Forms.TextBox temporadaInput;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DataIniciInput;
        private System.Windows.Forms.DateTimePicker DataFinalInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    }
}