namespace Dual_Hotel_EX3.View
{
    partial class AfegirClient
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
            this.afegirClientLabel = new System.Windows.Forms.Label();
            this.nomInput = new System.Windows.Forms.TextBox();
            this.nomLabel = new System.Windows.Forms.Label();
            this.afegirClientB = new System.Windows.Forms.Button();
            this.clientsRegistratsDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsRegistratsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // afegirClientLabel
            // 
            this.afegirClientLabel.AutoSize = true;
            this.afegirClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirClientLabel.Location = new System.Drawing.Point(12, 9);
            this.afegirClientLabel.Name = "afegirClientLabel";
            this.afegirClientLabel.Size = new System.Drawing.Size(105, 20);
            this.afegirClientLabel.TabIndex = 0;
            this.afegirClientLabel.Text = "Afegir client";
            this.afegirClientLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // nomInput
            // 
            this.nomInput.Location = new System.Drawing.Point(16, 55);
            this.nomInput.Name = "nomInput";
            this.nomInput.Size = new System.Drawing.Size(227, 20);
            this.nomInput.TabIndex = 1;
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(13, 39);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(32, 13);
            this.nomLabel.TabIndex = 2;
            this.nomLabel.Text = "Nom:";
            // 
            // afegirClientB
            // 
            this.afegirClientB.Location = new System.Drawing.Point(168, 81);
            this.afegirClientB.Name = "afegirClientB";
            this.afegirClientB.Size = new System.Drawing.Size(75, 23);
            this.afegirClientB.TabIndex = 3;
            this.afegirClientB.Text = "Afegir";
            this.afegirClientB.UseVisualStyleBackColor = true;
            this.afegirClientB.Click += new System.EventHandler(this.AfegirClientB_Click);
            // 
            // clientsRegistratsDGV
            // 
            this.clientsRegistratsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsRegistratsDGV.Location = new System.Drawing.Point(249, 55);
            this.clientsRegistratsDGV.Name = "clientsRegistratsDGV";
            this.clientsRegistratsDGV.Size = new System.Drawing.Size(293, 345);
            this.clientsRegistratsDGV.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clients registrats";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AfegirClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientsRegistratsDGV);
            this.Controls.Add(this.afegirClientB);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.afegirClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AfegirClient";
            this.Text = "AfegirClient";
            ((System.ComponentModel.ISupportInitialize)(this.clientsRegistratsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label afegirClientLabel;
        private System.Windows.Forms.TextBox nomInput;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Button afegirClientB;
        private System.Windows.Forms.DataGridView clientsRegistratsDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}