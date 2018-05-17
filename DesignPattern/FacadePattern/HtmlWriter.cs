using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FacadePattern
{
    public class HtmlWriter
    {
        private StreamWriter _streamWriter;
        private FileStream _fileStream;


        public HtmlWriter(string fileName)
        {
            //fileName += ".html";
            _fileStream = new FileStream(fileName, FileMode.Create);
            _streamWriter = new StreamWriter(_fileStream);
        }

        public void Title(string title)
        {
            _streamWriter.Write("<html>");
            _streamWriter.Write("<head>");
            _streamWriter.Write($"<title>{title}</title>");
            _streamWriter.Write("<body>\n");
            _streamWriter.Write($"<h1>{title}</h1>\n");
        }

        public void Paragraph(string msg)
        {
            _streamWriter.Write($"<p>{msg}</p>\n");
        }

        public void Link(string href, string caption)
        {
            _streamWriter.Write($"<a href=\"{href}\">{caption}</a>\n");
        }

        public void Mailto(string mailaddr, string userName)
        {
            Link($"Mailto:{mailaddr}", userName);
        }

        public void Close()
        {
            _streamWriter.Write("</body>\n");
            _streamWriter.Write("</html>\n");
            _streamWriter.Flush();
            _streamWriter.Close();
            _fileStream.Close();
        }
    }
}
