using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }
        Cars[] carsArray = {
            new Cars() { carID = 1, carBrand = "BMW",carModel="318i", carPlate ="07 AC 001",carType="Sedan",carProduceDate=2017,carKilometer=65000,carColor="Kahverengi",carFuelType="Benzin",carPrice=1000,carStatus="Kiralanabilir",carPicture="C:/Users/Omer/Desktop/Arabalar/BMW 318i 2017.jpg"},
            new Cars() { carID = 2, carBrand = "BMW",carModel="116i", carPlate ="07 AC 002",carType="Hatchback",carProduceDate=2014,carKilometer=125000,carColor="Beyaz",carFuelType="Benzin",carPrice=750,carStatus="Kiralanabilir",carPicture="C:/Users/Omer/Desktop/Arabalar/bmw 116i 2014 hatcback.jpg"},
            new Cars() { carID = 3, carBrand = "Skoda",carModel="Octavia", carPlate ="07 AC 003",carType="Sedan",carProduceDate=2021,carKilometer=10000,carColor="Mavi",carFuelType="Benzin&Elektrik",carPrice=900,carStatus="Kiralanabilir",carPicture="C:/Users/Omer/Desktop/Arabalar/skoda octavia 2021 sedan.jpg"},
            new Cars() { carID = 4, carBrand = "Skoda",carModel="Scala", carPlate ="07 AC 004",carType="Hatchback",carProduceDate=2020,carKilometer=30000,carColor="Mavi",carFuelType="Benzin",carPrice=950,carStatus="Kiralanabilir",carPicture="C:/Users/Omer/Desktop/Arabalar/skoda scala 2020 hatchback.jpg"},
            new Cars() { carID = 5, carBrand = "Fiat",carModel="Egea", carPlate ="07 AC 005",carType="Sedan",carProduceDate=2020,carKilometer=25000,carColor="Kırmızı",carFuelType="Dizel",carPrice=350,carStatus="Kiralanabilir" ,carPicture="C:/Users/Omer/Desktop/Arabalar/Fiat egea 2020 sedan.jpg"},
            new Cars() { carID = 6, carBrand = "Fiat",carModel="Egea", carPlate ="07 AC 006",carType="Hatchback",carProduceDate=2021,carKilometer=10000,carColor="Kırmızı",carFuelType="Dizel",carPrice=400,carStatus="Kiralanabilir" ,carPicture="C:/Users/Omer/Desktop/Arabalar/Fiat egea hatchback.jpg"},
            new Cars() { carID = 7, carBrand = "Hyundai",carModel="i20", carPlate ="07 AC 007",carType="Hatchback",carProduceDate=2015,carKilometer=100000,carColor="Kahverengi",carFuelType="Dizel",carPrice=300,carStatus="Kiralanabilir" ,carPicture="C:/Users/Omer/Desktop/Arabalar/hyundai i20 2015.jpg"},
            new Cars() { carID = 8, carBrand = "Hyundai",carModel="Accent Blue", carPlate ="07 AC 008",carType="Sedan",carProduceDate=2018,carKilometer=64000,carColor="Gri",carFuelType="Dizel",carPrice=650,carStatus="Kiralanabilir" ,carPicture="C:/Users/Omer/Desktop/Arabalar/hyundai accent blue 2018 sedan.png"},
            new Cars() { carID = 9, carBrand = "Toyota",carModel="Corolla", carPlate ="07 AC 009",carType="Sedan",carProduceDate=2021,carKilometer=20000,carColor="Gri",carFuelType="Benzin",carPrice=900,carStatus="Kiralanabilir" ,carPicture="C:/Users/Omer/Desktop/Arabalar/toyota corolla 2021 sedan.jpg"},
            new Cars() { carID = 10, carBrand = "Toyota",carModel="Auris", carPlate ="07 AC 010",carType="Hatchback",carProduceDate=2016,carKilometer=120000,carColor="Mavi",carFuelType="Benzin",carPrice=500,carStatus="Kiralanabilir" ,carPicture="C:/Users/Omer/Desktop/Arabalar/toyota auris 2016 hatchback.jpg"},

            };
        private void button1_Click(object sender, EventArgs e)
        {
            
            var car = from s in carsArray
                      where s.carBrand == comboBox1.Text && s.carType == comboBox2.Text
                      select s;
            foreach (var item in car)
            {
                textBoxColor.Text = item.carColor;
                textBoxFueltype.Text = item.carFuelType;
                textBoxKilometer.Text = Convert.ToString(item.carKilometer);
                textBoxModel.Text = item.carModel;
                textBoxPlate.Text = item.carPlate;
                textBoxPrice.Text = Convert.ToString(item.carPrice);
                textBoxProduceDate.Text = Convert.ToString(item.carProduceDate);
                textBoxStatus.Text = item.carStatus;
                pictureBox1.ImageLocation = item.carPicture;
            }
                      
            




        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (textBoxModel.ReadOnly==true)
            {
                textBoxPassword.Visible = true;
                buttonControl.Visible = true;
                labelPassword.Visible = true;
                
            }
            else
            {
                textBoxPlate.ReadOnly = true;
                textBoxModel.ReadOnly = true;
                textBoxProduceDate.ReadOnly = true;
                textBoxKilometer.ReadOnly = true;
                textBoxColor.ReadOnly = true;
                textBoxFueltype.ReadOnly = true;
                textBoxPrice.ReadOnly = true;
                textBoxStatus.ReadOnly = true;
                buttonSave.Visible = false;
                labelName.Visible = false;
                labelSurname.Visible = false;
                textBoxName.Visible = false;
                textBoxSurname.Visible = false;
                buttonRent.Visible = false;
            }
            
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            
            
                if (textBoxPassword.Text == "123")
                {
                    textBoxPlate.ReadOnly = false;
                    textBoxModel.ReadOnly = false;
                    textBoxProduceDate.ReadOnly = false;
                    textBoxKilometer.ReadOnly = false;
                    textBoxColor.ReadOnly = false;
                    textBoxFueltype.ReadOnly = false;
                    textBoxPrice.ReadOnly = false;
                    textBoxStatus.ReadOnly = false;
                    textBoxPassword.Visible = false;
                    buttonControl.Visible = false;
                    labelPassword.Visible = false;
                    buttonSave.Visible = true;
                    labelName.Visible = true;
                    labelSurname.Visible = true;
                    textBoxName.Visible = true;
                    textBoxSurname.Visible = true;
                    buttonRent.Visible = true;
                MessageBox.Show("Yönetici ayrıcalıkları alındı. Araç bilgilerini düzenleyebilirsiniz. Kapatmak için Kaydet tuşuna ya da tekrar aynı tuşa basabilirsiniz.;");
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış!");
                    textBoxPassword.Visible = false;
                    buttonControl.Visible = false;
                    labelPassword.Visible = false;
                    buttonSave.Visible = false;
                }
            
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var car = from s in carsArray
                      where s.carBrand == comboBox1.Text && s.carType == comboBox2.Text
                      select s;
            foreach (var item in car)
            {
                item.carColor = textBoxColor.Text;
                item.carFuelType=textBoxFueltype.Text;
                item.carKilometer = Convert.ToInt32(textBoxKilometer.Text);
                item.carModel = textBoxModel.Text;
                item.carPlate = textBoxPlate.Text;
                item.carPrice = Convert.ToInt32(textBoxPrice.Text);
                item.carProduceDate = Convert.ToInt32(textBoxProduceDate.Text);
                item.carStatus = textBoxStatus.Text;
                
            }
            textBoxPlate.ReadOnly = true;
            textBoxModel.ReadOnly = true;
            textBoxProduceDate.ReadOnly = true;
            textBoxKilometer.ReadOnly = true;
            textBoxColor.ReadOnly = true;
            textBoxFueltype.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            textBoxStatus.ReadOnly = true;
            buttonSave.Visible = false;
            labelName.Visible = false;
            labelSurname.Visible = false;
            textBoxName.Visible = false;
            textBoxSurname.Visible = false;
            buttonRent.Visible = false;
        }

        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (textBoxStatus.Text=="Kiralanabilir")
            {
                listBox1.Items.Add($"{textBoxName.Text} {textBoxSurname.Text} {comboBox1.Text} {textBoxModel.Text} kiraladı.");
                var car = from s in carsArray
                          where s.carBrand == comboBox1.Text && s.carType == comboBox2.Text
                          select s;
                foreach (var item in car)
                {
                    item.carStatus = "Kiralanamaz";
                    textBoxStatus.Text = item.carStatus;
                }
            }
            else { MessageBox.Show("Bu araba çoktan kiralandı. Lütfen başka bir araba seçiniz."); }
            

        }
    }
}
