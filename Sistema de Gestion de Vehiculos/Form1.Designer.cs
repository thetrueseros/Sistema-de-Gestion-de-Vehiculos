namespace Sistema_de_Gestion_de_Vehiculos
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
            this.lblSisGesVehiculos = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.txtbModelo = new System.Windows.Forms.TextBox();
            this.txtbPrecioBase = new System.Windows.Forms.TextBox();
            this.lstVehiculos = new System.Windows.Forms.ListView();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSisGesVehiculos
            // 
            this.lblSisGesVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSisGesVehiculos.AutoSize = true;
            this.lblSisGesVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisGesVehiculos.Location = new System.Drawing.Point(260, 9);
            this.lblSisGesVehiculos.Name = "lblSisGesVehiculos";
            this.lblSisGesVehiculos.Size = new System.Drawing.Size(285, 24);
            this.lblSisGesVehiculos.TabIndex = 0;
            this.lblSisGesVehiculos.Text = "Sistema de gestión de Vehículos";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(60, 190);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(74, 24);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(60, 147);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 24);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(60, 95);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 24);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioBase.Location = new System.Drawing.Point(60, 238);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(110, 24);
            this.lblPrecioBase.TabIndex = 4;
            this.lblPrecioBase.Text = "Precio base";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "(Seleccione)",
            "Automovil",
            "Motocicleta"});
            this.cmbTipo.Location = new System.Drawing.Point(192, 95);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // txtbMarca
            // 
            this.txtbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbMarca.Location = new System.Drawing.Point(192, 150);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.Size = new System.Drawing.Size(121, 20);
            this.txtbMarca.TabIndex = 6;
            // 
            // txtbModelo
            // 
            this.txtbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbModelo.Location = new System.Drawing.Point(192, 193);
            this.txtbModelo.Name = "txtbModelo";
            this.txtbModelo.Size = new System.Drawing.Size(121, 20);
            this.txtbModelo.TabIndex = 7;
            // 
            // txtbPrecioBase
            // 
            this.txtbPrecioBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbPrecioBase.Location = new System.Drawing.Point(192, 241);
            this.txtbPrecioBase.Name = "txtbPrecioBase";
            this.txtbPrecioBase.Size = new System.Drawing.Size(121, 20);
            this.txtbPrecioBase.TabIndex = 8;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVehiculos.HideSelection = false;
            this.lstVehiculos.Location = new System.Drawing.Point(365, 95);
            this.lstVehiculos.MinimumSize = new System.Drawing.Size(423, 167);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(423, 167);
            this.lstVehiculos.TabIndex = 9;
            this.lstVehiculos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(305, 288);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(169, 40);
            this.btnAgregarVehiculo.TabIndex = 10;
            this.btnAgregarVehiculo.Text = "Agregar Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.txtbPrecioBase);
            this.Controls.Add(this.txtbModelo);
            this.Controls.Add(this.txtbMarca);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblSisGesVehiculos);
            this.MinimumSize = new System.Drawing.Size(816, 379);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSisGesVehiculos;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.TextBox txtbModelo;
        private System.Windows.Forms.TextBox txtbPrecioBase;
        private System.Windows.Forms.ListView lstVehiculos;
        private System.Windows.Forms.Button btnAgregarVehiculo;
    }
}

