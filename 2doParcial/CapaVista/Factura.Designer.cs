
namespace CapaVista
{
    partial class Factura
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIdCliente = new System.Windows.Forms.ComboBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarEncabezado = new System.Windows.Forms.Button();
            this.btnLimparG = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimparD = new System.Windows.Forms.Button();
            this.btnCancelarD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(441, 83);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(443, 492);
            this.dgvDetalles.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(140, 271);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(218, 27);
            this.txtTotal.TabIndex = 15;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(367, 217);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(218, 27);
            this.txtFecha.TabIndex = 16;
            this.txtFecha.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(140, 83);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(218, 27);
            this.txtID.TabIndex = 17;
            // 
            // gbEstado
            // 
            this.gbEstado.BackColor = System.Drawing.Color.Transparent;
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbEstado.Location = new System.Drawing.Point(48, 303);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(357, 75);
            this.gbEstado.TabIndex = 11;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbInactivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbInactivo.Location = new System.Drawing.Point(201, 37);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(94, 25);
            this.rbInactivo.TabIndex = 0;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = false;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbActivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbActivo.Location = new System.Drawing.Point(37, 36);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(81, 25);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Acitvo";
            this.rbActivo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(44, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(592, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Facturación";
            // 
            // cbxIdCliente
            // 
            this.cbxIdCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdCliente.FormattingEnabled = true;
            this.cbxIdCliente.Location = new System.Drawing.Point(140, 125);
            this.cbxIdCliente.Name = "cbxIdCliente";
            this.cbxIdCliente.Size = new System.Drawing.Size(218, 29);
            this.cbxIdCliente.TabIndex = 19;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNit.Location = new System.Drawing.Point(136, 176);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(0, 21);
            this.lblNit.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(44, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nit:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(364, 133);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 13);
            this.lblIdCliente.TabIndex = 21;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(140, 216);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(218, 27);
            this.dtpFecha.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(44, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Detalle:";
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Enabled = false;
            this.txtIdDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalle.Location = new System.Drawing.Point(140, 465);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(218, 27);
            this.txtIdDetalle.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(44, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Producto:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(140, 507);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(218, 29);
            this.cbxProducto.TabIndex = 19;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(377, 432);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 13);
            this.lblIdProducto.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(44, 554);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(140, 548);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(218, 27);
            this.txtPrecio.TabIndex = 15;
            // 
            // dgvFacturas
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(904, 83);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(433, 492);
            this.dgvFacturas.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(192, 395);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 50);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(249, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 50);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarEncabezado
            // 
            this.btnGuardarEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEncabezado.BackgroundImage")));
            this.btnGuardarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarEncabezado.FlatAppearance.BorderSize = 0;
            this.btnGuardarEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEncabezado.Location = new System.Drawing.Point(135, 395);
            this.btnGuardarEncabezado.Name = "btnGuardarEncabezado";
            this.btnGuardarEncabezado.Size = new System.Drawing.Size(51, 50);
            this.btnGuardarEncabezado.TabIndex = 27;
            this.btnGuardarEncabezado.UseVisualStyleBackColor = false;
            // 
            // btnLimparG
            // 
            this.btnLimparG.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparG.BackgroundImage")));
            this.btnLimparG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparG.FlatAppearance.BorderSize = 0;
            this.btnLimparG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparG.Location = new System.Drawing.Point(752, 593);
            this.btnLimparG.Name = "btnLimparG";
            this.btnLimparG.Size = new System.Drawing.Size(51, 50);
            this.btnLimparG.TabIndex = 28;
            this.btnLimparG.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(684, 593);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 50);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(613, 593);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(51, 50);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(538, 593);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 50);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(135, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 50);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnLimparD
            // 
            this.btnLimparD.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimparD.BackgroundImage")));
            this.btnLimparD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparD.FlatAppearance.BorderSize = 0;
            this.btnLimparD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparD.Location = new System.Drawing.Point(192, 593);
            this.btnLimparD.Name = "btnLimparD";
            this.btnLimparD.Size = new System.Drawing.Size(51, 50);
            this.btnLimparD.TabIndex = 28;
            this.btnLimparD.UseVisualStyleBackColor = false;
            // 
            // btnCancelarD
            // 
            this.btnCancelarD.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarD.BackgroundImage")));
            this.btnCancelarD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarD.FlatAppearance.BorderSize = 0;
            this.btnCancelarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarD.Location = new System.Drawing.Point(249, 593);
            this.btnCancelarD.Name = "btnCancelarD";
            this.btnCancelarD.Size = new System.Drawing.Size(51, 50);
            this.btnCancelarD.TabIndex = 26;
            this.btnCancelarD.UseVisualStyleBackColor = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.FondoFRM;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimparD);
            this.Controls.Add(this.btnLimparG);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelarD);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarEncabezado);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.cbxIdCliente);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIdDetalle);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Size = new System.Drawing.Size(1358, 663);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxIdCliente;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarEncabezado;
        private System.Windows.Forms.Button btnLimparG;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimparD;
        private System.Windows.Forms.Button btnCancelarD;
    }
}
