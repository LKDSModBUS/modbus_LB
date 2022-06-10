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
         //byte i = 0;
         //byte j = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
              byte[] array = File.ReadAllBytes(dlg.FileName);
                //array[23] = i;
                //i += 255;
                //array[29] = i;
                //i += 30;
                //array[22] = j;
                liftcontroll.SetData(array);
            }

        }

        private void liftcontroll_Load(object sender, EventArgs e)
        {
             
        }
    }
}
