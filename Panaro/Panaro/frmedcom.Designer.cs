namespace Panaro
{
    partial class frmedcom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet4 = new Panaro.panaroDataSet4();
            this.Produtos_Adc = new System.Windows.Forms.ListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panaroDataSet5 = new Panaro.panaroDataSet5();
            this.Prod_Sel_Remov = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tiposTableAdapter = new Panaro.panaroDataSet4TableAdapters.tiposTableAdapter();
            this.tiposTableAdapter1 = new Panaro.panaroDataSet5TableAdapters.tiposTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecionar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selecionados/Remover:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiposBindingSource1;
            this.comboBox1.DisplayMember = "descricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tiposBindingSource
            // 
            this.tiposBindingSource.DataMember = "tipos";
            this.tiposBindingSource.DataSource = this.panaroDataSet4;
            // 
            // panaroDataSet4
            // 
            this.panaroDataSet4.DataSetName = "panaroDataSet4";
            this.panaroDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Produtos_Adc
            // 
            this.Produtos_Adc.FormattingEnabled = true;
            this.Produtos_Adc.Location = new System.Drawing.Point(47, 114);
            this.Produtos_Adc.Name = "Produtos_Adc";
            this.Produtos_Adc.Size = new System.Drawing.Size(172, 238);
            this.Produtos_Adc.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tiposBindingSource1;
            this.comboBox2.DisplayMember = "descricao";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(283, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // tiposBindingSource1
            // 
            this.tiposBindingSource1.DataMember = "tipos";
            this.tiposBindingSource1.DataSource = this.panaroDataSet5;
            // 
            // panaroDataSet5
            // 
            this.panaroDataSet5.DataSetName = "panaroDataSet5";
            this.panaroDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Prod_Sel_Remov
            // 
            this.Prod_Sel_Remov.FormattingEnabled = true;
            this.Prod_Sel_Remov.Location = new System.Drawing.Point(283, 114);
            this.Prod_Sel_Remov.Name = "Prod_Sel_Remov";
            this.Prod_Sel_Remov.Size = new System.Drawing.Size(172, 238);
            this.Prod_Sel_Remov.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fechar Comanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(145, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(45, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 11;
            // 
            // tiposTableAdapter
            // 
            this.tiposTableAdapter.ClearBeforeFill = true;
            // 
            // tiposTableAdapter1
            // 
            this.tiposTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 390);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Prod_Sel_Remov);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Produtos_Adc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar comanda";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox Produtos_Adc;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox Prod_Sel_Remov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private panaroDataSet4 panaroDataSet4;
        private System.Windows.Forms.BindingSource tiposBindingSource;
        private panaroDataSet4TableAdapters.tiposTableAdapter tiposTableAdapter;
        private panaroDataSet5 panaroDataSet5;
        private System.Windows.Forms.BindingSource tiposBindingSource1;
        private panaroDataSet5TableAdapters.tiposTableAdapter tiposTableAdapter1;
        private System.Windows.Forms.Button button2;
    }
}