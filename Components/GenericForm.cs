using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public class GenericForm : Form
    {
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = string.Format("Message Express - {0}", value); }
        }
    }
}
