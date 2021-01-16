namespace binek
{
    partial class PageCustomers
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.customersDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataTable
            // 
            this.customersDataTable.AllowUserToAddRows = false;
            this.customersDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.customersDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDataTable.Location = new System.Drawing.Point(0, 0);
            this.customersDataTable.Margin = new System.Windows.Forms.Padding(0);
            this.customersDataTable.MultiSelect = false;
            this.customersDataTable.Name = "customersDataTable";
            this.customersDataTable.ReadOnly = true;
            this.customersDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDataTable.Size = new System.Drawing.Size(855, 553);
            this.customersDataTable.TabIndex = 0;
            this.customersDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataTable_CellClick);
            // 
            // PageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersDataTable);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PageCustomers";
            this.Size = new System.Drawing.Size(855, 553);
            this.Load += new System.EventHandler(this.PageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDataTable;
    }
}
