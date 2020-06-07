using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishLearning.Forms
{
    public partial class Welcome_menu : Form
    {
        public Welcome_menu()
        {
            InitializeComponent();
        }

        private void TheBackground_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
