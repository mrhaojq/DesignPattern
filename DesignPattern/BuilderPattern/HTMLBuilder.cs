using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HTMLBuilder : Builder
    {
        private string _filename;
        private FileStream _fileStream;
        private StreamWriter _streamWriter;

        //public HTMLBuilder(string filename)
        //{
        //    _filename = filename;
        //    _fileStream = new FileStream(_filename, FileMode.Create);
        //    _streamWriter = new StreamWriter(_fileStream);
        //}

        public override void Close()
        {
            _streamWriter.Write("</body></html>");
            _streamWriter.Flush();
            _streamWriter.Close();
            _fileStream.Close();
        }

        public override void MakeItems(string[] items)
        {
            _streamWriter.Write($"<ul>");
            foreach (var item in items)
            {
                _streamWriter.Write($"<li>{item}</li>");
            }
            _streamWriter.Write($"</ul>");
        }

        public override void MakeString(string str)
        {
            _streamWriter.Write($"<p>{str}</p>");
        }

        public override void MakeTitle(string title)
        {
            CreateFile(title);
            _streamWriter.Write($"<html><head><title>{title}</title></head><body>");
            _streamWriter.Write($"<h1>{title}</h1>");
        }

        public string GetResult()
        {
            return _filename;
        }

        private bool CreateFile(string title)
        {
            _filename = title+".html";
            _fileStream = new FileStream(_filename, FileMode.Create);
            _streamWriter = new StreamWriter(_fileStream);
            return true;
        }
    }
}
