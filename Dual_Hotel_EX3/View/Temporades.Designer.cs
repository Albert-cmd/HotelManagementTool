namespace Dual_Hotel_EX3.View
{
    partial class Temporades
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
            this.temporadesGrid = new System.Windows.Forms.DataGridView();
            this.temporadesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temporadesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // temporadesGrid
            // 
            this.temporadesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temporadesGrid.Location = new System.Drawing.Point(12, 57);
            this.temporadesGrid.Name = "temporadesGrid";
            this.temporadesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.temporadesGrid.Size = new System.Drawing.Size(631, 368);
            this.temporadesGrid.TabIndex = 5;
            // 
            // temporadesLabel
            // 
            this.temporadesLabel.AutoSize = true;
            this.temporadesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporadesLabel.Location = new System.Drawing.Point(6, 11);
            this.temporadesLabel.Name = "temporadesLabel";
            this.temporadesLabel.Size = new System.Drawing.Size(185, 31);
            this.temporadesLabel.TabIndex = 4;
            this.temporadesLabel.Text = "Temporades:";
            // 
            // Temporades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.temporadesGrid);
            this.Controls.Add(this.temporadesLabel);
            this.Name = "Temporades";
            this.Text = "Temporades";
            ((System.ComponentModel.ISupportInitialize)(this.temporadesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView temporadesGrid;
        private System.Windows.Forms.Label temporadesLabel;
    }
}