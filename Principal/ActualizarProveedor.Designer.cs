namespace Principal
{
    partial class ActualizarProveedor
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
            txtTelefono = new TextBox();
            label3 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            btnActualizarProveedor = new Button();
            label4 = new Label();
            txtID = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 9.75F);
            txtTelefono.Location = new Point(187, 170);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(166, 22);
            txtTelefono.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(110, 172);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 61;
            label3.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Arial", 9.75F);
            txtDireccion.Location = new Point(509, 170);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(166, 22);
            txtDireccion.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 167);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 59;
            label2.Text = "Dirección";
            // 
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.BackColor = Color.Navy;
            btnActualizarProveedor.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarProveedor.ForeColor = SystemColors.ButtonFace;
            btnActualizarProveedor.Location = new Point(318, 219);
            btnActualizarProveedor.Margin = new Padding(3, 2, 3, 2);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.Size = new Size(162, 48);
            btnActualizarProveedor.TabIndex = 58;
            btnActualizarProveedor.Text = "Actualizar Proveedor";
            btnActualizarProveedor.UseVisualStyleBackColor = false;
            btnActualizarProveedor.Click += btnActualizarProveedor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(110, 115);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 57;
            label4.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 9.75F);
            txtID.Location = new Point(187, 112);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(166, 22);
            txtID.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 115);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 55;
            label7.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(509, 112);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 22);
            txtNombre.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(274, 44);
            label1.Name = "label1";
            label1.Size = new Size(252, 29);
            label1.TabIndex = 53;
            label1.Text = "Actualizar Proveedor";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 35);
            toolStrip1.TabIndex = 52;
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
            // ActualizarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(btnActualizarProveedor);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "ActualizarProveedor";
            Text = "ActualizarProveedor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtDireccion;
        private Label label2;
        private Button btnActualizarProveedor;
        private Label label4;
        private TextBox txtID;
        private Label label7;
        private TextBox txtNombre;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
    }
}