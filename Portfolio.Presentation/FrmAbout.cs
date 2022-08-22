using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio.Presentation
{
    public partial class FrmAbout : Form
    {
        Form previousForm;

        public FrmAbout(Form form)
        {
            previousForm = form;
            InitializeComponent();            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
            previousForm.Show();
        }
    }
}
