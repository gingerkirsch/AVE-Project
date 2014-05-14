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
    public partial class ExecuteForm : Form
    {
        public ExecuteForm()
        {
            InitializeComponent();
            Dump.ReadOnly = true;
            Output.ReadOnly = true;
        }

        public void UpdateDamp(string damp)
        {
            Dump.Text = damp;
        }

        public void UpdateOutput(string output)
        {
            Output.Text = output;
        }

        public void UpdateRegisters(string registers) {
            Registers.Text = registers;        
        }

        private void ExecuteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.HasDump = false;
        }
    }
}
