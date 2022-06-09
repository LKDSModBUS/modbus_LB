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

                    DeviceClass.WorkMode type2 = (DeviceClass.WorkMode)array[28];
                    working_mode.Text = type2.GetNameOfEnum();

                    lb_appver.Text = $"{array[4]}.{array[5]}.{array[6]}";

                    restart.Text = $"код {array[7]} ({array[8]})";

                    DeviceClass.Union32 val1 = new DeviceClass.Union32();
                    val1.Byte0 = array[120];
                    val1.Byte1 = array[121];
                    val1.Byte2 = array[122];
                    val1.Byte3 = array[123];
                    main_drive_inclusions.Text = val1.Value.ToString();

                    DeviceClass.Union32 val2 = new DeviceClass.Union32();
                    val2.Byte0 = array[124];
                    val2.Byte1 = array[125];
                    val2.Byte2 = array[126];
                    val2.Byte3 = array[127];
                    main_drive_work_time.Text = $"{val2.Value.ToString()} сек.";

                    DeviceClass.Union32 val3 = new DeviceClass.Union32();
                    val3.Byte0 = array[128];
                    val3.Byte1 = array[129];
                    val3.Byte2 = array[130];
                    val3.Byte3 = array[131];
                    door_drive_inclusions.Text = val3.Value.ToString();

                    DeviceClass.Union32 val4 = new DeviceClass.Union32();
                    val4.Byte0 = array[132];
                    val4.Byte1 = array[133];
                    val4.Byte2 = array[134];
                    val4.Byte3 = array[135];
                    door_drive_work_time.Text = $"{val4.Value.ToString()} сек.";

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

                    #region [passangers]
                    passangers.Checked = (array[29] >= 10 && array[29] <= 100);

                    if (array[29] >= 0 && array[29] <= 100)
                    {
                        precent.Text = $"{array[29]}%";
                    }
                    if (array[29] == 255)
                    {
                        precent.Text = $"???  :')";
                    }

                    if (array[29] >= 0 && array[29] <= 100)
                    {
                        progressBar1.Value = array[29];
                        progressBar1.ValueColor = Color.Green;
                    }
                    if (array[29] == 100)
                    {
                        progressBar1.Value = 100;
                        progressBar1.ValueColor = Color.Yellow;
                    }
                    if (array[29] > 100)
                    {
                        progressBar1.Value = 100;
                        progressBar1.ValueColor = Color.Red;
                    }
                    if (array[29] == 255)
                    {
                        progressBar1.Value = 0;
                    }
                    #endregion

                    #region [battary_precent]
                    if (array[16] >= 0 && array[29] <= 100)
                    {
                        battary_precent.Text = $"{array[16]}%";
                    }
                    if (array[16] == 255)
                    {
                        battary_precent.Text = $"???  :')";
                    }

                    if (array[16] >= 0 && array[16] <= 20)
                    {
                        progressBar2.Value = array[16];
                        progressBar2.ValueColor = Color.Red;
                    }
                    if (array[16] >= 21 && array[16] <= 50)
                    {
                        progressBar2.Value = array[16];
                        progressBar2.ValueColor = Color.Yellow;
                    }
                    if (array[16] >= 51 && array[16] <= 99)
                    {
                        progressBar2.Value = array[16];
                        progressBar2.ValueColor = Color.Green;
                    }
                    if (array[16] >= 100)
                    {
                        progressBar2.Value = 100;
                        progressBar2.ValueColor = Color.Green;
                    }
                    if (array[16] == 255)
                    {
                        progressBar2.Value = 0;
                    }
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
