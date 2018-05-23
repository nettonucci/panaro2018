namespace Panaro
{
    partial class teste
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
            this.panaroDataSet8 = new Panaro.panaroDataSet8();
            this.comandasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandasTableAdapter = new Panaro.panaroDataSet8TableAdapters.comandasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panaroDataSet8
            // 
            this.panaroDataSet8.DataSetName = "panaroDataSet8";
            this.panaroDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandasBindingSource
            // 
            this.comandasBindingSource.DataMember = "comandas";
            this.comandasBindingSource.DataSource = this.panaroDataSet8;
            // 
            // comandasTableAdapter
            // 
            this.comandasTableAdapter.ClearBeforeFill = true;
            // 
            // teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "teste";
            this.Text = "teste";
            this.Load += new System.EventHandler(this.teste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panaroDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private panaroDataSet8 panaroDataSet8;
        private System.Windows.Forms.BindingSource comandasBindingSource;
        private panaroDataSet8TableAdapters.comandasTableAdapter comandasTableAdapter;
    }
}