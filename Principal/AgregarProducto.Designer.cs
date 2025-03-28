namespace Principal
{
    partial class AgregarProducto
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtExistencia = new TextBox();
            label6 = new Label();
            pbAgregarProducto = new PictureBox();
            btnCargarImagen = new Button();
            btnGuardarProducto = new Button();
            label7 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)pbAgregarProducto).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 95);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(596, 98);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(162, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 98);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(489, 100);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(489, 198);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 6;
            label3.Text = "Existencia";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(121, 147);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(190, 23);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 153);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(596, 148);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(162, 23);
            txtCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(489, 153);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 10;
            label5.Text = "Cantidad";
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(596, 194);
            txtExistencia.Margin = new Padding(3, 2, 3, 2);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(162, 23);
            txtExistencia.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 206);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 11;
            label6.Text = "Imagen";
            // 
            // pbAgregarProducto
            // 
            pbAgregarProducto.Location = new Point(121, 206);
            pbAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            pbAgregarProducto.Name = "pbAgregarProducto";
            pbAgregarProducto.Size = new Size(190, 94);
            pbAgregarProducto.TabIndex = 12;
            pbAgregarProducto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.Navy;
            btnCargarImagen.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarImagen.ForeColor = SystemColors.ButtonFace;
            btnCargarImagen.Location = new Point(144, 317);
            btnCargarImagen.Margin = new Padding(3, 2, 3, 2);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(132, 25);
            btnCargarImagen.TabIndex = 13;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.Navy;
            btnGuardarProducto.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.ForeColor = SystemColors.ButtonFace;
            btnGuardarProducto.Location = new Point(634, 424);
            btnGuardarProducto.Margin = new Padding(3, 2, 3, 2);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(145, 48);
            btnGuardarProducto.TabIndex = 14;
            btnGuardarProducto.Text = "Agregar Producto";
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(284, 50);
            label7.Name = "label7";
            label7.Size = new Size(217, 29);
            label7.TabIndex = 15;
            label7.Text = "Agregar Producto";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Font = new Font("Arial", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(834, 35);
            toolStrip1.TabIndex = 16;
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
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 499);
            Controls.Add(toolStrip1);
            Controls.Add(label7);
            Controls.Add(btnGuardarProducto);
            Controls.Add(btnCargarImagen);
            Controls.Add(pbAgregarProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtExistencia);
            Controls.Add(label4);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)pbAgregarProducto).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtCantidad;
        private Label label5;
        private TextBox txtExistencia;
        private Label label6;
        private PictureBox pbAgregarProducto;
        private Button btnCargarImagen;
        private Button btnGuardarProducto;
        private Label label7;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
    }
}