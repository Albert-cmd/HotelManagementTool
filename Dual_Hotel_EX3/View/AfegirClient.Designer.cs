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
            this.afegirClientB.Location = new System.Drawing.Point(168, 82);
            this.afegirClientB.Name = "afegirClientB";
            this.afegirClientB.Size = new System.Drawing.Size(75, 23);
            this.afegirClientB.TabIndex = 3;
            this.afegirClientB.Text = "Afegir";
            this.afegirClientB.UseVisualStyleBackColor = true;
            this.afegirClientB.Click += new System.EventHandler(this.AfegirClientB_Click);
            // 
            // AfegirClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 117);
            this.Controls.Add(this.afegirClientB);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.afegirClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AfegirClient";
            this.Text = "AfegirClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label afegirClientLabel;
        private System.Windows.Forms.TextBox nomInput;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Button afegirClientB;
    }
}