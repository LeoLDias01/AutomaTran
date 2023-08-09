namespace AutomaTran.Screens
{
    partial class SingleSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleSearch));
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRenavam = new System.Windows.Forms.Panel();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.pnlPlaca = new System.Windows.Forms.Panel();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.pnlChassi = new System.Windows.Forms.Panel();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.lblChassi = new System.Windows.Forms.Label();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.btnVerify = new AutomaTran.Components.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.customPanel1 = new AutomaTran.Components.CustomPanel();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartProcess = new AutomaTran.Components.CustomButton();
            this.btnClear = new AutomaTran.Components.CustomButton();
            this.btnCallSupport = new AutomaTran.Components.CustomButton();
            this.gpbInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlRenavam.SuspendLayout();
            this.pnlPlaca.SuspendLayout();
            this.pnlChassi.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.flowLayoutPanel1);
            this.gpbInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gpbInfo.ForeColor = System.Drawing.Color.White;
            this.gpbInfo.Location = new System.Drawing.Point(12, 97);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(246, 203);
            this.gpbInfo.TabIndex = 38;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Dados de Busca";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pnlRenavam);
            this.flowLayoutPanel1.Controls.Add(this.pnlPlaca);
            this.flowLayoutPanel1.Controls.Add(this.pnlChassi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 172);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlRenavam
            // 
            this.pnlRenavam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRenavam.Controls.Add(this.txtRenavam);
            this.pnlRenavam.Controls.Add(this.lblRenavam);
            this.pnlRenavam.Location = new System.Drawing.Point(3, 3);
            this.pnlRenavam.Name = "pnlRenavam";
            this.pnlRenavam.Size = new System.Drawing.Size(233, 50);
            this.pnlRenavam.TabIndex = 34;
            this.pnlRenavam.Visible = false;
            // 
            // txtRenavam
            // 
            this.txtRenavam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRenavam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenavam.Location = new System.Drawing.Point(4, 23);
            this.txtRenavam.MaxLength = 11;
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(218, 23);
            this.txtRenavam.TabIndex = 4;
            this.txtRenavam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenavam_KeyPress);
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblRenavam.ForeColor = System.Drawing.Color.White;
            this.lblRenavam.Location = new System.Drawing.Point(3, 0);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(72, 20);
            this.lblRenavam.TabIndex = 15;
            this.lblRenavam.Text = "Renavam";
            // 
            // pnlPlaca
            // 
            this.pnlPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlaca.Controls.Add(this.txtLicensePlate);
            this.pnlPlaca.Controls.Add(this.lblPlaca);
            this.pnlPlaca.Location = new System.Drawing.Point(3, 59);
            this.pnlPlaca.Name = "pnlPlaca";
            this.pnlPlaca.Size = new System.Drawing.Size(233, 50);
            this.pnlPlaca.TabIndex = 35;
            this.pnlPlaca.Visible = false;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicensePlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLicensePlate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(4, 23);
            this.txtLicensePlate.MaxLength = 9;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(218, 23);
            this.txtLicensePlate.TabIndex = 5;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(3, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(45, 20);
            this.lblPlaca.TabIndex = 17;
            this.lblPlaca.Text = "Placa";
            // 
            // pnlChassi
            // 
            this.pnlChassi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChassi.Controls.Add(this.txtChassi);
            this.pnlChassi.Controls.Add(this.lblChassi);
            this.pnlChassi.Location = new System.Drawing.Point(3, 115);
            this.pnlChassi.Name = "pnlChassi";
            this.pnlChassi.Size = new System.Drawing.Size(233, 54);
            this.pnlChassi.TabIndex = 36;
            this.pnlChassi.Visible = false;
            // 
            // txtChassi
            // 
            this.txtChassi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChassi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChassi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassi.Location = new System.Drawing.Point(4, 23);
            this.txtChassi.MaxLength = 17;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(218, 23);
            this.txtChassi.TabIndex = 6;
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblChassi.ForeColor = System.Drawing.Color.White;
            this.lblChassi.Location = new System.Drawing.Point(3, 0);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(51, 20);
            this.lblChassi.TabIndex = 19;
            this.lblChassi.Text = "Chassi";
            // 
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.btnVerify);
            this.gpbAddress.Controls.Add(this.label6);
            this.gpbAddress.Controls.Add(this.txtCep);
            this.gpbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gpbAddress.ForeColor = System.Drawing.Color.White;
            this.gpbAddress.Location = new System.Drawing.Point(12, 12);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(246, 79);
            this.gpbAddress.TabIndex = 36;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Identificando Uf";
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerify.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVerify.CorBorda = System.Drawing.Color.White;
            this.btnVerify.CorBotao = System.Drawing.Color.SteelBlue;
            this.btnVerify.CorTextoBotao = System.Drawing.Color.White;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.Location = new System.Drawing.Point(187, 22);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(53, 48);
            this.btnVerify.TabIndex = 42;
            this.btnVerify.TamanhoBorda = 0;
            this.btnVerify.TamanhoRaio = 15;
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerify.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Digite seu CEP";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(10, 47);
            this.txtCep.MaxLength = 11;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(171, 23);
            this.txtCep.TabIndex = 1;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.customPanel1.Controls.Add(this.txtUf);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.CorBorda = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.CorBotao = System.Drawing.Color.SlateGray;
            this.customPanel1.CorTextoBotao = System.Drawing.Color.White;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(264, 25);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(165, 66);
            this.customPanel1.TabIndex = 42;
            this.customPanel1.TamanhoBorda = 0;
            this.customPanel1.TamanhoRaio = 10;
            // 
            // txtUf
            // 
            this.txtUf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUf.Enabled = false;
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(41, 22);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.ReadOnly = true;
            this.txtUf.Size = new System.Drawing.Size(107, 23);
            this.txtUf.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "UF";
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.BackColor = System.Drawing.Color.Green;
            this.btnStartProcess.CorBorda = System.Drawing.Color.White;
            this.btnStartProcess.CorBotao = System.Drawing.Color.Green;
            this.btnStartProcess.CorTextoBotao = System.Drawing.Color.White;
            this.btnStartProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartProcess.Enabled = false;
            this.btnStartProcess.FlatAppearance.BorderSize = 0;
            this.btnStartProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartProcess.ForeColor = System.Drawing.Color.White;
            this.btnStartProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnStartProcess.Image")));
            this.btnStartProcess.Location = new System.Drawing.Point(264, 147);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(165, 44);
            this.btnStartProcess.TabIndex = 41;
            this.btnStartProcess.TamanhoBorda = 2;
            this.btnStartProcess.TamanhoRaio = 20;
            this.btnStartProcess.Text = "Processar";
            this.btnStartProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStartProcess.UseVisualStyleBackColor = false;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.CorBorda = System.Drawing.Color.White;
            this.btnClear.CorBotao = System.Drawing.Color.Transparent;
            this.btnClear.CorTextoBotao = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(264, 247);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 44);
            this.btnClear.TabIndex = 40;
            this.btnClear.TamanhoBorda = 2;
            this.btnClear.TamanhoRaio = 20;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCallSupport
            // 
            this.btnCallSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCallSupport.CorBorda = System.Drawing.Color.White;
            this.btnCallSupport.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCallSupport.CorTextoBotao = System.Drawing.Color.White;
            this.btnCallSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCallSupport.FlatAppearance.BorderSize = 0;
            this.btnCallSupport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCallSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallSupport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCallSupport.ForeColor = System.Drawing.Color.White;
            this.btnCallSupport.Image = ((System.Drawing.Image)(resources.GetObject("btnCallSupport.Image")));
            this.btnCallSupport.Location = new System.Drawing.Point(264, 197);
            this.btnCallSupport.Name = "btnCallSupport";
            this.btnCallSupport.Size = new System.Drawing.Size(165, 44);
            this.btnCallSupport.TabIndex = 39;
            this.btnCallSupport.TamanhoBorda = 2;
            this.btnCallSupport.TamanhoRaio = 20;
            this.btnCallSupport.Text = "Suporte";
            this.btnCallSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCallSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCallSupport.UseVisualStyleBackColor = false;
            this.btnCallSupport.Click += new System.EventHandler(this.btnCallSupport_Click);
            // 
            // SingleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCallSupport);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleSearch";
            this.gpbInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlRenavam.ResumeLayout(false);
            this.pnlRenavam.PerformLayout();
            this.pnlPlaca.ResumeLayout(false);
            this.pnlPlaca.PerformLayout();
            this.pnlChassi.ResumeLayout(false);
            this.pnlChassi.PerformLayout();
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlRenavam;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.Panel pnlPlaca;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Panel pnlChassi;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCep;
        private Components.CustomButton btnCallSupport;
        private Components.CustomButton btnClear;
        private Components.CustomButton btnStartProcess;
        private Components.CustomButton btnVerify;
        private Components.CustomPanel customPanel1;
        private System.Windows.Forms.TextBox txtUf;
    }
}