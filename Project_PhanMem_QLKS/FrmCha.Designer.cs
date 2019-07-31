namespace Project_PhanMem_QLKS
{
    partial class frmCha
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
            this.menuNhanVien = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien.SuspendLayout();
            this.menuQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuNhanVien.Location = new System.Drawing.Point(0, 24);
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(787, 24);
            this.menuNhanVien.TabIndex = 1;
            this.menuNhanVien.Text = "menuNhanVien";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.quảnLýToolStripMenuItem.Text = "Nhân Viên";
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuQuanLy.Location = new System.Drawing.Point(0, 0);
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(787, 24);
            this.menuQuanLy.TabIndex = 2;
            this.menuQuanLy.Text = "menuQuanLy";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nhânViênToolStripMenuItem.Text = "Quản Lý";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // frmCha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.menuNhanVien);
            this.Controls.Add(this.menuQuanLy);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuNhanVien;
            this.Name = "frmCha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCha_Load);
            this.menuNhanVien.ResumeLayout(false);
            this.menuNhanVien.PerformLayout();
            this.menuQuanLy.ResumeLayout(false);
            this.menuQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}