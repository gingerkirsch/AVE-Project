using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCPU_16.Forms
{
    public partial class InputForm : Form
    {
        public int Value { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                Value = Int32.Parse(value.Text);
            }
            catch (Exception)
            {
                Value = 0;
            }
            Close();
        }

        private void value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                Value = Int32.Parse(value.Text);
            }
            catch (Exception)
            {
                Value = 0;
            }
            Close();
        }

    }
}
