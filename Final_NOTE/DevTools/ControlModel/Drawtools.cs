using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace NOTE.ControlModel
{
    [Serializable]
public    class DrawTools
    {
        public Graphics targetGraphics;//目标绘图板
        public Pen pen;//笔
        private Image orginalImg;//原始画布
        private Image kkk;//原始画布
        private Color drawColor = Color.Black;//绘图颜色
        private Graphics newGraphics;//过渡画板
        private Image finishingImg;//过渡画布，用来保存绘图过程中的痕迹
        public Image begin;
        public List<Image> images = new List<Image>();
        public List<Image> imagesSave = new List<Image>();

        public Color DrawColor//绘图颜色
        {
            get { return drawColor; }
            set
            {
                drawColor = value;
                pen.Color = value;
            }
        }
        public Image OrginalImg//原始画布
        {
            get { return orginalImg; }
            set
            {
                finishingImg = (Image)value.Clone();
                orginalImg = (Image)value.Clone();
            }
        }

        public bool startDraw = false;//是否开始绘图
        public PointF startPointF;//绘图起点

        /// <param name="g">绘图板</param>
        /// <param name="c">绘图颜色</param>
        /// <param name="img">初始画布</param>
        public DrawTools(Graphics g, Color c, Image img)//初始化绘图工具
        {
            targetGraphics = g;
            drawColor = c;
            pen = new Pen(c, 1);
            finishingImg = (Image)img.Clone();
            orginalImg = (Image)img.Clone();
            images.Add((Image)orginalImg.Clone());
            begin = (Image)orginalImg.Clone();
        }
        /// <param name="e">鼠标参数</param>
        /// <param name="sType">绘图类型</param>
        public void Dash(String dash)
        {
            if (dash == "Dash")
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; //虚线
                Application.DoEvents();
            }
            else if (dash == "Normal")
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Application.DoEvents();
            }
        }
        public void Draw(MouseEventArgs e, String sType)//绘制各种图形
        {
            if (startDraw)
            {
                Image img = (Image)orginalImg.Clone();//为防止直接改写原始画布，我们定义一个新的image获取原始画布的克隆
                newGraphics = Graphics.FromImage(img);//通过原始画布的克隆，实例化中间画板
                switch (sType)
                {
                    case "Dash":
                        {
                            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; //虚线
                            Application.DoEvents();
                            break;
                        }
                    case "Normal":
                        {
                            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            Application.DoEvents();
                            break;
                        }
                    case "Line":
                        {

                            newGraphics.DrawLine(pen, startPointF, new PointF(e.X, e.Y));
                            break;
                        }
                    case "Rect":
                        {
                            float width = Math.Abs(e.X - startPointF.X);
                            float heigth = Math.Abs(e.Y - startPointF.Y);
                            PointF rectStartPointF = startPointF;
                            if (e.X < startPointF.X)
                            {
                                rectStartPointF.X = e.X;
                            }
                            if (e.Y < startPointF.Y)
                            {
                                rectStartPointF.Y = e.Y;
                            }
                            newGraphics.DrawRectangle(pen, rectStartPointF.X, rectStartPointF.Y, width, heigth);
                            break;
                        }
                    case "Ellipse":
                        {
                            newGraphics.DrawEllipse(pen, startPointF.X, startPointF.Y, e.X - startPointF.X, e.Y - startPointF.Y);
                            break;
                        }
                    case "Circle":
                        {
                            newGraphics.DrawEllipse(pen, startPointF.X, startPointF.Y, e.X - startPointF.X, e.Y - startPointF.Y);
                            break;
                        }
                    case "Fillrect":
                        {
                            float width = Math.Abs(e.X - startPointF.X);//确定矩形的宽
                            float heigth = Math.Abs(e.Y - startPointF.Y);//确定矩形的高
                            PointF rectStartPointF = startPointF;
                            if (e.X < startPointF.X)
                            {
                                rectStartPointF.X = e.X;
                            }
                            if (e.Y < startPointF.Y)
                            {
                                rectStartPointF.Y = e.Y;
                            }
                            newGraphics.FillRectangle(new SolidBrush(drawColor), rectStartPointF.X, rectStartPointF.Y, width, heigth);
                            break;
                        }
                    case "Fillcircle":
                        {
                            newGraphics.FillEllipse(new SolidBrush(drawColor), startPointF.X, startPointF.Y, e.X - startPointF.X, e.Y - startPointF.Y);
                            break;
                        }
                }
                newGraphics.Dispose();//绘图完毕释放中间画板所占资源
                newGraphics = Graphics.FromImage(finishingImg);//另建一个中间画板，画布为中间图片
                newGraphics.DrawImage(img, 0, 0);//将图片画到中间图片
                newGraphics.Dispose();
                targetGraphics.DrawImage(img, 0, 0);//将图片画到目标画板上
                img.Dispose();

            }
        }
        

        public void EndDraw()
        {
            startDraw = false;
            //为了让完成后的绘图过程保留下来，要将中间图片绘制到原始画布上
            newGraphics = Graphics.FromImage(orginalImg);
            newGraphics.DrawImage(finishingImg, 0, 0);
            newGraphics.Dispose();
            images.Add((Image)orginalImg.Clone());
            imagesSave.Clear();
        }

        // 橡皮方法

        public void Eraser(MouseEventArgs e)
        {
            if (startDraw)
            {
                newGraphics = Graphics.FromImage(finishingImg);
                newGraphics.FillRectangle(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                newGraphics.Dispose();
                targetGraphics.DrawImage(finishingImg, 0, 0);
            }
        }


        // 铅笔方法

        public void DrawDot(MouseEventArgs e)
        {
            if (startDraw)
            {
                newGraphics = Graphics.FromImage(finishingImg);
                PointF currentPointF = new PointF(e.X, e.Y);
                newGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                newGraphics.DrawLine(pen, startPointF, currentPointF);
                startPointF = currentPointF;
                newGraphics.Dispose();
                targetGraphics.DrawImage(finishingImg, 0, 0);
            }
        }

        public void revocation()//撤销
        {
            if (images != null && images.Count > 1)
            {
                imagesSave.Add((Image)finishingImg.Clone());
                images.Remove(images.Last());
                orginalImg = (Image)images.Last().Clone();
                finishingImg = (Image)images.Last().Clone();
                // targetGraphics.Dispose();
                // targetGraphics = Graphics.FromImage(orginalImg);
                targetGraphics.Clear(Color.White);
                targetGraphics.DrawImage(orginalImg, 0, 0);
            }
        }

        public void clear()//清空
        {
                newGraphics = Graphics.FromImage(orginalImg);
                newGraphics.Clear(Color.White);
                newGraphics = Graphics.FromImage(finishingImg);
                newGraphics.Clear(Color.White);
                targetGraphics.Clear(Color.White);
                images.Clear();
                imagesSave.Clear();
                images.Add(begin);
        }

        public void advance()//前进一步
        {
            if (imagesSave != null && imagesSave.Count > 0)
            {
                orginalImg = (Image)imagesSave.Last().Clone();
                finishingImg = (Image)imagesSave.Last().Clone();
                imagesSave.Remove(imagesSave.Last());
                targetGraphics.Clear(Color.White);
                targetGraphics.DrawImage(orginalImg, 0, 0);
            }
        }
        // 清除变量，释放内存

        public void ClearVar()
        {
            targetGraphics.Dispose();
            finishingImg.Dispose();
            orginalImg.Dispose();
            pen.Dispose();
        }

    }
}

