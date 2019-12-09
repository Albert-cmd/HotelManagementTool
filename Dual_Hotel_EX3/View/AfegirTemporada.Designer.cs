namespace Dual_Hotel_EX3.View
{
    partial class AfegirTemporada
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
            this.nomErrorLabel = new System.Windows.Forms.Label();
            this.afegirTemporadaB = new System.Windows.Forms.Button();
            this.nomCompletLabel = new System.Windows.Forms.Label();
            this.nomTemporadaInput = new System.Windows.Forms.TextBox();
            this.afegirTemporadaLabel = new System.Windows.Forms.Label();
            this.MultiplicadorLabel = new System.Windows.Forms.Label();
            this.multiplicadorInput = new System.Windows.Forms.TextBox();
            this.dateTimeInici = new System.Windows.Forms.DateTimePicker();
            this.dataIniciLabel = new System.Windows.Forms.Label();
            this.dataFinalLabel = new System.Windows.Forms.Label();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nomErrorLabel
            // 
            this.nomErrorLabel.AutoSize = true;
            this.nomErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nomErrorLabel.Location = new System.Drawing.Point(138, 45);
            this.nomErrorLabel.Name = "nomErrorLabel";
            this.nomErrorLabel.Size = new System.Drawing.Size(102, 13);
            this.nomErrorLabel.TabIndex = 27;
            this.nomErrorLabel.Text = "Temporada repetida";
            this.nomErrorLabel.Visible = false;
            // 
            // afegirTemporadaB
            // 
            this.afegirTemporadaB.Enabled = false;
            this.afegirTemporadaB.Location = new System.Drawing.Point(165, 227);
            this.afegirTemporadaB.Name = "afegirTemporadaB";
            this.afegirTemporadaB.Size = new System.Drawing.Size(75, 23);
            this.afegirTemporadaB.TabIndex = 26;
            this.afegirTemporadaB.Text = "Afegir";
            this.afegirTemporadaB.UseVisualStyleBackColor = true;
            // 
            // nomCompletLabel
            // 
            this.nomCompletLabel.AutoSize = true;
            this.nomCompletLabel.Location = new System.Drawing.Point(9, 45);
            this.nomCompletLabel.Name = "nomCompletLabel";
            this.nomCompletLabel.Size = new System.Drawing.Size(72, 13);
            this.nomCompletLabel.TabIndex = 25;
            this.nomCompletLabel.Text = "Nom complet:";
            // 
            // nomTemporadaInput
            // 
            this.nomTemporadaInput.Location = new System.Drawing.Point(12, 61);
            this.nomTemporadaInput.Name = "nomTemporadaInput";
            this.nomTemporadaInput.Size = new System.Drawing.Size(227, 20);
            this.nomTemporadaInput.TabIndex = 24;
            // 
            // afegirTemporadaLabel
            // 
            this.afegirTemporadaLabel.AutoSize = true;
            this.afegirTemporadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirTemporadaLabel.Location = new System.Drawing.Point(8, 15);
            this.afegirTemporadaLabel.Name = "afegirTemporadaLabel";
            this.afegirTemporadaLabel.Size = new System.Drawing.Size(148, 20);
            this.afegirTemporadaLabel.TabIndex = 23;
            this.afegirTemporadaLabel.Text = "Afegir temporada";
            // 
            // MultiplicadorLabel
            // 
            this.MultiplicadorLabel.AutoSize = true;
            this.MultiplicadorLabel.Location = new System.Drawing.Point(9, 88);
            this.MultiplicadorLabel.Name = "MultiplicadorLabel";
            this.MultiplicadorLabel.Size = new System.Drawing.Size(69, 13);
            this.MultiplicadorLabel.TabIndex = 29;
            this.MultiplicadorLabel.Text = "Multiplicador:";
            // 
            // multiplicadorInput
            // 
            this.multiplicadorInput.Location = new System.Drawing.Point(12, 104);
            this.multiplicadorInput.Name = "multiplicadorInput";
            this.multiplicadorInput.Size = new System.Drawing.Size(227, 20);
            this.multiplicadorInput.TabIndex = 28;
            // 
            // dateTimeInici
            // 
            this.dateTimeInici.Location = new System.Drawing.Point(12, 152);
            this.dateTimeInici.Name = "dateTimeInici";
            this.dateTimeInici.Size = new System.Drawing.Size(227, 20);
            this.dateTimeInici.TabIndex = 30;
            // 
            // dataIniciLabel
            // 
            this.dataIniciLabel.AutoSize = true;
            this.dataIniciLabel.Location = new System.Drawing.Point(12, 136);
            this.dataIniciLabel.Name = "dataIniciLabel";
            this.dataIniciLabel.Size = new System.Drawing.Size(62, 13);
            this.dataIniciLabel.TabIndex = 31;
            this.dataIniciLabel.Text = "Data d\'inici:";
            // 
            // dataFinalLabel
            // 
            this.dataFinalLabel.AutoSize = true;
            this.dataFinalLabel.Location = new System.Drawing.Point(12, 185);
            this.dataFinalLabel.Name = "dataFinalLabel";
            this.dataFinalLabel.Size = new System.Drawing.Size(55, 13);
            this.dataFinalLabel.TabIndex = 33;
            this.dataFinalLabel.Text = "Data final:";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Location = new System.Drawing.Point(12, 201);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(227, 20);
            this.dateTimeFinal.TabIndex = 32;
            // 
            // AfegirTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 269);
            this.Controls.Add(this.dataFinalLabel);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dataIniciLabel);
            this.Controls.Add(this.dateTimeInici);
            this.Controls.Add(this.MultiplicadorLabel);
            this.Controls.Add(this.multiplicadorInput);
            this.Controls.Add(this.nomErrorLabel);
            this.Controls.Add(this.afegirTemporadaB);
            this.Controls.Add(this.nomCompletLabel);
            this.Controls.Add(this.nomTemporadaInput);
            this.Controls.Add(this.afegirTemporadaLabel);
            this.Name = "AfegirTemporada";
            this.Text = "AfegirTemporada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label nomErrorLabel;
        public System.Windows.Forms.Button afegirTemporadaB;
        private System.Windows.Forms.Label nomCompletLabel;
        public System.Windows.Forms.TextBox nomTemporadaInput;
        private System.Windows.Forms.Label afegirTemporadaLabel;
        private System.Windows.Forms.Label MultiplicadorLabel;
        public System.Windows.Forms.TextBox multiplicadorInput;
        private System.Windows.Forms.Label dataIniciLabel;
        private System.Windows.Forms.Label dataFinalLabel;
        public System.Windows.Forms.DateTimePicker dateTimeInici;
        public System.Windows.Forms.DateTimePicker dateTimeFinal;
    }
}