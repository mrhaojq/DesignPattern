using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class PageMaker
    {
        private PageMaker()
        { }

        public static void MakeWelcomePage(string mailaddr, string fileName)
        {
            try
            {
                Dictionary<string, string> mailProp = Database.GetProperties("dbname");
                string userName = string.Empty;
                if (mailProp.ContainsKey(mailaddr))
                {
                    userName = mailProp[mailaddr];
                }

                HtmlWriter htmlWriter = new HtmlWriter(fileName);
                htmlWriter.Title($"Welcome to {userName} 's page!");
                htmlWriter.Paragraph($"{userName} 欢迎来到 {userName} 的主页。");
                htmlWriter.Paragraph("等着你的邮件哦！");
                htmlWriter.Mailto(mailaddr, userName);
                htmlWriter.Close();
                Console.WriteLine($"{fileName} is created for {mailaddr} ({userName})");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
