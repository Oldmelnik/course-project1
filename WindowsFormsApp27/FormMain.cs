/*
# Практическая работа по профессиональному модулю МДК.03.01 "Прикладное программирование"
# Название: Автотранспортное предприятие
# Разработал: Смирнов Юрий, группа ТМП-72,
# Дата и номер версии: 16.1.2021 v1.0
# Язык: C#
# Краткое описание: 
#   Данная программа является информационной системой для автотранспортного предприятия.
# Задание:
#   Разработать информационную систему, предназначенную для работников автотранспортного предприятия.
# Предприятие владеет парком трейлеров. Трейлерлер характеризуется номерным знаком, маркой, фирмой,
# грузоподъемностью, расходом топлива на 100 км, длиной прицепа, стоимостью перевозки (руб/км), водителем.
# Имеются также водители: паспортные данные, стаж работы, классность, напарник (описывается так же как
# водитель). Предприятие получает заказы на перевозку товаров: количество мест, пункт отправления,
# пункт назначения, расстояние (км), трейлер, водитель. При расстоянии перевозки до 500 км
# водитель едет без напарника.
# Форма:
# FormMain - основная форма программы.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp27
{
    public partial class FormMain : Form
    {

                                                                                // Инициализация объектов окна
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtClientType_TextChanged(object sender, EventArgs e)
        {

        }

        // Кнопка добавления объекта трейлера
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnCarInp_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    Car c = new Car() { Model = TxtCarModel.Text, Firm = TxtCarFirm.Text, Num = TxtCarNum.Text, Capacity = int.Parse(TxtCarCapacity.Text), Consumption = int.Parse(TxtCarConsumption.Text), LenTruck = int.Parse(TxtCarLenTruck.Text), Price = double.Parse(TxtCarConsumption.Text) };
                    db.Cars.Add(c);
                    db.SaveChanges();
                }
                UpdDGVCar();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить трейлер", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка удаления объекта трейлера
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnCarDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    Car c = db.Cars.Find(int.Parse(ComboCarId.Text));
                    db.Cars.Remove(c);
                    db.SaveChanges();
                }
                UpdDGVCar();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить трейлер", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка изменения объекта трейлера
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnCarEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    int ind = int.Parse(ComboCarId.Text);
                    if (ind == -1)
                    {
                        throw new Exception("Null");
                    }
                    Car c = db.Cars.Find(ind);
                    c.Model = TxtCarModel.Text;
                    c.Firm = TxtCarFirm.Text;
                    c.Num = TxtCarNum.Text;
                    c.Capacity = int.Parse(TxtCarCapacity.Text);
                    c.Consumption = int.Parse(TxtCarConsumption.Text);
                    c.LenTruck = int.Parse(TxtCarLenTruck.Text);
                    c.Price = double.Parse(TxtCarConsumption.Text);

                    db.SaveChanges();
                }
                UpdDGVCar();
            }
            catch
            {
                MessageBox.Show("Не удалось изменить трейлер", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка добавления объекта водителя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnDriverInp_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    Driver d = new Driver() { FIO = TxtDriverFio.Text, Passport = TxtDriverPassport.Text, SecDr = int.Parse(ComboDriverSecDr.Text), ClassDr = int.Parse(TxtDriverClassDr.Text), Exp = int.Parse(TxtDriverExp.Text) };
                    db.Drivers.Add(d);
                    db.SaveChanges();
                }
                UpdDGVDriver();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить водителя", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка удаления объекта водителя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnDriverDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    Driver d = db.Drivers.Find(int.Parse(ComboDriverId.Text));
                    db.Drivers.Remove(d);
                    db.SaveChanges();
                }
                UpdDGVDriver();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить водителя", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка изменения объекта водителя
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnDriverEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    int ind = int.Parse(ComboDriverId.Text);
                    if (ind == -1)
                    {
                        throw new Exception("Null");
                    }
                    Driver d = db.Drivers.Find(ind);
                    d.FIO = TxtDriverFio.Text;
                    d.Passport = TxtDriverPassport.Text;
                    d.SecDr = int.Parse(ComboDriverSecDr.Text);
                    d.ClassDr = int.Parse(TxtDriverClassDr.Text);
                    d.Exp = int.Parse(TxtDriverExp.Text);
                    db.SaveChanges();
                }
                UpdDGVDriver();
            }
            catch
            {
                MessageBox.Show("Не удалось изменить водителя", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка добавления объекта заказа
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnOrdInpt_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    Ord o = new Ord() { Name = TxtOrdName.Text, Start = TxtOrdStart.Text, Finish = TxtOrdFinish.Text, Length = int.Parse(TxtOrdLength.Text), Width = int.Parse(TxtOrdWidth.Text), CarId = int.Parse(ComboOrdCar.Text), DriverId = int.Parse(ComboOrdDriver.Text) };
                    db.Ords.Add(o);
                    db.SaveChanges();
                }
                UpdDGVOrd();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить заказ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка удаления объекта заказа
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnOrdDel_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    Ord o = db.Ords.Find(int.Parse(ComboOrdId.Text));
                    db.Ords.Remove(o);
                    db.SaveChanges();
                }
                UpdDGVOrd();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить заказ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Кнопка изменения объекта заказа
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void BtnOrdEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Db db = new Db())
                {
                    int ind = int.Parse(ComboOrdId.Text);
                    if (ind == -1)
                    {
                        throw new Exception("Null");
                    }
                    Ord o = db.Ords.Find(ind);
                    o.Name = TxtOrdName.Text;
                    o.Start = TxtOrdStart.Text;
                    o.Finish = TxtOrdFinish.Text;
                    o.Length = int.Parse(TxtOrdLength.Text);
                    o.Width = int.Parse(TxtOrdWidth.Text);
                    o.CarId = int.Parse(ComboOrdCar.Text);
                    o.DriverId = int.Parse(ComboOrdDriver.Text);
                    db.SaveChanges();
                }
                UpdDGVOrd();
            }
            catch
            {
                MessageBox.Show("Не удалось изменить заказ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Открытие вкладки услуг
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            UpdDGVOrd();
        }

        // Открытие вкладки мастеров
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            UpdDGVDriver();
        }

        // Открытие вкладки клиентов
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            UpdDGVCar();
        }

        // Обновление таблицы услуг
        /*
            Логальные параметры:
            db - указатель на базу данных;
            bs - источник данных.
        */
        void UpdDGVOrd()
        {
            using (Db db = new Db())
            {
                BindingSource bs = new BindingSource();
                //bs.DataSource = db.Ords.ToList();
                DGVOrd.DataSource = bs;
            }
        }

        // Обновление таблицы мастеров
        /*
            Логальные параметры:
            db - указатель на базу данных;
            bs - источник данных.
        */
        void UpdDGVDriver()
        {
            using (Db db = new Db())
            {
                BindingSource bs = new BindingSource();
                //bs.DataSource = db.Drivers.ToList();
                DGVDriver.DataSource = bs;
            }
        }

        // Обновление таблицы клиентов
        /*
            Логальные параметры:
            db - указатель на базу данных;
            bs - источник данных.
        */
        void UpdDGVCar()
        {
            using (Db db = new Db())
            {
                BindingSource bs = new BindingSource();

               // bs.DataSource = db.Cars.ToList();

                DGVCar.DataSource = bs;
            }
        }

        

        // Открытие списка клиентов
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void ComboCarId_Enter(object sender, EventArgs e)
        {
            ComboCarId.Items.Clear();
            UpdDGVCar();
            for (int i = 0; i < DGVCar.Rows.Count-1; i++)
            {
                ComboCarId.Items.Add(DGVCar.Rows[i].Cells[0].Value.ToString());
            }
        }

        // Открытие списка путевок
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void ComboMaserId_Enter(object sender, EventArgs e)
        {
            ComboDriverId.Items.Clear();
            UpdDGVDriver();
            for (int i = 0; i < DGVDriver.Rows.Count - 1; i++)
            {
                ComboDriverId.Items.Add(DGVDriver.Rows[i].Cells[0].Value.ToString());

            }
        }

        // Открытие списка услуг
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
        */
        private void ComboKeyId_Enter(object sender, EventArgs e)
        {
            ComboOrdId.Items.Clear();
            UpdDGVOrd();
            for (int i = 0; i < DGVOrd.Rows.Count - 1; i++)
            {
                ComboOrdId.Items.Add(DGVOrd.Rows[i].Cells[0].Value.ToString());
            }
        }





        // Заполнение текстовых полей по выбранному трейлеру
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            db - база данных;
            c - объект клиента.
        */
        private void ComboCarId_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                Car c = db.Cars.Find(int.Parse(ComboCarId.Text));
                TxtCarModel.Text = c.Model;
                TxtCarFirm.Text = c.Firm;
                TxtCarNum.Text = c.Num;
                TxtCarCapacity.Text = c.Capacity.ToString();
                TxtCarConsumption.Text = c.Consumption.ToString();
                TxtCarLenTruck.Text = c.LenTruck.ToString();
                TxtCarPrice.Text = c.Price.ToString();
            }
        }

        // Заполнение текстовых полей по выбранном водителе
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            db - база данных;
            m - объект мастера.
        */
        private void ComboDriverId_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                Driver d = db.Drivers.Find( int.Parse(ComboDriverId.Text));
                TxtDriverFio.Text = d.FIO;
                TxtDriverPassport.Text = d.Passport;
                ComboDriverSecDr.Text = d.SecDr.ToString();
                TxtDriverClassDr.Text = d.ClassDr.ToString();
                TxtDriverExp.Text = d.Exp.ToString();
                
            }
        }

        // Заполнение текстовых полей по выбранном заказе
        /*
            Формальные параметры:
            sender - объект, издающий события;
            e - данные событий.
            Локальные параметры:
            db - база данных;
            k - объект услуги.
        */
        private void ComboOrdId_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                Ord o = db.Ords.Find(int.Parse(ComboOrdId.Text));
                TxtOrdName.Text = o.Name;
                TxtOrdStart.Text = o.Start;
                TxtOrdFinish.Text = o.Finish;
                TxtOrdLength.Text = o.Length.ToString();
                TxtOrdWidth.Text = o.Width.ToString();
            }
        }

        // Формирование комбобокса трейлеров для заказа
        private void ComboOrdCar_Enter(object sender, EventArgs e)
        {
            ComboOrdCar.Items.Clear();
            UpdDGVCar();
            for (int i = 0; i < DGVCar.Rows.Count-1; i++)
            {
                ComboOrdCar.Items.Add(DGVCar.Rows[i].Cells[0].Value.ToString());
            }
        }

        // Формирование комбобокса водителей для заказа
        private void ComboOrdDriver_Enter(object sender, EventArgs e)
        {
            ComboOrdDriver.Items.Clear();
            UpdDGVDriver();
            for (int i = 0; i < DGVDriver.Rows.Count - 1; i++)
            {
                ComboOrdDriver.Items.Add(DGVDriver.Rows[i].Cells[0].Value.ToString());

            }
        }


        // Формирование комбобокса возможных напарников
        private void ComboDriverSecDr_Enter(object sender, EventArgs e)
        {
            ComboDriverSecDr.Items.Clear();
            ComboDriverSecDr.Items.Add("0");
            UpdDGVDriver();
            for (int i = 0; i < DGVDriver.Rows.Count-1; i++)
            {
                ComboDriverSecDr.Items.Add(DGVDriver.Rows[i].Cells[0].Value.ToString());

            }
        }

        // Сортировка заказов по длине пути
        private void BtnSortOrdByLenWay_Click(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.Ords.OrderBy(x => x.Length).ToList();
                DGVOrd.DataSource = bs;
            }
        }

        // Сортировка заказов по весу
        private void BtnSortOrdByWidth_Click(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.Ords.OrderBy(x => x.Width).ToList();
                DGVOrd.DataSource = bs;
            }
        }

        // Узнать трейлер на котором выполнено больше всех заказов
        private void BtnCarMaxOrd_Click(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                List<Ord> OrdL = db.Ords.ToList();
                int MaxId = 0;
                int MaxCnt = 0;
                int tmp;
                foreach(var i in OrdL)
                {
                    tmp = OrdL.Count(x => (x.CarId == i.CarId));
                    if (tmp > MaxCnt)
                    {
                        MaxId = int.Parse(i.CarId.ToString());
                        MaxCnt = tmp;
                    }
                }
                List<Car> CarL = db.Cars.Where(x => x.Id == MaxId).ToList();
                MessageBox.Show(CarL[0].Model + ' ' + CarL[0].Firm + " Количество заказов " + MaxCnt.ToString());
            }
        }

        // Узнать водителя который выполнил больше всех заказов
        private void BtnDriverMaxOrd_Click(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                List<Ord> OrdL = db.Ords.ToList();
                int MaxId = 0;
                int MaxCnt = 0;
                int tmp;
                foreach (var i in OrdL)
                {
                    tmp = OrdL.Count(x => (x.DriverId == i.DriverId));
                    if (tmp > MaxCnt)
                    {
                        MaxId = int.Parse(i.DriverId.ToString());
                        MaxCnt = tmp;
                    }
                }
                List<Driver> DriverL = db.Drivers.Where(x => x.Id == MaxId).ToList();
                MessageBox.Show(DriverL[0].FIO + ' ' + DriverL[0].Exp.ToString() + " Количество заказов " + MaxCnt.ToString());
            }
        }

        // Вывести всех водителей без напарников
        private void BtnDriversWithoutSec_Click(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.Drivers.Where(x => x.SecDr == 0).ToList();
                DGVDriver.DataSource = bs;
            }
        }

        // Вывести всех водителей
        private void BtnShowAllDrivers_Click(object sender, EventArgs e)
        {
            UpdDGVDriver();
        }

        // Вывести все доходы
        private void BtnTotalPriceOrd_Click(object sender, EventArgs e)
        {
            using (Db db = new Db())
            {
                int TotalWay = db.Ords.Sum(x => x.Length);
                double TotalPriceOnKM = db.Cars.Sum(x => x.Price);
                MessageBox.Show("Общий доход " + (TotalPriceOnKM * (double)TotalWay).ToString());
            }
        }

        private void DGVCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCarModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
