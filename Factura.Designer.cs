
namespace facturacion
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum_fac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuReg = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnIrRegArt = new System.Windows.Forms.Button();
            this.btnIrRegCliente = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Reportes = new System.Windows.Forms.Panel();
            this.btnCuenPCob = new System.Windows.Forms.Button();
            this.btnCuenCibrar = new System.Windows.Forms.Button();
            this.btnCuaFecha = new System.Windows.Forms.Button();
            this.btnFac8p = new System.Windows.Forms.Button();
            this.btnFac3p = new System.Windows.Forms.Button();
            this.btnRepUsu = new System.Windows.Forms.Button();
            this.btnRegProv = new System.Windows.Forms.Button();
            this.btnRepCliente = new System.Windows.Forms.Button();
            this.btnRepArt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripartdftemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantartdftemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predftemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temdetallefacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new facturacion.facturacionDataSet();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMonDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescIte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotPag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPorDesc = new System.Windows.Forms.TextBox();
            this.txtPorDescIte = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipFac = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.temdetallefacturaTableAdapter = new facturacion.facturacionDataSetTableAdapters.temdetallefacturaTableAdapter();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelMenuReg.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Reportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temdetallefacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Blue;
            this.btnNuevo.Location = new System.Drawing.Point(675, 105);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 28);
            this.btnNuevo.TabIndex = 80;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminar.Location = new System.Drawing.Point(675, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 28);
            this.btnEliminar.TabIndex = 78;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(761, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 29);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 77;
            this.btnCerrar.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Blue;
            this.btnRegistrar.Location = new System.Drawing.Point(675, 140);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 28);
            this.btnRegistrar.TabIndex = 75;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.DimGray;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(622, 70);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(45, 16);
            this.txtHora.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(619, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Hora";
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.DimGray;
            this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.ForeColor = System.Drawing.Color.White;
            this.txtArticulo.Location = new System.Drawing.Point(218, 146);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(169, 16);
            this.txtArticulo.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(215, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Articulo";
            // 
            // txtSubTot
            // 
            this.txtSubTot.BackColor = System.Drawing.Color.DimGray;
            this.txtSubTot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTot.ForeColor = System.Drawing.Color.White;
            this.txtSubTot.Location = new System.Drawing.Point(601, 155);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.Size = new System.Drawing.Size(66, 16);
            this.txtSubTot.TabIndex = 70;
            this.txtSubTot.TextChanged += new System.EventHandler(this.txtTotPag_TextChanged);
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.ForeColor = System.Drawing.Color.White;
            this.lblSector.Location = new System.Drawing.Point(530, 154);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(65, 17);
            this.lblSector.TabIndex = 69;
            this.lblSector.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tipo de Factura";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.DimGray;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(488, 70);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(128, 16);
            this.txtFecha.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(485, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Descripcion";
            // 
            // txtnum_fac
            // 
            this.txtnum_fac.BackColor = System.Drawing.Color.DimGray;
            this.txtnum_fac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_fac.ForeColor = System.Drawing.Color.White;
            this.txtnum_fac.Location = new System.Drawing.Point(218, 70);
            this.txtnum_fac.Name = "txtnum_fac";
            this.txtnum_fac.Size = new System.Drawing.Size(127, 16);
            this.txtnum_fac.TabIndex = 62;
            this.txtnum_fac.TextChanged += new System.EventHandler(this.txtnum_fac_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Numero de Factura";
            // 
            // panelMenuReg
            // 
            this.panelMenuReg.AutoScroll = true;
            this.panelMenuReg.BackColor = System.Drawing.Color.DimGray;
            this.panelMenuReg.Controls.Add(this.button2);
            this.panelMenuReg.Controls.Add(this.button5);
            this.panelMenuReg.Controls.Add(this.button4);
            this.panelMenuReg.Controls.Add(this.btnIrRegArt);
            this.panelMenuReg.Controls.Add(this.btnIrRegCliente);
            this.panelMenuReg.Location = new System.Drawing.Point(0, 32);
            this.panelMenuReg.Name = "panelMenuReg";
            this.panelMenuReg.Size = new System.Drawing.Size(200, 153);
            this.panelMenuReg.TabIndex = 81;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 115);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registrar Factura";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 84);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(200, 31);
            this.button5.TabIndex = 3;
            this.button5.Text = "Registrar Usuario";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 56);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Registrar Proveedor";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnIrRegArt
            // 
            this.btnIrRegArt.BackColor = System.Drawing.Color.DimGray;
            this.btnIrRegArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIrRegArt.FlatAppearance.BorderSize = 0;
            this.btnIrRegArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrRegArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrRegArt.ForeColor = System.Drawing.Color.White;
            this.btnIrRegArt.Location = new System.Drawing.Point(0, 28);
            this.btnIrRegArt.Name = "btnIrRegArt";
            this.btnIrRegArt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIrRegArt.Size = new System.Drawing.Size(200, 28);
            this.btnIrRegArt.TabIndex = 1;
            this.btnIrRegArt.Text = "Registrar Articulo";
            this.btnIrRegArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrRegArt.UseVisualStyleBackColor = false;
            this.btnIrRegArt.Click += new System.EventHandler(this.btnIrRegArt_Click);
            // 
            // btnIrRegCliente
            // 
            this.btnIrRegCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnIrRegCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIrRegCliente.FlatAppearance.BorderSize = 0;
            this.btnIrRegCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrRegCliente.ForeColor = System.Drawing.Color.White;
            this.btnIrRegCliente.Location = new System.Drawing.Point(0, 0);
            this.btnIrRegCliente.Name = "btnIrRegCliente";
            this.btnIrRegCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIrRegCliente.Size = new System.Drawing.Size(200, 28);
            this.btnIrRegCliente.TabIndex = 0;
            this.btnIrRegCliente.Text = "Registrar Cliente";
            this.btnIrRegCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrRegCliente.UseVisualStyleBackColor = false;
            this.btnIrRegCliente.Click += new System.EventHandler(this.btnIrRegCliente_Click);
            // 
            // btnreg
            // 
            this.btnreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreg.FlatAppearance.BorderSize = 0;
            this.btnreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreg.Location = new System.Drawing.Point(0, 0);
            this.btnreg.Name = "btnreg";
            this.btnreg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnreg.Size = new System.Drawing.Size(200, 36);
            this.btnreg.TabIndex = 82;
            this.btnreg.Text = "Registro";
            this.btnreg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreg.UseVisualStyleBackColor = false;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 61);
            this.panel2.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel_Reportes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnreg);
            this.panel1.Controls.Add(this.panelMenuReg);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 390);
            this.panel1.TabIndex = 84;
            // 
            // panel_Reportes
            // 
            this.panel_Reportes.AutoScroll = true;
            this.panel_Reportes.BackColor = System.Drawing.Color.DimGray;
            this.panel_Reportes.Controls.Add(this.btnCuenPCob);
            this.panel_Reportes.Controls.Add(this.btnCuenCibrar);
            this.panel_Reportes.Controls.Add(this.btnCuaFecha);
            this.panel_Reportes.Controls.Add(this.btnFac8p);
            this.panel_Reportes.Controls.Add(this.btnFac3p);
            this.panel_Reportes.Controls.Add(this.btnRepUsu);
            this.panel_Reportes.Controls.Add(this.btnRegProv);
            this.panel_Reportes.Controls.Add(this.btnRepCliente);
            this.panel_Reportes.Controls.Add(this.btnRepArt);
            this.panel_Reportes.Location = new System.Drawing.Point(0, 218);
            this.panel_Reportes.Name = "panel_Reportes";
            this.panel_Reportes.Size = new System.Drawing.Size(200, 262);
            this.panel_Reportes.TabIndex = 88;
            // 
            // btnCuenPCob
            // 
            this.btnCuenPCob.BackColor = System.Drawing.Color.DimGray;
            this.btnCuenPCob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuenPCob.FlatAppearance.BorderSize = 0;
            this.btnCuenPCob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenPCob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenPCob.ForeColor = System.Drawing.Color.White;
            this.btnCuenPCob.Location = new System.Drawing.Point(0, 227);
            this.btnCuenPCob.Name = "btnCuenPCob";
            this.btnCuenPCob.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCuenPCob.Size = new System.Drawing.Size(200, 28);
            this.btnCuenPCob.TabIndex = 8;
            this.btnCuenPCob.Text = "Cuentas por Cobrar";
            this.btnCuenPCob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenPCob.UseVisualStyleBackColor = false;
            // 
            // btnCuenCibrar
            // 
            this.btnCuenCibrar.BackColor = System.Drawing.Color.DimGray;
            this.btnCuenCibrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuenCibrar.FlatAppearance.BorderSize = 0;
            this.btnCuenCibrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenCibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenCibrar.ForeColor = System.Drawing.Color.White;
            this.btnCuenCibrar.Location = new System.Drawing.Point(0, 199);
            this.btnCuenCibrar.Name = "btnCuenCibrar";
            this.btnCuenCibrar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCuenCibrar.Size = new System.Drawing.Size(200, 28);
            this.btnCuenCibrar.TabIndex = 7;
            this.btnCuenCibrar.Text = "Cuentas por Cobrar";
            this.btnCuenCibrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenCibrar.UseVisualStyleBackColor = false;
            // 
            // btnCuaFecha
            // 
            this.btnCuaFecha.BackColor = System.Drawing.Color.DimGray;
            this.btnCuaFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCuaFecha.FlatAppearance.BorderSize = 0;
            this.btnCuaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuaFecha.ForeColor = System.Drawing.Color.White;
            this.btnCuaFecha.Location = new System.Drawing.Point(0, 171);
            this.btnCuaFecha.Name = "btnCuaFecha";
            this.btnCuaFecha.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCuaFecha.Size = new System.Drawing.Size(200, 28);
            this.btnCuaFecha.TabIndex = 6;
            this.btnCuaFecha.Text = "Cuadre por Fecha";
            this.btnCuaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuaFecha.UseVisualStyleBackColor = false;
            // 
            // btnFac8p
            // 
            this.btnFac8p.BackColor = System.Drawing.Color.DimGray;
            this.btnFac8p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFac8p.FlatAppearance.BorderSize = 0;
            this.btnFac8p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFac8p.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFac8p.ForeColor = System.Drawing.Color.White;
            this.btnFac8p.Location = new System.Drawing.Point(0, 143);
            this.btnFac8p.Name = "btnFac8p";
            this.btnFac8p.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFac8p.Size = new System.Drawing.Size(200, 28);
            this.btnFac8p.TabIndex = 5;
            this.btnFac8p.Text = "Factura de 8½  x 11 ";
            this.btnFac8p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFac8p.UseVisualStyleBackColor = false;
            // 
            // btnFac3p
            // 
            this.btnFac3p.BackColor = System.Drawing.Color.DimGray;
            this.btnFac3p.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFac3p.FlatAppearance.BorderSize = 0;
            this.btnFac3p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFac3p.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFac3p.ForeColor = System.Drawing.Color.White;
            this.btnFac3p.Location = new System.Drawing.Point(0, 115);
            this.btnFac3p.Name = "btnFac3p";
            this.btnFac3p.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFac3p.Size = new System.Drawing.Size(200, 28);
            this.btnFac3p.TabIndex = 4;
            this.btnFac3p.Text = "Factura de 3 in";
            this.btnFac3p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFac3p.UseVisualStyleBackColor = false;
            // 
            // btnRepUsu
            // 
            this.btnRepUsu.BackColor = System.Drawing.Color.DimGray;
            this.btnRepUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepUsu.FlatAppearance.BorderSize = 0;
            this.btnRepUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepUsu.ForeColor = System.Drawing.Color.White;
            this.btnRepUsu.Location = new System.Drawing.Point(0, 84);
            this.btnRepUsu.Name = "btnRepUsu";
            this.btnRepUsu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRepUsu.Size = new System.Drawing.Size(200, 31);
            this.btnRepUsu.TabIndex = 3;
            this.btnRepUsu.Text = "Listado de Usuario";
            this.btnRepUsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepUsu.UseVisualStyleBackColor = false;
            // 
            // btnRegProv
            // 
            this.btnRegProv.BackColor = System.Drawing.Color.DimGray;
            this.btnRegProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegProv.FlatAppearance.BorderSize = 0;
            this.btnRegProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegProv.ForeColor = System.Drawing.Color.White;
            this.btnRegProv.Location = new System.Drawing.Point(0, 56);
            this.btnRegProv.Name = "btnRegProv";
            this.btnRegProv.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegProv.Size = new System.Drawing.Size(200, 28);
            this.btnRegProv.TabIndex = 2;
            this.btnRegProv.Text = "Listado de Proveedor";
            this.btnRegProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegProv.UseVisualStyleBackColor = false;
            // 
            // btnRepCliente
            // 
            this.btnRepCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnRepCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepCliente.FlatAppearance.BorderSize = 0;
            this.btnRepCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepCliente.ForeColor = System.Drawing.Color.White;
            this.btnRepCliente.Location = new System.Drawing.Point(0, 28);
            this.btnRepCliente.Name = "btnRepCliente";
            this.btnRepCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRepCliente.Size = new System.Drawing.Size(200, 28);
            this.btnRepCliente.TabIndex = 1;
            this.btnRepCliente.Text = "Listado de Clientes";
            this.btnRepCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepCliente.UseVisualStyleBackColor = false;
            // 
            // btnRepArt
            // 
            this.btnRepArt.BackColor = System.Drawing.Color.DimGray;
            this.btnRepArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepArt.FlatAppearance.BorderSize = 0;
            this.btnRepArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepArt.ForeColor = System.Drawing.Color.White;
            this.btnRepArt.Location = new System.Drawing.Point(0, 0);
            this.btnRepArt.Name = "btnRepArt";
            this.btnRepArt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRepArt.Size = new System.Drawing.Size(200, 28);
            this.btnRepArt.TabIndex = 0;
            this.btnRepArt.Text = "Listado de Articulos";
            this.btnRepArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepArt.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 185);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 87;
            this.button1.Text = "Reportes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.descripartdftemDataGridViewTextBoxColumn,
            this.cantartdftemDataGridViewTextBoxColumn,
            this.predftemDataGridViewTextBoxColumn,
            this.stotal});
            this.dataGridView1.DataSource = this.temdetallefacturaBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(220, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 186);
            this.dataGridView1.TabIndex = 85;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "cod_art_dftem";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // descripartdftemDataGridViewTextBoxColumn
            // 
            this.descripartdftemDataGridViewTextBoxColumn.DataPropertyName = "descrip_art_dftem";
            this.descripartdftemDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.descripartdftemDataGridViewTextBoxColumn.Name = "descripartdftemDataGridViewTextBoxColumn";
            // 
            // cantartdftemDataGridViewTextBoxColumn
            // 
            this.cantartdftemDataGridViewTextBoxColumn.DataPropertyName = "cant_art_dftem";
            this.cantartdftemDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cantartdftemDataGridViewTextBoxColumn.Name = "cantartdftemDataGridViewTextBoxColumn";
            // 
            // predftemDataGridViewTextBoxColumn
            // 
            this.predftemDataGridViewTextBoxColumn.DataPropertyName = "pre_dftem";
            this.predftemDataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.predftemDataGridViewTextBoxColumn.Name = "predftemDataGridViewTextBoxColumn";
            // 
            // stotal
            // 
            this.stotal.DataPropertyName = "stotal";
            this.stotal.HeaderText = "SUB-TOTAL";
            this.stotal.Name = "stotal";
            // 
            // temdetallefacturaBindingSource
            // 
            this.temdetallefacturaBindingSource.DataMember = "temdetallefactura";
            this.temdetallefacturaBindingSource.DataSource = this.facturacionDataSet;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "facturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(326, 188);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 16);
            this.txtDescripcion.TabIndex = 86;
            // 
            // txtMonDesc
            // 
            this.txtMonDesc.BackColor = System.Drawing.Color.DimGray;
            this.txtMonDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonDesc.ForeColor = System.Drawing.Color.White;
            this.txtMonDesc.Location = new System.Drawing.Point(601, 176);
            this.txtMonDesc.Name = "txtMonDesc";
            this.txtMonDesc.Size = new System.Drawing.Size(66, 16);
            this.txtMonDesc.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(520, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Itebis";
            // 
            // txtDescIte
            // 
            this.txtDescIte.BackColor = System.Drawing.Color.DimGray;
            this.txtDescIte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescIte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescIte.ForeColor = System.Drawing.Color.White;
            this.txtDescIte.Location = new System.Drawing.Point(601, 197);
            this.txtDescIte.Name = "txtDescIte";
            this.txtDescIte.Size = new System.Drawing.Size(66, 16);
            this.txtDescIte.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(485, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Descuento";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.DimGray;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(351, 70);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(107, 16);
            this.txtCliente.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(348, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 91;
            this.label9.Text = "Cliente";
            // 
            // txtTotPag
            // 
            this.txtTotPag.BackColor = System.Drawing.Color.DimGray;
            this.txtTotPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotPag.ForeColor = System.Drawing.Color.White;
            this.txtTotPag.Location = new System.Drawing.Point(601, 219);
            this.txtTotPag.Name = "txtTotPag";
            this.txtTotPag.Size = new System.Drawing.Size(66, 16);
            this.txtTotPag.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(500, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 93;
            this.label10.Text = "Total a Pagar";
            // 
            // txtPorDesc
            // 
            this.txtPorDesc.BackColor = System.Drawing.Color.DimGray;
            this.txtPorDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorDesc.ForeColor = System.Drawing.Color.White;
            this.txtPorDesc.Location = new System.Drawing.Point(560, 177);
            this.txtPorDesc.Name = "txtPorDesc";
            this.txtPorDesc.Size = new System.Drawing.Size(35, 16);
            this.txtPorDesc.TabIndex = 95;
            // 
            // txtPorDescIte
            // 
            this.txtPorDescIte.BackColor = System.Drawing.Color.DimGray;
            this.txtPorDescIte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorDescIte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorDescIte.ForeColor = System.Drawing.Color.White;
            this.txtPorDescIte.Location = new System.Drawing.Point(560, 197);
            this.txtPorDescIte.Name = "txtPorDescIte";
            this.txtPorDescIte.Size = new System.Drawing.Size(35, 16);
            this.txtPorDescIte.TabIndex = 96;
            this.txtPorDescIte.TextChanged += new System.EventHandler(this.txtPorDescIte_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(218, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 16);
            this.txtNombre.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(217, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 97;
            this.label11.Text = "Nombre";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.DimGray;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(220, 231);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(48, 16);
            this.txtPrecio.TabIndex = 100;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(217, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 99;
            this.label12.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.DimGray;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(393, 146);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(65, 16);
            this.txtCantidad.TabIndex = 102;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(394, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 101;
            this.label13.Text = "Cantidad";
            // 
            // cmbTipFac
            // 
            this.cmbTipFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTipFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipFac.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbTipFac.FormattingEnabled = true;
            this.cmbTipFac.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.cmbTipFac.Location = new System.Drawing.Point(220, 187);
            this.cmbTipFac.Name = "cmbTipFac";
            this.cmbTipFac.Size = new System.Drawing.Size(100, 21);
            this.cmbTipFac.TabIndex = 103;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAtras
            // 
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Blue;
            this.btnAtras.Location = new System.Drawing.Point(675, 208);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(114, 28);
            this.btnAtras.TabIndex = 104;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.AcceptsReturn = true;
            this.txtsubtotal.BackColor = System.Drawing.Color.DimGray;
            this.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.Color.White;
            this.txtsubtotal.Location = new System.Drawing.Point(279, 231);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(66, 16);
            this.txtsubtotal.TabIndex = 106;
            this.txtsubtotal.TextChanged += new System.EventHandler(this.txtsubtotal_TextChanged);
            this.txtsubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubtotal_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(280, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 105;
            this.label14.Text = "SubTotal";
            // 
            // temdetallefacturaTableAdapter
            // 
            this.temdetallefacturaTableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Blue;
            this.btnImprimir.Location = new System.Drawing.Point(675, 71);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 28);
            this.btnImprimir.TabIndex = 107;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmbTipFac);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPorDescIte);
            this.Controls.Add(this.txtPorDesc);
            this.Controls.Add(this.txtTotPag);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDescIte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubTot);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum_fac);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelMenuReg.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_Reportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temdetallefacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum_fac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenuReg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnIrRegArt;
        private System.Windows.Forms.Button btnIrRegCliente;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_Reportes;
        private System.Windows.Forms.Button btnCuenPCob;
        private System.Windows.Forms.Button btnCuenCibrar;
        private System.Windows.Forms.Button btnCuaFecha;
        private System.Windows.Forms.Button btnFac8p;
        private System.Windows.Forms.Button btnFac3p;
        private System.Windows.Forms.Button btnRepUsu;
        private System.Windows.Forms.Button btnRegProv;
        private System.Windows.Forms.Button btnRepCliente;
        private System.Windows.Forms.Button btnRepArt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMonDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescIte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotPag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPorDesc;
        private System.Windows.Forms.TextBox txtPorDescIte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipFac;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label14;
        private facturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource temdetallefacturaBindingSource;
        private facturacionDataSetTableAdapters.temdetallefacturaTableAdapter temdetallefacturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_tot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripartdftemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantartdftemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predftemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotal;
        private System.Windows.Forms.Button btnImprimir;
    }
}