using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class TextBuilder : Builder
    {
        private StringBuilder _buffer = new StringBuilder();

        public string GetResult()
        {
            return _buffer.ToString();
        }

        public override void Close()
        {
            _buffer.Append("==================================================\n");
        }

        public override void MakeItems(string[] items)
        {
            foreach (var item in items)
            {
                _buffer.Append($"   {item}\n");
            }
            _buffer.Append("\n");
        }

        public override void MakeString(string str)
        {
            _buffer.Append($"● {str}\n");
            _buffer.Append("\n");
        }

        public override void MakeTitle(string title)
        {
            _buffer.Append("==================================================\n");
            _buffer.Append($"『{title}』");
            _buffer.Append("\n");
        }
    }
}
