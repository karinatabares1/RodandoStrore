namespace Principal
{
    partial class RegistrarVentas
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
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtCantidad = new TextBox();
            label3 = new Label();
            btnAgregarDetalle = new Button();
            label4 = new Label();
            txtID = new TextBox();
            label7 = new Label();
            txtPrecio = new TextBox();
            dgvDetalle = new DataGridView();
            label2 = new Label();
            txtTotal = new TextBox();
            btnRegistrarVenta = new Button();
            cbxProducto = new ComboBox();
            label5 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(276, 49);
            label1.Name = "label1";
            label1.Size = new Size(201, 29);
            label1.TabIndex = 43;
            label1.Text = "Registrar Ventas";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 35);
            toolStrip1.TabIndex = 42;
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
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Arial", 9.75F);
            txtCantidad.Location = new Point(176, 185);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(166, 22);
            txtCantidad.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(85, 186);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 79;
            label3.Text = "Cantidad";
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.Navy;
            btnAgregarDetalle.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarDetalle.ForeColor = SystemColors.ButtonFace;
            btnAgregarDetalle.Location = new Point(88, 236);
            btnAgregarDetalle.Margin = new Padding(3, 2, 3, 2);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(145, 48);
            btnAgregarDetalle.TabIndex = 76;
            btnAgregarDetalle.Text = "Agregar Detalle";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 130);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 75;
            label4.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 9.75F);
            txtID.Location = new Point(176, 127);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(166, 22);
            txtID.TabIndex = 74;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(397, 133);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 73;
            label7.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(486, 130);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(166, 22);
            txtPrecio.TabIndex = 72;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(88, 298);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(564, 209);
            dgvDetalle.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 543);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 83;
            label2.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(176, 543);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(135, 22);
            txtTotal.TabIndex = 82;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.Navy;
            btnRegistrarVenta.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarVenta.ForeColor = SystemColors.ButtonFace;
            btnRegistrarVenta.Location = new Point(507, 529);
            btnRegistrarVenta.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(145, 48);
            btnRegistrarVenta.TabIndex = 84;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // cbxProducto
            // 
            cbxProducto.FormattingEnabled = true;
            cbxProducto.Location = new Point(486, 186);
            cbxProducto.Name = "cbxProducto";
            cbxProducto.Size = new Size(121, 23);
            cbxProducto.TabIndex = 85;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F);
            label5.Location = new Point(397, 192);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 86;
            label5.Text = "Producto";
            // 
            // RegistrarVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(label5);
            Controls.Add(cbxProducto);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(dgvDetalle);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(btnAgregarDetalle);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "RegistrarVentas";
            Text = "RegistrarVentas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Label label6;
        private DateTimePicker dtpFecha;
        private TextBox txtCantidad;
        private Label label3;
        private TextBox txtDireccion;
        private Label label2;
        private Button btnAgregarDetalle;
        private Label label4;
        private TextBox txtID;
        private Label label7;
        private TextBox txtPrecio;
        private DataGridView dgvDetalle;
        private TextBox txtTotal;
        private Button btnRegistrarVenta;
        private ComboBox cbxProducto;
        private Label label5;
    }
}