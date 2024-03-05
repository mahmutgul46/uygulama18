using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama18
{
    public partial class MaskedTextBox : Form
    {
        public MaskedTextBox()
        {
            InitializeComponent();
        }

        private void MaskedTextBox_Load(object sender, EventArgs e)
        {
            maskTC.Mask = "00000000000";
            maskTelefon.Mask = "(999) 000 00 00";
            maskDTarihi.Mask = "00 / 00 / 0000";
            maskKart.Mask = "0000 - 0000 - 0000 - 0000";
            maskIP.Mask = "###.###.###.###";
        }
    }
}
