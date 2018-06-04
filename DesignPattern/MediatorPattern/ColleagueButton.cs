using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ColleagueButton : System.Windows.Forms.Button, Colleague
    {
        private Mediator _mediator;

        public ColleagueButton(string caption)
        {
            this.Text = caption;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}
