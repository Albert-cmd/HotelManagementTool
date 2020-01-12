namespace Dual_Hotel_EX3.View
{
    partial class AfegirNouServei
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AfegeixServei = new System.Windows.Forms.Button();
            this.NomServei = new System.Windows.Forms.TextBox();
            this.InsertaPreu = new System.Windows.Forms.TextBox();
            this.AfegeixNom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.EliminaServeiButton = new System.Windows.Forms.Button();
            this.EditaServeiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Afegeix nous serveis ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preu: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AfegeixServei
            // 
            this.AfegeixServei.Location = new System.Drawing.Point(128, 233);
            this.AfegeixServei.Name = "AfegeixServei";
            this.AfegeixServei.Size = new System.Drawing.Size(75, 23);
            this.AfegeixServei.TabIndex = 5;
            this.AfegeixServei.Text = "Afegeix";
            this.AfegeixServei.UseVisualStyleBackColor = true;
            // 
            // NomServei
            // 
            this.NomServei.Location = new System.Drawing.Point(128, 67);
            this.NomServei.Name = "NomServei";
            this.NomServei.Size = new System.Drawing.Size(174, 20);
            this.NomServei.TabIndex = 6;
            // 
            // InsertaPreu
            // 
            this.InsertaPreu.Location = new System.Drawing.Point(128, 115);
            this.InsertaPreu.Name = "InsertaPreu";
            this.InsertaPreu.Size = new System.Drawing.Size(174, 20);
            this.InsertaPreu.TabIndex = 7;
            // 
            // AfegeixNom
            // 
            this.AfegeixNom.Location = new System.Drawing.Point(128, 163);
            this.AfegeixNom.Name = "AfegeixNom";
            this.AfegeixNom.Size = new System.Drawing.Size(174, 20);
            this.AfegeixNom.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Serveis Registrats";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // EliminaServeiButton
            // 
            this.EliminaServeiButton.Location = new System.Drawing.Point(337, 263);
            this.EliminaServeiButton.Name = "EliminaServeiButton";
            this.EliminaServeiButton.Size = new System.Drawing.Size(75, 23);
            this.EliminaServeiButton.TabIndex = 11;
            this.EliminaServeiButton.Text = "Elimina ";
            this.EliminaServeiButton.UseVisualStyleBackColor = true;
            // 
            // EditaServeiButton
            // 
            this.EditaServeiButton.Location = new System.Drawing.Point(419, 263);
            this.EditaServeiButton.Name = "EditaServeiButton";
            this.EditaServeiButton.Size = new System.Drawing.Size(75, 23);
            this.EditaServeiButton.TabIndex = 12;
            this.EditaServeiButton.Text = "Edita";
            this.EditaServeiButton.UseVisualStyleBackColor = true;
            // 
            // AfegirNouServei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 357);
            this.Controls.Add(this.EditaServeiButton);
            this.Controls.Add(this.EliminaServeiButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AfegeixNom);
            this.Controls.Add(this.InsertaPreu);
            this.Controls.Add(this.NomServei);
            this.Controls.Add(this.AfegeixServei);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AfegirNouServei";
            this.Text = "AfegirNouServei";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AfegeixServei;
        private System.Windows.Forms.TextBox NomServei;
        private System.Windows.Forms.TextBox InsertaPreu;
        private System.Windows.Forms.TextBox AfegeixNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EliminaServeiButton;
        private System.Windows.Forms.Button EditaServeiButton;
    }
}