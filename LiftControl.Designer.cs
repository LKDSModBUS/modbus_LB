namespace modbusLB
{
    partial class LiftControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.batt_support_no = new System.Windows.Forms.CheckBox();
            this.test_batery_ok = new System.Windows.Forms.CheckBox();
            this.batery_err = new System.Windows.Forms.CheckBox();
            this.power_device_basic = new System.Windows.Forms.CheckBox();
            this.power_device_backup = new System.Windows.Forms.CheckBox();
            this.change_mode_support_no = new System.Windows.Forms.CheckBox();
            this.change_mode_support_yes = new System.Windows.Forms.CheckBox();
            this.batt_support_yes = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.door_drive_work_time = new System.Windows.Forms.TextBox();
            this.door_drive_inclusions = new System.Windows.Forms.TextBox();
            this.main_drive_work_time = new System.Windows.Forms.TextBox();
            this.main_drive_inclusions = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lift_status = new System.Windows.Forms.ListBox();
            this.door_status = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.working_mode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lift = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.TextBox();
            this.up = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.precent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.call_source = new System.Windows.Forms.TextBox();
            this.passangers = new System.Windows.Forms.RadioButton();
            this.workload = new System.Windows.Forms.ProgressBar();
            this.emergency_stop = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_appver = new System.Windows.Forms.Label();
            this.test_batery_go = new System.Windows.Forms.CheckBox();
            this.battery_charge = new System.Windows.Forms.CheckBox();
            this.no_battery = new System.Windows.Forms.CheckBox();
            this.dispatcher = new System.Windows.Forms.CheckBox();
            this.fire_subdivision = new System.Windows.Forms.CheckBox();
            this.ggs_off = new System.Windows.Forms.CheckBox();
            this.ggs_on = new System.Windows.Forms.CheckBox();
            this.test_ggs_no_data = new System.Windows.Forms.CheckBox();
            this.test_ggs_yes = new System.Windows.Forms.CheckBox();
            this.test_result_yes = new System.Windows.Forms.CheckBox();
            this.test_result_ggs_err = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergency_stop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.test_result_yes);
            this.groupBox1.Controls.Add(this.test_result_ggs_err);
            this.groupBox1.Controls.Add(this.test_ggs_yes);
            this.groupBox1.Controls.Add(this.test_ggs_no_data);
            this.groupBox1.Controls.Add(this.ggs_on);
            this.groupBox1.Controls.Add(this.ggs_off);
            this.groupBox1.Controls.Add(this.fire_subdivision);
            this.groupBox1.Controls.Add(this.dispatcher);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(290, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "Результат теста ГГС ЛБ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(8, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Тест ГГС ЛБ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Состояние ГГС\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.no_battery);
            this.groupBox2.Controls.Add(this.battery_charge);
            this.groupBox2.Controls.Add(this.test_batery_go);
            this.groupBox2.Controls.Add(this.batt_support_no);
            this.groupBox2.Controls.Add(this.test_batery_ok);
            this.groupBox2.Controls.Add(this.batery_err);
            this.groupBox2.Controls.Add(this.power_device_basic);
            this.groupBox2.Controls.Add(this.power_device_backup);
            this.groupBox2.Controls.Add(this.change_mode_support_no);
            this.groupBox2.Controls.Add(this.change_mode_support_yes);
            this.groupBox2.Controls.Add(this.batt_support_yes);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(627, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные аккумулятора";
            // 
            // batt_support_no
            // 
            this.batt_support_no.AutoSize = true;
            this.batt_support_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batt_support_no.Location = new System.Drawing.Point(10, 43);
            this.batt_support_no.Name = "batt_support_no";
            this.batt_support_no.Size = new System.Drawing.Size(53, 22);
            this.batt_support_no.TabIndex = 29;
            this.batt_support_no.Text = "Нет";
            this.batt_support_no.UseVisualStyleBackColor = true;
            // 
            // test_batery_ok
            // 
            this.test_batery_ok.AutoSize = true;
            this.test_batery_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_batery_ok.Location = new System.Drawing.Point(9, 207);
            this.test_batery_ok.Name = "test_batery_ok";
            this.test_batery_ok.Size = new System.Drawing.Size(224, 40);
            this.test_batery_ok.TabIndex = 28;
            this.test_batery_ok.Text = "Тест аккумулятора успешно\r\nвыполнен\r\n";
            this.test_batery_ok.UseVisualStyleBackColor = true;
            this.test_batery_ok.CheckedChanged += new System.EventHandler(this.test_batery_ok_CheckedChanged);
            // 
            // batery_err
            // 
            this.batery_err.AutoSize = true;
            this.batery_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batery_err.Location = new System.Drawing.Point(9, 181);
            this.batery_err.Name = "batery_err";
            this.batery_err.Size = new System.Drawing.Size(204, 22);
            this.batery_err.TabIndex = 27;
            this.batery_err.Text = "Неисправен аккумулятор";
            this.batery_err.UseVisualStyleBackColor = true;
            // 
            // power_device_basic
            // 
            this.power_device_basic.AutoSize = true;
            this.power_device_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.power_device_basic.Location = new System.Drawing.Point(9, 153);
            this.power_device_basic.Name = "power_device_basic";
            this.power_device_basic.Size = new System.Drawing.Size(97, 22);
            this.power_device_basic.TabIndex = 26;
            this.power_device_basic.Text = "Основное";
            this.power_device_basic.UseVisualStyleBackColor = true;
            // 
            // power_device_backup
            // 
            this.power_device_backup.AutoSize = true;
            this.power_device_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.power_device_backup.Location = new System.Drawing.Point(119, 153);
            this.power_device_backup.Name = "power_device_backup";
            this.power_device_backup.Size = new System.Drawing.Size(102, 22);
            this.power_device_backup.TabIndex = 25;
            this.power_device_backup.Text = "Резервное";
            this.power_device_backup.UseVisualStyleBackColor = true;
            // 
            // change_mode_support_no
            // 
            this.change_mode_support_no.AutoSize = true;
            this.change_mode_support_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_mode_support_no.Location = new System.Drawing.Point(9, 107);
            this.change_mode_support_no.Name = "change_mode_support_no";
            this.change_mode_support_no.Size = new System.Drawing.Size(53, 22);
            this.change_mode_support_no.TabIndex = 24;
            this.change_mode_support_no.Text = "Нет";
            this.change_mode_support_no.UseVisualStyleBackColor = true;
            // 
            // change_mode_support_yes
            // 
            this.change_mode_support_yes.AutoSize = true;
            this.change_mode_support_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_mode_support_yes.Location = new System.Drawing.Point(119, 107);
            this.change_mode_support_yes.Name = "change_mode_support_yes";
            this.change_mode_support_yes.Size = new System.Drawing.Size(60, 22);
            this.change_mode_support_yes.TabIndex = 23;
            this.change_mode_support_yes.Text = "Есть";
            this.change_mode_support_yes.UseVisualStyleBackColor = true;
            // 
            // batt_support_yes
            // 
            this.batt_support_yes.AutoSize = true;
            this.batt_support_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batt_support_yes.Location = new System.Drawing.Point(119, 43);
            this.batt_support_yes.Name = "batt_support_yes";
            this.batt_support_yes.Size = new System.Drawing.Size(60, 22);
            this.batt_support_yes.TabIndex = 21;
            this.batt_support_yes.Text = "Есть";
            this.batt_support_yes.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(7, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 36);
            this.label19.TabIndex = 15;
            this.label19.Text = "Поддержка режима\r\nзаряда аккумулятора";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(7, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 18);
            this.label18.TabIndex = 14;
            this.label18.Text = "Питание устройства";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(7, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 18);
            this.label17.TabIndex = 13;
            this.label17.Text = "Поддержка аккумулятора";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.door_drive_work_time);
            this.groupBox3.Controls.Add(this.door_drive_inclusions);
            this.groupBox3.Controls.Add(this.main_drive_work_time);
            this.groupBox3.Controls.Add(this.main_drive_inclusions);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(290, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статистика работы приводов лифта";
            // 
            // door_drive_work_time
            // 
            this.door_drive_work_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.door_drive_work_time.Location = new System.Drawing.Point(197, 183);
            this.door_drive_work_time.Name = "door_drive_work_time";
            this.door_drive_work_time.Size = new System.Drawing.Size(100, 24);
            this.door_drive_work_time.TabIndex = 7;
            // 
            // door_drive_inclusions
            // 
            this.door_drive_inclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.door_drive_inclusions.Location = new System.Drawing.Point(197, 136);
            this.door_drive_inclusions.Name = "door_drive_inclusions";
            this.door_drive_inclusions.Size = new System.Drawing.Size(100, 24);
            this.door_drive_inclusions.TabIndex = 6;
            // 
            // main_drive_work_time
            // 
            this.main_drive_work_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_drive_work_time.Location = new System.Drawing.Point(197, 88);
            this.main_drive_work_time.Name = "main_drive_work_time";
            this.main_drive_work_time.Size = new System.Drawing.Size(100, 24);
            this.main_drive_work_time.TabIndex = 5;
            // 
            // main_drive_inclusions
            // 
            this.main_drive_inclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_drive_inclusions.Location = new System.Drawing.Point(197, 40);
            this.main_drive_inclusions.Name = "main_drive_inclusions";
            this.main_drive_inclusions.Size = new System.Drawing.Size(100, 24);
            this.main_drive_inclusions.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 36);
            this.label8.TabIndex = 3;
            this.label8.Text = "Время работы \r\nпривода дверей";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Количество включений \r\nпривода дверей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Время работы \r\nглавного привода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество включений \r\nглавного привода";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lift_status);
            this.groupBox4.Controls.Add(this.door_status);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.working_mode);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(627, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 271);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // lift_status
            // 
            this.lift_status.FormattingEnabled = true;
            this.lift_status.Location = new System.Drawing.Point(10, 94);
            this.lift_status.Name = "lift_status";
            this.lift_status.Size = new System.Drawing.Size(256, 95);
            this.lift_status.TabIndex = 19;
            // 
            // door_status
            // 
            this.door_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.door_status.Location = new System.Drawing.Point(9, 217);
            this.door_status.Multiline = true;
            this.door_status.Name = "door_status";
            this.door_status.Size = new System.Drawing.Size(257, 30);
            this.door_status.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Состояние дверей";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(7, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Состояние лифта";
            // 
            // working_mode
            // 
            this.working_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.working_mode.Location = new System.Drawing.Point(9, 37);
            this.working_mode.Multiline = true;
            this.working_mode.Name = "working_mode";
            this.working_mode.Size = new System.Drawing.Size(257, 30);
            this.working_mode.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Режим работы лифта";
            // 
            // lift
            // 
            this.lift.Location = new System.Drawing.Point(53, 132);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(182, 160);
            this.lift.TabIndex = 4;
            this.lift.TabStop = false;
            // 
            // floor
            // 
            this.floor.Location = new System.Drawing.Point(89, 26);
            this.floor.Multiline = true;
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(114, 44);
            this.floor.TabIndex = 5;
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(119, 76);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(48, 50);
            this.up.TabIndex = 6;
            this.up.TabStop = false;
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(119, 302);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(48, 50);
            this.down.TabIndex = 7;
            this.down.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Процент загруженности кабины:";
            // 
            // precent
            // 
            this.precent.AutoSize = true;
            this.precent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.precent.Location = new System.Drawing.Point(218, 403);
            this.precent.Name = "precent";
            this.precent.Size = new System.Drawing.Size(51, 20);
            this.precent.TabIndex = 10;
            this.precent.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(286, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Исполнение ЛБ Type";
            // 
            // lb_type
            // 
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_type.Location = new System.Drawing.Point(290, 40);
            this.lb_type.Multiline = true;
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(317, 30);
            this.lb_type.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(286, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Источник вызова";
            // 
            // call_source
            // 
            this.call_source.Location = new System.Drawing.Point(290, 103);
            this.call_source.Multiline = true;
            this.call_source.Name = "call_source";
            this.call_source.Size = new System.Drawing.Size(317, 30);
            this.call_source.TabIndex = 14;
            // 
            // passangers
            // 
            this.passangers.AutoSize = true;
            this.passangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passangers.Location = new System.Drawing.Point(30, 436);
            this.passangers.Name = "passangers";
            this.passangers.Size = new System.Drawing.Size(188, 24);
            this.passangers.TabIndex = 15;
            this.passangers.TabStop = true;
            this.passangers.Text = "Наличие пассажиров";
            this.passangers.UseVisualStyleBackColor = true;
            // 
            // workload
            // 
            this.workload.Location = new System.Drawing.Point(30, 400);
            this.workload.Name = "workload";
            this.workload.Size = new System.Drawing.Size(173, 23);
            this.workload.TabIndex = 9;
            // 
            // emergency_stop
            // 
            this.emergency_stop.Location = new System.Drawing.Point(30, 469);
            this.emergency_stop.Name = "emergency_stop";
            this.emergency_stop.Size = new System.Drawing.Size(48, 50);
            this.emergency_stop.TabIndex = 16;
            this.emergency_stop.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(85, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 40);
            this.label12.TabIndex = 17;
            this.label12.Text = "Аварийная\r\nостановка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(26, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Рестарт";
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.Location = new System.Drawing.Point(104, 528);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(176, 21);
            this.restart.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Версия программы:";
            // 
            // lb_appver
            // 
            this.lb_appver.AutoSize = true;
            this.lb_appver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_appver.Location = new System.Drawing.Point(189, 566);
            this.lb_appver.Name = "lb_appver";
            this.lb_appver.Size = new System.Drawing.Size(60, 20);
            this.lb_appver.TabIndex = 21;
            this.lb_appver.Text = "label20";
            // 
            // test_batery_go
            // 
            this.test_batery_go.AutoSize = true;
            this.test_batery_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_batery_go.Location = new System.Drawing.Point(9, 249);
            this.test_batery_go.Name = "test_batery_go";
            this.test_batery_go.Size = new System.Drawing.Size(257, 22);
            this.test_batery_go.TabIndex = 30;
            this.test_batery_go.Text = "Выполняется тест аккумулятора";
            this.test_batery_go.UseVisualStyleBackColor = true;
            // 
            // battery_charge
            // 
            this.battery_charge.AutoSize = true;
            this.battery_charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.battery_charge.Location = new System.Drawing.Point(9, 277);
            this.battery_charge.Name = "battery_charge";
            this.battery_charge.Size = new System.Drawing.Size(204, 22);
            this.battery_charge.TabIndex = 31;
            this.battery_charge.Text = "Аккумулятор заряжается";
            this.battery_charge.UseVisualStyleBackColor = true;
            // 
            // no_battery
            // 
            this.no_battery.AutoSize = true;
            this.no_battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no_battery.Location = new System.Drawing.Point(9, 305);
            this.no_battery.Name = "no_battery";
            this.no_battery.Size = new System.Drawing.Size(207, 22);
            this.no_battery.TabIndex = 32;
            this.no_battery.Text = "Отсутствует аккумулятор";
            this.no_battery.UseVisualStyleBackColor = true;
            // 
            // dispatcher
            // 
            this.dispatcher.AutoSize = true;
            this.dispatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispatcher.Location = new System.Drawing.Point(11, 15);
            this.dispatcher.Name = "dispatcher";
            this.dispatcher.Size = new System.Drawing.Size(157, 22);
            this.dispatcher.TabIndex = 11;
            this.dispatcher.Text = "Вызов диспетчера";
            this.dispatcher.UseVisualStyleBackColor = true;
            // 
            // fire_subdivision
            // 
            this.fire_subdivision.AutoSize = true;
            this.fire_subdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fire_subdivision.Location = new System.Drawing.Point(10, 42);
            this.fire_subdivision.Name = "fire_subdivision";
            this.fire_subdivision.Size = new System.Drawing.Size(224, 22);
            this.fire_subdivision.TabIndex = 12;
            this.fire_subdivision.Text = "Работает режим связи ППП";
            this.fire_subdivision.UseVisualStyleBackColor = true;
            // 
            // ggs_off
            // 
            this.ggs_off.AutoSize = true;
            this.ggs_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ggs_off.Location = new System.Drawing.Point(126, 89);
            this.ggs_off.Name = "ggs_off";
            this.ggs_off.Size = new System.Drawing.Size(108, 22);
            this.ggs_off.TabIndex = 13;
            this.ggs_off.Text = "Выключена";
            this.ggs_off.UseVisualStyleBackColor = true;
            // 
            // ggs_on
            // 
            this.ggs_on.AutoSize = true;
            this.ggs_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ggs_on.Location = new System.Drawing.Point(10, 89);
            this.ggs_on.Name = "ggs_on";
            this.ggs_on.Size = new System.Drawing.Size(97, 22);
            this.ggs_on.TabIndex = 14;
            this.ggs_on.Text = "Включена";
            this.ggs_on.UseVisualStyleBackColor = true;
            // 
            // test_ggs_no_data
            // 
            this.test_ggs_no_data.AutoSize = true;
            this.test_ggs_no_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_ggs_no_data.Location = new System.Drawing.Point(10, 135);
            this.test_ggs_no_data.Name = "test_ggs_no_data";
            this.test_ggs_no_data.Size = new System.Drawing.Size(108, 22);
            this.test_ggs_no_data.TabIndex = 15;
            this.test_ggs_no_data.Text = "Нет данных";
            this.test_ggs_no_data.UseVisualStyleBackColor = true;
            // 
            // test_ggs_yes
            // 
            this.test_ggs_yes.AutoSize = true;
            this.test_ggs_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_ggs_yes.Location = new System.Drawing.Point(124, 135);
            this.test_ggs_yes.Name = "test_ggs_yes";
            this.test_ggs_yes.Size = new System.Drawing.Size(47, 22);
            this.test_ggs_yes.TabIndex = 16;
            this.test_ggs_yes.Text = "Да";
            this.test_ggs_yes.UseVisualStyleBackColor = true;
            // 
            // test_result_yes
            // 
            this.test_result_yes.AutoSize = true;
            this.test_result_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_result_yes.Location = new System.Drawing.Point(124, 182);
            this.test_result_yes.Name = "test_result_yes";
            this.test_result_yes.Size = new System.Drawing.Size(47, 22);
            this.test_result_yes.TabIndex = 18;
            this.test_result_yes.Text = "Да";
            this.test_result_yes.UseVisualStyleBackColor = true;
            // 
            // test_result_ggs_err
            // 
            this.test_result_ggs_err.AutoSize = true;
            this.test_result_ggs_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_result_ggs_err.Location = new System.Drawing.Point(10, 182);
            this.test_result_ggs_err.Name = "test_result_ggs_err";
            this.test_result_ggs_err.Size = new System.Drawing.Size(83, 22);
            this.test_result_ggs_err.TabIndex = 17;
            this.test_result_ggs_err.Text = "Ошибка";
            this.test_result_ggs_err.UseVisualStyleBackColor = true;
            // 
            // LiftControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_appver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.emergency_stop);
            this.Controls.Add(this.passangers);
            this.Controls.Add(this.call_source);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.precent);
            this.Controls.Add(this.workload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.down);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.up);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LiftControl";
            this.Size = new System.Drawing.Size(928, 627);
            this.Load += new System.EventHandler(this.LiftControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergency_stop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox lift;
        private System.Windows.Forms.TextBox floor;
        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label precent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lb_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lift_status;
        private System.Windows.Forms.TextBox door_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox working_mode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox call_source;
        private System.Windows.Forms.RadioButton passangers;
        private System.Windows.Forms.ProgressBar workload;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox emergency_stop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox restart;
        private System.Windows.Forms.TextBox door_drive_work_time;
        private System.Windows.Forms.TextBox door_drive_inclusions;
        private System.Windows.Forms.TextBox main_drive_work_time;
        private System.Windows.Forms.TextBox main_drive_inclusions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_appver;
        private System.Windows.Forms.CheckBox batt_support_yes;
        private System.Windows.Forms.CheckBox change_mode_support_no;
        private System.Windows.Forms.CheckBox change_mode_support_yes;
        private System.Windows.Forms.CheckBox power_device_basic;
        private System.Windows.Forms.CheckBox power_device_backup;
        private System.Windows.Forms.CheckBox test_batery_ok;
        private System.Windows.Forms.CheckBox batery_err;
        private System.Windows.Forms.CheckBox batt_support_no;
        private System.Windows.Forms.CheckBox no_battery;
        private System.Windows.Forms.CheckBox battery_charge;
        private System.Windows.Forms.CheckBox test_batery_go;
        private System.Windows.Forms.CheckBox test_result_yes;
        private System.Windows.Forms.CheckBox test_result_ggs_err;
        private System.Windows.Forms.CheckBox test_ggs_yes;
        private System.Windows.Forms.CheckBox test_ggs_no_data;
        private System.Windows.Forms.CheckBox ggs_on;
        private System.Windows.Forms.CheckBox ggs_off;
        private System.Windows.Forms.CheckBox fire_subdivision;
        private System.Windows.Forms.CheckBox dispatcher;
    }
}
