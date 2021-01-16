namespace binek
{
    partial class PageReservations
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
            this.reservationsDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationsDataTable
            // 
            this.reservationsDataTable.AllowUserToAddRows = false;
            this.reservationsDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationsDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.reservationsDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationsDataTable.Location = new System.Drawing.Point(0, 0);
            this.reservationsDataTable.Margin = new System.Windows.Forms.Padding(0);
            this.reservationsDataTable.MultiSelect = false;
            this.reservationsDataTable.Name = "reservationsDataTable";
            this.reservationsDataTable.ReadOnly = true;
            this.reservationsDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationsDataTable.Size = new System.Drawing.Size(873, 620);
            this.reservationsDataTable.TabIndex = 1;
            this.reservationsDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationsDataTable_CellClick);
            // 
            // PageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reservationsDataTable);
            this.Name = "PageReservations";
            this.Size = new System.Drawing.Size(873, 620);
            this.Load += new System.EventHandler(this.PageReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationsDataTable;
    }
}
