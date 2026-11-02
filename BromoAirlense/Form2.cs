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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                var uc = new detailPenumpang($"Penumpang #{i + 1}");

                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Cast<detailPenumpang>().ToList().ForEach(x =>
            {
                MessageBox.Show($"Nama : {x.namaLengkap}, Title : {x.title}");
            });
        }
    }
}
