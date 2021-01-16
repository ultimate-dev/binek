namespace binek
{
    partial class PageAddReservation
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
            this.addReservation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.carComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.totalPriceEdit = new DevExpress.XtraEditors.SpinEdit();
            this.customerComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // addReservation
            // 
            this.addReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.addReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addReservation.ForeColor = System.Drawing.Color.White;
            this.addReservation.Location = new System.Drawing.Point(12, 357);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(410, 45);
            this.addReservation.TabIndex = 27;
            this.addReservation.Text = "Oluştur";
            this.addReservation.UseVisualStyleBackColor = false;
            this.addReservation.Click += new System.EventHandler(this.addReservation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Toplam Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Araç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri";
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(12, 232);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Properties.AutoHeight = false;
            this.endDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.DisplayFormat.FormatString = "";
            this.endDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.endDateEdit.Properties.EditFormat.FormatString = "";
            this.endDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.endDateEdit.Properties.Mask.EditMask = "";
            this.endDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.endDateEdit.Size = new System.Drawing.Size(410, 35);
            this.endDateEdit.TabIndex = 20;
            this.endDateEdit.EditValueChanged += new System.EventHandler(this.endDateEdit_EditValueChanged);
            // 
            // startDateEdit
            // 
            this.startDateEdit.EditValue = null;
            this.startDateEdit.Location = new System.Drawing.Point(12, 165);
            this.startDateEdit.Name = "startDateEdit";
            this.startDateEdit.Properties.AutoHeight = false;
            this.startDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.startDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateEdit.Properties.DisplayFormat.FormatString = "";
            this.startDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startDateEdit.Properties.EditFormat.FormatString = "";
            this.startDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startDateEdit.Properties.Mask.EditMask = "";
            this.startDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.startDateEdit.Size = new System.Drawing.Size(410, 35);
            this.startDateEdit.TabIndex = 18;
            this.startDateEdit.EditValueChanged += new System.EventHandler(this.startDateEdit_EditValueChanged);
            // 
            // carComboBox
            // 
            this.carComboBox.Location = new System.Drawing.Point(12, 100);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Properties.AutoHeight = false;
            this.carComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.carComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.carComboBox.Size = new System.Drawing.Size(410, 35);
            this.carComboBox.TabIndex = 15;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.carComboBox_SelectedIndexChanged);
            // 
            // totalPriceEdit
            // 
            this.totalPriceEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.totalPriceEdit.Location = new System.Drawing.Point(12, 296);
            this.totalPriceEdit.Name = "totalPriceEdit";
            this.totalPriceEdit.Properties.AutoHeight = false;
            this.totalPriceEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.totalPriceEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.totalPriceEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.totalPriceEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.totalPriceEdit.Properties.ReadOnly = true;
            this.totalPriceEdit.Size = new System.Drawing.Size(410, 35);
            this.totalPriceEdit.TabIndex = 22;
            // 
            // customerComboBox
            // 
            this.customerComboBox.Location = new System.Drawing.Point(12, 36);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Properties.AutoHeight = false;
            this.customerComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.customerComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerComboBox.Size = new System.Drawing.Size(410, 35);
            this.customerComboBox.TabIndex = 16;
            // 
            // PageAddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(436, 416);
            this.Controls.Add(this.addReservation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDateEdit);
            this.Controls.Add(this.startDateEdit);
            this.Controls.Add(this.carComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.totalPriceEdit);
            this.Name = "PageAddReservation";
            this.Text = "Binek | Rezervasyon Oluştur";
            this.Load += new System.EventHandler(this.PageAddReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addReservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.DateEdit startDateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit carComboBox;
        private DevExpress.XtraEditors.SpinEdit totalPriceEdit;
        private DevExpress.XtraEditors.ComboBoxEdit customerComboBox;
    }
}