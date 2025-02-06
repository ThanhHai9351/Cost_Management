using System;
using System.Drawing;
using System.Windows.Forms;

namespace Custom_Field
{
    public class TextActive : TextBox
    {
        private Color focusColor = Color.LightBlue;
        private Color defaultColor = Color.White;
        private ErrorProvider errorProvider = new ErrorProvider();

        public TextActive()
        {
            this.Enter += TextActive_Enter;
            this.Leave += TextActive_Leave;
            this.KeyPress += TextActive_KeyPress;
        }

        private void TextActive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                errorProvider.SetError(this, "Không được để trống trường này!");
            }
            else
            {
                errorProvider.SetError(this, "");
            }
        }

        private void TextActive_Enter(object sender, EventArgs e)
        {
            this.BackColor = focusColor;
        }

        private void TextActive_Leave(object sender, EventArgs e)
        {
            this.BackColor = defaultColor;
        }
    }
}
