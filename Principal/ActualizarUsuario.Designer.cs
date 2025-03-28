namespace Principal
{
    partial class ActualizarUsuario
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
            label1 = new Label();
            btnActualizaUsuario = new Button();
            label4 = new Label();
            txtID = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            cmbRoles = new ComboBox();
            label2 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(681, 35);
            toolStrip1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(231, 48);
            label1.Name = "label1";
            label1.Size = new Size(223, 29);
            label1.TabIndex = 1;
            label1.Text = "Actualizar Usuario";
            // 
            // btnActualizaUsuario
            // 
            btnActualizaUsuario.BackColor = Color.Navy;
            btnActualizaUsuario.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizaUsuario.ForeColor = SystemColors.ButtonFace;
            btnActualizaUsuario.Location = new Point(277, 257);
            btnActualizaUsuario.Margin = new Padding(3, 2, 3, 2);
            btnActualizaUsuario.Name = "btnActualizaUsuario";
            btnActualizaUsuario.Size = new Size(145, 51);
            btnActualizaUsuario.TabIndex = 28;
            btnActualizaUsuario.Text = "Actualizar Usuario";
            btnActualizaUsuario.UseVisualStyleBackColor = false;
            btnActualizaUsuario.Click += btnActualizaUsuario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 117);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 22;
            label4.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(127, 115);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(166, 22);
            txtID.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 171);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 17;
            label7.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 167);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 22);
            txtNombre.TabIndex = 15;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Arial", 8.25F);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(467, 115);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(141, 22);
            cmbRoles.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(396, 117);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 30;
            label2.Text = "Rol";
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 379);
            Controls.Add(label2);
            Controls.Add(cmbRoles);
            Controls.Add(btnActualizaUsuario);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ActualizarUsuario";
            Text = "ActualizarUsuario";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private Label label1;
        private Button btnActualizaUsuario;
        private Label label4;
        private TextBox txtID;
        private Label label7;
        private TextBox txtNombre;
        private ComboBox cmbRoles;
        private Label label2;
    }
}