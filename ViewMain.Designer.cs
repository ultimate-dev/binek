namespace binek
{
    partial class ViewMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMain));
            this.articlePanel = new System.Windows.Forms.Panel();
            this.ribbonPageReservations = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.allReservationsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addReservationBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editReservationBtn = new DevExpress.XtraBars.BarButtonItem();
            this.delReservationBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCars = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.allCarsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addCarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCustomers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.allCustomersBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addCustomerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.dellCustomerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.delCarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.controlBar = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.refreshCustomersBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshCarsBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.controlBar)).BeginInit();
            this.SuspendLayout();
            // 
            // articlePanel
            // 
            resources.ApplyResources(this.articlePanel, "articlePanel");
            this.articlePanel.Name = "articlePanel";
            // 
            // ribbonPageReservations
            // 
            this.ribbonPageReservations.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPageReservations.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageReservations.ImageOptions.ImageIndex")));
            this.ribbonPageReservations.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageReservations.ImageOptions.SvgImage")));
            this.ribbonPageReservations.Name = "ribbonPageReservations";
            resources.ApplyResources(this.ribbonPageReservations, "ribbonPageReservations");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageGroup4.ImageOptions.ImageIndex")));
            this.ribbonPageGroup4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup4.ImageOptions.SvgImage")));
            this.ribbonPageGroup4.ItemLinks.Add(this.allReservationsBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.addReservationBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.delReservationBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            resources.ApplyResources(this.ribbonPageGroup4, "ribbonPageGroup4");
            // 
            // allReservationsBtn
            // 
            resources.ApplyResources(this.allReservationsBtn, "allReservationsBtn");
            this.allReservationsBtn.Id = 11;
            this.allReservationsBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("allReservationsBtn.ImageOptions.ImageIndex")));
            this.allReservationsBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("allReservationsBtn.ImageOptions.LargeImageIndex")));
            this.allReservationsBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("allReservationsBtn.ImageOptions.SvgImage")));
            this.allReservationsBtn.Name = "allReservationsBtn";
            this.allReservationsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.allReservationsBtn_ItemClick);
            // 
            // addReservationBtn
            // 
            resources.ApplyResources(this.addReservationBtn, "addReservationBtn");
            this.addReservationBtn.Id = 12;
            this.addReservationBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("addReservationBtn.ImageOptions.ImageIndex")));
            this.addReservationBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("addReservationBtn.ImageOptions.LargeImageIndex")));
            this.addReservationBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("addReservationBtn.ImageOptions.SvgImage")));
            this.addReservationBtn.Name = "addReservationBtn";
            this.addReservationBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addReservationBtn_ItemClick);
            // 
            // editReservationBtn
            // 
            resources.ApplyResources(this.editReservationBtn, "editReservationBtn");
            this.editReservationBtn.Enabled = false;
            this.editReservationBtn.Id = 13;
            this.editReservationBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("editReservationBtn.ImageOptions.ImageIndex")));
            this.editReservationBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("editReservationBtn.ImageOptions.LargeImageIndex")));
            this.editReservationBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editReservationBtn.ImageOptions.SvgImage")));
            this.editReservationBtn.Name = "editReservationBtn";
            // 
            // delReservationBtn
            // 
            resources.ApplyResources(this.delReservationBtn, "delReservationBtn");
            this.delReservationBtn.Enabled = false;
            this.delReservationBtn.Id = 14;
            this.delReservationBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("delReservationBtn.ImageOptions.ImageIndex")));
            this.delReservationBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("delReservationBtn.ImageOptions.LargeImageIndex")));
            this.delReservationBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("delReservationBtn.ImageOptions.SvgImage")));
            this.delReservationBtn.Name = "delReservationBtn";
            this.delReservationBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.delReservationBtn_ItemClick);
            // 
            // ribbonPageCars
            // 
            this.ribbonPageCars.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPageCars.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageCars.ImageOptions.ImageIndex")));
            this.ribbonPageCars.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageCars.ImageOptions.SvgImage")));
            this.ribbonPageCars.Name = "ribbonPageCars";
            resources.ApplyResources(this.ribbonPageCars, "ribbonPageCars");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageGroup3.ImageOptions.ImageIndex")));
            this.ribbonPageGroup3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup3.ImageOptions.SvgImage")));
            this.ribbonPageGroup3.ItemLinks.Add(this.allCarsBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.addCarBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // allCarsBtn
            // 
            resources.ApplyResources(this.allCarsBtn, "allCarsBtn");
            this.allCarsBtn.Id = 6;
            this.allCarsBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("allCarsBtn.ImageOptions.ImageIndex")));
            this.allCarsBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("allCarsBtn.ImageOptions.LargeImageIndex")));
            this.allCarsBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("allCarsBtn.ImageOptions.SvgImage")));
            this.allCarsBtn.Name = "allCarsBtn";
            this.allCarsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.allCarsBtn_ItemClick);
            // 
            // addCarBtn
            // 
            resources.ApplyResources(this.addCarBtn, "addCarBtn");
            this.addCarBtn.Id = 8;
            this.addCarBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("addCarBtn.ImageOptions.ImageIndex")));
            this.addCarBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("addCarBtn.ImageOptions.LargeImageIndex")));
            this.addCarBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("addCarBtn.ImageOptions.SvgImage")));
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCarBtn_ItemClick);
            // 
            // ribbonPageCustomers
            // 
            this.ribbonPageCustomers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPageCustomers.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageCustomers.ImageOptions.ImageIndex")));
            this.ribbonPageCustomers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageCustomers.ImageOptions.SvgImage")));
            this.ribbonPageCustomers.Name = "ribbonPageCustomers";
            resources.ApplyResources(this.ribbonPageCustomers, "ribbonPageCustomers");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageGroup2.ImageOptions.ImageIndex")));
            this.ribbonPageGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup2.ImageOptions.SvgImage")));
            this.ribbonPageGroup2.ItemLinks.Add(this.allCustomersBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.addCustomerBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.dellCustomerBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // allCustomersBtn
            // 
            resources.ApplyResources(this.allCustomersBtn, "allCustomersBtn");
            this.allCustomersBtn.Id = 1;
            this.allCustomersBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("allCustomersBtn.ImageOptions.ImageIndex")));
            this.allCustomersBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("allCustomersBtn.ImageOptions.LargeImageIndex")));
            this.allCustomersBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("allCustomersBtn.ImageOptions.SvgImage")));
            this.allCustomersBtn.Name = "allCustomersBtn";
            this.allCustomersBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.allCustomersBtn_ItemClick);
            // 
            // addCustomerBtn
            // 
            resources.ApplyResources(this.addCustomerBtn, "addCustomerBtn");
            this.addCustomerBtn.Id = 2;
            this.addCustomerBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("addCustomerBtn.ImageOptions.ImageIndex")));
            this.addCustomerBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("addCustomerBtn.ImageOptions.LargeImageIndex")));
            this.addCustomerBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("addCustomerBtn.ImageOptions.SvgImage")));
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCustomerBtn_ItemClick);
            // 
            // dellCustomerBtn
            // 
            resources.ApplyResources(this.dellCustomerBtn, "dellCustomerBtn");
            this.dellCustomerBtn.Enabled = false;
            this.dellCustomerBtn.Id = 5;
            this.dellCustomerBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("dellCustomerBtn.ImageOptions.ImageIndex")));
            this.dellCustomerBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("dellCustomerBtn.ImageOptions.LargeImageIndex")));
            this.dellCustomerBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dellCustomerBtn.ImageOptions.SvgImage")));
            this.dellCustomerBtn.Name = "dellCustomerBtn";
            this.dellCustomerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dellCustomerBtn_ItemClick);
            // 
            // editCarBtn
            // 
            resources.ApplyResources(this.editCarBtn, "editCarBtn");
            this.editCarBtn.Enabled = false;
            this.editCarBtn.Id = 9;
            this.editCarBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("editCarBtn.ImageOptions.ImageIndex")));
            this.editCarBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("editCarBtn.ImageOptions.LargeImageIndex")));
            this.editCarBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editCarBtn.ImageOptions.SvgImage")));
            this.editCarBtn.Name = "editCarBtn";
            // 
            // delCarBtn
            // 
            resources.ApplyResources(this.delCarBtn, "delCarBtn");
            this.delCarBtn.Enabled = false;
            this.delCarBtn.Id = 10;
            this.delCarBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("delCarBtn.ImageOptions.ImageIndex")));
            this.delCarBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("delCarBtn.ImageOptions.LargeImageIndex")));
            this.delCarBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("delCarBtn.ImageOptions.SvgImage")));
            this.delCarBtn.Name = "delCarBtn";
            // 
            // controlBar
            // 
            resources.ApplyResources(this.controlBar, "controlBar");
            this.controlBar.ExpandCollapseItem.Id = 0;
            this.controlBar.ExpandCollapseItem.ImageOptions.ImageIndex = ((int)(resources.GetObject("controlBar.ExpandCollapseItem.ImageOptions.ImageIndex")));
            this.controlBar.ExpandCollapseItem.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("controlBar.ExpandCollapseItem.ImageOptions.LargeImageIndex")));
            this.controlBar.ExpandCollapseItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("controlBar.ExpandCollapseItem.ImageOptions.SvgImage")));
            this.controlBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.controlBar.ExpandCollapseItem,
            this.allCustomersBtn,
            this.addCustomerBtn,
            this.dellCustomerBtn,
            this.allCarsBtn,
            this.addCarBtn,
            this.editCarBtn,
            this.delCarBtn,
            this.allReservationsBtn,
            this.addReservationBtn,
            this.editReservationBtn,
            this.delReservationBtn,
            this.refreshCustomersBtn,
            this.refreshCarsBtn});
            this.controlBar.MaxItemId = 18;
            this.controlBar.Name = "controlBar";
            this.controlBar.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCustomers,
            this.ribbonPageCars,
            this.ribbonPageReservations});
            this.controlBar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            // 
            // refreshCustomersBtn
            // 
            resources.ApplyResources(this.refreshCustomersBtn, "refreshCustomersBtn");
            this.refreshCustomersBtn.Id = 16;
            this.refreshCustomersBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("refreshCustomersBtn.ImageOptions.ImageIndex")));
            this.refreshCustomersBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("refreshCustomersBtn.ImageOptions.LargeImageIndex")));
            this.refreshCustomersBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("refreshCustomersBtn.ImageOptions.SvgImage")));
            this.refreshCustomersBtn.Name = "refreshCustomersBtn";
            // 
            // refreshCarsBtn
            // 
            resources.ApplyResources(this.refreshCarsBtn, "refreshCarsBtn");
            this.refreshCarsBtn.Id = 17;
            this.refreshCarsBtn.ImageOptions.ImageIndex = ((int)(resources.GetObject("refreshCarsBtn.ImageOptions.ImageIndex")));
            this.refreshCarsBtn.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("refreshCarsBtn.ImageOptions.LargeImageIndex")));
            this.refreshCarsBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("refreshCarsBtn.ImageOptions.SvgImage")));
            this.refreshCarsBtn.Name = "refreshCarsBtn";
            // 
            // ViewMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Controls.Add(this.articlePanel);
            this.Controls.Add(this.controlBar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(48)))));
            this.Name = "ViewMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewMain_FormClosed);
            this.Load += new System.EventHandler(this.ViewMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel articlePanel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageReservations;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem allReservationsBtn;
        private DevExpress.XtraBars.BarButtonItem addReservationBtn;
        private DevExpress.XtraBars.BarButtonItem editReservationBtn;
        private DevExpress.XtraBars.BarButtonItem delReservationBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCars;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem allCarsBtn;
        private DevExpress.XtraBars.BarButtonItem addCarBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCustomers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem allCustomersBtn;
        private DevExpress.XtraBars.BarButtonItem addCustomerBtn;
        private DevExpress.XtraBars.BarButtonItem dellCustomerBtn;
        private DevExpress.XtraBars.BarButtonItem editCarBtn;
        private DevExpress.XtraBars.BarButtonItem delCarBtn;
        private DevExpress.XtraBars.Ribbon.RibbonControl controlBar;
        private DevExpress.XtraBars.BarButtonItem refreshCustomersBtn;
        private DevExpress.XtraBars.BarButtonItem refreshCarsBtn;
    }
}