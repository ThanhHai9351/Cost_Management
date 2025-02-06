using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Custom_Field
{
    public class ButtonHover : Button
    {
        private Color defaultColor = Color.LightBlue;
        private Color hoverColor = Color.Blue;

        public ButtonHover()
        {
            this.BackColor = defaultColor;
            this.Enter += ButtonHover_Enter;
            this.Leave += ButtonHover_Leave;
        }

        private void ButtonHover_Leave(object sender, EventArgs e)
        {
            this.BackColor = hoverColor;
        }

        private void ButtonHover_Enter(object sender, EventArgs e)
        {
            this.BackColor = defaultColor;
        }
    }
}
