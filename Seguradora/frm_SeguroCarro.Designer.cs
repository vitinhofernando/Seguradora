﻿namespace Seguradora
{
    partial class frm_SeguroCarro
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
            this.cbc_Carro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelCelular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCRLV = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCRV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtValorCarro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAnoCarro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPlacaCarro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtChassiCarro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_Roubo = new System.Windows.Forms.CheckBox();
            this.checkBox_Furto = new System.Windows.Forms.CheckBox();
            this.checkBox_Incendio = new System.Windows.Forms.CheckBox();
            this.checkBox_Acidente = new System.Windows.Forms.CheckBox();
            this.checkBox_Total = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_SegundoSegurado = new System.Windows.Forms.Panel();
            this.btn_CancelarSegundo = new System.Windows.Forms.Button();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCPF2 = new System.Windows.Forms.TextBox();
            this.checkBox_Sim = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_SegundoSegurado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbc_Carro
            // 
            this.cbc_Carro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbc_Carro.FormattingEnabled = true;
            this.cbc_Carro.Items.AddRange(new object[] {
            "CHEVROLET CORSA",
            "CHEVROLET CELTA",
            "CHEVROLET ONIX",
            "FIAT PUNTO",
            "FIAT SIENA",
            "FIAT UNO",
            "VOLKSWAGEN GOL",
            "VOLKSWAGEN FOX",
            "VOLKSWAGEN UP",
            "FORD FOCUS",
            "FORD ECOSPORT",
            "FORD FIESTA",
            "RENAULT SANDERO",
            "RENAULT LOGAN",
            "RENAULT CLIO",
            "HYUNDAI HB20",
            "HYUNDAI I30",
            "HYUNDAI TUCSON",
            "TOYOTA COROLLA",
            "TOYOTA HILUX",
            "HONDA FIT",
            "HONDA CIVIC"});
            this.cbc_Carro.Location = new System.Drawing.Point(15, 34);
            this.cbc_Carro.Name = "cbc_Carro";
            this.cbc_Carro.Size = new System.Drawing.Size(204, 28);
            this.cbc_Carro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Carro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(363, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF do proprietario";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(363, 202);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(188, 27);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelCelular
            // 
            this.txtTelCelular.Enabled = false;
            this.txtTelCelular.Location = new System.Drawing.Point(11, 262);
            this.txtTelCelular.Name = "txtTelCelular";
            this.txtTelCelular.Size = new System.Drawing.Size(122, 27);
            this.txtTelCelular.TabIndex = 23;
            this.txtTelCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Celular";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(433, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Enabled = false;
            this.txtCEP.Location = new System.Drawing.Point(433, 315);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(110, 27);
            this.txtCEP.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(78, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(78, 315);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(172, 27);
            this.txtCidade.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(256, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(256, 315);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(171, 27);
            this.txtBairro.TabIndex = 29;
            // 
            // txtNEndereco
            // 
            this.txtNEndereco.Enabled = false;
            this.txtNEndereco.Location = new System.Drawing.Point(11, 315);
            this.txtNEndereco.Name = "txtNEndereco";
            this.txtNEndereco.Size = new System.Drawing.Size(61, 27);
            this.txtNEndereco.TabIndex = 27;
            this.txtNEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Numero";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(139, 262);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(404, 27);
            this.txtEndereco.TabIndex = 26;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(139, 239);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 20);
            this.label.TabIndex = 24;
            this.label.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(11, 202);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(351, 27);
            this.txtNome.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtCRLV);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtCRV);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtValorCarro);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtAnoCarro);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtPlacaCarro);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtChassiCarro);
            this.panel2.Controls.Add(this.cbc_Carro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTelCelular);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCPF);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCEP);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.txtCidade);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Controls.Add(this.txtNEndereco);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 368);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(146, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 50;
            this.label20.Text = "CRLV";
            // 
            // txtCRLV
            // 
            this.txtCRLV.Location = new System.Drawing.Point(146, 139);
            this.txtCRLV.Name = "txtCRLV";
            this.txtCRLV.Size = new System.Drawing.Size(125, 27);
            this.txtCRLV.TabIndex = 49;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(15, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 20);
            this.label19.TabIndex = 48;
            this.label19.Text = "CRV";
            // 
            // txtCRV
            // 
            this.txtCRV.Location = new System.Drawing.Point(15, 139);
            this.txtCRV.Name = "txtCRV";
            this.txtCRV.Size = new System.Drawing.Size(125, 27);
            this.txtCRV.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(383, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "Valor";
            // 
            // txtValorCarro
            // 
            this.txtValorCarro.Location = new System.Drawing.Point(306, 86);
            this.txtValorCarro.Name = "txtValorCarro";
            this.txtValorCarro.Size = new System.Drawing.Size(202, 27);
            this.txtValorCarro.TabIndex = 45;
            this.txtValorCarro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(163, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Ano";
            // 
            // txtAnoCarro
            // 
            this.txtAnoCarro.Location = new System.Drawing.Point(163, 86);
            this.txtAnoCarro.Name = "txtAnoCarro";
            this.txtAnoCarro.Size = new System.Drawing.Size(125, 27);
            this.txtAnoCarro.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(237, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "Placa";
            // 
            // txtPlacaCarro
            // 
            this.txtPlacaCarro.Location = new System.Drawing.Point(237, 34);
            this.txtPlacaCarro.Name = "txtPlacaCarro";
            this.txtPlacaCarro.Size = new System.Drawing.Size(125, 27);
            this.txtPlacaCarro.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(15, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Cor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(383, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Chassi";
            // 
            // txtChassiCarro
            // 
            this.txtChassiCarro.Location = new System.Drawing.Point(383, 34);
            this.txtChassiCarro.Name = "txtChassiCarro";
            this.txtChassiCarro.Size = new System.Drawing.Size(125, 27);
            this.txtChassiCarro.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de Seguro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(968, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 40;
            // 
            // checkBox_Roubo
            // 
            this.checkBox_Roubo.AutoSize = true;
            this.checkBox_Roubo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Roubo.Location = new System.Drawing.Point(17, 36);
            this.checkBox_Roubo.Name = "checkBox_Roubo";
            this.checkBox_Roubo.Size = new System.Drawing.Size(84, 24);
            this.checkBox_Roubo.TabIndex = 41;
            this.checkBox_Roubo.Text = "ROUBO";
            this.checkBox_Roubo.UseVisualStyleBackColor = true;
            // 
            // checkBox_Furto
            // 
            this.checkBox_Furto.AutoSize = true;
            this.checkBox_Furto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Furto.Location = new System.Drawing.Point(104, 36);
            this.checkBox_Furto.Name = "checkBox_Furto";
            this.checkBox_Furto.Size = new System.Drawing.Size(79, 24);
            this.checkBox_Furto.TabIndex = 42;
            this.checkBox_Furto.Text = "FURTO";
            this.checkBox_Furto.UseVisualStyleBackColor = true;
            // 
            // checkBox_Incendio
            // 
            this.checkBox_Incendio.AutoSize = true;
            this.checkBox_Incendio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Incendio.Location = new System.Drawing.Point(184, 36);
            this.checkBox_Incendio.Name = "checkBox_Incendio";
            this.checkBox_Incendio.Size = new System.Drawing.Size(104, 24);
            this.checkBox_Incendio.TabIndex = 43;
            this.checkBox_Incendio.Text = "INCENDIO";
            this.checkBox_Incendio.UseVisualStyleBackColor = true;
            // 
            // checkBox_Acidente
            // 
            this.checkBox_Acidente.AutoSize = true;
            this.checkBox_Acidente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Acidente.Location = new System.Drawing.Point(290, 36);
            this.checkBox_Acidente.Name = "checkBox_Acidente";
            this.checkBox_Acidente.Size = new System.Drawing.Size(104, 24);
            this.checkBox_Acidente.TabIndex = 44;
            this.checkBox_Acidente.Text = "ACIDENTE";
            this.checkBox_Acidente.UseVisualStyleBackColor = true;
            // 
            // checkBox_Total
            // 
            this.checkBox_Total.AutoSize = true;
            this.checkBox_Total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Total.Location = new System.Drawing.Point(403, 36);
            this.checkBox_Total.Name = "checkBox_Total";
            this.checkBox_Total.Size = new System.Drawing.Size(76, 24);
            this.checkBox_Total.TabIndex = 45;
            this.checkBox_Total.Text = "TOTAL";
            this.checkBox_Total.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_SegundoSegurado);
            this.panel1.Controls.Add(this.checkBox_Sim);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.checkBox_Acidente);
            this.panel1.Controls.Add(this.checkBox_Total);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.checkBox_Roubo);
            this.panel1.Controls.Add(this.checkBox_Incendio);
            this.panel1.Controls.Add(this.checkBox_Furto);
            this.panel1.Location = new System.Drawing.Point(12, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 255);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_SegundoSegurado
            // 
            this.panel_SegundoSegurado.Controls.Add(this.btn_CancelarSegundo);
            this.panel_SegundoSegurado.Controls.Add(this.txtNome2);
            this.panel_SegundoSegurado.Controls.Add(this.label13);
            this.panel_SegundoSegurado.Controls.Add(this.label12);
            this.panel_SegundoSegurado.Controls.Add(this.txtCPF2);
            this.panel_SegundoSegurado.Location = new System.Drawing.Point(11, 147);
            this.panel_SegundoSegurado.Name = "panel_SegundoSegurado";
            this.panel_SegundoSegurado.Size = new System.Drawing.Size(545, 102);
            this.panel_SegundoSegurado.TabIndex = 47;
            this.panel_SegundoSegurado.Visible = false;
            // 
            // btn_CancelarSegundo
            // 
            this.btn_CancelarSegundo.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarSegundo.Location = new System.Drawing.Point(15, 70);
            this.btn_CancelarSegundo.Name = "btn_CancelarSegundo";
            this.btn_CancelarSegundo.Size = new System.Drawing.Size(75, 29);
            this.btn_CancelarSegundo.TabIndex = 48;
            this.btn_CancelarSegundo.Text = "Cancelar";
            this.btn_CancelarSegundo.UseVisualStyleBackColor = true;
            this.btn_CancelarSegundo.Click += new System.EventHandler(this.btn_CancelarSegundo_Click);
            // 
            // txtNome2
            // 
            this.txtNome2.Enabled = false;
            this.txtNome2.Location = new System.Drawing.Point(15, 32);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(347, 27);
            this.txtNome2.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(15, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(368, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "CPF";
            // 
            // txtCPF2
            // 
            this.txtCPF2.Enabled = false;
            this.txtCPF2.Location = new System.Drawing.Point(368, 32);
            this.txtCPF2.Name = "txtCPF2";
            this.txtCPF2.Size = new System.Drawing.Size(172, 27);
            this.txtCPF2.TabIndex = 36;
            this.txtCPF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_Sim
            // 
            this.checkBox_Sim.AutoSize = true;
            this.checkBox_Sim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Sim.Location = new System.Drawing.Point(21, 117);
            this.checkBox_Sim.Name = "checkBox_Sim";
            this.checkBox_Sim.Size = new System.Drawing.Size(58, 24);
            this.checkBox_Sim.TabIndex = 47;
            this.checkBox_Sim.Text = "SIM";
            this.checkBox_Sim.UseVisualStyleBackColor = true;
            this.checkBox_Sim.CheckedChanged += new System.EventHandler(this.checkBox_Sim_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Segurar mais de uma pessoa a esse veiculo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"});
            this.comboBox1.Location = new System.Drawing.Point(17, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 51;
            // 
            // frm_SeguroCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Name = "frm_SeguroCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SeguroCarro";
            this.Load += new System.EventHandler(this.frm_SeguroCarro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_SegundoSegurado.ResumeLayout(false);
            this.panel_SegundoSegurado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbc_Carro;
        private Label label1;
        private Label label2;
        private TextBox txtCPF;
        private TextBox txtTelCelular;
        private Label label10;
        private Label label7;
        private TextBox txtCEP;
        private Label label6;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtBairro;
        private TextBox txtNEndereco;
        private Label label4;
        private TextBox txtEndereco;
        private Label label;
        private TextBox txtNome;
        private Label label3;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private CheckBox checkBox_Roubo;
        private CheckBox checkBox_Furto;
        private CheckBox checkBox_Incendio;
        private CheckBox checkBox_Acidente;
        private CheckBox checkBox_Total;
        private Panel panel1;
        private Label label12;
        private TextBox txtCPF2;
        private Label label13;
        private TextBox txtNome2;
        private Label label11;
        private CheckBox checkBox_Sim;
        private Panel panel_SegundoSegurado;
        private Button btn_CancelarSegundo;
        private Label label16;
        private Label label15;
        private TextBox txtChassiCarro;
        private Label label18;
        private TextBox txtValorCarro;
        private Label label17;
        private TextBox txtAnoCarro;
        private Label label14;
        private TextBox txtPlacaCarro;
        private Label label19;
        private TextBox txtCRV;
        private Label label20;
        private TextBox txtCRLV;
        private ComboBox comboBox1;
    }
}