namespace Dual_Hotel_EX3.View
{
    partial class AfegeixTipusHabitacio
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
            this.CaracteristiquesHabitacioDGV = new System.Windows.Forms.DataGridView();
            this.CategoriaHabitacioCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaracteristiquesHabitacioDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CaracteristiquesHabitacioDGV
            // 
            this.CaracteristiquesHabitacioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CaracteristiquesHabitacioDGV.Location = new System.Drawing.Point(319, 79);
            this.CaracteristiquesHabitacioDGV.Name = "CaracteristiquesHabitacioDGV";
            this.CaracteristiquesHabitacioDGV.Size = new System.Drawing.Size(406, 313);
            this.CaracteristiquesHabitacioDGV.TabIndex = 0;
            // 
            // CategoriaHabitacioCB
            // 
            this.CategoriaHabitacioCB.FormattingEnabled = true;
            this.CategoriaHabitacioCB.Location = new System.Drawing.Point(31, 106);
            this.CategoriaHabitacioCB.Name = "CategoriaHabitacioCB";
            this.CategoriaHabitacioCB.Size = new System.Drawing.Size(168, 21);
            this.CategoriaHabitacioCB.TabIndex = 2;
            this.CategoriaHabitacioCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Afegeix mes tipus d\'habitacio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria d\'habitacio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Assigna";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AfegeixTipusHabitacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoriaHabitacioCB);
            this.Controls.Add(this.CaracteristiquesHabitacioDGV);
            this.Name = "AfegeixTipusHabitacio";
            this.Text = "GestioHabitacio";
            this.Load += new System.EventHandler(this.GestioHabitacio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaracteristiquesHabitacioDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CaracteristiquesHabitacioDGV;
        private System.Windows.Forms.ComboBox CategoriaHabitacioCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}