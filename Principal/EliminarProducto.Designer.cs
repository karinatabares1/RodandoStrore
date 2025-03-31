namespace Principal
{
    partial class EliminarProducto
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
            btnEliminarProducto = new Button();
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
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Navy;
            btnEliminarProducto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.ButtonFace;
            btnEliminarProducto.Location = new Point(328, 268);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(166, 64);
            btnEliminarProducto.TabIndex = 46;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(112, 183);
            label4.Name = "label4";
            label4.Size = new Size(27, 21);
            label4.TabIndex = 45;
            label4.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 9.75F);
            txtID.Location = new Point(184, 181);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 26);
            txtID.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(450, 185);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 43;
            label7.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(552, 181);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 26);
            txtNombre.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(283, 90);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 41;
            label1.Text = "Eliminar Producto";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 42);
            toolStrip1.TabIndex = 40;
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
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarProducto);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "EliminarProducto";
            Text = "EliminarProducto";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarProducto;
        private Label label4;
        private TextBox txtID;
        private Label label7;
        private TextBox txtNombre;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
    }
}