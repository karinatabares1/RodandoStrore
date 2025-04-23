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
            lbCliente = new Label();
            lblFecha = new Label();
            lblTotal = new Label();
            dgvFactura = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            label3 = new Label();
            txtNombre = new TextBox();
            txtTotal = new TextBox();
            dtpFecha = new DateTimePicker();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCliente.Location = new Point(40, 114);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(123, 18);
            lbCliente.TabIndex = 0;
            lbCliente.Text = "Nombre Cliente ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblFecha.Location = new Point(40, 151);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(99, 18);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha venta ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblTotal.Location = new Point(40, 187);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(43, 18);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(40, 231);
            dgvFactura.Margin = new Padding(3, 2, 3, 2);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(609, 150);
            dgvFactura.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 35);
            toolStrip1.TabIndex = 33;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = SystemColors.Control;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(254, 32);
            toolStripLabel1.Text = "RODANDO STORE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(290, 49);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 34;
            label3.Text = "Factura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 22);
            txtNombre.TabIndex = 35;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(181, 185);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(198, 22);
            txtTotal.TabIndex = 36;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(181, 151);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(260, 22);
            dtpFecha.TabIndex = 37;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Navy;
            btnMostrar.ForeColor = SystemColors.Control;
            btnMostrar.Location = new Point(276, 393);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(165, 52);
            btnMostrar.TabIndex = 38;
            btnMostrar.Text = "Mostrar Factura";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 457);
            Controls.Add(btnMostrar);
            Controls.Add(dtpFecha);
            Controls.Add(txtTotal);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(dgvFactura);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lbCliente);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Factura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCliente;
        private Label lblFecha;
        private Label lblTotal;
        private DataGridView dgvFactura;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtTotal;
        private DateTimePicker dtpFecha;
        private Button btnMostrar;
    }
}