﻿namespace Principal
{
    partial class EliminarProveedor
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
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.BackColor = Color.Navy;
            btnActualizarProveedor.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarProveedor.ForeColor = SystemColors.ButtonFace;
            btnActualizarProveedor.Location = new Point(296, 194);
            btnActualizarProveedor.Margin = new Padding(3, 2, 3, 2);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.Size = new Size(162, 48);
            btnActualizarProveedor.TabIndex = 69;
            btnActualizarProveedor.Text = "Eliminar Proveedor";
            btnActualizarProveedor.UseVisualStyleBackColor = false;
            btnActualizarProveedor.Click += btnActualizarProveedor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 124);
            label4.Name = "label4";
            label4.Size = new Size(22, 17);
            label4.TabIndex = 68;
            label4.Text = "ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial", 9.75F);
            txtID.Location = new Point(165, 121);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(166, 22);
            txtID.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(398, 124);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 66;
            label7.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(487, 121);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 22);
            txtNombre.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(252, 53);
            label1.Name = "label1";
            label1.Size = new Size(233, 29);
            label1.TabIndex = 64;
            label1.Text = "Eliminar Proveedor";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(730, 35);
            toolStrip1.TabIndex = 63;
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
            // EliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(btnActualizarProveedor);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "EliminarProveedor";
            Text = "EliminarProveedor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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