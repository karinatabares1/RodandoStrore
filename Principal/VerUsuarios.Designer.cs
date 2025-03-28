namespace Principal
{
    partial class VerUsuarios
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
            dgvUsuarios = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(267, 47);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 34;
            label1.Text = "Usuarios";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Navy;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(677, 35);
            toolStrip1.TabIndex = 33;
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
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(8, 104);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(660, 197);
            dgvUsuarios.TabIndex = 35;
            // 
            // VerUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "VerUsuarios";
            Text = "VerUsuarios";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private DataGridView dgvUsuarios;
    }
}