namespace Panaro
{
    partial class frmnewconta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnlpesquisa = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbnome = new System.Windows.Forms.RadioButton();
            this.rdbcod = new System.Windows.Forms.RadioButton();
            this.rdbtodos = new System.Windows.Forms.RadioButton();
            this.pnlpesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descriçao:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 20);
            this.textBox3.TabIndex = 6;
            // 
            // pnlpesquisa
            // 
            this.pnlpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpesquisa.Controls.Add(this.btnbuscar);
            this.pnlpesquisa.Controls.Add(this.txtPesquisa);
            this.pnlpesquisa.Controls.Add(this.lblPesquisa);
            this.pnlpesquisa.Controls.Add(this.groupBox1);
            this.pnlpesquisa.Location = new System.Drawing.Point(482, 12);
            this.pnlpesquisa.Name = "pnlpesquisa";
            this.pnlpesquisa.Size = new System.Drawing.Size(216, 181);
            this.pnlpesquisa.TabIndex = 13;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(128, 150);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
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
            // 
            // frmnewconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlpesquisa);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmnewconta";
            this.Text = "frmnewconta";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
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