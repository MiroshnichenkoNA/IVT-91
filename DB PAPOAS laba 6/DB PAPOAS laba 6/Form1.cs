using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_PAPOAS_laba_6
{
    public partial class Form1 : Form
    {
        DataGridView dg;
        MySqlDataAdapter da;
        TextBox TextBox1, text1, text2, text3, text4, text5,text6,text7;
        MenuItem menuItem2;
        Label label1 = new Label();
        CheckBox check1;
        RadioButton radio1, radio2, radio3;
        RichTextBox rich1;
        string Connect = "Server=localhost;Database=bdp;Uid=root;pwd=popkins2001;charset=utf8";
        public Form1()
        {
            InitializeComponent();
            this.Text = "База данных";
            this.Width = 500;
            this.Height = 300;
            MainMenu mainMenu1 = new MainMenu();

            menuItem2 = new MenuItem("Правка");
            menuItem2.MenuItems.Add("Сохранить изменения", new EventHandler(mainMenu1_Save_Select));
            menuItem2.MenuItems.Add("Удалить", new EventHandler(MainMenu1_Del_Select));
            mainMenu1.MenuItems.Add(menuItem2);
            menuItem2.Enabled = false;

            Button button1 = new Button();
            button1.Text = "Заведующий";
            button1.Size = new Size(200, 200);
            button1.Location = new Point(10, 10);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "Кладовщик";
            button2.Size = new Size(200, 200);
            button2.Location = new Point(300, 10);
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);
            
            Button button3 = new Button();
            button3.Text = "Рабочий";
            button3.Size = new Size(200, 200);
            button3.Location = new Point(150, 250);
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);
            

            this.Menu = mainMenu1;

        }
        //заведующий
        private void button1_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Button button1 = new Button();
            button1.Text = "Сотрудник";
            button1.Size = new Size(100, 100);
            button1.Location = new Point(10, 10);
            button1.Click += new EventHandler(mainMenu1_Zapros1_Select);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "Заказы";
            button2.Size = new Size(100, 100);
            button2.Location = new Point(110, 10);
            button2.Click += new EventHandler(button12_Click);
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "Поставщики";
            button3.Size = new Size(100, 100);
            button3.Location = new Point(10, 110);
            button3.Click += new EventHandler(button13_Click);
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Text = "Клиенты";
            button4.Size = new Size(100, 100);
            button4.Location = new Point(110, 110);
            button4.Click += new EventHandler(button14_Click);
            this.Controls.Add(button4);

            Button button5 = new Button();
            button5.Text = "Сотрудники";
            button5.Size = new Size(100, 100);
            button5.Location = new Point(10, 210);
            button5.Click += new EventHandler(button15_Click);
            this.Controls.Add(button5);
        }
        //кладовщик
        private void button2_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Button button1 = new Button();
            button1.Text = "Товар";
            button1.Size = new Size(100, 100);
            button1.Location = new Point(10, 10);
            button1.Click += new EventHandler(button21_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "Отправили";
            button2.Size = new Size(100, 100);
            button2.Location = new Point(110, 10);
            button2.Click += new EventHandler(button22_Click);
            this.Controls.Add(button2);
        }
        private void button3_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Button button1 = new Button();
            button1.Text = "Товар";
            button1.Size = new Size(100, 100);
            button1.Location = new Point(10, 10);
            button1.Click += new EventHandler(button21_Click);
            this.Controls.Add(button1);
        }
        private void button21_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Товар";
            label1.Width = 100;
            label1.Location = new Point(400, 200);
            this.Controls.Add(label1);
            //добавление таблицы на форму
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            //соединение с базой данных
            da = new MySqlDataAdapter("SELECT * FROM tovar", Connect);
            DataTable dt = new DataTable();
            //заполнение таблицы данными из БД
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "id товара";
            dg.Columns[1].HeaderText = "Цена";
            dg.Columns[2].HeaderText = "Имеется";
            dg.Columns[3].HeaderText = "Поставщик";
            menuItem2.Enabled = true;
        }
        private void button22_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Отправлено";
            label1.Width = 100;
            label1.Location = new Point(400, 200);
            this.Controls.Add(label1);
            //добавление таблицы на форму
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            //соединение с базой данных
            da = new MySqlDataAdapter("SELECT * FROM otzakaz", Connect);
            DataTable dt = new DataTable();
            //заполнение таблицы данными из БД
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "id заказа";
            dg.Columns[1].HeaderText = "Дата отгрузки";
            dg.Columns[2].HeaderText = "Дата оплаты";
            dg.Columns[3].HeaderText = "Адрес";
            dg.Columns[4].HeaderText = "id клиента";
            menuItem2.Enabled = true;
        }
        //заведующий - отчет
        private void button11_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Width = 300;
            label1.Text = "Итоговая Цена:";
            label1.Location = new Point(300, 150);
            this.Controls.Add(label1);
        }
        //заведующий - заказы
        private void button12_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "заказ";
            label1.Width = 100;
            label1.Location = new Point(400, 200);
            this.Controls.Add(label1);
            //добавление таблицы на форму
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            //соединение с базой данных
            da = new MySqlDataAdapter("SELECT * FROM zakaz", Connect);
            DataTable dt = new DataTable();
            //заполнение таблицы данными из БД
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Номер зала";
            dg.Columns[1].HeaderText = "Название";
            dg.Columns[2].HeaderText = "Вместимость";
            dg.Columns[3].HeaderText = "Номер билета";
            menuItem2.Enabled = true;
        }
        private void button13_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "поставщики";
            label1.Width = 50;
            label1.Location = new Point(400, 200);
            this.Controls.Add(label1);
            //добавление таблицы на форму
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            //соединение с базой данных
            da = new MySqlDataAdapter("SELECT * FROM postav", Connect);
            DataTable dt = new DataTable();
            //заполнение таблицы данными из БД
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "id";
            dg.Columns[1].HeaderText = "название";
            dg.Columns[2].HeaderText = "телефон";
            dg.Columns[3].HeaderText = "почта";
            menuItem2.Enabled = true;
        }
        private void button14_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            label1.Text = "Клиент";
            label1.Width = 50;
            label1.Location = new Point(400, 200);
            this.Controls.Add(label1);
            //добавление таблицы на форму
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            //соединение с базой данных
            da = new MySqlDataAdapter("SELECT * FROM klient", Connect);
            DataTable dt = new DataTable();
            //заполнение таблицы данными из БД
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "id";
            dg.Columns[1].HeaderText = "договор";
            dg.Columns[2].HeaderText = "номер телефона";
            dg.Columns[3].HeaderText = "почта";
            menuItem2.Enabled = true;
        }
        private void button15_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "сотрудники";
            label1.Width = 100;
            label1.Location = new Point(400, 200);
            this.Controls.Add(label1);
            //добавление таблицы на форму
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            //соединение с базой данных
            da = new MySqlDataAdapter("SELECT * FROM sotrud", Connect);
            DataTable dt = new DataTable();
            //заполнение таблицы данными из БД
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "id";
            dg.Columns[1].HeaderText = "фамилия";
            dg.Columns[2].HeaderText = "должность";
            dg.Columns[3].HeaderText = "телефон";
            menuItem2.Enabled = true;
        }
        private void button5_Click(object sender, System.EventArgs e)

        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Width = 300;
            label1.Text = "Итоговая Цена:";
            label1.Location = new Point(300, 150);
            this.Controls.Add(label1);
        }
        private void mainMenu1_Save_Select(object sender, System.EventArgs e)
        {
            try
            {
                da.Update((DataTable)dg.DataSource);
                MessageBox.Show("Изменение сохранено", "Информация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mainMenu1_Zapros1_Select(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            label1.Text = "Фамилия сотрудника: ";
            label1.Width = 150;
            label1.Location = new Point(10, 10);
            this.Controls.Add(label1);
            TextBox1 = new TextBox();
            TextBox1.Location = new Point(160, 10);
            TextBox1.Width = 200;
            TextBox1.Text = "Тутуту";
            this.Controls.Add(TextBox1);
            Button bt1 = new Button();
            bt1.Text = "Поиск";
            bt1.Location = new Point(400, 10);
            bt1.Click += new EventHandler(bt1_Click);
            this.Controls.Add(bt1);
            dg = new DataGridView();
            dg.Width = 450;
            dg.Height = 150;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            menuItem2.Enabled = false;
        }
        private void bt1_Click(object sender, System.EventArgs e)
        {
            dg.Rows.Clear();
            dg.Columns.Clear();
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            string CommandText = "select * from sotrud where fam = @text";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            //добавляем параметр
            myCommand.Parameters.Add(new MySqlParameter("@text", MySqlDbType.VarChar, 20));
            myCommand.Parameters["@text"].Value = TextBox1.Text;
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            try
            {
                int k = 0;
                if (myDataReader.HasRows)
                {
                    dg.Columns.Add("Номер билета", "");
                    dg.Columns.Add("Фамилия", "");
                    dg.Columns.Add("Номер телефона", "");
                    dg.Columns.Add("Номер паспорта", "");
                    //dg.Columns.Add("Дата рождения", "");
                    //dg.Columns.Add("Образование", "");
                    //dg.Columns.Add("Нал. уч. степени", "");
                }
                while (myDataReader.Read())
                {
                    k++;
                    dg.Rows.Add(myDataReader[0].ToString(), myDataReader[1].ToString(), myDataReader[2].ToString(), myDataReader[3].ToString());
                }
                if (k == 0) MessageBox.Show("Ошибка: нет такого сотрудника");
            }
            catch (Exception) { MessageBox.Show("Ошибка"); }
            myConnection.Close();
        }
        private void MainMenu1_Del_Select(object sender, System.EventArgs e)
        {
            DataRow current = ((DataRowView)dg.CurrentRow.DataBoundItem).Row;
            current.Delete();
        }
       

    }
}

