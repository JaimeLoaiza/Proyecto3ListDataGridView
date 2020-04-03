namespace Proyecto_Lista3_ListDataGridView
{
    partial class Form1
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
            this.lbllistasdgv = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.btnguardarpersona = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllistasdgv
            // 
            this.lbllistasdgv.AutoSize = true;
            this.lbllistasdgv.Location = new System.Drawing.Point(108, 31);
            this.lbllistasdgv.Name = "lbllistasdgv";
            this.lbllistasdgv.Size = new System.Drawing.Size(225, 13);
            this.lbllistasdgv.TabIndex = 0;
            this.lbllistasdgv.Text = "LISTAS CON DATAGRIDVIEW - DINAMICAS";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(108, 81);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(108, 110);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(108, 136);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "Edad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(174, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(154, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(174, 107);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(154, 20);
            this.txtapellido.TabIndex = 5;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(174, 133);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(154, 20);
            this.txtedad.TabIndex = 6;
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(12, 185);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(421, 196);
            this.dgvlista.TabIndex = 7;
            // 
            // btnguardarpersona
            // 
            this.btnguardarpersona.Location = new System.Drawing.Point(12, 392);
            this.btnguardarpersona.Name = "btnguardarpersona";
            this.btnguardarpersona.Size = new System.Drawing.Size(107, 23);
            this.btnguardarpersona.TabIndex = 8;
            this.btnguardarpersona.Text = "Guardar Persona";
            this.btnguardarpersona.UseVisualStyleBackColor = true;
            this.btnguardarpersona.Click += new System.EventHandler(this.btnguardarpersona_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(358, 392);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardarpersona);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbllistasdgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllistasdgv;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.Button btnguardarpersona;
        private System.Windows.Forms.Button btnsalir;
    }
}

