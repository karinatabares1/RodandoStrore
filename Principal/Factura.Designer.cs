namespace Principal
{
    partial class Factura
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
            lblCliente = new Label();
            lblFecha = new Label();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(35, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(119, 22);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nombre cliente ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(35, 75);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(109, 19);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha venta ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(35, 119);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(47, 19);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(35, 175);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(696, 188);
            dgvDetalle.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(356, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgvDetalle);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lblCliente);
            Name = "Factura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblFecha;
        private Label lblTotal;
        private DataGridView dgvDetalle;
        private Button button1;
    }
}