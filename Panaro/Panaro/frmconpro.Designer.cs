namespace Panaro
{
    partial class frmconpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconpro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.txtboxprod = new System.Windows.Forms.TextBox();
            this.txtboxvalor = new System.Windows.Forms.TextBox();
            this.txtboxqtd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.pnlpesquisa = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnome = new System.Windows.Forms.RadioButton();
            this.rdbcod = new System.Windows.Forms.RadioButton();
            this.rdbtodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.pnlpesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtboxid
            // 
            this.txtboxid.Enabled = false;
            this.txtboxid.Location = new System.Drawing.Point(83, 15);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(48, 20);
            this.txtboxid.TabIndex = 5;
            // 
            // txtboxprod
            // 
            this.txtboxprod.Enabled = false;
            this.txtboxprod.Location = new System.Drawing.Point(83, 51);
            this.txtboxprod.Name = "txtboxprod";
            this.txtboxprod.Size = new System.Drawing.Size(257, 20);
            this.txtboxprod.TabIndex = 6;
            // 
            // txtboxvalor
            // 
            this.txtboxvalor.Enabled = false;
            this.txtboxvalor.Location = new System.Drawing.Point(83, 92);
            this.txtboxvalor.Name = "txtboxvalor";
            this.txtboxvalor.Size = new System.Drawing.Size(91, 20);
            this.txtboxvalor.TabIndex = 8;
            this.txtboxvalor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtboxqtd
            // 
            this.txtboxqtd.Enabled = false;
            this.txtboxqtd.Location = new System.Drawing.Point(83, 127);
            this.txtboxqtd.Name = "txtboxqtd";
            this.txtboxqtd.Size = new System.Drawing.Size(100, 20);
            this.txtboxqtd.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 119);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(12, 211);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 23);
            this.Limpar.TabIndex = 11;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvprod
            // 
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Location = new System.Drawing.Point(98, 211);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.Size = new System.Drawing.Size(549, 220);
            this.dgvprod.TabIndex = 14;
            this.dgvprod.DoubleClick += new System.EventHandler(this.dgvprod_DoubleClick);
            // 
            // pnlpesquisa
            // 
            this.pnlpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpesquisa.Controls.Add(this.btnbuscar);
            this.pnlpesquisa.Controls.Add(this.txtPesquisa);
            this.pnlpesquisa.Controls.Add(this.lblPesquisa);
            this.pnlpesquisa.Controls.Add(this.groupBox1);
            this.pnlpesquisa.Location = new System.Drawing.Point(412, 15);
            this.pnlpesquisa.Name = "pnlpesquisa";
            this.pnlpesquisa.Size = new System.Drawing.Size(216, 181);
            this.pnlpesquisa.TabIndex = 15;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(128, 150);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(14, 124);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(189, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Location = new System.Drawing.Point(11, 108);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(192, 23);
            this.lblPesquisa.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbnome);
            this.groupBox1.Controls.Add(this.rdbcod);
            this.groupBox1.Controls.Add(this.rdbtodos);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // rdbnome
            // 
            this.rdbnome.AutoSize = true;
            this.rdbnome.Location = new System.Drawing.Point(16, 74);
            this.rdbnome.Name = "rdbnome";
            this.rdbnome.Size = new System.Drawing.Size(53, 17);
            this.rdbnome.TabIndex = 2;
            this.rdbnome.Text = "Nome";
            this.rdbnome.UseVisualStyleBackColor = true;
            this.rdbnome.CheckedChanged += new System.EventHandler(this.rdbnome_CheckedChanged);
            // 
            // rdbcod
            // 
            this.rdbcod.AutoSize = true;
            this.rdbcod.Location = new System.Drawing.Point(16, 51);
            this.rdbcod.Name = "rdbcod";
            this.rdbcod.Size = new System.Drawing.Size(58, 17);
            this.rdbcod.TabIndex = 1;
            this.rdbcod.Text = "Codigo";
            this.rdbcod.UseVisualStyleBackColor = true;
            this.rdbcod.CheckedChanged += new System.EventHandler(this.rdbcod_CheckedChanged);
            // 
            // rdbtodos
            // 
            this.rdbtodos.AutoSize = true;
            this.rdbtodos.Checked = true;
            this.rdbtodos.Location = new System.Drawing.Point(16, 28);
            this.rdbtodos.Name = "rdbtodos";
            this.rdbtodos.Size = new System.Drawing.Size(55, 17);
            this.rdbtodos.TabIndex = 0;
            this.rdbtodos.TabStop = true;
            this.rdbtodos.Text = "Todos";
            this.rdbtodos.UseVisualStyleBackColor = true;
            this.rdbtodos.CheckedChanged += new System.EventHandler(this.rdbtodos_CheckedChanged);
            // 
            // frmconpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 439);
            this.ControlBox = false;
            this.Controls.Add(this.pnlpesquisa);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxqtd);
            this.Controls.Add(this.txtboxvalor);
            this.Controls.Add(this.txtboxprod);
            this.Controls.Add(this.txtboxid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmconpro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.Load += new System.EventHandler(this.frmconpro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.pnlpesquisa.ResumeLayout(false);
            this.pnlpesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.TextBox txtboxprod;
        private System.Windows.Forms.TextBox txtboxvalor;
        private System.Windows.Forms.TextBox txtboxqtd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.Panel pnlpesquisa;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbnome;
        private System.Windows.Forms.RadioButton rdbcod;
        private System.Windows.Forms.RadioButton rdbtodos;
    }
}