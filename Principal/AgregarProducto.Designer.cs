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
            txtExistencia = new TextBox();
            label6 = new Label();
            pbAgregarProducto = new PictureBox();
            btnCargarImagen = new Button();
            btnGuardarProducto = new Button();
            label7 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            lbid = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbAgregarProducto).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 198);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(681, 131);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(185, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 197);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(559, 133);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(559, 196);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 6;
            label3.Text = "Existencia";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(138, 264);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(217, 27);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 264);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(681, 191);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(185, 27);
            txtExistencia.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 339);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 11;
            label6.Text = "Imagen";
            // 
            // pbAgregarProducto
            // 
            pbAgregarProducto.Location = new Point(138, 339);
            pbAgregarProducto.Name = "pbAgregarProducto";
            pbAgregarProducto.Size = new Size(217, 125);
            pbAgregarProducto.TabIndex = 12;
            pbAgregarProducto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.Navy;
            btnCargarImagen.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarImagen.ForeColor = SystemColors.ButtonFace;
            btnCargarImagen.Location = new Point(174, 492);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(151, 33);
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
            btnGuardarProducto.Location = new Point(725, 565);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(166, 64);
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
            label7.Location = new Point(325, 67);
            label7.Name = "label7";
            label7.Size = new Size(269, 35);
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
            toolStrip1.Size = new Size(953, 42);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = SystemColors.ControlLight;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(318, 39);
            toolStripLabel1.Text = "RODANDO STORE";
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbid.Location = new Point(37, 137);
            lbid.Name = "lbid";
            lbid.Size = new Size(27, 21);
            lbid.TabIndex = 17;
            lbid.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(138, 131);
            txtID.Name = "txtID";
            txtID.Size = new Size(217, 27);
            txtID.TabIndex = 18;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 665);
            Controls.Add(txtID);
            Controls.Add(lbid);
            Controls.Add(toolStrip1);
            Controls.Add(label7);
            Controls.Add(btnGuardarProducto);
            Controls.Add(btnCargarImagen);
            Controls.Add(pbAgregarProducto);
            Controls.Add(label6);
            Controls.Add(txtExistencia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
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
        private TextBox txtExistencia;
        private Label label6;
        private PictureBox pbAgregarProducto;
        private Button btnCargarImagen;
        private Button btnGuardarProducto;
        private Label label7;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Label lbid;
        private TextBox txtID;
    }
}