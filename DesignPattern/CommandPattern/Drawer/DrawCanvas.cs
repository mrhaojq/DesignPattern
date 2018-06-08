using CommandPattern.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern.Drawer
{
    public class DrawCanvas : PictureBox, IDrawable
    {
        private Color _color = Color.Red;
        private int _radius = 4;
        private MacroCommand _history;

        public DrawCanvas(int width, int height, MacroCommand history)
        {
            //初始化Canvas
            this.Width = width;
            this.Height = height;
            _history = history;
            this.BackColor = Color.Black;
        }

        /// <summary>
        /// 重绘时 直接添加的所有命令
        /// </summary>
        protected override void OnCreateControl()
        {
            //要持有之前的所有命令记录，才能执行历史命令
            _history.Execute();
        }

        //具体的单个命令就是在DrawCanvas上画一个点
        public void Draw(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(new Pen(_color), x - _radius, y - _radius, _radius / 2, _radius / 2);
        }
          
    }
}
