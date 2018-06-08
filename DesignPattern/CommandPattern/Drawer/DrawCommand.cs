using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;

namespace CommandPattern.Drawer
{
    public class DrawCommand : ICommand
    {
        protected IDrawable _drawable;

        protected Point _position;

        public DrawCommand(IDrawable drawable, Point position)
        {
            _drawable = drawable;
            _position = position;
        }

        public void Execute()
        {
            _drawable.Draw(_position.X, _position.Y);
        }
    }
}
