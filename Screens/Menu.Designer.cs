namespace AutomaTran.Screens
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblSaudation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit = new AutomaTran.Components.CustomButton();
            this.MassSearch = new AutomaTran.Components.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SingleSearch = new AutomaTran.Components.CustomButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaudation
            // 
            this.lblSaudation.AutoSize = true;
            this.lblSaudation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudation.ForeColor = System.Drawing.Color.White;
            this.lblSaudation.Location = new System.Drawing.Point(12, 6);
            this.lblSaudation.Name = "lblSaudation";
            this.lblSaudation.Size = new System.Drawing.Size(258, 25);
            this.lblSaudation.TabIndex = 5;
            this.lblSaudation.Text = "Olá bom dia, do que precisa?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Exit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.MassSearch, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SingleSearch, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 326);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.CorBorda = System.Drawing.Color.White;
            this.Exit.CorBotao = System.Drawing.Color.Transparent;
            this.Exit.CorTextoBotao = System.Drawing.Color.White;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(3, 279);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(265, 44);
            this.Exit.TabIndex = 3;
            this.Exit.TamanhoBorda = 2;
            this.Exit.TamanhoRaio = 20;
            this.Exit.Text = "       Finalizar  ";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MassSearch
            // 
            this.MassSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MassSearch.CorBorda = System.Drawing.Color.White;
            this.MassSearch.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MassSearch.CorTextoBotao = System.Drawing.Color.White;
            this.MassSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MassSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MassSearch.FlatAppearance.BorderSize = 0;
            this.MassSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.MassSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MassSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.MassSearch.ForeColor = System.Drawing.Color.White;
            this.MassSearch.Image = ((System.Drawing.Image)(resources.GetObject("MassSearch.Image")));
            this.MassSearch.Location = new System.Drawing.Point(3, 229);
            this.MassSearch.Name = "MassSearch";
            this.MassSearch.Size = new System.Drawing.Size(265, 44);
            this.MassSearch.TabIndex = 2;
            this.MassSearch.TamanhoBorda = 2;
            this.MassSearch.TamanhoRaio = 20;
            this.MassSearch.Text = "Busca em Lote";
            this.MassSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MassSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MassSearch.UseVisualStyleBackColor = false;
            this.MassSearch.Click += new System.EventHandler(this.MassSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SingleSearch
            // 
            this.SingleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingleSearch.CorBorda = System.Drawing.Color.White;
            this.SingleSearch.CorBotao = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SingleSearch.CorTextoBotao = System.Drawing.Color.White;
            this.SingleSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingleSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleSearch.FlatAppearance.BorderSize = 0;
            this.SingleSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.SingleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingleSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SingleSearch.ForeColor = System.Drawing.Color.White;
            this.SingleSearch.Image = ((System.Drawing.Image)(resources.GetObject("SingleSearch.Image")));
            this.SingleSearch.Location = new System.Drawing.Point(3, 179);
            this.SingleSearch.Name = "SingleSearch";
            this.SingleSearch.Size = new System.Drawing.Size(265, 44);
            this.SingleSearch.TabIndex = 1;
            this.SingleSearch.TamanhoBorda = 2;
            this.SingleSearch.TamanhoRaio = 20;
            this.SingleSearch.Text = "Busca Única";
            this.SingleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SingleSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SingleSearch.UseVisualStyleBackColor = false;
            this.SingleSearch.Click += new System.EventHandler(this.SingleSearch_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(295, 383);
            this.Controls.Add(this.lblSaudation);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaudation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Components.CustomButton SingleSearch;
        private Components.CustomButton Exit;
        private Components.CustomButton MassSearch;
    }
}