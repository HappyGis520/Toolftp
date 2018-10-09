namespace Ellamaker.FTP.Controls
{
    partial class UcBookResource
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBookResource));
            this.pagLower = new System.Windows.Forms.TabPage();
            this.lstLower = new System.Windows.Forms.ListView();
            this.pagHD = new System.Windows.Forms.TabPage();
            this.lstHD = new System.Windows.Forms.ListView();
            this.tabBookResource = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateDir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.LargImages = new System.Windows.Forms.ImageList(this.components);
            this.SmallImages = new System.Windows.Forms.ImageList(this.components);
            this.pagLower.SuspendLayout();
            this.pagHD.SuspendLayout();
            this.tabBookResource.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pagLower
            // 
            this.pagLower.Controls.Add(this.lstLower);
            this.pagLower.Location = new System.Drawing.Point(4, 22);
            this.pagLower.Name = "pagLower";
            this.pagLower.Padding = new System.Windows.Forms.Padding(3);
            this.pagLower.Size = new System.Drawing.Size(926, 509);
            this.pagLower.TabIndex = 1;
            this.pagLower.Text = "低清资源 ";
            this.pagLower.UseVisualStyleBackColor = true;
            // 
            // lstLower
            // 
            this.lstLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLower.Location = new System.Drawing.Point(3, 3);
            this.lstLower.Name = "lstLower";
            this.lstLower.Size = new System.Drawing.Size(920, 503);
            this.lstLower.TabIndex = 0;
            this.lstLower.UseCompatibleStateImageBehavior = false;
            this.lstLower.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstHD_MouseDown);
            // 
            // pagHD
            // 
            this.pagHD.Controls.Add(this.lstHD);
            this.pagHD.Location = new System.Drawing.Point(4, 22);
            this.pagHD.Name = "pagHD";
            this.pagHD.Padding = new System.Windows.Forms.Padding(3);
            this.pagHD.Size = new System.Drawing.Size(926, 509);
            this.pagHD.TabIndex = 0;
            this.pagHD.Text = "高清资源";
            this.pagHD.UseVisualStyleBackColor = true;
            // 
            // lstHD
            // 
            this.lstHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHD.Location = new System.Drawing.Point(3, 3);
            this.lstHD.Name = "lstHD";
            this.lstHD.Size = new System.Drawing.Size(920, 503);
            this.lstHD.TabIndex = 0;
            this.lstHD.UseCompatibleStateImageBehavior = false;
            this.lstHD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstHD_MouseDown);
            // 
            // tabBookResource
            // 
            this.tabBookResource.Controls.Add(this.pagHD);
            this.tabBookResource.Controls.Add(this.pagLower);
            this.tabBookResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBookResource.Location = new System.Drawing.Point(0, 0);
            this.tabBookResource.Name = "tabBookResource";
            this.tabBookResource.SelectedIndex = 0;
            this.tabBookResource.Size = new System.Drawing.Size(934, 535);
            this.tabBookResource.TabIndex = 0;
            //this.tabBookResource.SelectedIndexChanged += new System.EventHandler(this.tabBookResource_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemCreateDir,
            this.menuItemDownload});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(137, 70);
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(136, 22);
            this.menuItemOpen.Text = "打开";
            // 
            // menuItemCreateDir
            // 
            this.menuItemCreateDir.Name = "menuItemCreateDir";
            this.menuItemCreateDir.Size = new System.Drawing.Size(136, 22);
            this.menuItemCreateDir.Text = "创建文件夹";
            // 
            // menuItemDownload
            // 
            this.menuItemDownload.Name = "menuItemDownload";
            this.menuItemDownload.Size = new System.Drawing.Size(136, 22);
            this.menuItemDownload.Text = "下载文件";
            // 
            // LargImages
            // 
            this.LargImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargImages.ImageStream")));
            this.LargImages.TransparentColor = System.Drawing.Color.Transparent;
            this.LargImages.Images.SetKeyName(0, "微信图片_20180925101230.jpg");
            // 
            // SmallImages
            // 
            this.SmallImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallImages.ImageStream")));
            this.SmallImages.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallImages.Images.SetKeyName(0, "snapshot.png");
            // 
            // UcBookResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabBookResource);
            this.Name = "UcBookResource";
            this.Size = new System.Drawing.Size(934, 535);
            this.pagLower.ResumeLayout(false);
            this.pagHD.ResumeLayout(false);
            this.tabBookResource.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pagLower;
        private System.Windows.Forms.TabPage pagHD;
        private System.Windows.Forms.TabControl tabBookResource;
        private System.Windows.Forms.ListView lstLower;
        private System.Windows.Forms.ListView lstHD;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreateDir;
        private System.Windows.Forms.ToolStripMenuItem menuItemDownload;
        private System.Windows.Forms.ImageList LargImages;
        private System.Windows.Forms.ImageList SmallImages;
    }
}
