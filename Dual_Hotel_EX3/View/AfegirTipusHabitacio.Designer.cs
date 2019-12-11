namespace Dual_Hotel_EX3.View
{
    partial class AfegirTipusHabitacio
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
            this.nomLabel = new System.Windows.Forms.Label();
            this.nomInput = new System.Windows.Forms.TextBox();
            this.descripcioLabel = new System.Windows.Forms.Label();
            this.descripcioInput = new System.Windows.Forms.RichTextBox();
            this.capacitatInput = new System.Windows.Forms.TextBox();
            this.capacitatLabel = new System.Windows.Forms.Label();
            this.suplementInput = new System.Windows.Forms.TextBox();
            this.suplementLabel = new System.Windows.Forms.Label();
            this.afegirB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(12, 18);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(32, 13);
            this.nomLabel.TabIndex = 2;
            this.nomLabel.Text = "Nom:";
            // 
            // nomInput
            // 
            this.nomInput.Location = new System.Drawing.Point(15, 35);
            this.nomInput.Name = "nomInput";
            this.nomInput.Size = new System.Drawing.Size(272, 20);
            this.nomInput.TabIndex = 3;
            this.nomInput.TextChanged += new System.EventHandler(this.NomInput_TextChanged);
            // 
            // descripcioLabel
            // 
            this.descripcioLabel.AutoSize = true;
            this.descripcioLabel.Location = new System.Drawing.Point(12, 64);
            this.descripcioLabel.Name = "descripcioLabel";
            this.descripcioLabel.Size = new System.Drawing.Size(60, 13);
            this.descripcioLabel.TabIndex = 4;
            this.descripcioLabel.Text = "Descripcio:";
            // 
            // descripcioInput
            // 
            this.descripcioInput.Location = new System.Drawing.Point(15, 80);
            this.descripcioInput.Name = "descripcioInput";
            this.descripcioInput.Size = new System.Drawing.Size(272, 96);
            this.descripcioInput.TabIndex = 5;
            this.descripcioInput.Text = "";
            this.descripcioInput.TextChanged += new System.EventHandler(this.DescripcioInput_TextChanged);
            // 
            // capacitatInput
            // 
            this.capacitatInput.Location = new System.Drawing.Point(15, 205);
            this.capacitatInput.Name = "capacitatInput";
            this.capacitatInput.Size = new System.Drawing.Size(272, 20);
            this.capacitatInput.TabIndex = 7;
            this.capacitatInput.TextChanged += new System.EventHandler(this.CapacitatInput_TextChanged);
            // 
            // capacitatLabel
            // 
            this.capacitatLabel.AutoSize = true;
            this.capacitatLabel.Location = new System.Drawing.Point(12, 188);
            this.capacitatLabel.Name = "capacitatLabel";
            this.capacitatLabel.Size = new System.Drawing.Size(55, 13);
            this.capacitatLabel.TabIndex = 6;
            this.capacitatLabel.Text = "Capacitat:";
            // 
            // suplementInput
            // 
            this.suplementInput.Location = new System.Drawing.Point(15, 254);
            this.suplementInput.Name = "suplementInput";
            this.suplementInput.Size = new System.Drawing.Size(272, 20);
            this.suplementInput.TabIndex = 9;
            this.suplementInput.TextChanged += new System.EventHandler(this.SuplementInput_TextChanged);
            // 
            // suplementLabel
            // 
            this.suplementLabel.AutoSize = true;
            this.suplementLabel.Location = new System.Drawing.Point(12, 238);
            this.suplementLabel.Name = "suplementLabel";
            this.suplementLabel.Size = new System.Drawing.Size(119, 13);
            this.suplementLabel.TabIndex = 8;
            this.suplementLabel.Text = "Suplement per persona:";
            // 
            // afegirB
            // 
            this.afegirB.Enabled = false;
            this.afegirB.Location = new System.Drawing.Point(212, 289);
            this.afegirB.Name = "afegirB";
            this.afegirB.Size = new System.Drawing.Size(75, 23);
            this.afegirB.TabIndex = 10;
            this.afegirB.Text = "Afegir";
            this.afegirB.UseVisualStyleBackColor = true;
            // 
            // AfegirTipusHabitacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 327);
            this.Controls.Add(this.afegirB);
            this.Controls.Add(this.suplementInput);
            this.Controls.Add(this.suplementLabel);
            this.Controls.Add(this.capacitatInput);
            this.Controls.Add(this.capacitatLabel);
            this.Controls.Add(this.descripcioInput);
            this.Controls.Add(this.descripcioLabel);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.nomLabel);
            this.Name = "AfegirTipusHabitacio";
            this.Text = "AfegirTipusHabitacio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label descripcioLabel;
        private System.Windows.Forms.Label capacitatLabel;
        private System.Windows.Forms.Label suplementLabel;
        public System.Windows.Forms.TextBox nomInput;
        public System.Windows.Forms.RichTextBox descripcioInput;
        public System.Windows.Forms.TextBox capacitatInput;
        public System.Windows.Forms.TextBox suplementInput;
        public System.Windows.Forms.Button afegirB;
    }
}