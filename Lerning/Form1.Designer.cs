namespace Lerning
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ani1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuThinButton212 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton211 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton210 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton29 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleBitmapControl1
            // 
            this.ani1.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.doubleBitmapControl1.Location = new System.Drawing.Point(181, 199);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 0;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ani1
            // 
            this.ani1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.ani1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.ani1.DefaultAnimation = animation2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.bunifuThinButton22);
            this.panel2.Controls.Add(this.bunifuThinButton26);
            this.panel2.Controls.Add(this.bunifuThinButton23);
            this.panel2.Controls.Add(this.bunifuThinButton24);
            this.panel2.Controls.Add(this.panel3);
            this.ani1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 393);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.ani1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::Lerning.Properties.Resources.download;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(928, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 34);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 13;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.ani1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::Lerning.Properties.Resources.images;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(971, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "শ্রণী নিবা্চন";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(5, 5);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton22.TabIndex = 6;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            this.bunifuThinButton22.MouseHover += new System.EventHandler(this.bunifuThinButton22_MouseHover);
            this.bunifuThinButton22.MouseLeave += new System.EventHandler(this.bunifuThinButton22_MouseLeave);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "ThinButton";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton26, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 20;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.Location = new System.Drawing.Point(196, 5);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton26.TabIndex = 10;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "ThinButton";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton23, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(387, 5);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton23.TabIndex = 7;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "সম্পর্কিত";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton24, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(578, 5);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton24.TabIndex = 8;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            this.bunifuThinButton24.MouseHover += new System.EventHandler(this.bunifuThinButton24_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.bunifuThinButton212);
            this.panel3.Controls.Add(this.bunifuThinButton211);
            this.panel3.Controls.Add(this.bunifuThinButton210);
            this.panel3.Controls.Add(this.bunifuThinButton29);
            this.panel3.Controls.Add(this.bunifuThinButton28);
            this.panel3.Controls.Add(this.bunifuThinButton27);
            this.ani1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(3, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 303);
            this.panel3.TabIndex = 11;
            this.panel3.Visible = false;
            // 
            // bunifuThinButton212
            // 
            this.bunifuThinButton212.ActiveBorderThickness = 1;
            this.bunifuThinButton212.ActiveCornerRadius = 20;
            this.bunifuThinButton212.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton212.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton212.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton212.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton212.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton212.BackgroundImage")));
            this.bunifuThinButton212.ButtonText = "পঞ্চম শ্রণী";
            this.bunifuThinButton212.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton212, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton212.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton212.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton212.IdleBorderThickness = 1;
            this.bunifuThinButton212.IdleCornerRadius = 20;
            this.bunifuThinButton212.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton212.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton212.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton212.Location = new System.Drawing.Point(2, 194);
            this.bunifuThinButton212.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton212.Name = "bunifuThinButton212";
            this.bunifuThinButton212.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton212.TabIndex = 10;
            this.bunifuThinButton212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton212.MouseHover += new System.EventHandler(this.bunifuThinButton212_MouseHover);
            // 
            // bunifuThinButton211
            // 
            this.bunifuThinButton211.ActiveBorderThickness = 1;
            this.bunifuThinButton211.ActiveCornerRadius = 20;
            this.bunifuThinButton211.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton211.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton211.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton211.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton211.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton211.BackgroundImage")));
            this.bunifuThinButton211.ButtonText = "চতুর্থ শ্রণী";
            this.bunifuThinButton211.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton211, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton211.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton211.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton211.IdleBorderThickness = 1;
            this.bunifuThinButton211.IdleCornerRadius = 20;
            this.bunifuThinButton211.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton211.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton211.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton211.Location = new System.Drawing.Point(5, 143);
            this.bunifuThinButton211.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton211.Name = "bunifuThinButton211";
            this.bunifuThinButton211.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton211.TabIndex = 9;
            this.bunifuThinButton211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton211.MouseHover += new System.EventHandler(this.bunifuThinButton211_MouseHover);
            // 
            // bunifuThinButton210
            // 
            this.bunifuThinButton210.ActiveBorderThickness = 1;
            this.bunifuThinButton210.ActiveCornerRadius = 20;
            this.bunifuThinButton210.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton210.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton210.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton210.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton210.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton210.BackgroundImage")));
            this.bunifuThinButton210.ButtonText = "ছষ্ঠ শ্রণী";
            this.bunifuThinButton210.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton210, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton210.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton210.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton210.IdleBorderThickness = 1;
            this.bunifuThinButton210.IdleCornerRadius = 20;
            this.bunifuThinButton210.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton210.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton210.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton210.Location = new System.Drawing.Point(2, 245);
            this.bunifuThinButton210.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton210.Name = "bunifuThinButton210";
            this.bunifuThinButton210.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton210.TabIndex = 8;
            this.bunifuThinButton210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton210.Click += new System.EventHandler(this.bunifuThinButton210_Click);
            this.bunifuThinButton210.MouseHover += new System.EventHandler(this.bunifuThinButton210_MouseHover);
            // 
            // bunifuThinButton29
            // 
            this.bunifuThinButton29.ActiveBorderThickness = 1;
            this.bunifuThinButton29.ActiveCornerRadius = 20;
            this.bunifuThinButton29.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton29.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton29.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton29.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton29.BackgroundImage")));
            this.bunifuThinButton29.ButtonText = "তৃতীয় শ্রণী";
            this.bunifuThinButton29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton29, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton29.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton29.IdleBorderThickness = 1;
            this.bunifuThinButton29.IdleCornerRadius = 20;
            this.bunifuThinButton29.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton29.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton29.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton29.Location = new System.Drawing.Point(2, 96);
            this.bunifuThinButton29.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton29.Name = "bunifuThinButton29";
            this.bunifuThinButton29.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton29.TabIndex = 7;
            this.bunifuThinButton29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton29.MouseHover += new System.EventHandler(this.bunifuThinButton29_MouseHover);
            // 
            // bunifuThinButton28
            // 
            this.bunifuThinButton28.ActiveBorderThickness = 1;
            this.bunifuThinButton28.ActiveCornerRadius = 20;
            this.bunifuThinButton28.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton28.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton28.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton28.BackgroundImage")));
            this.bunifuThinButton28.ButtonText = "প্রথম শ্রণী";
            this.bunifuThinButton28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton28, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton28.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton28.IdleBorderThickness = 1;
            this.bunifuThinButton28.IdleCornerRadius = 20;
            this.bunifuThinButton28.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton28.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton28.Location = new System.Drawing.Point(2, 0);
            this.bunifuThinButton28.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton28.Name = "bunifuThinButton28";
            this.bunifuThinButton28.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton28.TabIndex = 6;
            this.bunifuThinButton28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton28.Click += new System.EventHandler(this.bunifuThinButton28_Click);
            this.bunifuThinButton28.MouseHover += new System.EventHandler(this.bunifuThinButton28_MouseHover);
            // 
            // bunifuThinButton27
            // 
            this.bunifuThinButton27.ActiveBorderThickness = 1;
            this.bunifuThinButton27.ActiveCornerRadius = 20;
            this.bunifuThinButton27.ActiveFillColor = System.Drawing.Color.Lime;
            this.bunifuThinButton27.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton27.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton27.BackgroundImage")));
            this.bunifuThinButton27.ButtonText = "দ্বিতীয় শ্রণী";
            this.bunifuThinButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton27, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton27.ForeColor = System.Drawing.Color.Yellow;
            this.bunifuThinButton27.IdleBorderThickness = 1;
            this.bunifuThinButton27.IdleCornerRadius = 20;
            this.bunifuThinButton27.IdleFillColor = System.Drawing.Color.Cyan;
            this.bunifuThinButton27.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton27.Location = new System.Drawing.Point(2, 49);
            this.bunifuThinButton27.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton27.Name = "bunifuThinButton27";
            this.bunifuThinButton27.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton27.TabIndex = 5;
            this.bunifuThinButton27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton27.Click += new System.EventHandler(this.bunifuThinButton27_Click);
            this.bunifuThinButton27.MouseHover += new System.EventHandler(this.bunifuThinButton27_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Lerning.Properties.Resources.primary_school;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.ani1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 393);
            this.panel1.TabIndex = 1;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "প্রবেশ করুন";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ani1.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(416, 185);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(207, 57);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            this.bunifuThinButton21.MouseHover += new System.EventHandler(this.bunifuThinButton21_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.ani1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private BunifuAnimatorNS.BunifuTransition ani1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton212;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton211;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton210;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton29;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton28;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton27;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

