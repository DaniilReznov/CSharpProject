using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;
using static WindowsFormsApp1.XMLParse;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form 
    {
        public DataTable dt = new DataTable();
        public int number;
        public bool visible = false;

        public Form1() {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // автоматически настраивается ширина столбцов
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                while (dt.Columns.Count != 0) {
                    dt.Columns.Remove(dt.Columns[dt.Columns.Count - 1]);
                }
                FillData();
            }
            catch (Exception) {
                MessageBox.Show("Выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Выбор файла для парсинга
        private void button2_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "xml files (*.xml)|*.xml",
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filename = openFileDialog.FileName;
                fileXML = File.ReadAllText(filename);
            }
        }

        // Метод для создания строк в таблице
        private void AddRows() {
            XmlDocument docXML = new XmlDocument(); // XML-документ
            docXML.LoadXml(fileXML); // загрузить XML
            textBox7.Text = docXML.GetElementsByTagName("read")[0].InnerText;
            number = Convert.ToInt32(textBox7.Text);
            for (int i = 0; i < number; i++) {
                dt.Rows.Add(new Object[] { "" });
            }
        }

        // Метод для заполнения таблицы
        private void FillData() {
            ProductData2 productData2 = new ProductData2();
            XMLParse parser = new XMLParse();
            
            // Создание колон в таблице
            dt.Columns.Add("Код с криптохвостом");
            dt.Columns.Add("Код без криптохвоста");
            dt.Columns.Add("Дата производства");
            dt.Columns.Add("Тип производства");
            dt.Columns.Add("Тип сертификата");

            AddRows();

            productData2 = parser.XMLParse_Doc();

            textBox1.Text = productData2.product_date1;
            textBox2.Text = productData2.batch;
            textBox3.Text = productData2.line;
            textBox4.Text = productData2.startmarking;
            textBox5.Text = productData2.stopmarking;
            textBox6.Text = productData2.produced;
            textBox7.Text = productData2.read;
            textBox8.Text = productData2.record;
            textBox9.Text = productData2.rejected;
            textBox10.Text = productData2.production_order;

            number = Convert.ToInt32(textBox7.Text);
            for (int i = 0; i < number; i++) {
                dt.Rows[i]["Код с криптохвостом"] = productData2.products.ElementAt(i).ki;
                dt.Rows[i]["Код без криптохвоста"] = productData2.products.ElementAt(i).cis;
                dt.Rows[i]["Дата производства"] = productData2.products.ElementAt(i).product_date;
                dt.Rows[i]["Тип производства"] = productData2.products.ElementAt(i).tnved_code;
                dt.Rows[i]["Тип сертификата"] = productData2.products.ElementAt(i).certificate_type;
            }
            //Присвоение DataTable для компонента DataGridView
            dataGridView1.DataSource = dt;
            //Сброс источника данных
            dataGridView1.DataSource = null;
            //Присвоение источника данных
            dataGridView1.DataSource = dt;
        }
    }
}