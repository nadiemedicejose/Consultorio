namespace Consultorio
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDentistas = new System.Windows.Forms.DataGridView();
            this.txtDentistas = new System.Windows.Forms.TextBox();
            this.btnMostrarTodos_txt = new System.Windows.Forms.Button();
            this.btnMostrarTodos_dgv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnMostrarTodos_txt);
            this.groupBox1.Controls.Add(this.txtDentistas);
            this.groupBox1.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1000, 226);
            this.groupBox1.MinimumSize = new System.Drawing.Size(618, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dentistas (TextBox)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnMostrarTodos_dgv);
            this.groupBox2.Controls.Add(this.dgvDentistas);
            this.groupBox2.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(12, 246);
            this.groupBox2.MaximumSize = new System.Drawing.Size(1000, 226);
            this.groupBox2.MinimumSize = new System.Drawing.Size(618, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dentistas (DataGridViw)";
            // 
            // dgvDentistas
            // 
            this.dgvDentistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDentistas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDentistas.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvDentistas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDentistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDentistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("DM Sans", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDentistas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDentistas.Location = new System.Drawing.Point(7, 31);
            this.dgvDentistas.MaximumSize = new System.Drawing.Size(880, 188);
            this.dgvDentistas.MinimumSize = new System.Drawing.Size(440, 188);
            this.dgvDentistas.Name = "dgvDentistas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDentistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDentistas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDentistas.Size = new System.Drawing.Size(440, 188);
            this.dgvDentistas.TabIndex = 0;
            // 
            // txtDentistas
            // 
            this.txtDentistas.BackColor = System.Drawing.Color.MintCream;
            this.txtDentistas.Font = new System.Drawing.Font("DM Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDentistas.Location = new System.Drawing.Point(7, 32);
            this.txtDentistas.MaximumSize = new System.Drawing.Size(880, 188);
            this.txtDentistas.MinimumSize = new System.Drawing.Size(440, 188);
            this.txtDentistas.Multiline = true;
            this.txtDentistas.Name = "txtDentistas";
            this.txtDentistas.Size = new System.Drawing.Size(440, 188);
            this.txtDentistas.TabIndex = 0;
            // 
            // btnMostrarTodos_txt
            // 
            this.btnMostrarTodos_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos_txt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrarTodos_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodos_txt.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarTodos_txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarTodos_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos_txt.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos_txt.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos_txt.Location = new System.Drawing.Point(477, 83);
            this.btnMostrarTodos_txt.Name = "btnMostrarTodos_txt";
            this.btnMostrarTodos_txt.Size = new System.Drawing.Size(108, 60);
            this.btnMostrarTodos_txt.TabIndex = 1;
            this.btnMostrarTodos_txt.Text = "Mostrar todos";
            this.btnMostrarTodos_txt.UseVisualStyleBackColor = false;
            this.btnMostrarTodos_txt.Click += new System.EventHandler(this.btnMostrarTodos_txt_Click);
            // 
            // btnMostrarTodos_dgv
            // 
            this.btnMostrarTodos_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos_dgv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrarTodos_dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodos_dgv.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarTodos_dgv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMostrarTodos_dgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos_dgv.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos_dgv.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTodos_dgv.Location = new System.Drawing.Point(477, 83);
            this.btnMostrarTodos_dgv.Name = "btnMostrarTodos_dgv";
            this.btnMostrarTodos_dgv.Size = new System.Drawing.Size(108, 60);
            this.btnMostrarTodos_dgv.TabIndex = 2;
            this.btnMostrarTodos_dgv.Text = "Mostrar todos";
            this.btnMostrarTodos_dgv.UseVisualStyleBackColor = false;
            this.btnMostrarTodos_dgv.Click += new System.EventHandler(this.btnMostrarTodos_dgv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(642, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrarTodos_txt;
        private System.Windows.Forms.TextBox txtDentistas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarTodos_dgv;
        private System.Windows.Forms.DataGridView dgvDentistas;
    }
}

