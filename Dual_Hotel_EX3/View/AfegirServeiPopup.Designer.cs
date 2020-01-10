namespace Dual_Hotel_EX3.View
{
    partial class AfegirServeiPopup
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
            this.afegirServeiLabel = new System.Windows.Forms.Label();
            this.serveisBox = new System.Windows.Forms.ComboBox();
            this.afegirServeiB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // afegirServeiLabel
            // 
            this.afegirServeiLabel.AutoSize = true;
            this.afegirServeiLabel.Location = new System.Drawing.Point(13, 13);
            this.afegirServeiLabel.Name = "afegirServeiLabel";
            this.afegirServeiLabel.Size = new System.Drawing.Size(65, 13);
            this.afegirServeiLabel.TabIndex = 0;
            this.afegirServeiLabel.Text = "Afegir servei";
            // 
            // serveisBox
            // 
            this.serveisBox.FormattingEnabled = true;
            this.serveisBox.Location = new System.Drawing.Point(16, 29);
            this.serveisBox.Name = "serveisBox";
            this.serveisBox.Size = new System.Drawing.Size(209, 21);
            this.serveisBox.TabIndex = 1;
            this.serveisBox.SelectedIndexChanged += new System.EventHandler(this.ServeisBox_SelectedIndexChanged);
            // 
            // afegirServeiB
            // 
            this.afegirServeiB.Location = new System.Drawing.Point(150, 56);
            this.afegirServeiB.Name = "afegirServeiB";
            this.afegirServeiB.Size = new System.Drawing.Size(75, 23);
            this.afegirServeiB.TabIndex = 2;
            this.afegirServeiB.Text = "Afegir";
            this.afegirServeiB.UseVisualStyleBackColor = true;
            this.afegirServeiB.Click += new System.EventHandler(this.AfegirServeiB_Click);
            // 
            // AfegirServeiPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 89);
            this.Controls.Add(this.afegirServeiB);
            this.Controls.Add(this.serveisBox);
            this.Controls.Add(this.afegirServeiLabel);
            this.Name = "AfegirServeiPopup";
            this.Text = "AfegirServeiPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label afegirServeiLabel;
        private System.Windows.Forms.ComboBox serveisBox;
        private System.Windows.Forms.Button afegirServeiB;
    }
}