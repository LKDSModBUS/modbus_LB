using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modbusLB
{
    public partial class LiftControl : UserControl
    {
        public LiftControl()
        {
            InitializeComponent();
        }

        public void SetData(byte[] array)
        {
            if (array.Length > 230)
            {
                if(array[0] == 4)
                {
                    DeviceClass.Union16 val = new DeviceClass.Union16();
                    val.Byte0 = array[2];
                    val.Byte1 = array[3];

                    DeviceClass.LBClassType type = (DeviceClass.LBClassType)val.Value;
                    lb_type.Text = type.GetNameOfEnum();

                    DeviceClass.Stage type1 = (DeviceClass.Stage)array[14];
                    call_source.Text = type1.GetNameOfEnum();

                    lb_appver.Text = $"{array[4]}.{array[5]}.{array[6]}";

                    #region [ggs]
                    dispatcher.Checked = ((array[13] & 0x20) != 0);
                    fire_subdivision.Checked = ((array[13] & 0x80) != 0);

                    if (((array[13] & 0x40) == 1))
                        ggs_on.Checked = true;
                    else
                        ggs_off.Checked = true;

                    if (((array[13] & 0x01) == 0))
                        test_ggs_no_data.Checked = true;
                    else
                        test_ggs_yes.Checked = true;

                    if (((array[13] & 0x02) == 1))
                        test_result_yes.Checked = true;
                    else
                        test_result_ggs_err.Checked = true;
                    #endregion

                    #region [battary]
                    if (((array[15] & 0x01) == 1))
                        batt_support_yes.Checked = true;
                    else
                        batt_support_no.Checked = true;

                    if (((array[15] & 0x02) == 1))
                        change_mode_support_no.Checked = true;
                    else
                        change_mode_support_yes.Checked = true;

                    if (((array[15] & 0x80) == 1))
                        power_device_backup.Checked = true;
                    else
                        power_device_basic.Checked = true;

                    batery_err.Checked = ((array[15] & 0x04) != 0);
                    test_batery_ok.Checked = ((array[15] & 0x08) != 0);
                    test_batery_go.Checked = ((array[15] & 0x10) != 0);
                    battery_charge.Checked = ((array[15] & 0x20) != 0);
                    no_battery.Checked = ((array[15] & 0x40) != 0);
                    #endregion
                }
            }
        }
        private void LiftControl_Load(object sender, EventArgs e)
        {

        }

        private void test_batery_ok_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
