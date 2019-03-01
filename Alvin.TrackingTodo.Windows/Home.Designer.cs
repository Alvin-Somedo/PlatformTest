namespace Alvin.TrackingTodo.Windows
{
    partial class Home
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trackingDataSet = new Alvin.TrackingTodo.Windows.trackingDataSet();
            this.todolistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todolistTableAdapter = new Alvin.TrackingTodo.Windows.trackingDataSetTableAdapters.todolistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todolistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.todolistBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // trackingDataSet
            // 
            this.trackingDataSet.DataSetName = "trackingDataSet";
            this.trackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // todolistBindingSource
            // 
            this.todolistBindingSource.DataMember = "todolist";
            this.todolistBindingSource.DataSource = this.trackingDataSet;
            // 
            // todolistTableAdapter
            // 
            this.todolistTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 425);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todolistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private trackingDataSet trackingDataSet;
        private System.Windows.Forms.BindingSource todolistBindingSource;
        private trackingDataSetTableAdapters.todolistTableAdapter todolistTableAdapter;
    }
}

