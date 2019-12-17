using System.Collections.Generic;

namespace NOTE
{
    partial class NoteInterface
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.笔记本ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.Line = new System.Windows.Forms.ToolStripMenuItem();
            this.Rect = new System.Windows.Forms.ToolStripMenuItem();
            this.Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.Fillrect = new System.Windows.Forms.ToolStripMenuItem();
            this.Fillcircle = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忘记密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Palette = new System.Windows.Forms.Button();
            this.NoteList = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Eraser = new System.Windows.Forms.Button();
            this.penSize = new System.Windows.Forms.ComboBox();
            this.RevokeBtn = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.Format_Painter = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.FontColor = new System.Windows.Forms.Button();
            this.MouseBtn = new System.Windows.Forms.Button();
            this.UnderlineBtn = new System.Windows.Forms.Button();
            this.ItalicBtn = new System.Windows.Forms.Button();
            this.BoldBtn = new System.Windows.Forms.Button();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ReverseSort = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.Fontbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reSize = new System.Windows.Forms.PictureBox();
            this.Drawbox = new System.Windows.Forms.PictureBox();
            this.Dash = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Clearpicture = new System.Windows.Forms.Button();
            this.FontSizePlus = new System.Windows.Forms.Button();
            this.FontSizeMinus = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.CMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除笔记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Savebtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawbox)).BeginInit();
            this.CMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.笔记本ToolStripMenuItem1,
            this.插入ToolStripMenuItem,
            this.用户ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 笔记本ToolStripMenuItem1
            // 
            this.笔记本ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.排序ToolStripMenuItem,
            this.查找ToolStripMenuItem});
            this.笔记本ToolStripMenuItem1.Name = "笔记本ToolStripMenuItem1";
            this.笔记本ToolStripMenuItem1.Size = new System.Drawing.Size(56, 21);
            this.笔记本ToolStripMenuItem1.Text = "笔记本";
            // 
            // 排序ToolStripMenuItem
            // 
            this.排序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建时间ToolStripMenuItem,
            this.修改时间ToolStripMenuItem});
            this.排序ToolStripMenuItem.Name = "排序ToolStripMenuItem";
            this.排序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.排序ToolStripMenuItem.Text = "排序";
            // 
            // 创建时间ToolStripMenuItem
            // 
            this.创建时间ToolStripMenuItem.Name = "创建时间ToolStripMenuItem";
            this.创建时间ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.创建时间ToolStripMenuItem.Text = "创建时间";
            this.创建时间ToolStripMenuItem.Click += new System.EventHandler(this.创建时间ToolStripMenuItem_Click);
            // 
            // 修改时间ToolStripMenuItem
            // 
            this.修改时间ToolStripMenuItem.Name = "修改时间ToolStripMenuItem";
            this.修改时间ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改时间ToolStripMenuItem.Text = "修改时间";
            this.修改时间ToolStripMenuItem.Click += new System.EventHandler(this.修改时间ToolStripMenuItem_Click);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查找ToolStripMenuItem.Text = "查找";
            // 
            // 插入ToolStripMenuItem
            // 
            this.插入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文本框ToolStripMenuItem,
            this.图形ToolStripMenuItem});
            this.插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            this.插入ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.插入ToolStripMenuItem.Text = "插入";
            // 
            // 文本框ToolStripMenuItem
            // 
            this.文本框ToolStripMenuItem.Name = "文本框ToolStripMenuItem";
            this.文本框ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.文本框ToolStripMenuItem.Text = "文本框";
            this.文本框ToolStripMenuItem.Click += new System.EventHandler(this.文本框ToolStripMenuItem_Click);
            // 
            // 图形ToolStripMenuItem
            // 
            this.图形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ellipse,
            this.Line,
            this.Rect,
            this.Circle,
            this.Fillrect,
            this.Fillcircle});
            this.图形ToolStripMenuItem.Name = "图形ToolStripMenuItem";
            this.图形ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.图形ToolStripMenuItem.Text = "图形";
            // 
            // Ellipse
            // 
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(124, 22);
            this.Ellipse.Text = "椭圆";
            this.Ellipse.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // Line
            // 
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(124, 22);
            this.Line.Text = "直线";
            this.Line.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // Rect
            // 
            this.Rect.Name = "Rect";
            this.Rect.Size = new System.Drawing.Size(124, 22);
            this.Rect.Text = "矩形";
            this.Rect.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // Circle
            // 
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(124, 22);
            this.Circle.Text = "圆";
            this.Circle.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // Fillrect
            // 
            this.Fillrect.Name = "Fillrect";
            this.Fillrect.Size = new System.Drawing.Size(124, 22);
            this.Fillrect.Text = "实心矩形";
            this.Fillrect.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // Fillcircle
            // 
            this.Fillcircle.Name = "Fillcircle";
            this.Fillcircle.Size = new System.Drawing.Size(124, 22);
            this.Fillcircle.Text = "实心圆";
            this.Fillcircle.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登入ToolStripMenuItem,
            this.登出ToolStripMenuItem,
            this.切换用户ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.忘记密码ToolStripMenuItem,
            this.注册ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 登入ToolStripMenuItem
            // 
            this.登入ToolStripMenuItem.Name = "登入ToolStripMenuItem";
            this.登入ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.登入ToolStripMenuItem.Text = "登入";
            this.登入ToolStripMenuItem.Click += new System.EventHandler(this.登入ToolStripMenuItem_Click);
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.登出ToolStripMenuItem.Text = "登出";
            this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
            // 
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切换用户ToolStripMenuItem.Text = "切换用户";
            this.切换用户ToolStripMenuItem.Click += new System.EventHandler(this.切换用户ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 忘记密码ToolStripMenuItem
            // 
            this.忘记密码ToolStripMenuItem.Name = "忘记密码ToolStripMenuItem";
            this.忘记密码ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.忘记密码ToolStripMenuItem.Text = "忘记密码";
            this.忘记密码ToolStripMenuItem.Click += new System.EventHandler(this.忘记密码ToolStripMenuItem_Click);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // Palette
            // 
            this.Palette.AutoSize = true;
            this.Palette.Image = global::NOTE.Properties.Resources.调色盘;
            this.Palette.Location = new System.Drawing.Point(656, 26);
            this.Palette.Name = "Palette";
            this.Palette.Size = new System.Drawing.Size(27, 29);
            this.Palette.TabIndex = 2;
            this.Palette.UseVisualStyleBackColor = true;
            this.Palette.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoteList
            // 
            this.NoteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteList.FormattingEnabled = true;
            this.NoteList.ItemHeight = 12;
            this.NoteList.Location = new System.Drawing.Point(0, 86);
            this.NoteList.Name = "NoteList";
            this.NoteList.Size = new System.Drawing.Size(95, 376);
            this.NoteList.TabIndex = 4;
            this.NoteList.SelectedIndexChanged += new System.EventHandler(this.NoteList_SelectedIndexChanged);
            this.NoteList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NoteList_MouseUp);
            // 
            // Eraser
            // 
            this.Eraser.Image = global::NOTE.Properties.Resources.橡皮;
            this.Eraser.Location = new System.Drawing.Point(695, 26);
            this.Eraser.Margin = new System.Windows.Forms.Padding(2);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(27, 29);
            this.Eraser.TabIndex = 16;
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Rubber_Click);
            // 
            // penSize
            // 
            this.penSize.FormattingEnabled = true;
            this.penSize.Location = new System.Drawing.Point(737, 26);
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(41, 20);
            this.penSize.TabIndex = 17;
            this.penSize.SelectedIndexChanged += new System.EventHandler(this.penSize_SelectedIndexChanged);
            // 
            // RevokeBtn
            // 
            this.RevokeBtn.Image = global::NOTE.Properties.Resources.撤销;
            this.RevokeBtn.Location = new System.Drawing.Point(512, 26);
            this.RevokeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RevokeBtn.Name = "RevokeBtn";
            this.RevokeBtn.Size = new System.Drawing.Size(27, 29);
            this.RevokeBtn.TabIndex = 6;
            this.RevokeBtn.UseVisualStyleBackColor = true;
            this.RevokeBtn.Click += new System.EventHandler(this.RevokeBtn_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Image = global::NOTE.Properties.Resources.恢复;
            this.RestoreBtn.Location = new System.Drawing.Point(544, 26);
            this.RestoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(27, 29);
            this.RestoreBtn.TabIndex = 7;
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // Format_Painter
            // 
            this.Format_Painter.Image = global::NOTE.Properties.Resources.格式刷;
            this.Format_Painter.Location = new System.Drawing.Point(329, 29);
            this.Format_Painter.Margin = new System.Windows.Forms.Padding(2);
            this.Format_Painter.Name = "Format_Painter";
            this.Format_Painter.Size = new System.Drawing.Size(27, 29);
            this.Format_Painter.TabIndex = 12;
            this.Format_Painter.UseVisualStyleBackColor = true;
            this.Format_Painter.Click += new System.EventHandler(this.Format_Painter_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::NOTE.Properties.Resources.清除格式;
            this.ClearBtn.Location = new System.Drawing.Point(409, 28);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(27, 29);
            this.ClearBtn.TabIndex = 13;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FontColor
            // 
            this.FontColor.Image = global::NOTE.Properties.Resources.字体颜色;
            this.FontColor.Location = new System.Drawing.Point(290, 22);
            this.FontColor.Margin = new System.Windows.Forms.Padding(2);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(27, 29);
            this.FontColor.TabIndex = 11;
            this.FontColor.UseVisualStyleBackColor = true;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // MouseBtn
            // 
            this.MouseBtn.Image = global::NOTE.Properties.Resources.指针;
            this.MouseBtn.Location = new System.Drawing.Point(481, 26);
            this.MouseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MouseBtn.Name = "MouseBtn";
            this.MouseBtn.Size = new System.Drawing.Size(27, 29);
            this.MouseBtn.TabIndex = 14;
            this.MouseBtn.UseVisualStyleBackColor = true;
            this.MouseBtn.Click += new System.EventHandler(this.Rubber_Click);
            // 
            // UnderlineBtn
            // 
            this.UnderlineBtn.Image = global::NOTE.Properties.Resources.下划线;
            this.UnderlineBtn.Location = new System.Drawing.Point(238, 22);
            this.UnderlineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UnderlineBtn.Name = "UnderlineBtn";
            this.UnderlineBtn.Size = new System.Drawing.Size(27, 29);
            this.UnderlineBtn.TabIndex = 10;
            this.UnderlineBtn.UseVisualStyleBackColor = true;
            this.UnderlineBtn.Click += new System.EventHandler(this.UnderlineBtn_Click);
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.Image = global::NOTE.Properties.Resources.斜体;
            this.ItalicBtn.Location = new System.Drawing.Point(194, 25);
            this.ItalicBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(27, 29);
            this.ItalicBtn.TabIndex = 9;
            this.ItalicBtn.UseVisualStyleBackColor = true;
            this.ItalicBtn.Click += new System.EventHandler(this.ItalicBtn_Click);
            // 
            // BoldBtn
            // 
            this.BoldBtn.Image = global::NOTE.Properties.Resources.加粗;
            this.BoldBtn.Location = new System.Drawing.Point(146, 25);
            this.BoldBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(27, 29);
            this.BoldBtn.TabIndex = 8;
            this.BoldBtn.UseVisualStyleBackColor = true;
            this.BoldBtn.Click += new System.EventHandler(this.BoldBtn_Click);
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Location = new System.Drawing.Point(35, 29);
            this.FontBox.Margin = new System.Windows.Forms.Padding(2);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(92, 20);
            this.FontBox.TabIndex = 5;
            this.FontBox.SelectedIndexChanged += new System.EventHandler(this.FontBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Image = global::NOTE.Properties.Resources.搜索__1;
            this.button2.Location = new System.Drawing.Point(35, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 29);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReverseSort
            // 
            this.ReverseSort.Image = global::NOTE.Properties.Resources.时间_历史记录_计时_钟表_线性;
            this.ReverseSort.Location = new System.Drawing.Point(67, 54);
            this.ReverseSort.Margin = new System.Windows.Forms.Padding(2);
            this.ReverseSort.Name = "ReverseSort";
            this.ReverseSort.Size = new System.Drawing.Size(27, 29);
            this.ReverseSort.TabIndex = 21;
            this.ReverseSort.UseVisualStyleBackColor = true;
            this.ReverseSort.Click += new System.EventHandler(this.ReverseSort_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(100, 62);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(113, 21);
            this.SearchBox.TabIndex = 22;
            this.SearchBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.SearchBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // delete
            // 
            this.delete.Image = global::NOTE.Properties.Resources.垃圾桶_删除;
            this.delete.Location = new System.Drawing.Point(440, 28);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(27, 29);
            this.delete.TabIndex = 23;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Fontbtn
            // 
            this.Fontbtn.Image = global::NOTE.Properties.Resources.字体_;
            this.Fontbtn.Location = new System.Drawing.Point(4, 25);
            this.Fontbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Fontbtn.Name = "Fontbtn";
            this.Fontbtn.Size = new System.Drawing.Size(27, 29);
            this.Fontbtn.TabIndex = 24;
            this.Fontbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reSize);
            this.panel1.Controls.Add(this.Drawbox);
            this.panel1.Location = new System.Drawing.Point(100, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 386);
            this.panel1.TabIndex = 25;
            // 
            // reSize
            // 
            this.reSize.BackColor = System.Drawing.Color.Black;
            this.reSize.Location = new System.Drawing.Point(297, 260);
            this.reSize.Margin = new System.Windows.Forms.Padding(2);
            this.reSize.Name = "reSize";
            this.reSize.Size = new System.Drawing.Size(8, 8);
            this.reSize.TabIndex = 1;
            this.reSize.TabStop = false;
            this.reSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.reSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.reSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Drawbox
            // 
            this.Drawbox.BackColor = System.Drawing.Color.White;
            this.Drawbox.Location = new System.Drawing.Point(0, 0);
            this.Drawbox.Margin = new System.Windows.Forms.Padding(2);
            this.Drawbox.Name = "Drawbox";
            this.Drawbox.Size = new System.Drawing.Size(297, 259);
            this.Drawbox.TabIndex = 0;
            this.Drawbox.TabStop = false;
            this.Drawbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drawbox_MouseDown);
            this.Drawbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawbox_MouseMove);
            this.Drawbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drawbox_MouseUp);
            // 
            // Dash
            // 
            this.Dash.Image = global::NOTE.Properties.Resources.虚线_1_;
            this.Dash.Location = new System.Drawing.Point(656, 56);
            this.Dash.Margin = new System.Windows.Forms.Padding(2);
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(27, 29);
            this.Dash.TabIndex = 26;
            this.Dash.UseVisualStyleBackColor = true;
            this.Dash.Click += new System.EventHandler(this.Dash_Click);
            // 
            // Normal
            // 
            this.Normal.Image = global::NOTE.Properties.Resources.实线_1_;
            this.Normal.Location = new System.Drawing.Point(695, 56);
            this.Normal.Margin = new System.Windows.Forms.Padding(2);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(27, 29);
            this.Normal.TabIndex = 27;
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Dash_Click);
            // 
            // Dot
            // 
            this.Dot.Image = global::NOTE.Properties.Resources.画笔;
            this.Dot.Location = new System.Drawing.Point(575, 26);
            this.Dot.Margin = new System.Windows.Forms.Padding(2);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(27, 29);
            this.Dot.TabIndex = 28;
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Rubber_Click);
            // 
            // Clearpicture
            // 
            this.Clearpicture.Image = global::NOTE.Properties.Resources.清除;
            this.Clearpicture.Location = new System.Drawing.Point(377, 26);
            this.Clearpicture.Margin = new System.Windows.Forms.Padding(2);
            this.Clearpicture.Name = "Clearpicture";
            this.Clearpicture.Size = new System.Drawing.Size(27, 29);
            this.Clearpicture.TabIndex = 29;
            this.Clearpicture.UseVisualStyleBackColor = true;
            this.Clearpicture.Click += new System.EventHandler(this.Clearpicture_Click);
            // 
            // FontSizePlus
            // 
            this.FontSizePlus.Image = global::NOTE.Properties.Resources.增大字号_文字操作_jurassic;
            this.FontSizePlus.Location = new System.Drawing.Point(238, 56);
            this.FontSizePlus.Margin = new System.Windows.Forms.Padding(2);
            this.FontSizePlus.Name = "FontSizePlus";
            this.FontSizePlus.Size = new System.Drawing.Size(27, 29);
            this.FontSizePlus.TabIndex = 30;
            this.FontSizePlus.UseVisualStyleBackColor = true;
            this.FontSizePlus.Click += new System.EventHandler(this.FontSizePlus_Click);
            // 
            // FontSizeMinus
            // 
            this.FontSizeMinus.Image = global::NOTE.Properties.Resources.缩小减小字号_文字操作_jurassic;
            this.FontSizeMinus.Location = new System.Drawing.Point(290, 56);
            this.FontSizeMinus.Margin = new System.Windows.Forms.Padding(2);
            this.FontSizeMinus.Name = "FontSizeMinus";
            this.FontSizeMinus.Size = new System.Drawing.Size(27, 29);
            this.FontSizeMinus.TabIndex = 31;
            this.FontSizeMinus.UseVisualStyleBackColor = true;
            this.FontSizeMinus.Click += new System.EventHandler(this.FontSizeMinus_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(742, 7);
            this.namelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(0, 12);
            this.namelabel.TabIndex = 36;
            // 
            // CMStrip
            // 
            this.CMStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem,
            this.删除笔记ToolStripMenuItem});
            this.CMStrip.Name = "CMStrip";
            this.CMStrip.Size = new System.Drawing.Size(125, 48);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 删除笔记ToolStripMenuItem
            // 
            this.删除笔记ToolStripMenuItem.Name = "删除笔记ToolStripMenuItem";
            this.删除笔记ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除笔记ToolStripMenuItem.Text = "删除笔记";
            this.删除笔记ToolStripMenuItem.Click += new System.EventHandler(this.删除笔记ToolStripMenuItem_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Image = global::NOTE.Properties.Resources.保存_线性;
            this.Savebtn.Location = new System.Drawing.Point(4, 56);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(27, 29);
            this.Savebtn.TabIndex = 37;
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // NoteInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.FontSizeMinus);
            this.Controls.Add(this.FontSizePlus);
            this.Controls.Add(this.Clearpicture);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Dash);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fontbtn);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ReverseSort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Palette);
            this.Controls.Add(this.penSize);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.RevokeBtn);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.MouseBtn);
            this.Controls.Add(this.UnderlineBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FontColor);
            this.Controls.Add(this.Format_Painter);
            this.Controls.Add(this.ItalicBtn);
            this.Controls.Add(this.BoldBtn);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.NoteList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NoteInterface";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawbox)).EndInit();
            this.CMStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Text.InstalledFontCollection objFont = new System.Drawing.Text.InstalledFontCollection();
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 笔记本ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建时间ToolStripMenuItem;
        private System.Windows.Forms.Button Palette;
        private System.Windows.Forms.ListBox NoteList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.ComboBox penSize;
        private System.Windows.Forms.ToolStripMenuItem 修改时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 忘记密码ToolStripMenuItem;
        private System.Windows.Forms.Button ShowNoteBtn;
        private System.Windows.Forms.Button RevokeBtn;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.ToolStripMenuItem 文本框ToolStripMenuItem;
        private System.Windows.Forms.Button Format_Painter;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button FontColor;
        private System.Windows.Forms.Button MouseBtn;
        private System.Windows.Forms.Button UnderlineBtn;
        private System.Windows.Forms.Button ItalicBtn;
        private System.Windows.Forms.Button BoldBtn;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ReverseSort;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Fontbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Drawbox;
        private System.Windows.Forms.Button Dash;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.ToolStripMenuItem 图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ellipse;
        private System.Windows.Forms.ToolStripMenuItem Line;
        private System.Windows.Forms.ToolStripMenuItem Rect;
        private System.Windows.Forms.ToolStripMenuItem Circle;
        private System.Windows.Forms.ToolStripMenuItem Fillrect;
        private System.Windows.Forms.ToolStripMenuItem Fillcircle;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.PictureBox reSize;
        private System.Windows.Forms.Button Clearpicture;
        private System.Windows.Forms.Button FontSizePlus;
        private System.Windows.Forms.Button FontSizeMinus;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.ContextMenuStrip CMStrip;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除笔记ToolStripMenuItem;
        private System.Windows.Forms.Button Savebtn;
    }
}

