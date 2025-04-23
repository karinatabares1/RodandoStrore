namespace Principal
{
    partial class VerVentas
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
            dgvVentas = new DataGridView();
            btnVerDetalles = new Button();
            btnEliminarVenta = new Button();
            btnActualizarVenta = new Button();
            dgvDetallesVenta = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaVenta = new DateTimePicker();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(375, 68);
            label1.Name = "label1";
            label1.Size = new Size(167, 35);
            label1.TabIndex = 45;
            label1.Text = "Ver Ventas";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 42);
            toolStrip1.TabIndex = 44;
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
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(107, 220);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(701, 224);
            dgvVentas.TabIndex = 46;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.BackColor = Color.Navy;
            btnVerDetalles.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerDetalles.ForeColor = SystemColors.ButtonFace;
            btnVerDetalles.Location = new Point(221, 481);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(166, 64);
            btnVerDetalles.TabIndex = 77;
            btnVerDetalles.Text = "Ver Detalles";
            btnVerDetalles.UseVisualStyleBackColor = false;
            btnVerDetalles.Click += btnVerDetalles_Click_1;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.BackColor = Color.Navy;
            btnEliminarVenta.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarVenta.ForeColor = SystemColors.ButtonFace;
            btnEliminarVenta.Location = new Point(447, 481);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(166, 64);
            btnEliminarVenta.TabIndex = 78;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = false;
            btnEliminarVenta.Click += btnEliminarVenta_Click_1;
            // 
            // btnActualizarVenta
            // 
            btnActualizarVenta.BackColor = Color.Navy;
            btnActualizarVenta.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarVenta.ForeColor = SystemColors.ButtonFace;
            btnActualizarVenta.Location = new Point(642, 481);
            btnActualizarVenta.Name = "btnActualizarVenta";
            btnActualizarVenta.Size = new Size(166, 64);
            btnActualizarVenta.TabIndex = 79;
            btnActualizarVenta.Text = "Actualizar Venta";
            btnActualizarVenta.UseVisualStyleBackColor = false;
            btnActualizarVenta.Click += btnActualizarVenta_Click;
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesVenta.Location = new Point(107, 625);
            dgvDetallesVenta.Margin = new Padding(3, 4, 3, 4);
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.RowHeadersWidth = 51;
            dgvDetallesVenta.Size = new Size(701, 224);
            dgvDetallesVenta.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 179);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 81;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(107, 160);
            label3.Name = "label3";
            label3.Size = new Size(220, 29);
            label3.TabIndex = 82;
            label3.Text = "Listado De Ventas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(107, 572);
            label4.Name = "label4";
            label4.Size = new Size(199, 29);
            label4.TabIndex = 83;
            label4.Text = "Detalle De Venta";
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.CalendarTitleBackColor = SystemColors.ActiveBorder;
            dtpFechaVenta.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaVenta.Location = new Point(321, 574);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(292, 25);
            dtpFechaVenta.TabIndex = 84;
            // 
            // VerVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 865);
            Controls.Add(dtpFechaVenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvDetallesVenta);
            Controls.Add(btnActualizarVenta);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnVerDetalles);
            Controls.Add(dgvVentas);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VerVentas";
            Text = "VerVentas";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private DataGridView dgvVentas;
        private Button btnVerDetalles;
        private Button btnEliminarVenta;
        private Button btnActualizarVenta;
        private DataGridView dgvDetallesVenta;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaVenta;
    }
}