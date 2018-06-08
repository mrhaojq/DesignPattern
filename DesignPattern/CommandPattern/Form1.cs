using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandPattern.Command;
using CommandPattern.Drawer;

namespace CommandPattern
{
    public partial class Form1 : Form
    {

        private MacroCommand history;

        private DrawCanvas canvas;

        public Form1()
        {
            history = new MacroCommand();
            canvas = new DrawCanvas(400, 400, history);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(pic_MouseMove);//PictureBox 的双击事件
            canvas.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(canvas);

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //当条件满足时，触发添加命令，
                //在当前鼠标位置再画一个点的命令
                //将这个命令添加到命令列表中
                //执行这个命令
                CommandPattern.Command.ICommand cmd = new DrawCommand(canvas, e.Location);
                history.Append(cmd);
                cmd.Execute();//执行的是具体命令表 MacroCommand中的方法
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            history.Clear();
            canvas.Refresh();
        }
    }
}
