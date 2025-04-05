namespace Principal
{
    partial class Ventas
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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            label7 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            txtTotal = new TextBox();
            label2 = new Label();
            dgvDetalle = new DataGridView();
            txtIdProducto = new TextBox();
            label3 = new Label();
            txtCantidadVentas = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            btnAgregarDetalle = new Button();
            btnRegistrarVenta = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Font = new Font("Arial", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 35);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = SystemColors.ControlLight;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(254, 32);
            toolStripLabel1.Text = "RODANDO STORE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(352, 35);
            label7.Name = "label7";
            label7.Size = new Size(90, 29);
            label7.TabIndex = 17;
            label7.Text = "Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 93);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 19;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtID.Location = new Point(86, 92);
            txtID.Name = "txtID";
            txtID.Size = new Size(130, 22);
            txtID.TabIndex = 20;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Arial", 9.75F);
            txtTotal.Location = new Point(555, 94);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(130, 22);
            txtTotal.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(507, 95);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 21;
            label2.Text = "Total";
            // 
            // dgvDetalle
            // 
            dgvDetalle.BackgroundColor = SystemColors.Control;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(27, 187);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(502, 199);
            dgvDetalle.TabIndex = 23;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Arial", 9.75F);
            txtIdProducto.Location = new Point(340, 90);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(130, 22);
            txtIdProducto.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(249, 94);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 24;
            label3.Text = "ID Producto";
            // 
            // txtCantidadVentas
            // 
            txtCantidadVentas.Font = new Font("Arial", 9.75F);
            txtCantidadVentas.Location = new Point(340, 146);
            txtCantidadVentas.Name = "txtCantidadVentas";
            txtCantidadVentas.Size = new Size(130, 22);
            txtCantidadVentas.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 151);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 26;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Arial", 9.75F);
            txtPrecio.Location = new Point(86, 146);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(130, 22);
            txtPrecio.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(249, 151);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 28;
            label5.Text = "Cantidad";
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.Navy;
            btnAgregarDetalle.Font = new Font("Arial", 11.25F);
            btnAgregarDetalle.ForeColor = SystemColors.ButtonFace;
            btnAgregarDetalle.Location = new Point(555, 136);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(151, 47);
            btnAgregarDetalle.TabIndex = 30;
            btnAgregarDetalle.Text = "Agregar Detalle";
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.Navy;
            btnRegistrarVenta.Font = new Font("Arial", 11.25F);
            btnRegistrarVenta.ForeColor = SystemColors.ButtonFace;
            btnRegistrarVenta.Location = new Point(555, 339);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(151, 47);
            btnRegistrarVenta.TabIndex = 31;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(btnAgregarDetalle);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtCantidadVentas);
            Controls.Add(label4);
            Controls.Add(txtIdProducto);
            Controls.Add(label3);
            Controls.Add(dgvDetalle);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(label7);
            Name = "Ventas";
            Text = "Ventas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Label label7;
        private Label label1;
        private TextBox txtID;
        private TextBox txtTotal;
        private Label label2;
        private DataGridView dgvDetalle;
        private TextBox txtIdProducto;
        private Label label3;
        private TextBox txtCantidadVentas;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private Button btnAgregarDetalle;
        private Button btnRegistrarVenta;
    }
}