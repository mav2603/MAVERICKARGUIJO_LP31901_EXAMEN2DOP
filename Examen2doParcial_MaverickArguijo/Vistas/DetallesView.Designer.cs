
namespace Examen2doParcial_MaverickArguijo.Vistas
{
    partial class DetallesView
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
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.MostrarTicketButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DetalleDataGridView.Location = new System.Drawing.Point(0, 197);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(563, 150);
            this.DetalleDataGridView.TabIndex = 0;
            // 
            // MostrarTicketButton
            // 
            this.MostrarTicketButton.BackColor = System.Drawing.Color.OrangeRed;
            this.MostrarTicketButton.Location = new System.Drawing.Point(26, 44);
            this.MostrarTicketButton.Name = "MostrarTicketButton";
            this.MostrarTicketButton.Size = new System.Drawing.Size(243, 102);
            this.MostrarTicketButton.TabIndex = 1;
            this.MostrarTicketButton.Text = "Mostrar Tickets";
            this.MostrarTicketButton.UseVisualStyleBackColor = false;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.Color.OrangeRed;
            this.LimpiarButton.Location = new System.Drawing.Point(280, 44);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(271, 104);
            this.LimpiarButton.TabIndex = 1;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            // 
            // DetallesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 347);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.MostrarTicketButton);
            this.Controls.Add(this.DetalleDataGridView);
            this.Name = "DetallesView";
            this.Text = "DetallesView";
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DetalleDataGridView;
        public System.Windows.Forms.Button MostrarTicketButton;
        public System.Windows.Forms.Button LimpiarButton;
    }
}