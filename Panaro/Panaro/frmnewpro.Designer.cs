﻿namespace Panaro
{
    partial class frmnewpro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnewpro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxqtd = new System.Windows.Forms.TextBox();
            this.txtboxvalor = new System.Windows.Forms.TextBox();
            this.txtboxdesc = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panaroDataSet = new Panaro.panaroDataSet();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTableAdapter = new Panaro.panaroDataSetTableAdapters.tiposTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panaroDataSet3 = new Panaro.panaroDataSet3();
            this.tiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiposTableAdapter1 = new Panaro.panaroDataSet3TableAdapters.tiposTableAdapter();
            this.cbbprod = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet7 = new Panaro.panaroDataSet7();
            this.tipoTableAdapter = new Panaro.panaroDataSet7TableAdapters.tipoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descriçao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade:";
            // 
            // txtboxqtd
            // 
            this.txtboxqtd.Location = new System.Drawing.Point(83, 137);
            this.txtboxqtd.Name = "txtboxqtd";
            this.txtboxqtd.Size = new System.Drawing.Size(67, 20);
            this.txtboxqtd.TabIndex = 3;
            // 
            // txtboxvalor
            // 
            this.txtboxvalor.Location = new System.Drawing.Point(83, 111);
            this.txtboxvalor.Name = "txtboxvalor";
            this.txtboxvalor.Size = new System.Drawing.Size(150, 20);
            this.txtboxvalor.TabIndex = 2;
            // 
            // txtboxdesc
            // 
            this.txtboxdesc.Location = new System.Drawing.Point(83, 85);
            this.txtboxdesc.Name = "txtboxdesc";
            this.txtboxdesc.Size = new System.Drawing.Size(360, 20);
            this.txtboxdesc.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(83, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 20);
            this.textBox5.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 206);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panaroDataSet
            // 
            this.panaroDataSet.DataSetName = "panaroDataSet";
            this.panaroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "tipos";
            this.tiposBindingSource.DataSource = this.panaroDataSet;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Novo Tipo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panaroDataSet3
            // 
            this.panaroDataSet3.DataSetName = "panaroDataSet3";
            this.panaroDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposBindingSource1
            // 
            this.tiposBindingSource1.DataMember = "tipos";
            this.tiposBindingSource1.DataSource = this.panaroDataSet3;
            // 
            // tiposTableAdapter1
            // 
            this.tiposTableAdapter1.ClearBeforeFill = true;
            // 
            // cbbprod
            // 
            this.cbbprod.DataSource = this.tipoBindingSource;
            this.cbbprod.DisplayMember = "descricao";
            this.cbbprod.FormattingEnabled = true;
            this.cbbprod.Location = new System.Drawing.Point(83, 59);
            this.cbbprod.Name = "cbbprod";
            this.cbbprod.Size = new System.Drawing.Size(121, 21);
            this.cbbprod.TabIndex = 17;
            this.cbbprod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.panaroDataSet7;
            // 
            // panaroDataSet7
            // 
            this.panaroDataSet7.DataSetName = "panaroDataSet7";
            this.panaroDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // frmnewpro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 242);
            this.ControlBox = false;
            this.Controls.Add(this.cbbprod);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtboxdesc);
            this.Controls.Add(this.txtboxvalor);
            this.Controls.Add(this.txtboxqtd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmnewpro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.frmnewpro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxqtd;
        private System.Windows.Forms.TextBox txtboxvalor;
        private System.Windows.Forms.TextBox txtboxdesc;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private panaroDataSet panaroDataSet;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private panaroDataSetTableAdapters.tiposTableAdapter tiposTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private panaroDataSet3 panaroDataSet3;
        private System.Windows.Forms.BindingSource tiposBindingSource1;
        private panaroDataSet3TableAdapters.tiposTableAdapter tiposTableAdapter1;
        private System.Windows.Forms.ComboBox cbbprod;
        private panaroDataSet7 panaroDataSet7;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private panaroDataSet7TableAdapters.tipoTableAdapter tipoTableAdapter;
    }
}