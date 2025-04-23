namespace Principal
{
    partial class FormCompra
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
            btnConfirmarCompra = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvCarrito = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(915, 35);
            toolStrip1.TabIndex = 34;
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
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.BackColor = Color.Navy;
            btnConfirmarCompra.ForeColor = SystemColors.Control;
            btnConfirmarCompra.Location = new Point(738, 554);
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.Size = new Size(165, 52);
            btnConfirmarCompra.TabIndex = 40;
            btnConfirmarCompra.Text = "Confirmar Compra";
            btnConfirmarCompra.UseVisualStyleBackColor = false;
            btnConfirmarCompra.Click += btnConfirmarCompra_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 10, 10, 220);
            flowLayoutPanel1.Size = new Size(915, 300);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(0, 351);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(915, 197);
            dgvCarrito.TabIndex = 42;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(915, 618);
            Controls.Add(dgvCarrito);
            Controls.Add(btnConfirmarCompra);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(toolStrip1);
            Font = new Font("Arial", 11.25F);
            Margin = new Padding(4);
            Name = "FormCompra";
            Text = "FormCompra";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Button btnConfirmarCompra;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvCarrito;
    }
}