namespace AI_test
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblPatrones = new System.Windows.Forms.Label();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.txtEntradas = new System.Windows.Forms.TextBox();
            this.txtPatrones = new System.Windows.Forms.TextBox();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(53, 58);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(373, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "Seleccione la ubicación del archivo";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(465, 56);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Location = new System.Drawing.Point(50, 116);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(52, 13);
            this.lblEntradas.TabIndex = 2;
            this.lblEntradas.Text = "Entradas:";
            // 
            // lblPatrones
            // 
            this.lblPatrones.AutoSize = true;
            this.lblPatrones.Location = new System.Drawing.Point(279, 119);
            this.lblPatrones.Name = "lblPatrones";
            this.lblPatrones.Size = new System.Drawing.Size(52, 13);
            this.lblPatrones.TabIndex = 3;
            this.lblPatrones.Text = "Patrones:";
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Location = new System.Drawing.Point(507, 116);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(44, 13);
            this.lblSalidas.TabIndex = 4;
            this.lblSalidas.Text = "Salidas:";
            // 
            // txtEntradas
            // 
            this.txtEntradas.Enabled = false;
            this.txtEntradas.Location = new System.Drawing.Point(108, 113);
            this.txtEntradas.Name = "txtEntradas";
            this.txtEntradas.Size = new System.Drawing.Size(51, 20);
            this.txtEntradas.TabIndex = 5;
            this.txtEntradas.Text = "0";
            // 
            // txtPatrones
            // 
            this.txtPatrones.Enabled = false;
            this.txtPatrones.Location = new System.Drawing.Point(337, 116);
            this.txtPatrones.Name = "txtPatrones";
            this.txtPatrones.Size = new System.Drawing.Size(51, 20);
            this.txtPatrones.TabIndex = 6;
            this.txtPatrones.Text = "0";
            // 
            // txtSalidas
            // 
            this.txtSalidas.Enabled = false;
            this.txtSalidas.Location = new System.Drawing.Point(557, 113);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(51, 20);
            this.txtSalidas.TabIndex = 7;
            this.txtSalidas.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.txtSalidas);
            this.Controls.Add(this.txtPatrones);
            this.Controls.Add(this.txtEntradas);
            this.Controls.Add(this.lblSalidas);
            this.Controls.Add(this.lblPatrones);
            this.Controls.Add(this.lblEntradas);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPath);
            this.Name = "Main";
            this.Text = "Entradas - Patrones - Salidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblPatrones;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.TextBox txtEntradas;
        private System.Windows.Forms.TextBox txtPatrones;
        private System.Windows.Forms.TextBox txtSalidas;
    }
}

