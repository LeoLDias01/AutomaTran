namespace AutomaTran.Screens
{
    partial class GroupSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupSearch));
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.colRenavam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChassi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.btnImportData = new AutomaTran.Components.CustomButton();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.btnStartProcess = new AutomaTran.Components.CustomButton();
            this.btnClear = new AutomaTran.Components.CustomButton();
            this.btnCallSupport = new AutomaTran.Components.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.gpbAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.AllowUserToAddRows = false;
            this.dgvImport.AllowUserToDeleteRows = false;
            this.dgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImport.BackgroundColor = System.Drawing.Color.White;
            this.dgvImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvImport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRenavam,
            this.colPlaca,
            this.colChassi,
            this.colState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImport.EnableHeadersVisualStyles = false;
            this.dgvImport.Location = new System.Drawing.Point(12, 97);
            this.dgvImport.MultiSelect = false;
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImport.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvImport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImport.Size = new System.Drawing.Size(977, 262);
            this.dgvImport.TabIndex = 36;
            // 
            // colRenavam
            // 
            this.colRenavam.DataPropertyName = "Renavam";
            this.colRenavam.HeaderText = "Renavam";
            this.colRenavam.Name = "colRenavam";
            this.colRenavam.ReadOnly = true;
            // 
            // colPlaca
            // 
            this.colPlaca.DataPropertyName = "LicensePlate";
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.ReadOnly = true;
            // 
            // colChassi
            // 
            this.colChassi.DataPropertyName = "Chassi";
            this.colChassi.HeaderText = "Chassi";
            this.colChassi.Name = "colChassi";
            this.colChassi.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "Uf";
            this.colState.HeaderText = "Estado";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // gpbAddress
            // 
            this.gpbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAddress.Controls.Add(this.btnImportData);
            this.gpbAddress.Controls.Add(this.lblSelectFile);
            this.gpbAddress.Controls.Add(this.txtFileLocation);
            this.gpbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gpbAddress.ForeColor = System.Drawing.Color.White;
            this.gpbAddress.Location = new System.Drawing.Point(12, 12);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(977, 79);
            this.gpbAddress.TabIndex = 35;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Importação de Arquivo de Lote";
            // 
            // btnImportData
            // 
            this.btnImportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImportData.CorBorda = System.Drawing.Color.White;
            this.btnImportData.CorBotao = System.Drawing.Color.SteelBlue;
            this.btnImportData.CorTextoBotao = System.Drawing.Color.White;
            this.btnImportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportData.FlatAppearance.BorderSize = 0;
            this.btnImportData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnImportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnImportData.ForeColor = System.Drawing.Color.White;
            this.btnImportData.Image = ((System.Drawing.Image)(resources.GetObject("btnImportData.Image")));
            this.btnImportData.Location = new System.Drawing.Point(918, 25);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(53, 48);
            this.btnImportData.TabIndex = 43;
            this.btnImportData.TamanhoBorda = 0;
            this.btnImportData.TamanhoRaio = 15;
            this.btnImportData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImportData.UseVisualStyleBackColor = false;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectFile.ForeColor = System.Drawing.Color.White;
            this.lblSelectFile.Location = new System.Drawing.Point(6, 39);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(132, 19);
            this.lblSelectFile.TabIndex = 28;
            this.lblSelectFile.Text = "Selecione o arquivo";
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileLocation.Enabled = false;
            this.txtFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.Location = new System.Drawing.Point(144, 39);
            this.txtFileLocation.MaxLength = 11;
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.Size = new System.Drawing.Size(768, 23);
            this.txtFileLocation.TabIndex = 1;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnStartProcess.Location = new System.Drawing.Point(824, 365);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(165, 44);
            this.btnStartProcess.TabIndex = 44;
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
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnClear.Location = new System.Drawing.Point(482, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 44);
            this.btnClear.TabIndex = 43;
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
            this.btnCallSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnCallSupport.Location = new System.Drawing.Point(653, 365);
            this.btnCallSupport.Name = "btnCallSupport";
            this.btnCallSupport.Size = new System.Drawing.Size(165, 44);
            this.btnCallSupport.TabIndex = 42;
            this.btnCallSupport.TamanhoBorda = 2;
            this.btnCallSupport.TamanhoRaio = 20;
            this.btnCallSupport.Text = "Suporte";
            this.btnCallSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCallSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCallSupport.UseVisualStyleBackColor = false;
            this.btnCallSupport.Click += new System.EventHandler(this.btnCallSupport_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 90);
            this.label1.TabIndex = 46;
            this.label1.Text = "Guia:\r\n- Baixe o arquivo no drive\r\n- Edite com o excel seguindo o padrão\r\n- Faça " +
    "a importação\r\n\r\nLink do arquivo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(108, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(816, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "https://docs.google.com/spreadsheets/d/10p8yr2lID7DmemMo0SgOs-zXFve4p1iM/edit?usp" +
    "=sharing&ouid=106087217898398992158&rtpof=true&sd=true";
            // 
            // GroupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1001, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCallSupport);
            this.Controls.Add(this.dgvImport);
            this.Controls.Add(this.gpbAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRenavam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.TextBox txtFileLocation;
        private Components.CustomButton btnImportData;
        private Components.CustomButton btnStartProcess;
        private Components.CustomButton btnClear;
        private Components.CustomButton btnCallSupport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}