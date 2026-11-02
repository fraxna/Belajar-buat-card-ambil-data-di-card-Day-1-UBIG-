using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BromoAirlense
{
    public partial class detailPenumpang : UserControl
    {
        public string namaLengkap
        {
            get
            {
                return textBox1.Text;
            }
        }

        public string title
        {
            get
            {
                return comboBox1.Text;
            }
        }
        public detailPenumpang(string title)
        {
            InitializeComponent();
            label3.Text = title;
        }

        private void detailPenumpang_Load(object sender, EventArgs e)
        {
        }
    }
}
