using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WTTV
{
    public partial class TvLocation : Form
    {
        private decimal EditTop = 0;
        private decimal EditRight = 0;
        public TvLocation(decimal editTop, decimal editRight)
        {
            InitializeComponent();
            this.EditTop = editTop;
            this.EditRight = editRight;
            PanleRelative();
        }

        /// <summary>
        /// 定位panle相对位置
        /// </summary>
        private void PanleRelative()
        {
            if (EditRight != 0 && EditTop != 0)
            {
              this.panel2.Top= Convert.ToInt32(this.panel1.Height * this.EditTop);
              this.panel2.Left =this.panel1.Width- Convert.ToInt32(this.panel1.Width * this.EditRight)-this.panel2.Width;
            }
        }
        //鼠标按下坐标（control控件的相对坐标） 
        Point mouseDownPoint = Point.Empty;
        //显示拖动效果的矩形 
        Rectangle rect = Rectangle.Empty;
        //是否正在拖拽 
        bool isDrag = false;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = e.Location;
                //记录控件的大小 
                rect = this.panel2.Bounds;
            } 
        }
        //把相对与control控件的坐标，转换成相对于窗体的坐标。 
        private Point getPointToForm(Point p)
        {
            return this.PointToClient(this.panel2.PointToScreen(p));
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {                
                isDrag = true;
                //重新设置rect的位置，跟随鼠标移动 
                rect.Location = getPointToForm(new Point(e.Location.X - mouseDownPoint.X, e.Location.Y - mouseDownPoint.Y));
                this.Refresh();

            } 
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrag)
                {
                    isDrag = false;
                    //移动control到放开鼠标的地方 
                    this.panel2.Location = rect.Location;
                    this.Refresh();
                }
                reset();
            } 
        }
        //重置变量 
        private void reset()
        {
            mouseDownPoint = Point.Empty;
            rect = Rectangle.Empty;
            isDrag = false;
        }

        private void TvLocation_Paint(object sender, PaintEventArgs e)
        {
            if (rect != Rectangle.Empty)
            {
                if (isDrag)
                {//画一个和Control一样大小的黑框 
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                }
                else
                {
                    e.Graphics.DrawRectangle(new Pen(this.BackColor), rect);
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float top = this.panel2.Top;
            float height = this.panel1.Height;
            this.RelativeTop = top / height; //获取相对top
            float right = this.panel1.Width - (this
                .panel2.Left + this.panel2.Width);
            float width = this.panel1.Width;
            this.RelativeRight = right / width;
            this.Close();
        }
        private void TvLocation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private float relativetop;
        private float relativeright;
        /// <summary>
        /// 弹出框的相对top
        /// </summary>
        public float RelativeTop
        {
            get {
                return relativetop;
            }
            set {
                relativetop = value;
            }
        }
        /// <summary>
        /// 弹出框的相对Right
        /// </summary>
        public float RelativeRight
        {
            get {
                return relativeright;
            }
            set {
                relativeright = value;
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.RelativeTop = 0;
            this.RelativeRight = 0;
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            panel2_MouseDown(this, e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            panel2_MouseMove(this, e);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            panel2_MouseUp(this, e);
        }
    }
}
