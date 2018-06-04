using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern
{
    public class LoginForm : Form, Mediator
    {

        private ColleagueCheckbox checkGuest;
        private ColleagueCheckbox checkLogin;
        private ColleagueTextField textUser;
        private ColleagueTextField textPass;
        private ColleagueButton buttonOk;
        private ColleagueButton buttonCancel;

        public LoginForm(string title)
        {
            this.Text = title;

            this.BackColor = System.Drawing.Color.LightGray;

            CreateColleagues();
        }

       
        public void ColleagueChanged()
        {
            throw new NotImplementedException();
        }

        public void CreateColleagues()
        {
            checkGuest = new ColleagueCheckbox("Guest", true);
            checkLogin = new ColleagueCheckbox("Login", false);
            textUser = new ColleagueTextField();
            textPass = new ColleagueTextField();
            buttonOk = new ColleagueButton("OK");
            buttonCancel = new ColleagueButton("Cancel");
            //设置Mediator
            checkGuest.SetMediator(this);
            checkLogin.SetMediator(this);
            textUser.SetMediator(this);
            textPass.SetMediator(this);
            buttonOk.SetMediator(this);
            buttonOk.SetMediator(this);

            //设置Listener
            //checkGuest.CheckedChanged += checkGuest.ItemStateChanged();
        }
    }
}
