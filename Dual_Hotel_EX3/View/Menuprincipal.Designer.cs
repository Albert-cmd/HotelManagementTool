namespace Dual_Hotel_EX3.View
{
    partial class Menuprincipal
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
            this.TitolHotelLabel = new System.Windows.Forms.Label();
            this.reservesB = new System.Windows.Forms.Button();
            this.afegirReservaB = new System.Windows.Forms.Button();
            this.clientsB = new System.Windows.Forms.Button();
            this.afegirTipusHabitacioB = new System.Windows.Forms.Button();
            this.tipusHabitacioB = new System.Windows.Forms.Button();
            this.afegirTemporadaB = new System.Windows.Forms.Button();
            this.temporadesB = new System.Windows.Forms.Button();
            this.ultimesReservesGrid = new System.Windows.Forms.DataGridView();
            this.ultimesReservesLabel = new System.Windows.Forms.Label();
            this.afegirClientsB = new System.Windows.Forms.Button();
            this.afegirHostesB = new System.Windows.Forms.Button();
            this.hostesB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultimesReservesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitolHotelLabel
            // 
            this.TitolHotelLabel.AutoSize = true;
            this.TitolHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitolHotelLabel.Location = new System.Drawing.Point(23, 20);
            this.TitolHotelLabel.Name = "TitolHotelLabel";
            this.TitolHotelLabel.Size = new System.Drawing.Size(236, 25);
            this.TitolHotelLabel.TabIndex = 0;
            this.TitolHotelLabel.Text = "HOTEL | MAIN MENU";
            // 
            // reservesB
            // 
            this.reservesB.BackColor = System.Drawing.Color.Transparent;
            this.reservesB.FlatAppearance.BorderSize = 0;
            this.reservesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservesB.Location = new System.Drawing.Point(28, 58);
            this.reservesB.Name = "reservesB";
            this.reservesB.Size = new System.Drawing.Size(174, 39);
            this.reservesB.TabIndex = 2;
            this.reservesB.Text = "RESERVES";
            this.reservesB.UseVisualStyleBackColor = false;
            this.reservesB.Click += new System.EventHandler(this.ReservesB_Click);
            // 
            // afegirReservaB
            // 
            this.afegirReservaB.FlatAppearance.BorderSize = 0;
            this.afegirReservaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirReservaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirReservaB.Location = new System.Drawing.Point(208, 58);
            this.afegirReservaB.Name = "afegirReservaB";
            this.afegirReservaB.Size = new System.Drawing.Size(51, 39);
            this.afegirReservaB.TabIndex = 3;
            this.afegirReservaB.Text = "+";
            this.afegirReservaB.UseVisualStyleBackColor = true;
            this.afegirReservaB.Click += new System.EventHandler(this.AfegirReservaB_Click);
            // 
            // clientsB
            // 
            this.clientsB.FlatAppearance.BorderSize = 0;
            this.clientsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsB.Location = new System.Drawing.Point(28, 103);
            this.clientsB.Margin = new System.Windows.Forms.Padding(0);
            this.clientsB.Name = "clientsB";
            this.clientsB.Size = new System.Drawing.Size(174, 39);
            this.clientsB.TabIndex = 4;
            this.clientsB.Text = "CLIENTS";
            this.clientsB.UseVisualStyleBackColor = true;
            this.clientsB.Click += new System.EventHandler(this.ClientsB_Click);
            // 
            // afegirTipusHabitacioB
            // 
            this.afegirTipusHabitacioB.FlatAppearance.BorderSize = 0;
            this.afegirTipusHabitacioB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirTipusHabitacioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirTipusHabitacioB.Location = new System.Drawing.Point(208, 190);
            this.afegirTipusHabitacioB.Name = "afegirTipusHabitacioB";
            this.afegirTipusHabitacioB.Size = new System.Drawing.Size(51, 39);
            this.afegirTipusHabitacioB.TabIndex = 7;
            this.afegirTipusHabitacioB.Text = "+";
            this.afegirTipusHabitacioB.UseVisualStyleBackColor = true;
            // 
            // tipusHabitacioB
            // 
            this.tipusHabitacioB.FlatAppearance.BorderSize = 0;
            this.tipusHabitacioB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipusHabitacioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipusHabitacioB.Location = new System.Drawing.Point(28, 190);
            this.tipusHabitacioB.Name = "tipusHabitacioB";
            this.tipusHabitacioB.Size = new System.Drawing.Size(174, 39);
            this.tipusHabitacioB.TabIndex = 6;
            this.tipusHabitacioB.Text = "TIPUS HABITACIONS";
            this.tipusHabitacioB.UseVisualStyleBackColor = true;
            // 
            // afegirTemporadaB
            // 
            this.afegirTemporadaB.FlatAppearance.BorderSize = 0;
            this.afegirTemporadaB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirTemporadaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirTemporadaB.Location = new System.Drawing.Point(208, 235);
            this.afegirTemporadaB.Name = "afegirTemporadaB";
            this.afegirTemporadaB.Size = new System.Drawing.Size(51, 39);
            this.afegirTemporadaB.TabIndex = 9;
            this.afegirTemporadaB.Text = "+";
            this.afegirTemporadaB.UseVisualStyleBackColor = true;
            this.afegirTemporadaB.Click += new System.EventHandler(this.AfegirTemporadaB_Click);
            // 
            // temporadesB
            // 
            this.temporadesB.FlatAppearance.BorderSize = 0;
            this.temporadesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temporadesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporadesB.Location = new System.Drawing.Point(28, 235);
            this.temporadesB.Name = "temporadesB";
            this.temporadesB.Size = new System.Drawing.Size(174, 39);
            this.temporadesB.TabIndex = 8;
            this.temporadesB.Text = "TEMPORADES";
            this.temporadesB.UseVisualStyleBackColor = true;
            // 
            // ultimesReservesGrid
            // 
            this.ultimesReservesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ultimesReservesGrid.Location = new System.Drawing.Point(348, 75);
            this.ultimesReservesGrid.Name = "ultimesReservesGrid";
            this.ultimesReservesGrid.Size = new System.Drawing.Size(394, 268);
            this.ultimesReservesGrid.TabIndex = 10;
            this.ultimesReservesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UltimesReservesGrid_CellContentClick);
            // 
            // ultimesReservesLabel
            // 
            this.ultimesReservesLabel.AutoSize = true;
            this.ultimesReservesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimesReservesLabel.Location = new System.Drawing.Point(343, 37);
            this.ultimesReservesLabel.Name = "ultimesReservesLabel";
            this.ultimesReservesLabel.Size = new System.Drawing.Size(197, 24);
            this.ultimesReservesLabel.TabIndex = 11;
            this.ultimesReservesLabel.Text = "ÚLTIMES RESERVES";
            // 
            // afegirClientsB
            // 
            this.afegirClientsB.FlatAppearance.BorderSize = 0;
            this.afegirClientsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirClientsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirClientsB.Location = new System.Drawing.Point(208, 103);
            this.afegirClientsB.Name = "afegirClientsB";
            this.afegirClientsB.Size = new System.Drawing.Size(51, 39);
            this.afegirClientsB.TabIndex = 5;
            this.afegirClientsB.Text = "+";
            this.afegirClientsB.UseVisualStyleBackColor = true;
            this.afegirClientsB.Click += new System.EventHandler(this.AfegirClientsB_Click);
            // 
            // afegirHostesB
            // 
            this.afegirHostesB.FlatAppearance.BorderSize = 0;
            this.afegirHostesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afegirHostesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afegirHostesB.Location = new System.Drawing.Point(208, 148);
            this.afegirHostesB.Name = "afegirHostesB";
            this.afegirHostesB.Size = new System.Drawing.Size(51, 39);
            this.afegirHostesB.TabIndex = 13;
            this.afegirHostesB.Text = "+";
            this.afegirHostesB.UseVisualStyleBackColor = true;
            this.afegirHostesB.Click += new System.EventHandler(this.AfegirHostesB_Click);
            // 
            // hostesB
            // 
            this.hostesB.FlatAppearance.BorderSize = 0;
            this.hostesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hostesB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostesB.Location = new System.Drawing.Point(28, 148);
            this.hostesB.Margin = new System.Windows.Forms.Padding(0);
            this.hostesB.Name = "hostesB";
            this.hostesB.Size = new System.Drawing.Size(174, 39);
            this.hostesB.TabIndex = 12;
            this.hostesB.Text = "HOSTES";
            this.hostesB.UseVisualStyleBackColor = true;
            this.hostesB.Click += new System.EventHandler(this.HostesB_Click);
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.afegirHostesB);
            this.Controls.Add(this.hostesB);
            this.Controls.Add(this.ultimesReservesLabel);
            this.Controls.Add(this.ultimesReservesGrid);
            this.Controls.Add(this.afegirTemporadaB);
            this.Controls.Add(this.temporadesB);
            this.Controls.Add(this.afegirTipusHabitacioB);
            this.Controls.Add(this.tipusHabitacioB);
            this.Controls.Add(this.afegirClientsB);
            this.Controls.Add(this.clientsB);
            this.Controls.Add(this.afegirReservaB);
            this.Controls.Add(this.reservesB);
            this.Controls.Add(this.TitolHotelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menuprincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultimesReservesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitolHotelLabel;
        private System.Windows.Forms.Button reservesB;
        private System.Windows.Forms.Button afegirReservaB;
        private System.Windows.Forms.Button clientsB;
        private System.Windows.Forms.Button afegirTipusHabitacioB;
        private System.Windows.Forms.Button tipusHabitacioB;
        private System.Windows.Forms.Button afegirTemporadaB;
        private System.Windows.Forms.Button temporadesB;
        private System.Windows.Forms.DataGridView ultimesReservesGrid;
        private System.Windows.Forms.Label ultimesReservesLabel;
        private System.Windows.Forms.Button afegirClientsB;
        private System.Windows.Forms.Button afegirHostesB;
        private System.Windows.Forms.Button hostesB;
    }
}

