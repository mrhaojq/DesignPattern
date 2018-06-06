using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePattern
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 form = new Form1();

        private void Form2_Load(object sender, EventArgs e)
        {
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                for (int i = 0; i < 24; i++)
                {
                    try
                    {
                        form.SetClock(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }

                }
            }));
        }
    }
}
