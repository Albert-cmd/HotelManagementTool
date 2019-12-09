namespace Dual_Hotel_EX3.View
{
    partial class Hostes
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
            this.hostesGrid = new System.Windows.Forms.DataGridView();
            this.hostesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hostesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hostesGrid
            // 
            this.hostesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostesGrid.Location = new System.Drawing.Point(12, 56);
            this.hostesGrid.Name = "hostesGrid";
            this.hostesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hostesGrid.Size = new System.Drawing.Size(817, 368);
            this.hostesGrid.TabIndex = 3;
            // 
            // hostesLabel
            // 
            this.hostesLabel.AutoSize = true;
            this.hostesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostesLabel.Location = new System.Drawing.Point(6, 10);
            this.hostesLabel.Name = "hostesLabel";
            this.hostesLabel.Size = new System.Drawing.Size(262, 31);
            this.hostesLabel.TabIndex = 2;
            this.hostesLabel.Text = "Detalls dels hostes";
            // 
            // Hostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.hostesGrid);
            this.Controls.Add(this.hostesLabel);
            this.Name = "Hostes";
            this.Text = "Hostes";
            ((System.ComponentModel.ISupportInitialize)(this.hostesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView hostesGrid;
        private System.Windows.Forms.Label hostesLabel;
    }
}