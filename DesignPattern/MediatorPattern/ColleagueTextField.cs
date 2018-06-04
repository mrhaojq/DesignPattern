using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ColleagueTextField : System.Windows.Forms.TextBox, Colleague
    {
        private Mediator _mediator;
        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
            this.BackColor = enabled ? System.Drawing.Color.White : System.Drawing.Color.LightGray;
        }

        public void SetMediator(Mediator mediator)
        {
            this._mediator = mediator;
        }

        public void TextValueChanged(object sender, EventArgs e)
        {
            _mediator.ColleagueChanged();
        }
    }
}
