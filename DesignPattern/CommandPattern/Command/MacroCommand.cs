using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> commands = new Stack<ICommand>();//命令集合

        public void Execute()
        {
            foreach (var cmd in commands)
            {
                cmd.Execute();
            }
        }

        public void Append(ICommand command)
        {
            if (command!=this)
            {
                commands.Push(command);
            }
        }

        public void Undo()
        {
            if (commands.Count>0)
            {
                commands.Pop();
            }
        }

        public void Clear()
        {
            commands.Clear();
        }
    }
}
