using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop_Team6
{
    internal class Functions
    {
        //Enable Text And Combobox
        public void EnableAllTextAndCombobox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Enabled = true;
                }
                if (control.HasChildren)
                {
                    EnableAllTextAndCombobox(control);
                }
            }
        }
        //Disable Text And Combobox
        public void DisableAllTextAndCombobox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Enabled = false;
                }
                if (control.HasChildren)
                {
                    DisableAllTextAndCombobox(control);
                }
            }
        }
        //Clear Data
        public void ClearField(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }
    }
}
