using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Users_Interface
{
    public partial class Form1 : Form
    {
        List<Apartments> apartments;
        public Form1()
        {
            InitializeComponent();
            dataGridViewApartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewApartments.RowHeadersWidth = 4;
            dataGridViewApartments.ColumnHeadersHeight = 30;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void FeelDataGridView(DataGridView data)
        {
            data.Rows.Clear();
            data.Refresh();
            using (WebClient client = new WebClient())
            {
                //Формируем url ссылку для подключения к локальному хосту
                string url = "http://localhost/PHP/CourseProject/getApartments.php";
                //Формируем строку взятую по url с сервера и дешифруем её с помощью класса JsonConvert библиотеки Newtonsoft.Json
                string json = client.DownloadString(url);
                apartments = JsonConvert.DeserializeObject<List<Apartments>>(json);

                //Для простоты работы добавляем названия столбцов и задаем размеры
                data.ColumnCount = 5;
                data.Columns[0].HeaderText = "Порядковый номер";
                data.Columns[0].Width = 150;
                data.Columns[1].HeaderText = "Количество комнат";
                data.Columns[1].Width = 150;
                data.Columns[2].HeaderText = "Площадь";
                data.Columns[3].HeaderText = "Этаж";
                data.Columns[4].HeaderText = "Адрес";
                data.Columns[4].Width = 220;

                //Запрет на сортировку ячеек таблицы пользователем
                foreach (DataGridViewColumn column in data.Columns)
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;

                int count = 0;
                //Получаем данные из БД и записываем их в наш класс Apartments
                foreach (Apartments apartment in apartments)
                {
                    count++;
                    string[] row = new string[] { count.ToString(), apartment.Rooms.ToString(), apartment.Area.ToString(), apartment.Floor.ToString(), apartment.Address };
                    data.Rows.Add(row);
                }
            }
        }

        private void buttonCreateCardCatalogue_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Visible = true;
                dataGridViewApartments.Visible = true;
                FeelDataGridView(dataGridViewApartments);
            }
            catch
            {
                MessageBox.Show("Не удается получить соединение с сервером!");
            }
        }

        private void buttonExchangeApplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRooms.Text == "" || textBoxArea.Text == "" || textBoxFloor.Text == "")
                {
                    MessageBox.Show("Все поля должны быть обязательно заполнены!");
                    return;
                }
                if (int.TryParse(textBoxRooms.Text, out int rooms) && int.TryParse(textBoxArea.Text, out int area) && int.TryParse(textBoxFloor.Text, out int floor))
                {
                    using (WebClient client = new WebClient())
                    {
                        string url = "http://localhost/PHP/CourseProject/exchangeApartment.php";
                        var data = new { rooms = textBoxRooms.Text, floor = textBoxFloor.Text, area = textBoxArea.Text };
                        string jsonData = JsonConvert.SerializeObject(data);

                        client.Headers[HttpRequestHeader.ContentType] = "application/json";
                        string responseString = client.UploadString(url, jsonData);
                        var responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseString);

                        if (responseData.ContainsKey("error"))
                        {
                            MessageBox.Show(responseData["error"].ToString());
                        }
                        else if (responseData.ContainsKey("apartment"))
                        {
                            var apartmentData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseData["apartment"].ToString());
                            MessageBox.Show("Найдена квартира: Комнаты - " + apartmentData["rooms"] + ", Этаж - " + apartmentData["floor"] + ", Площадь - " + apartmentData["area"] + ", Адрес - " + apartmentData["address"]);
                        }
                        else if (responseData.ContainsKey("message"))
                        {
                            MessageBox.Show(responseData["message"].ToString());
                        }
                    }
                    FeelDataGridView(dataGridViewApartments);
                }
                else
                {
                    MessageBox.Show("Данные для заявки могут быть только цифрами с целочисленными значениями!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не удается получить соединение с сервером!");
            }
        }

        private void buttonShowListOFApplications_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Visible = true;
                dataGridViewApplications.Visible = true;
                dataGridViewApplications.Rows.Clear();
                dataGridViewApplications.Refresh();
                using (WebClient client = new WebClient())
                {
                    //Формируем url ссылку для подключения к локальному хосту
                    string url = "http://localhost/PHP/CourseProject/getApplications.php";
                    //Формируем строку взятую по url с сервера и дешифруем её с помощью класса JsonConvert библиотеки Newtonsoft.Json
                    string json = client.DownloadString(url);
                    apartments = JsonConvert.DeserializeObject<List<Apartments>>(json);

                    dataGridViewApplications.ColumnCount = 4;

                    dataGridViewApplications.Columns[0].HeaderText = "Порядковый номер";
                    dataGridViewApplications.Columns[0].Width = 150;
                    dataGridViewApplications.Columns[1].HeaderText = "Количество комнат";
                    dataGridViewApplications.Columns[1].Width = 150;
                    dataGridViewApplications.Columns[2].HeaderText = "Площадь";
                    dataGridViewApplications.Columns[3].HeaderText = "Этаж";

                    //Запрет на сортировку ячеек таблицы пользователем
                    foreach (DataGridViewColumn column in dataGridViewApplications.Columns)
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;

                    int count = 0;
                    //Получаем данные из БД и записываем их в наш класс Apartments
                    foreach (Apartments apartment in apartments)
                    {
                        count++;
                        string[] row = new string[] { count.ToString(), apartment.Rooms.ToString(), apartment.Area.ToString(), apartment.Floor.ToString() };
                        dataGridViewApplications.Rows.Add(row);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удается получить соединение с сервером!");
            }
        }
    }
}
