using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace modbusLB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      // byte i = 10;
      // byte j = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
              byte[] array = File.ReadAllBytes(dlg.FileName);
              //array[29] = i;
              //i += 30;
              //array[16] = j;
              //j += 30;
              liftcontroll.SetData(array);
            }

        }

        private void liftcontroll_Load(object sender, EventArgs e)
        {
             
        }
    }
}
