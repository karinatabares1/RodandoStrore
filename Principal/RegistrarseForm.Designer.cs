namespace Principal
{
    partial class RegistrarseForm
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
            label3 = new Label();
            txtContrasena = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnRegistrarse = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(226, 77);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 39;
            label3.Text = "Registrarse";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(264, 206);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(154, 23);
            txtContrasena.TabIndex = 38;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(264, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 206);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 36;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 160);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 35;
            label1.Text = "Nombre";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.Navy;
            btnRegistrarse.ForeColor = SystemColors.Control;
            btnRegistrarse.Location = new Point(235, 269);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(144, 49);
            btnRegistrarse.TabIndex = 34;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(640, 35);
            toolStrip1.TabIndex = 40;
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
            // RegistrarseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 401);
            Controls.Add(toolStrip1);
            Controls.Add(label3);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistrarse);
            Name = "RegistrarseForm";
            Text = "RegistrarseForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtContrasena;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnRegistrarse;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
    }
}