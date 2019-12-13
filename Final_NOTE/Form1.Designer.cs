using System.Collections.Generic;

namespace NOTE
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快捷键ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.笔记本ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实时保存时钟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.链接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最近的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正方形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圆形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.直线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.虚线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.页面颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基准线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切换用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忘记密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Palette = new System.Windows.Forms.Button();
            this.penSize = new System.Windows.Forms.ComboBox();
            this.NoteList = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PenBtn = new System.Windows.Forms.Button();
            this.Rubber = new System.Windows.Forms.Button();
            this.RubberSize = new System.Windows.Forms.ComboBox();
            this.AddNoteBtn = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.笔记本ToolStripMenuItem1,
            this.插入ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.用户ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.导入ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.全屏ToolStripMenuItem,
            this.快捷键ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.另存为ToolStripMenuItem.Text = "另存为";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.导入ToolStripMenuItem.Text = "导入";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 全屏ToolStripMenuItem
            // 
            this.全屏ToolStripMenuItem.Name = "全屏ToolStripMenuItem";
            this.全屏ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.全屏ToolStripMenuItem.Text = "全屏";
            // 
            // 快捷键ToolStripMenuItem
            // 
            this.快捷键ToolStripMenuItem.Name = "快捷键ToolStripMenuItem";
            this.快捷键ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.快捷键ToolStripMenuItem.Text = "快捷键";
            // 
            // 笔记本ToolStripMenuItem1
            // 
            this.笔记本ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.排序ToolStripMenuItem,
            this.加密ToolStripMenuItem,
            this.实时保存时钟ToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.链接ToolStripMenuItem,
            this.最近的ToolStripMenuItem});
            this.笔记本ToolStripMenuItem1.Name = "笔记本ToolStripMenuItem1";
            this.笔记本ToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.笔记本ToolStripMenuItem1.Text = "笔记本";
            // 
            // 排序ToolStripMenuItem
            // 
            this.排序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.时间ToolStripMenuItem,
            this.名称ToolStripMenuItem,
            this.修改时间ToolStripMenuItem});
            this.排序ToolStripMenuItem.Name = "排序ToolStripMenuItem";
            this.排序ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.排序ToolStripMenuItem.Text = "排序";
            // 
            // 时间ToolStripMenuItem
            // 
            this.时间ToolStripMenuItem.Name = "时间ToolStripMenuItem";
            this.时间ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.时间ToolStripMenuItem.Text = "名称";
            // 
            // 名称ToolStripMenuItem
            // 
            this.名称ToolStripMenuItem.Name = "名称ToolStripMenuItem";
            this.名称ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.名称ToolStripMenuItem.Text = "创建时间";
            // 
            // 修改时间ToolStripMenuItem
            // 
            this.修改时间ToolStripMenuItem.Name = "修改时间ToolStripMenuItem";
            this.修改时间ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.修改时间ToolStripMenuItem.Text = "修改时间";
            // 
            // 加密ToolStripMenuItem
            // 
            this.加密ToolStripMenuItem.Name = "加密ToolStripMenuItem";
            this.加密ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.加密ToolStripMenuItem.Text = "加密";
            // 
            // 实时保存时钟ToolStripMenuItem
            // 
            this.实时保存时钟ToolStripMenuItem.Name = "实时保存时钟ToolStripMenuItem";
            this.实时保存时钟ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.实时保存时钟ToolStripMenuItem.Text = "实时保存(时钟)";
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.查找ToolStripMenuItem.Text = "查找";
            // 
            // 链接ToolStripMenuItem
            // 
            this.链接ToolStripMenuItem.Name = "链接ToolStripMenuItem";
            this.链接ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.链接ToolStripMenuItem.Text = "链接";
            // 
            // 最近的ToolStripMenuItem
            // 
            this.最近的ToolStripMenuItem.Name = "最近的ToolStripMenuItem";
            this.最近的ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.最近的ToolStripMenuItem.Text = "最近的";
            // 
            // 插入ToolStripMenuItem
            // 
            this.插入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文本框ToolStripMenuItem,
            this.表格ToolStripMenuItem,
            this.图形ToolStripMenuItem});
            this.插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            this.插入ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.插入ToolStripMenuItem.Text = "插入";
            // 
            // 文本框ToolStripMenuItem
            // 
            this.文本框ToolStripMenuItem.Name = "文本框ToolStripMenuItem";
            this.文本框ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.文本框ToolStripMenuItem.Text = "文本框";
            this.文本框ToolStripMenuItem.Click += new System.EventHandler(this.文本框ToolStripMenuItem_Click);
            // 
            // 表格ToolStripMenuItem
            // 
            this.表格ToolStripMenuItem.Name = "表格ToolStripMenuItem";
            this.表格ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.表格ToolStripMenuItem.Text = "表格";
            // 
            // 图形ToolStripMenuItem
            // 
            this.图形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.正方形ToolStripMenuItem,
            this.三角形ToolStripMenuItem,
            this.圆形ToolStripMenuItem,
            this.直线ToolStripMenuItem,
            this.虚线ToolStripMenuItem});
            this.图形ToolStripMenuItem.Name = "图形ToolStripMenuItem";
            this.图形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.图形ToolStripMenuItem.Text = "图形";
            // 
            // 正方形ToolStripMenuItem
            // 
            this.正方形ToolStripMenuItem.Name = "正方形ToolStripMenuItem";
            this.正方形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.正方形ToolStripMenuItem.Text = "矩形";
            // 
            // 三角形ToolStripMenuItem
            // 
            this.三角形ToolStripMenuItem.Name = "三角形ToolStripMenuItem";
            this.三角形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.三角形ToolStripMenuItem.Text = "三角形";
            // 
            // 圆形ToolStripMenuItem
            // 
            this.圆形ToolStripMenuItem.Name = "圆形ToolStripMenuItem";
            this.圆形ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.圆形ToolStripMenuItem.Text = "圆形";
            // 
            // 直线ToolStripMenuItem
            // 
            this.直线ToolStripMenuItem.Name = "直线ToolStripMenuItem";
            this.直线ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.直线ToolStripMenuItem.Text = "直线";
            // 
            // 虚线ToolStripMenuItem
            // 
            this.虚线ToolStripMenuItem.Name = "虚线ToolStripMenuItem";
            this.虚线ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.虚线ToolStripMenuItem.Text = "虚线";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.页面颜色ToolStripMenuItem,
            this.基准线ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 页面颜色ToolStripMenuItem
            // 
            this.页面颜色ToolStripMenuItem.Name = "页面颜色ToolStripMenuItem";
            this.页面颜色ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.页面颜色ToolStripMenuItem.Text = "页面颜色";
            // 
            // 基准线ToolStripMenuItem
            // 
            this.基准线ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.行线ToolStripMenuItem,
            this.网格ToolStripMenuItem});
            this.基准线ToolStripMenuItem.Name = "基准线ToolStripMenuItem";
            this.基准线ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.基准线ToolStripMenuItem.Text = "基准线";
            // 
            // 行线ToolStripMenuItem
            // 
            this.行线ToolStripMenuItem.Name = "行线ToolStripMenuItem";
            this.行线ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.行线ToolStripMenuItem.Text = "行线";
            // 
            // 网格ToolStripMenuItem
            // 
            this.网格ToolStripMenuItem.Name = "网格ToolStripMenuItem";
            this.网格ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.网格ToolStripMenuItem.Text = "网格";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登入ToolStripMenuItem,
            this.登出ToolStripMenuItem,
            this.切换用户ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.忘记密码ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 登入ToolStripMenuItem
            // 
            this.登入ToolStripMenuItem.Name = "登入ToolStripMenuItem";
            this.登入ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.登入ToolStripMenuItem.Text = "登入";
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.登出ToolStripMenuItem.Text = "登出";
            // 
            // 切换用户ToolStripMenuItem
            // 
            this.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem";
            this.切换用户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.切换用户ToolStripMenuItem.Text = "切换用户";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 忘记密码ToolStripMenuItem
            // 
            this.忘记密码ToolStripMenuItem.Name = "忘记密码ToolStripMenuItem";
            this.忘记密码ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.忘记密码ToolStripMenuItem.Text = "忘记密码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(133, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 488);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Palette
            // 
            this.Palette.AutoSize = true;
            this.Palette.Image = global::NOTE.Properties.Resources.Colour_Palette;
            this.Palette.Location = new System.Drawing.Point(1016, 33);
            this.Palette.Margin = new System.Windows.Forms.Padding(4);
            this.Palette.Name = "Palette";
            this.Palette.Size = new System.Drawing.Size(38, 38);
            this.Palette.TabIndex = 2;
            this.Palette.UseVisualStyleBackColor = true;
            this.Palette.Click += new System.EventHandler(this.button1_Click);
            // 
            // penSize
            // 
            this.penSize.FormattingEnabled = true;
            this.penSize.Location = new System.Drawing.Point(853, 35);
            this.penSize.Margin = new System.Windows.Forms.Padding(4);
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(53, 23);
            this.penSize.TabIndex = 3;
            this.penSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NoteList
            // 
            this.NoteList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteList.FormattingEnabled = true;
            this.NoteList.ItemHeight = 15;
            this.NoteList.Location = new System.Drawing.Point(0, 108);
            this.NoteList.Margin = new System.Windows.Forms.Padding(4);
            this.NoteList.Name = "NoteList";
            this.NoteList.Size = new System.Drawing.Size(125, 484);
            this.NoteList.TabIndex = 4;
            this.NoteList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NoteList_MouseClick);
            // 
            // PenBtn
            // 
            this.PenBtn.Image = ((System.Drawing.Image)(resources.GetObject("PenBtn.Image")));
            this.PenBtn.Location = new System.Drawing.Point(810, 33);
            this.PenBtn.Name = "PenBtn";
            this.PenBtn.Size = new System.Drawing.Size(36, 36);
            this.PenBtn.TabIndex = 15;
            this.PenBtn.UseVisualStyleBackColor = true;
            // 
            // Rubber
            // 
            this.Rubber.Image = global::NOTE.Properties.Resources.eraser;
            this.Rubber.Location = new System.Drawing.Point(912, 36);
            this.Rubber.Name = "Rubber";
            this.Rubber.Size = new System.Drawing.Size(36, 36);
            this.Rubber.TabIndex = 16;
            this.Rubber.UseVisualStyleBackColor = true;
            // 
            // RubberSize
            // 
            this.RubberSize.FormattingEnabled = true;
            this.RubberSize.Location = new System.Drawing.Point(955, 35);
            this.RubberSize.Margin = new System.Windows.Forms.Padding(4);
            this.RubberSize.Name = "RubberSize";
            this.RubberSize.Size = new System.Drawing.Size(53, 23);
            this.RubberSize.TabIndex = 17;
            // 
            // AddNoteBtn
            // 
            this.AddNoteBtn.Location = new System.Drawing.Point(12, 34);
            this.AddNoteBtn.Name = "AddNoteBtn";
            this.AddNoteBtn.Size = new System.Drawing.Size(65, 36);
            this.AddNoteBtn.TabIndex = 18;
            this.AddNoteBtn.Text = "新笔记";
            this.AddNoteBtn.UseVisualStyleBackColor = true;
            this.AddNoteBtn.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // RevokeBtn
            // 
            this.RevokeBtn.Image = ((System.Drawing.Image)(resources.GetObject("RevokeBtn.Image")));
            this.RevokeBtn.Location = new System.Drawing.Point(694, 33);
            this.RevokeBtn.Name = "RevokeBtn";
            this.RevokeBtn.Size = new System.Drawing.Size(36, 36);
            this.RevokeBtn.TabIndex = 6;
            this.RevokeBtn.UseVisualStyleBackColor = true;
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Image = global::NOTE.Properties.Resources.redo;
            this.RestoreBtn.Location = new System.Drawing.Point(746, 33);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(36, 36);
            this.RestoreBtn.TabIndex = 7;
            this.RestoreBtn.UseVisualStyleBackColor = true;
            // 
            // Format_Painter
            // 
            this.Format_Painter.Location = new System.Drawing.Point(463, 35);
            this.Format_Painter.Name = "Format_Painter";
            this.Format_Painter.Size = new System.Drawing.Size(60, 36);
            this.Format_Painter.TabIndex = 12;
            this.Format_Painter.Text = "格式刷";
            this.Format_Painter.UseVisualStyleBackColor = true;
            this.Format_Painter.Click += new System.EventHandler(this.Format_Painter_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(541, 34);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(78, 36);
            this.ClearBtn.TabIndex = 13;
            this.ClearBtn.Text = "清除格式";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FontColor
            // 
            this.FontColor.Location = new System.Drawing.Point(370, 36);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(76, 36);
            this.FontColor.TabIndex = 11;
            this.FontColor.Text = "字体颜色";
            this.FontColor.UseVisualStyleBackColor = true;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // MouseBtn
            // 
            this.MouseBtn.Image = global::NOTE.Properties.Resources.pointer;
            this.MouseBtn.Location = new System.Drawing.Point(641, 34);
            this.MouseBtn.Name = "MouseBtn";
            this.MouseBtn.Size = new System.Drawing.Size(36, 36);
            this.MouseBtn.TabIndex = 14;
            this.MouseBtn.UseVisualStyleBackColor = true;
            // 
            // UnderlineBtn
            // 
            this.UnderlineBtn.Location = new System.Drawing.Point(313, 36);
            this.UnderlineBtn.Name = "UnderlineBtn";
            this.UnderlineBtn.Size = new System.Drawing.Size(36, 36);
            this.UnderlineBtn.TabIndex = 10;
            this.UnderlineBtn.Text = "U";
            this.UnderlineBtn.UseVisualStyleBackColor = true;
            this.UnderlineBtn.Click += new System.EventHandler(this.UnderlineBtn_Click);
            // 
            // ItalicBtn
            // 
            this.ItalicBtn.Location = new System.Drawing.Point(271, 36);
            this.ItalicBtn.Name = "ItalicBtn";
            this.ItalicBtn.Size = new System.Drawing.Size(36, 36);
            this.ItalicBtn.TabIndex = 9;
            this.ItalicBtn.Text = "I";
            this.ItalicBtn.UseVisualStyleBackColor = true;
            this.ItalicBtn.Click += new System.EventHandler(this.ItalicBtn_Click);
            // 
            // BoldBtn
            // 
            this.BoldBtn.Location = new System.Drawing.Point(229, 36);
            this.BoldBtn.Name = "BoldBtn";
            this.BoldBtn.Size = new System.Drawing.Size(36, 36);
            this.BoldBtn.TabIndex = 8;
            this.BoldBtn.Text = "B";
            this.BoldBtn.UseVisualStyleBackColor = true;
            this.BoldBtn.Click += new System.EventHandler(this.BoldBtn_Click);
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Location = new System.Drawing.Point(102, 36);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(121, 23);
            this.FontBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = global::NOTE.Properties.Resources.书__1_;
            this.button1.Location = new System.Drawing.Point(0, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 26);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::NOTE.Properties.Resources.搜索__1;
            this.button2.Location = new System.Drawing.Point(44, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 26);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::NOTE.Properties.Resources.时间_历史记录_计时_钟表_线性;
            this.button3.Location = new System.Drawing.Point(92, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 26);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 25);
            this.textBox1.TabIndex = 22;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Palette);
            this.Controls.Add(this.RubberSize);
            this.Controls.Add(this.Rubber);
            this.Controls.Add(this.penSize);
            this.Controls.Add(this.PenBtn);
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
            this.Controls.Add(this.AddNoteBtn);
            this.Controls.Add(this.NoteList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Note";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快捷键ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 笔记本ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实时保存时钟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 链接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名称ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Palette;
        private System.Windows.Forms.ComboBox penSize;
        private System.Windows.Forms.ListBox NoteList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 最近的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem;
        private System.Windows.Forms.Button PenBtn;
        private System.Windows.Forms.Button Rubber;
        private System.Windows.Forms.ComboBox RubberSize;
        private System.Windows.Forms.ToolStripMenuItem 修改时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正方形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圆形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 虚线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 页面颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基准线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切换用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 忘记密码ToolStripMenuItem;
        private System.Windows.Forms.Button AddNoteBtn;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

