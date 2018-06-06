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
    public partial class Form1 : Form,IContext
    {

        private IState state = DayState.GetInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }



        public void CallSecurityCenter(string msg)
        {
            rtb_content.AppendText($"Call! {msg} \n");
        }

        public void ChangeState(IState state)
        {
            rtb_content.AppendText($"从 {this.state} 状态变为了 {state} 状态。\n");
            this.state = state;
        }

        public void RecordLog(string msg)
        {
            rtb_content.AppendText($"Record... {msg} \n");
        }

        public void SetClock(int hour)
        {
            string clockstring = "现在的时间是";
            if (hour<10)
            {
                clockstring += "0" + hour + ":00";
            }
            else
            {
                clockstring += hour + ":00";
            }
            this.lb_currentState.Text = clockstring;
            state.DoClock(this, hour);
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            state.DoUse(this);
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            state.DoAlarm(this);
        }

        private void btn_phone_Click(object sender, EventArgs e)
        {
            state.DoPhone(this);
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
