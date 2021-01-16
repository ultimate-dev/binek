namespace binek
{
    partial class ComponentCarBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editCar = new System.Windows.Forms.Button();
            this.segment = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.delCar = new System.Windows.Forms.Button();
            this.model = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.seats = new System.Windows.Forms.Label();
            this.fuel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gear = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.editCar);
            this.panel1.Controls.Add(this.segment);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.delCar);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(310, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 250);
            this.panel1.TabIndex = 0;
            // 
            // editCar
            // 
            this.editCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.editCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCar.FlatAppearance.BorderSize = 0;
            this.editCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editCar.ForeColor = System.Drawing.Color.White;
            this.editCar.Location = new System.Drawing.Point(0, 215);
            this.editCar.Name = "editCar";
            this.editCar.Size = new System.Drawing.Size(140, 35);
            this.editCar.TabIndex = 5;
            this.editCar.Text = "Düzenle";
            this.editCar.UseVisualStyleBackColor = false;
            this.editCar.Click += new System.EventHandler(this.editCar_Click);
            // 
            // segment
            // 
            this.segment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.segment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.segment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.segment.ForeColor = System.Drawing.Color.DarkViolet;
            this.segment.Location = new System.Drawing.Point(-3, 135);
            this.segment.Name = "segment";
            this.segment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.segment.Size = new System.Drawing.Size(129, 30);
            this.segment.TabIndex = 4;
            this.segment.Text = "Segment";
            this.segment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price.Location = new System.Drawing.Point(75, 175);
            this.price.Margin = new System.Windows.Forms.Padding(0);
            this.price.Name = "price";
            this.price.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.price.Size = new System.Drawing.Size(118, 30);
            this.price.TabIndex = 3;
            this.price.Text = "100₺";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // delCar
            // 
            this.delCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.delCar.BackgroundImage = global::binek.Properties.Resources.trash__1_;
            this.delCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delCar.FlatAppearance.BorderSize = 0;
            this.delCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delCar.Location = new System.Drawing.Point(140, 215);
            this.delCar.Name = "delCar";
            this.delCar.Size = new System.Drawing.Size(50, 35);
            this.delCar.TabIndex = 2;
            this.delCar.UseVisualStyleBackColor = false;
            this.delCar.Click += new System.EventHandler(this.delCar_Click);
            // 
            // model
            // 
            this.model.AutoEllipsis = true;
            this.model.Dock = System.Windows.Forms.DockStyle.Top;
            this.model.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.model.Location = new System.Drawing.Point(0, 48);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(190, 37);
            this.model.TabIndex = 1;
            this.model.Text = "Marka Marka Marka Marka Marka Marka Marka";
            this.model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brand
            // 
            this.brand.AutoEllipsis = true;
            this.brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.brand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brand.Location = new System.Drawing.Point(0, 0);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(190, 48);
            this.brand.TabIndex = 0;
            this.brand.Text = "Model ";
            this.brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 250);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::binek.Properties.Resources.sport_car;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 215);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.seats);
            this.panel4.Controls.Add(this.fuel);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.gear);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 35);
            this.panel4.TabIndex = 0;
            // 
            // seats
            // 
            this.seats.AutoSize = true;
            this.seats.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seats.Location = new System.Drawing.Point(243, 8);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(49, 15);
            this.seats.TabIndex = 1;
            this.seats.Text = "5 Koltuk";
            // 
            // fuel
            // 
            this.fuel.AutoSize = true;
            this.fuel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fuel.Location = new System.Drawing.Point(152, 8);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(33, 15);
            this.fuel.TabIndex = 1;
            this.fuel.Text = "Dizel";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::binek.Properties.Resources.seat;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(212, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 25);
            this.panel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::binek.Properties.Resources.gas_station;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(121, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 25);
            this.panel5.TabIndex = 0;
            // 
            // gear
            // 
            this.gear.AutoSize = true;
            this.gear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gear.Location = new System.Drawing.Point(49, 8);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(54, 15);
            this.gear.TabIndex = 1;
            this.gear.Text = "Otomatik";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::binek.Properties.Resources.settings;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(18, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(25, 25);
            this.panel7.TabIndex = 0;
            // 
            // ComponentCarBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "ComponentCarBox";
            this.Size = new System.Drawing.Size(500, 250);
            this.Load += new System.EventHandler(this.ComponentCarBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label brand;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.Label fuel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label seats;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button delCar;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label segment;
        private System.Windows.Forms.Button editCar;
    }
}
