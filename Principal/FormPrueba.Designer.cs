namespace Principal
{
    partial class FormPrueba
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
            btnUsuarios = new Button();
            btnProveedor = new Button();
            btnProducto = new Button();
            btnVentas = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Arial", 11.25F);
            btnUsuarios.Location = new Point(45, 57);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(166, 59);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Font = new Font("Arial", 11.25F);
            btnProveedor.Location = new Point(263, 57);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(166, 59);
            btnProveedor.TabIndex = 1;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnProducto
            // 
            btnProducto.Font = new Font("Arial", 11.25F);
            btnProducto.Location = new Point(45, 176);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(166, 59);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Arial", 11.25F);
            btnVentas.Location = new Point(263, 176);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(166, 59);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // FormPrueba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVentas);
            Controls.Add(btnProducto);
            Controls.Add(btnProveedor);
            Controls.Add(btnUsuarios);
            Name = "FormPrueba";
            Text = "FormPrueba";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnProveedor;
        private Button btnProducto;
        private Button btnVentas;
    }
}