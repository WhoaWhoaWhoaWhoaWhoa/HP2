namespace HomeProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bimboDBDataSet = new HomeProject.bimboDBDataSet();
            this.bimboDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bimboDBDataSet1 = new HomeProject.bimboDBDataSet1();
            this.specialtyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyTableTableAdapter = new HomeProject.bimboDBDataSet1TableAdapters.SpecialtyTableTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimboDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimboDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimboDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // bimboDBDataSet
            // 
            this.bimboDBDataSet.DataSetName = "bimboDBDataSet";
            this.bimboDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bimboDBDataSetBindingSource
            // 
            this.bimboDBDataSetBindingSource.DataSource = this.bimboDBDataSet;
            this.bimboDBDataSetBindingSource.Position = 0;
            // 
            // bimboDBDataSet1
            // 
            this.bimboDBDataSet1.DataSetName = "bimboDBDataSet1";
            this.bimboDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtyTableBindingSource
            // 
            this.specialtyTableBindingSource.DataMember = "SpecialtyTable";
            this.specialtyTableBindingSource.DataSource = this.bimboDBDataSet1;
            // 
            // specialtyTableTableAdapter
            // 
            this.specialtyTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 255);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(414, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimboDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimboDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimboDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bimboDBDataSetBindingSource;
        private bimboDBDataSet bimboDBDataSet;
        private bimboDBDataSet1 bimboDBDataSet1;
        private System.Windows.Forms.BindingSource specialtyTableBindingSource;
        private bimboDBDataSet1TableAdapters.SpecialtyTableTableAdapter specialtyTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

