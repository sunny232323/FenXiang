namespace 源代码
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.数据文件输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一键计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.计算MAX和MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分栅格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算栅格高度信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拟合平面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算投影坐标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 56);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据文件输入ToolStripMenuItem,
            this.一键计算ToolStripMenuItem,
            this.导出文件ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 数据文件输入ToolStripMenuItem
            // 
            this.数据文件输入ToolStripMenuItem.Name = "数据文件输入ToolStripMenuItem";
            this.数据文件输入ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.数据文件输入ToolStripMenuItem.Text = "数据文件输入";
            this.数据文件输入ToolStripMenuItem.Click += new System.EventHandler(this.数据文件输入ToolStripMenuItem_Click);
            // 
            // 一键计算ToolStripMenuItem
            // 
            this.一键计算ToolStripMenuItem.Name = "一键计算ToolStripMenuItem";
            this.一键计算ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.一键计算ToolStripMenuItem.Text = "一键计算";
            // 
            // 导出文件ToolStripMenuItem
            // 
            this.导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            this.导出文件ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.导出文件ToolStripMenuItem.Text = "导出文件";
            this.导出文件ToolStripMenuItem.Click += new System.EventHandler(this.导出文件ToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.计算ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 28);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算MAX和MinToolStripMenuItem,
            this.分栅格ToolStripMenuItem,
            this.计算栅格高度信息ToolStripMenuItem,
            this.拟合平面ToolStripMenuItem,
            this.计算ToolStripMenuItem1,
            this.计算投影坐标ToolStripMenuItem});
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.计算ToolStripMenuItem.Text = "计算";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 59);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 389);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "表格";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报告";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(761, 380);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // 计算MAX和MinToolStripMenuItem
            // 
            this.计算MAX和MinToolStripMenuItem.Name = "计算MAX和MinToolStripMenuItem";
            this.计算MAX和MinToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.计算MAX和MinToolStripMenuItem.Text = "计算MAX和Min";
            this.计算MAX和MinToolStripMenuItem.Click += new System.EventHandler(this.计算MAX和MinToolStripMenuItem_Click);
            // 
            // 分栅格ToolStripMenuItem
            // 
            this.分栅格ToolStripMenuItem.Name = "分栅格ToolStripMenuItem";
            this.分栅格ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.分栅格ToolStripMenuItem.Text = "分栅格";
            this.分栅格ToolStripMenuItem.Click += new System.EventHandler(this.分栅格ToolStripMenuItem_Click);
            // 
            // 计算栅格高度信息ToolStripMenuItem
            // 
            this.计算栅格高度信息ToolStripMenuItem.Name = "计算栅格高度信息ToolStripMenuItem";
            this.计算栅格高度信息ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.计算栅格高度信息ToolStripMenuItem.Text = "计算栅格高度信息";
            this.计算栅格高度信息ToolStripMenuItem.Click += new System.EventHandler(this.计算栅格高度信息ToolStripMenuItem_Click);
            // 
            // 拟合平面ToolStripMenuItem
            // 
            this.拟合平面ToolStripMenuItem.Name = "拟合平面ToolStripMenuItem";
            this.拟合平面ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.拟合平面ToolStripMenuItem.Text = "拟合平面";
            this.拟合平面ToolStripMenuItem.Click += new System.EventHandler(this.拟合平面ToolStripMenuItem_Click);
            // 
            // 计算ToolStripMenuItem1
            // 
            this.计算ToolStripMenuItem1.Name = "计算ToolStripMenuItem1";
            this.计算ToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.计算ToolStripMenuItem1.Text = "计算最佳分割面J1J2";
            this.计算ToolStripMenuItem1.Click += new System.EventHandler(this.计算ToolStripMenuItem1_Click);
            // 
            // 计算投影坐标ToolStripMenuItem
            // 
            this.计算投影坐标ToolStripMenuItem.Name = "计算投影坐标ToolStripMenuItem";
            this.计算投影坐标ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.计算投影坐标ToolStripMenuItem.Text = "计算投影坐标";
            this.计算投影坐标ToolStripMenuItem.Click += new System.EventHandler(this.计算投影坐标ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 数据文件输入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一键计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出文件ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 计算MAX和MinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分栅格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算栅格高度信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拟合平面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算投影坐标ToolStripMenuItem;
    }
}

