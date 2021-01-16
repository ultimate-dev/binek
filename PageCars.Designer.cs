namespace binek
{
    partial class PageCars
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
            this.carsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // carsLayout
            // 
            this.carsLayout.AutoScroll = true;
            this.carsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsLayout.Location = new System.Drawing.Point(0, 0);
            this.carsLayout.Name = "carsLayout";
            this.carsLayout.Size = new System.Drawing.Size(720, 494);
            this.carsLayout.TabIndex = 0;
            // 
            // PageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carsLayout);
            this.Name = "PageCars";
            this.Size = new System.Drawing.Size(720, 494);
            this.Load += new System.EventHandler(this.PageCars_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel carsLayout;
    }
}
