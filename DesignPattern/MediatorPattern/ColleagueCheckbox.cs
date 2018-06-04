using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern
{
    public class ColleagueCheckbox :CheckBox, Colleague
    {
        private Mediator _mediator;

        public ColleagueCheckbox(string caption, bool state)
        {
            this.Text = caption;
            this.Checked = state;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void ItemStateChanged()
        {
            _mediator.ColleagueChanged();
        }
    }
}
