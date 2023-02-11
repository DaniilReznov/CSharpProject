using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace pharmacy {
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        
        public class Medicines {
            public string ATX { get; set; }
            public string Decryption { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
        }

        private void showStock1_Click(object sender, RoutedEventArgs e) {
            var dbStock1 = dbPharmacyEntities.getContext().dbStock1.ToList();

            List<Medicines> MedicinesList = new List<Medicines> {
                
            };
            foreach (var test in dbStock1) {
                Medicines meds = new Medicines();
                meds.ATX = test.ATX;
                meds.Decryption = test.Dec;
                meds.Name = test.Name;
                meds.Price = test.Price;
                meds.Quantity = test.Quantity;

                MedicinesList.Add(meds);
            }
            DG.ItemsSource = MedicinesList;

            DG.Columns[0].Header = "Код ATX";
            DG.Columns[1].Header = "Анатомо-терапевтическо-химическая классификация (АТХ)";
            DG.Columns[2].Header = "Название препарата";
            DG.Columns[3].Header = "Цена/руб.";
            DG.Columns[4].Header = "Кол-во/шт.";

        }

        private void showStock2_Click(object sender, RoutedEventArgs e) {
            var dbStock2 = dbPharmacyEntities.getContext().dbStock2.ToList();

            List<Medicines> MedicinesList = new List<Medicines> {

            };
            foreach (var test in dbStock2) {
                Medicines meds = new Medicines();
                meds.ATX = test.ATX;
                meds.Decryption = test.Dec;
                meds.Name = test.Name;
                meds.Price = test.Price;
                meds.Quantity = test.Quantity;

                MedicinesList.Add(meds);
            }
            DG.ItemsSource = MedicinesList;

            DG.Columns[0].Header = "Код ATX";
            DG.Columns[1].Header = "Анатомо-терапевтическо-химическая классификация (АТХ)";
            DG.Columns[2].Header = "Название препарата";
            DG.Columns[3].Header = "Цена/руб.";
            DG.Columns[4].Header = "Кол-во/шт.";
        }

        private void helpButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Для того, чтобы отобразить пункты первого склада, нажмите на кнопку 'Отобразить склад №1';\n" +
                "\n" +
                "Для того, чтобы отобразить пункты второго склада, нажмите на кнопку 'Отобразить склад №1';\n" +
                "\n" +
                "Для того, чтобы удалить пункт склада, нажмите на кнопку 'Удалить', выберите склад и номер позиции;\n" +
                "\n" +
                "Чтобы добавить пункт, нажмите на кнопку 'Добавить', выберите склад и заполните все поля;\n" +
                "\n" +
                "Для выхода из программы, нажмите кнопку 'Выход'.", "Инструкция по использованию");
        }

        private void exit_Click(object sender, RoutedEventArgs e) {
            MainWindow login = new MainWindow();
            this.Close();
            login.Show();
        }

        private void add_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Находится в стадии разработки", "Внимание");
        }

        private void delete_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Находится в стадии разработки", "Внимание");
        }
    }
}
