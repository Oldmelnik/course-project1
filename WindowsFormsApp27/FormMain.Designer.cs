namespace WindowsFormsApp27
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCarModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDriverClassDr = new System.Windows.Forms.TextBox();
            this.TxtDriverFio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOrdWidth = new System.Windows.Forms.TextBox();
            this.TxtOrdFinish = new System.Windows.Forms.TextBox();
            this.TxtOrdStart = new System.Windows.Forms.TextBox();
            this.TxtOrdName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCarMaxOrd = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCarPrice = new System.Windows.Forms.TextBox();
            this.TxtCarLenTruck = new System.Windows.Forms.TextBox();
            this.TxtCarConsumption = new System.Windows.Forms.TextBox();
            this.TxtCarCapacity = new System.Windows.Forms.TextBox();
            this.TxtCarNum = new System.Windows.Forms.TextBox();
            this.TxtCarFirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboCarId = new System.Windows.Forms.ComboBox();
            this.DGVCar = new System.Windows.Forms.DataGridView();
            this.BtnCarEdit = new System.Windows.Forms.Button();
            this.BtnCarDel = new System.Windows.Forms.Button();
            this.BtnCarInp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnShowAllDrivers = new System.Windows.Forms.Button();
            this.BtnDriversWithoutSec = new System.Windows.Forms.Button();
            this.BtnDriverMaxOrd = new System.Windows.Forms.Button();
            this.ComboDriverSecDr = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtDriverExp = new System.Windows.Forms.TextBox();
            this.TxtDriverPassport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ComboDriverId = new System.Windows.Forms.ComboBox();
            this.DGVDriver = new System.Windows.Forms.DataGridView();
            this.BtnDriverEdit = new System.Windows.Forms.Button();
            this.BtnDriverDel = new System.Windows.Forms.Button();
            this.BtnDriverInp = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnTotalPriceOrd = new System.Windows.Forms.Button();
            this.BtnSortOrdByWidth = new System.Windows.Forms.Button();
            this.BtnSortOrdByLenWay = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtOrdLength = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboOrdDriver = new System.Windows.Forms.ComboBox();
            this.ComboOrdCar = new System.Windows.Forms.ComboBox();
            this.ComboOrdId = new System.Windows.Forms.ComboBox();
            this.DGVOrd = new System.Windows.Forms.DataGridView();
            this.BtnOrdEdit = new System.Windows.Forms.Button();
            this.BtnOrdDel = new System.Windows.Forms.Button();
            this.BtnOrdInpt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDriver)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrd)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCarModel
            // 
            this.TxtCarModel.Location = new System.Drawing.Point(6, 32);
            this.TxtCarModel.Name = "TxtCarModel";
            this.TxtCarModel.Size = new System.Drawing.Size(100, 20);
            this.TxtCarModel.TabIndex = 1;
            this.TxtCarModel.TextChanged += new System.EventHandler(this.TxtCarModel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фирма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Гос. номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Грузоподъемность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расход топлива";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Напарник";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Паспорт";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ФИО";
            // 
            // TxtDriverClassDr
            // 
            this.TxtDriverClassDr.Location = new System.Drawing.Point(22, 164);
            this.TxtDriverClassDr.Name = "TxtDriverClassDr";
            this.TxtDriverClassDr.Size = new System.Drawing.Size(100, 20);
            this.TxtDriverClassDr.TabIndex = 14;
            // 
            // TxtDriverFio
            // 
            this.TxtDriverFio.Location = new System.Drawing.Point(16, 31);
            this.TxtDriverFio.Name = "TxtDriverFio";
            this.TxtDriverFio.Size = new System.Drawing.Size(100, 20);
            this.TxtDriverFio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Вес";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Пункт назначения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Название";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Пункт отправления";
            // 
            // TxtOrdWidth
            // 
            this.TxtOrdWidth.Location = new System.Drawing.Point(17, 180);
            this.TxtOrdWidth.Name = "TxtOrdWidth";
            this.TxtOrdWidth.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdWidth.TabIndex = 25;
            // 
            // TxtOrdFinish
            // 
            this.TxtOrdFinish.Location = new System.Drawing.Point(14, 99);
            this.TxtOrdFinish.Name = "TxtOrdFinish";
            this.TxtOrdFinish.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdFinish.TabIndex = 24;
            // 
            // TxtOrdStart
            // 
            this.TxtOrdStart.Location = new System.Drawing.Point(14, 61);
            this.TxtOrdStart.Name = "TxtOrdStart";
            this.TxtOrdStart.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdStart.TabIndex = 23;
            // 
            // TxtOrdName
            // 
            this.TxtOrdName.Location = new System.Drawing.Point(14, 21);
            this.TxtOrdName.Name = "TxtOrdName";
            this.TxtOrdName.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdName.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1371, 524);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.BtnCarMaxOrd);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.TxtCarPrice);
            this.tabPage1.Controls.Add(this.TxtCarLenTruck);
            this.tabPage1.Controls.Add(this.TxtCarConsumption);
            this.tabPage1.Controls.Add(this.TxtCarCapacity);
            this.tabPage1.Controls.Add(this.TxtCarNum);
            this.tabPage1.Controls.Add(this.TxtCarFirm);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ComboCarId);
            this.tabPage1.Controls.Add(this.DGVCar);
            this.tabPage1.Controls.Add(this.BtnCarEdit);
            this.tabPage1.Controls.Add(this.BtnCarDel);
            this.tabPage1.Controls.Add(this.BtnCarInp);
            this.tabPage1.Controls.Add(this.TxtCarModel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1363, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Трейлер";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1250, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "connet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCarMaxOrd
            // 
            this.BtnCarMaxOrd.Location = new System.Drawing.Point(1250, 391);
            this.BtnCarMaxOrd.Name = "BtnCarMaxOrd";
            this.BtnCarMaxOrd.Size = new System.Drawing.Size(109, 77);
            this.BtnCarMaxOrd.TabIndex = 56;
            this.BtnCarMaxOrd.Text = "Трейлер с максимальным количеством заказов";
            this.BtnCarMaxOrd.UseVisualStyleBackColor = true;
            this.BtnCarMaxOrd.Click += new System.EventHandler(this.BtnCarMaxOrd_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 249);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Перевозка руб/км";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 210);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Длина прицепа";
            // 
            // TxtCarPrice
            // 
            this.TxtCarPrice.Location = new System.Drawing.Point(9, 264);
            this.TxtCarPrice.Name = "TxtCarPrice";
            this.TxtCarPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtCarPrice.TabIndex = 53;
            // 
            // TxtCarLenTruck
            // 
            this.TxtCarLenTruck.Location = new System.Drawing.Point(6, 226);
            this.TxtCarLenTruck.Name = "TxtCarLenTruck";
            this.TxtCarLenTruck.Size = new System.Drawing.Size(100, 20);
            this.TxtCarLenTruck.TabIndex = 52;
            // 
            // TxtCarConsumption
            // 
            this.TxtCarConsumption.Location = new System.Drawing.Point(6, 187);
            this.TxtCarConsumption.Name = "TxtCarConsumption";
            this.TxtCarConsumption.Size = new System.Drawing.Size(100, 20);
            this.TxtCarConsumption.TabIndex = 48;
            // 
            // TxtCarCapacity
            // 
            this.TxtCarCapacity.Location = new System.Drawing.Point(6, 148);
            this.TxtCarCapacity.Name = "TxtCarCapacity";
            this.TxtCarCapacity.Size = new System.Drawing.Size(100, 20);
            this.TxtCarCapacity.TabIndex = 47;
            // 
            // TxtCarNum
            // 
            this.TxtCarNum.Location = new System.Drawing.Point(6, 107);
            this.TxtCarNum.Name = "TxtCarNum";
            this.TxtCarNum.Size = new System.Drawing.Size(100, 20);
            this.TxtCarNum.TabIndex = 46;
            // 
            // TxtCarFirm
            // 
            this.TxtCarFirm.Location = new System.Drawing.Point(6, 70);
            this.TxtCarFirm.Name = "TxtCarFirm";
            this.TxtCarFirm.Size = new System.Drawing.Size(100, 20);
            this.TxtCarFirm.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Id трейлера";
            // 
            // ComboCarId
            // 
            this.ComboCarId.FormattingEnabled = true;
            this.ComboCarId.Location = new System.Drawing.Point(9, 356);
            this.ComboCarId.Name = "ComboCarId";
            this.ComboCarId.Size = new System.Drawing.Size(121, 21);
            this.ComboCarId.TabIndex = 43;
            this.ComboCarId.SelectedIndexChanged += new System.EventHandler(this.ComboCarId_SelectedIndexChanged);
            this.ComboCarId.Enter += new System.EventHandler(this.ComboCarId_Enter);
            // 
            // DGVCar
            // 
            this.DGVCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCar.Location = new System.Drawing.Point(136, -11);
            this.DGVCar.Name = "DGVCar";
            this.DGVCar.Size = new System.Drawing.Size(1089, 472);
            this.DGVCar.TabIndex = 37;
            this.DGVCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCar_CellContentClick);
            // 
            // BtnCarEdit
            // 
            this.BtnCarEdit.Location = new System.Drawing.Point(6, 429);
            this.BtnCarEdit.Name = "BtnCarEdit";
            this.BtnCarEdit.Size = new System.Drawing.Size(124, 41);
            this.BtnCarEdit.TabIndex = 36;
            this.BtnCarEdit.Text = "Изменить трейлер";
            this.BtnCarEdit.UseVisualStyleBackColor = true;
            this.BtnCarEdit.Click += new System.EventHandler(this.BtnCarEdit_Click);
            // 
            // BtnCarDel
            // 
            this.BtnCarDel.Location = new System.Drawing.Point(6, 383);
            this.BtnCarDel.Name = "BtnCarDel";
            this.BtnCarDel.Size = new System.Drawing.Size(124, 40);
            this.BtnCarDel.TabIndex = 35;
            this.BtnCarDel.Text = "Удалить трейлер";
            this.BtnCarDel.UseVisualStyleBackColor = true;
            this.BtnCarDel.Click += new System.EventHandler(this.BtnCarDel_Click);
            // 
            // BtnCarInp
            // 
            this.BtnCarInp.Location = new System.Drawing.Point(9, 300);
            this.BtnCarInp.Name = "BtnCarInp";
            this.BtnCarInp.Size = new System.Drawing.Size(111, 37);
            this.BtnCarInp.TabIndex = 34;
            this.BtnCarInp.Text = "Добавить трейлер";
            this.BtnCarInp.UseVisualStyleBackColor = true;
            this.BtnCarInp.Click += new System.EventHandler(this.BtnCarInp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnShowAllDrivers);
            this.tabPage2.Controls.Add(this.BtnDriversWithoutSec);
            this.tabPage2.Controls.Add(this.BtnDriverMaxOrd);
            this.tabPage2.Controls.Add(this.ComboDriverSecDr);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.TxtDriverExp);
            this.tabPage2.Controls.Add(this.TxtDriverPassport);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.ComboDriverId);
            this.tabPage2.Controls.Add(this.DGVDriver);
            this.tabPage2.Controls.Add(this.BtnDriverEdit);
            this.tabPage2.Controls.Add(this.BtnDriverDel);
            this.tabPage2.Controls.Add(this.BtnDriverInp);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TxtDriverFio);
            this.tabPage2.Controls.Add(this.TxtDriverClassDr);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1363, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Водитель";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // BtnShowAllDrivers
            // 
            this.BtnShowAllDrivers.Location = new System.Drawing.Point(825, 187);
            this.BtnShowAllDrivers.Name = "BtnShowAllDrivers";
            this.BtnShowAllDrivers.Size = new System.Drawing.Size(109, 58);
            this.BtnShowAllDrivers.TabIndex = 59;
            this.BtnShowAllDrivers.Text = "Вывести всех водителей";
            this.BtnShowAllDrivers.UseVisualStyleBackColor = true;
            this.BtnShowAllDrivers.Click += new System.EventHandler(this.BtnShowAllDrivers_Click);
            // 
            // BtnDriversWithoutSec
            // 
            this.BtnDriversWithoutSec.Location = new System.Drawing.Point(825, 103);
            this.BtnDriversWithoutSec.Name = "BtnDriversWithoutSec";
            this.BtnDriversWithoutSec.Size = new System.Drawing.Size(109, 58);
            this.BtnDriversWithoutSec.TabIndex = 58;
            this.BtnDriversWithoutSec.Text = "Вывести водителей без напарников";
            this.BtnDriversWithoutSec.UseVisualStyleBackColor = true;
            this.BtnDriversWithoutSec.Click += new System.EventHandler(this.BtnDriversWithoutSec_Click);
            // 
            // BtnDriverMaxOrd
            // 
            this.BtnDriverMaxOrd.Location = new System.Drawing.Point(825, 12);
            this.BtnDriverMaxOrd.Name = "BtnDriverMaxOrd";
            this.BtnDriverMaxOrd.Size = new System.Drawing.Size(109, 77);
            this.BtnDriverMaxOrd.TabIndex = 57;
            this.BtnDriverMaxOrd.Text = "Водитель с максимальным количеством заказов";
            this.BtnDriverMaxOrd.UseVisualStyleBackColor = true;
            this.BtnDriverMaxOrd.Click += new System.EventHandler(this.BtnDriverMaxOrd_Click);
            // 
            // ComboDriverSecDr
            // 
            this.ComboDriverSecDr.FormattingEnabled = true;
            this.ComboDriverSecDr.Location = new System.Drawing.Point(16, 119);
            this.ComboDriverSecDr.Name = "ComboDriverSecDr";
            this.ComboDriverSecDr.Size = new System.Drawing.Size(121, 21);
            this.ComboDriverSecDr.TabIndex = 53;
            this.ComboDriverSecDr.Enter += new System.EventHandler(this.ComboDriverSecDr_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 187);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "Стаж работы";
            // 
            // TxtDriverExp
            // 
            this.TxtDriverExp.Location = new System.Drawing.Point(22, 207);
            this.TxtDriverExp.Name = "TxtDriverExp";
            this.TxtDriverExp.Size = new System.Drawing.Size(100, 20);
            this.TxtDriverExp.TabIndex = 51;
            // 
            // TxtDriverPassport
            // 
            this.TxtDriverPassport.Location = new System.Drawing.Point(16, 80);
            this.TxtDriverPassport.Name = "TxtDriverPassport";
            this.TxtDriverPassport.Size = new System.Drawing.Size(100, 20);
            this.TxtDriverPassport.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Классность";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 308);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "Id водителя";
            // 
            // ComboDriverId
            // 
            this.ComboDriverId.FormattingEnabled = true;
            this.ComboDriverId.Location = new System.Drawing.Point(16, 333);
            this.ComboDriverId.Name = "ComboDriverId";
            this.ComboDriverId.Size = new System.Drawing.Size(106, 21);
            this.ComboDriverId.TabIndex = 24;
            this.ComboDriverId.SelectedIndexChanged += new System.EventHandler(this.ComboDriverId_SelectedIndexChanged);
            this.ComboDriverId.Enter += new System.EventHandler(this.ComboMaserId_Enter);
            // 
            // DGVDriver
            // 
            this.DGVDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDriver.Location = new System.Drawing.Point(150, 12);
            this.DGVDriver.Name = "DGVDriver";
            this.DGVDriver.Size = new System.Drawing.Size(648, 443);
            this.DGVDriver.TabIndex = 23;
            this.DGVDriver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDriver_CellContentClick);
            // 
            // BtnDriverEdit
            // 
            this.BtnDriverEdit.Location = new System.Drawing.Point(16, 417);
            this.BtnDriverEdit.Name = "BtnDriverEdit";
            this.BtnDriverEdit.Size = new System.Drawing.Size(86, 38);
            this.BtnDriverEdit.TabIndex = 22;
            this.BtnDriverEdit.Text = "Изменить водителя";
            this.BtnDriverEdit.UseVisualStyleBackColor = true;
            this.BtnDriverEdit.Click += new System.EventHandler(this.BtnDriverEdit_Click);
            // 
            // BtnDriverDel
            // 
            this.BtnDriverDel.Location = new System.Drawing.Point(16, 361);
            this.BtnDriverDel.Name = "BtnDriverDel";
            this.BtnDriverDel.Size = new System.Drawing.Size(86, 40);
            this.BtnDriverDel.TabIndex = 21;
            this.BtnDriverDel.Text = "Удалить водителя";
            this.BtnDriverDel.UseVisualStyleBackColor = true;
            this.BtnDriverDel.Click += new System.EventHandler(this.BtnDriverDel_Click);
            // 
            // BtnDriverInp
            // 
            this.BtnDriverInp.Location = new System.Drawing.Point(16, 252);
            this.BtnDriverInp.Name = "BtnDriverInp";
            this.BtnDriverInp.Size = new System.Drawing.Size(122, 23);
            this.BtnDriverInp.TabIndex = 20;
            this.BtnDriverInp.Text = "Добавить водителя";
            this.BtnDriverInp.UseVisualStyleBackColor = true;
            this.BtnDriverInp.Click += new System.EventHandler(this.BtnDriverInp_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnTotalPriceOrd);
            this.tabPage3.Controls.Add(this.BtnSortOrdByWidth);
            this.tabPage3.Controls.Add(this.BtnSortOrdByLenWay);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.TxtOrdLength);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.ComboOrdDriver);
            this.tabPage3.Controls.Add(this.ComboOrdCar);
            this.tabPage3.Controls.Add(this.ComboOrdId);
            this.tabPage3.Controls.Add(this.DGVOrd);
            this.tabPage3.Controls.Add(this.BtnOrdEdit);
            this.tabPage3.Controls.Add(this.BtnOrdDel);
            this.tabPage3.Controls.Add(this.BtnOrdInpt);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.TxtOrdName);
            this.tabPage3.Controls.Add(this.TxtOrdStart);
            this.tabPage3.Controls.Add(this.TxtOrdFinish);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.TxtOrdWidth);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1363, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // BtnTotalPriceOrd
            // 
            this.BtnTotalPriceOrd.Location = new System.Drawing.Point(1276, 139);
            this.BtnTotalPriceOrd.Name = "BtnTotalPriceOrd";
            this.BtnTotalPriceOrd.Size = new System.Drawing.Size(104, 47);
            this.BtnTotalPriceOrd.TabIndex = 56;
            this.BtnTotalPriceOrd.Text = "Вывести общую прибыль";
            this.BtnTotalPriceOrd.UseVisualStyleBackColor = true;
            this.BtnTotalPriceOrd.Click += new System.EventHandler(this.BtnTotalPriceOrd_Click);
            // 
            // BtnSortOrdByWidth
            // 
            this.BtnSortOrdByWidth.Location = new System.Drawing.Point(1276, 84);
            this.BtnSortOrdByWidth.Name = "BtnSortOrdByWidth";
            this.BtnSortOrdByWidth.Size = new System.Drawing.Size(104, 47);
            this.BtnSortOrdByWidth.TabIndex = 55;
            this.BtnSortOrdByWidth.Text = "Сортировать по весу";
            this.BtnSortOrdByWidth.UseVisualStyleBackColor = true;
            this.BtnSortOrdByWidth.Click += new System.EventHandler(this.BtnSortOrdByWidth_Click);
            // 
            // BtnSortOrdByLenWay
            // 
            this.BtnSortOrdByLenWay.Location = new System.Drawing.Point(1276, 27);
            this.BtnSortOrdByLenWay.Name = "BtnSortOrdByLenWay";
            this.BtnSortOrdByLenWay.Size = new System.Drawing.Size(104, 47);
            this.BtnSortOrdByLenWay.TabIndex = 54;
            this.BtnSortOrdByLenWay.Text = "Сортировать по расстоянию";
            this.BtnSortOrdByLenWay.UseVisualStyleBackColor = true;
            this.BtnSortOrdByLenWay.Click += new System.EventHandler(this.BtnSortOrdByLenWay_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Расстояние";
            // 
            // TxtOrdLength
            // 
            this.TxtOrdLength.Location = new System.Drawing.Point(12, 136);
            this.TxtOrdLength.Name = "TxtOrdLength";
            this.TxtOrdLength.Size = new System.Drawing.Size(100, 20);
            this.TxtOrdLength.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 329);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Id Заказа";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Id Водителя";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Id Трейлера";
            // 
            // ComboOrdDriver
            // 
            this.ComboOrdDriver.FormattingEnabled = true;
            this.ComboOrdDriver.Location = new System.Drawing.Point(14, 262);
            this.ComboOrdDriver.Name = "ComboOrdDriver";
            this.ComboOrdDriver.Size = new System.Drawing.Size(103, 21);
            this.ComboOrdDriver.TabIndex = 38;
            this.ComboOrdDriver.Enter += new System.EventHandler(this.ComboOrdDriver_Enter);
            // 
            // ComboOrdCar
            // 
            this.ComboOrdCar.FormattingEnabled = true;
            this.ComboOrdCar.Location = new System.Drawing.Point(14, 220);
            this.ComboOrdCar.Name = "ComboOrdCar";
            this.ComboOrdCar.Size = new System.Drawing.Size(103, 21);
            this.ComboOrdCar.TabIndex = 37;
            this.ComboOrdCar.Enter += new System.EventHandler(this.ComboOrdCar_Enter);
            // 
            // ComboOrdId
            // 
            this.ComboOrdId.FormattingEnabled = true;
            this.ComboOrdId.Location = new System.Drawing.Point(14, 344);
            this.ComboOrdId.Name = "ComboOrdId";
            this.ComboOrdId.Size = new System.Drawing.Size(103, 21);
            this.ComboOrdId.TabIndex = 36;
            this.ComboOrdId.SelectedIndexChanged += new System.EventHandler(this.ComboOrdId_SelectedIndexChanged);
            this.ComboOrdId.Enter += new System.EventHandler(this.ComboKeyId_Enter);
            // 
            // DGVOrd
            // 
            this.DGVOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrd.Location = new System.Drawing.Point(164, 3);
            this.DGVOrd.Name = "DGVOrd";
            this.DGVOrd.Size = new System.Drawing.Size(1106, 446);
            this.DGVOrd.TabIndex = 35;
            // 
            // BtnOrdEdit
            // 
            this.BtnOrdEdit.Location = new System.Drawing.Point(14, 413);
            this.BtnOrdEdit.Name = "BtnOrdEdit";
            this.BtnOrdEdit.Size = new System.Drawing.Size(100, 45);
            this.BtnOrdEdit.TabIndex = 34;
            this.BtnOrdEdit.Text = "Изменить заказ";
            this.BtnOrdEdit.UseVisualStyleBackColor = true;
            this.BtnOrdEdit.Click += new System.EventHandler(this.BtnOrdEdit_Click);
            // 
            // BtnOrdDel
            // 
            this.BtnOrdDel.Location = new System.Drawing.Point(14, 371);
            this.BtnOrdDel.Name = "BtnOrdDel";
            this.BtnOrdDel.Size = new System.Drawing.Size(100, 36);
            this.BtnOrdDel.TabIndex = 33;
            this.BtnOrdDel.Text = "Удалить заказ";
            this.BtnOrdDel.UseVisualStyleBackColor = true;
            this.BtnOrdDel.Click += new System.EventHandler(this.BtnOrdDel_Click);
            // 
            // BtnOrdInpt
            // 
            this.BtnOrdInpt.Location = new System.Drawing.Point(14, 289);
            this.BtnOrdInpt.Name = "BtnOrdInpt";
            this.BtnOrdInpt.Size = new System.Drawing.Size(100, 37);
            this.BtnOrdInpt.TabIndex = 32;
            this.BtnOrdInpt.Text = "Добавить заказ";
            this.BtnOrdInpt.UseVisualStyleBackColor = true;
            this.BtnOrdInpt.Click += new System.EventHandler(this.BtnOrdInpt_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDriver)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCarModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDriverClassDr;
        private System.Windows.Forms.TextBox TxtDriverFio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOrdWidth;
        private System.Windows.Forms.TextBox TxtOrdFinish;
        private System.Windows.Forms.TextBox TxtOrdStart;
        private System.Windows.Forms.TextBox TxtOrdName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnCarEdit;
        private System.Windows.Forms.Button BtnCarDel;
        private System.Windows.Forms.Button BtnCarInp;
        private System.Windows.Forms.Button BtnDriverEdit;
        private System.Windows.Forms.Button BtnDriverDel;
        private System.Windows.Forms.Button BtnDriverInp;
        private System.Windows.Forms.Button BtnOrdEdit;
        private System.Windows.Forms.Button BtnOrdDel;
        private System.Windows.Forms.Button BtnOrdInpt;
        private System.Windows.Forms.DataGridView DGVCar;
        private System.Windows.Forms.DataGridView DGVOrd;
        private System.Windows.Forms.DataGridView DGVDriver;
        private System.Windows.Forms.ComboBox ComboCarId;
        private System.Windows.Forms.ComboBox ComboDriverId;
        private System.Windows.Forms.ComboBox ComboOrdId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtCarFirm;
        private System.Windows.Forms.TextBox TxtCarConsumption;
        private System.Windows.Forms.TextBox TxtCarCapacity;
        private System.Windows.Forms.TextBox TxtCarNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboOrdDriver;
        private System.Windows.Forms.ComboBox ComboOrdCar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtCarPrice;
        private System.Windows.Forms.TextBox TxtCarLenTruck;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtDriverExp;
        private System.Windows.Forms.TextBox TxtDriverPassport;
        private System.Windows.Forms.ComboBox ComboDriverSecDr;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TxtOrdLength;
        private System.Windows.Forms.Button BtnSortOrdByLenWay;
        private System.Windows.Forms.Button BtnSortOrdByWidth;
        private System.Windows.Forms.Button BtnCarMaxOrd;
        private System.Windows.Forms.Button BtnDriverMaxOrd;
        private System.Windows.Forms.Button BtnShowAllDrivers;
        private System.Windows.Forms.Button BtnDriversWithoutSec;
        private System.Windows.Forms.Button BtnTotalPriceOrd;
        private System.Windows.Forms.Button button1;
    }
}

