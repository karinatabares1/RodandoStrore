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
            dgvFactura = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            label1 = new Label();
            txtNombre = new TextBox();
            txtTotal = new TextBox();
            dtpFecha = new DateTimePicker();
            btnMostrarFactura = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(55, 109);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(149, 21);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Nombre cliente ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblFecha.Location = new Point(55, 154);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(122, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha venta ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblTotal.Location = new Point(55, 196);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(52, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(55, 249);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(783, 179);
            dgvFactura.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 42);
            toolStrip1.TabIndex = 32;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = SystemColors.Control;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(318, 39);
            toolStripLabel1.Text = "RODANDO STORE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(382, 55);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 33;
            label1.Text = "Factura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(233, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 27);
            txtNombre.TabIndex = 34;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(233, 190);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(202, 27);
            txtTotal.TabIndex = 35;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(233, 154);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(335, 27);
            dtpFecha.TabIndex = 36;
            // 
            // btnMostrarFactura
            // 
            btnMostrarFactura.BackColor = Color.Navy;
            btnMostrarFactura.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarFactura.ForeColor = SystemColors.ButtonFace;
            btnMostrarFactura.Location = new Point(382, 453);
            btnMostrarFactura.Name = "btnMostrarFactura";
            btnMostrarFactura.Size = new Size(166, 64);
            btnMostrarFactura.TabIndex = 79;
            btnMostrarFactura.Text = "Mostrar";
            btnMostrarFactura.UseVisualStyleBackColor = false;
            btnMostrarFactura.Click += btnMostrarFactura_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 529);
            Controls.Add(btnMostrarFactura);
            Controls.Add(dtpFecha);
            Controls.Add(txtTotal);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(dgvFactura);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Controls.Add(lblCliente);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Factura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Label lblFecha;
        private Label lblTotal;
        private DataGridView dgvFactura;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTotal;
        private DateTimePicker dtpFecha;
        private Button btnMostrarFactura;
    }
}