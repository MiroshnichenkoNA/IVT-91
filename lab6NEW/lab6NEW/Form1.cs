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


namespace lab6NEW
{
    public partial class Form1 : Form
    {
        DataGridView dg;
        MySqlDataAdapter da;
        TextBox text1,text2,text3,text4,text5,text6,text7;
        RadioButton radio1, radio2, radio3;
        RichTextBox rich1;
        CheckBox check1;
        String nazv;
        MenuItem menuItem2;
        string Connect = "Database=ppap;Data Source=localhost;User Id=root;Password=R7SFHI29; Character set=utf8";

        public Form1()
        {
            InitializeComponent();
            this.Text = "База данных ppap";
            this.Width = 800;
            this.Height = 600;
            MainMenu mainMenu1 = new MainMenu();
            MenuItem menuItem1 = new MenuItem("Менеджер");
            menuItem1.MenuItems.Add("Свадьба",
                new EventHandler(mainMenu1_Table1_Select));
            menuItem1.MenuItems.Add("День Рождения",
                new EventHandler(mainMenu1_Table2_Select));
            menuItem1.MenuItems.Add("Выпускной",
                new EventHandler(mainMenu1_Table3_Select));
            menuItem1.MenuItems.Add("Юбилей",
                new EventHandler(mainMenu1_Table4_Select));
            mainMenu1.MenuItems.Add(menuItem1);

            menuItem2 = new MenuItem("Правка");
            menuItem2.MenuItems.Add("Сохранить изменения",
                new EventHandler(mainMenu1_Save_Select));
            menuItem2.MenuItems.Add("Удалить",
                new EventHandler(mainMenu1_Del_Select));
            mainMenu1.MenuItems.Add(menuItem2);
            menuItem2.Enabled = false;

            MenuItem menuItem3 = new MenuItem("Кладовщик");
            menuItem3.MenuItems.Add("Склад",
                new EventHandler(mainMenu1_Zapros1_Select));

            mainMenu1.MenuItems.Add(menuItem3);
            this.Menu = mainMenu1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "Свадьба";
            button1.Size = new Size(350, 250);
            button1.Location = new Point(10, 10);
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "Юбилей";
            button2.Size = new Size(350, 250);
            button2.Location = new Point(400, 10);
            button2.Click += new EventHandler(button2_Click);
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "День Рождения";
            button3.Size = new Size(350, 250);
            button3.Location = new Point(10, 300);
            button3.Click += new EventHandler(button3_Click);
            this.Controls.Add(button3);

            Button button4 = new Button();
            button4.Text = "Выпускной";
            button4.Size = new Size(350, 250);
            button4.Location = new Point(400, 300);
            button4.Click += new EventHandler(button4_Click);
            this.Controls.Add(button4);
        }

        private void mainMenu1_Table1_Select(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Свадьба:";
            label1.Width = 50;
            label1.Location = new Point(20, 20);
            this.Controls.Add(label1);
            dg = new DataGridView();
            dg.Width = 600;
            dg.Height = 300;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            da = new MySqlDataAdapter("Select * FROM merop where Nazvan_Merop='Свадьба'", Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Компания";
            dg.Columns[1].HeaderText = "ФИО";
            dg.Columns[2].HeaderText = "Паспорт";
            dg.Columns[3].HeaderText = "Номер Телефона";
            dg.Columns[4].HeaderText = "Кол-во Человек";
            dg.Columns[5].HeaderText = "ФИО юбиляра";
            dg.Columns[6].HeaderText = "Место праздника";
            dg.Columns[7].HeaderText = "Тема праздника";
            dg.Columns[8].HeaderText = "Индивидуальные пожелания";
            dg.Columns[9].HeaderText = "Цена";
            dg.Columns[10].HeaderText = "Название Мероприятия";
            dg.Columns[11].HeaderText = "ID Менеджера";
            dg.Columns[12].HeaderText = "Согласие на встречу";
            menuItem2.Enabled = true;
        }

        private void mainMenu1_Table2_Select(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "День Рождения:";
            label1.Width = 50;
            label1.Location = new Point(20, 20);
            this.Controls.Add(label1);
            dg = new DataGridView();
            dg.Width = 600;
            dg.Height = 300;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            da = new MySqlDataAdapter("Select * FROM merop where Nazvan_Merop='День Рождения'", Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Компания";
            dg.Columns[1].HeaderText = "ФИО";
            dg.Columns[2].HeaderText = "Паспорт";
            dg.Columns[3].HeaderText = "Номер Телефона";
            dg.Columns[4].HeaderText = "Кол-во Человек";
            dg.Columns[5].HeaderText = "ФИО юбиляра";
            dg.Columns[6].HeaderText = "Место праздника";
            dg.Columns[7].HeaderText = "Тема праздника";
            dg.Columns[8].HeaderText = "Индивидуальные пожелания";
            dg.Columns[9].HeaderText = "Цена";
            dg.Columns[10].HeaderText = "Название Мероприятия";
            dg.Columns[11].HeaderText = "ID Менеджера";
            dg.Columns[12].HeaderText = "Согласие на встречу";
            menuItem2.Enabled = true;
        }

        private void mainMenu1_Table3_Select(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Выпускной:";
            label1.Width = 50;
            label1.Location = new Point(20, 20);
            this.Controls.Add(label1);
            dg = new DataGridView();
            dg.Width = 600;
            dg.Height = 300;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            da = new MySqlDataAdapter("Select * FROM merop where Nazvan_Merop='Выпускной'", Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Компания";
            dg.Columns[1].HeaderText = "ФИО";
            dg.Columns[2].HeaderText = "Паспорт";
            dg.Columns[3].HeaderText = "Номер Телефона";
            dg.Columns[4].HeaderText = "Кол-во Человек";
            dg.Columns[5].HeaderText = "ФИО юбиляра";
            dg.Columns[6].HeaderText = "Место праздника";
            dg.Columns[7].HeaderText = "Тема праздника";
            dg.Columns[8].HeaderText = "Индивидуальные пожелания";
            dg.Columns[9].HeaderText = "Цена";
            dg.Columns[10].HeaderText = "Название Мероприятия";
            dg.Columns[11].HeaderText = "ID Менеджера";
            dg.Columns[12].HeaderText = "Согласие на встречу";
            menuItem2.Enabled = true;
        }

        private void mainMenu1_Table4_Select(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Юбилей:";
            label1.Width = 50;
            label1.Location = new Point(20, 20);
            this.Controls.Add(label1);
            dg = new DataGridView();
            dg.Width = 600;
            dg.Height = 300;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            da = new MySqlDataAdapter("Select * FROM merop where Nazvan_Merop='Юбилей'", Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Компания";
            dg.Columns[1].HeaderText = "ФИО";
            dg.Columns[2].HeaderText = "Паспорт";
            dg.Columns[3].HeaderText = "Номер Телефона";
            dg.Columns[4].HeaderText = "Кол-во Человек";
            dg.Columns[5].HeaderText = "ФИО юбиляра";
            dg.Columns[6].HeaderText = "Место праздника";
            dg.Columns[7].HeaderText = "Тема праздника";
            dg.Columns[8].HeaderText = "Индивидуальные пожелания";
            dg.Columns[9].HeaderText = "Цена";
            dg.Columns[10].HeaderText = "Название Мероприятия";
            dg.Columns[11].HeaderText = "ID Менеджера";
            dg.Columns[12].HeaderText = "Согласие на встречу";
            menuItem2.Enabled = true;
        }

        private void mainMenu1_Save_Select(object sender, System.EventArgs e)
        {
            try
            {
                da.Update((DataTable)dg.DataSource);
                MessageBox.Show("Изменение сохраненно", "Информация", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainMenu1_Del_Select(object sender, System.EventArgs e)
        {
            DataRow current = ((DataRowView)dg.CurrentRow.DataBoundItem).Row;
            current.Delete();
        }

        private void mainMenu1_Zapros1_Select(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Склад:";
            label1.Width = 50;
            label1.Location = new Point(20, 20);
            this.Controls.Add(label1);
            dg = new DataGridView();
            dg.Width = 600;
            dg.Height = 300;
            dg.Location = new Point(20, 50);
            this.Controls.Add(dg);
            da = new MySqlDataAdapter("Select * FROM sklad", Connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            dg.DataSource = dt;
            dg.Columns[0].HeaderText = "Название декорации";
            dg.Columns[1].HeaderText = "Кол-во Декораций";
            dg.Columns[2].HeaderText = "Название Мероприятия";
            dg.Columns[3].HeaderText = "ID Менеджера";
            dg.Columns[4].HeaderText = "ID Кладовщика";
            menuItem2.Enabled = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            nazv = "Свадьба";
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Заведующая компания:";
            label1.Width = 250;
            label1.Location = new Point(10, 10);
            this.Controls.Add(label1);

            check1 = new CheckBox();
            check1.Text = "Желание обсудить детали с ведущим лично";
            check1.Width = 250;
            check1.Location = new Point(80, 30);
            this.Controls.Add(check1);

            radio1 = new RadioButton();
            radio1.Text = "Алпес";
            radio1.Location = new Point(10, 30);
            this.Controls.Add(radio1);

            radio2 = new RadioButton();
            radio2.Text = "Лейнар";
            radio2.Location = new Point(10, 50);
            this.Controls.Add(radio2);

            radio3 = new RadioButton();
            radio3.Text = "Дарвин";
            radio3.Location = new Point(10, 70);
            this.Controls.Add(radio3);

            Label label2 = new Label();
            label2.Text = "ФИО";
            label2.Width = 250;
            label2.Location = new Point(10, 100);
            this.Controls.Add(label2);

            text1 = new TextBox();
            text1.Width = 250;
            text1.Location = new Point(10, 125);
            this.Controls.Add(text1);

            Label label3 = new Label();
            label3.Text = "Серия/Номер Паспорта";
            label3.Width = 250;
            label3.Location = new Point(10, 150);
            this.Controls.Add(label3);

            text2 = new TextBox();
            text2.Width = 250;
            text2.Location = new Point(10, 175);
            this.Controls.Add(text2);

            Label label4 = new Label();
            label4.Text = "Контактный Номер Телефона";
            label4.Width = 250;
            label4.Location = new Point(10, 200);
            this.Controls.Add(label4);

            text3 = new TextBox();
            text3.Width = 250;
            text3.Location = new Point(10, 225);
            this.Controls.Add(text3);

            Label label5 = new Label();
            label5.Text = "Кол-во Человек";
            label5.Width = 250;
            label5.Location = new Point(10, 250);
            this.Controls.Add(label5);

            text4 = new TextBox();
            text4.Width = 250;
            text4.Location = new Point(10, 275);
            this.Controls.Add(text4);

            Label label6 = new Label();
            label6.Text = "ФИО \"виновника торжества\" (При отсутствии введите \"-\")";
            label6.Width = 320;
            label6.Location = new Point(10, 300);
            this.Controls.Add(label6);

            text5 = new TextBox();
            text5.Width = 250;
            text5.Location = new Point(10, 325);
            this.Controls.Add(text5);

            Label label7 = new Label();
            label7.Text = "Место проведения";
            label7.Width = 250;
            label7.Location = new Point(10, 350);
            this.Controls.Add(label7);

            text6 = new TextBox();
            text6.Width = 250;
            text6.Location = new Point(10, 375);
            this.Controls.Add(text6);

            Label label8 = new Label();
            label8.Text = "Тематика Праздника (При отсутствии введите \"-\")";
            label8.Width = 320;
            label8.Location = new Point(10, 400);
            this.Controls.Add(label8);

            text7 = new TextBox();
            text7.Width = 250;
            text7.Location = new Point(10, 425);
            this.Controls.Add(text7);

            Button button5 = new Button();
            button5.Text = "Далее";
            button5.Size = new Size(770, 100);
            button5.Location = new Point(10, 450);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            Label label9 = new Label();
            label9.Text = "Поле индивидуальных предпочтений и пожеланий (При отсутствии введите \"-\")";
            label9.Width = 450;
            label9.Location = new Point(350, 10);
            this.Controls.Add(label9);

            rich1 = new RichTextBox();
            rich1.Size = new Size(400,400);
            rich1.Location = new Point(350,35);
            this.Controls.Add(rich1);

            
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            nazv ="Юбилей";
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Заведующая компания:";
            label1.Width = 250;
            label1.Location = new Point(10, 10);
            this.Controls.Add(label1);

            check1 = new CheckBox();
            check1.Text = "Желание обсудить детали с ведущим лично";
            check1.Width = 250;
            check1.Location = new Point(80, 30);
            this.Controls.Add(check1);

            radio1 = new RadioButton();
            radio1.Text = "Алпес";
            radio1.Location = new Point(10, 30);
            this.Controls.Add(radio1);

            radio2 = new RadioButton();
            radio2.Text = "Лейнар";
            radio2.Location = new Point(10, 50);
            this.Controls.Add(radio2);

            radio3 = new RadioButton();
            radio3.Text = "Дарвин";
            radio3.Location = new Point(10, 70);
            this.Controls.Add(radio3);

            Label label2 = new Label();
            label2.Text = "ФИО";
            label2.Width = 250;
            label2.Location = new Point(10, 100);
            this.Controls.Add(label2);

            text1 = new TextBox();
            text1.Width = 250;
            text1.Location = new Point(10, 125);
            this.Controls.Add(text1);

            Label label3 = new Label();
            label3.Text = "Серия/Номер Паспорта";
            label3.Width = 250;
            label3.Location = new Point(10, 150);
            this.Controls.Add(label3);

            text2 = new TextBox();
            text2.Width = 250;
            text2.Location = new Point(10, 175);
            this.Controls.Add(text2);

            Label label4 = new Label();
            label4.Text = "Контактный Номер Телефона";
            label4.Width = 250;
            label4.Location = new Point(10, 200);
            this.Controls.Add(label4);

            text3 = new TextBox();
            text3.Width = 250;
            text3.Location = new Point(10, 225);
            this.Controls.Add(text3);

            Label label5 = new Label();
            label5.Text = "Кол-во Человек";
            label5.Width = 250;
            label5.Location = new Point(10, 250);
            this.Controls.Add(label5);

            text4 = new TextBox();
            text4.Width = 250;
            text4.Location = new Point(10, 275);
            this.Controls.Add(text4);

            Label label6 = new Label();
            label6.Text = "ФИО \"виновника торжества\" (При отсутствии введите \"-\")";
            label6.Width = 320;
            label6.Location = new Point(10, 300);
            this.Controls.Add(label6);

            text5 = new TextBox();
            text5.Width = 250;
            text5.Location = new Point(10, 325);
            this.Controls.Add(text5);

            Label label7 = new Label();
            label7.Text = "Место проведения";
            label7.Width = 250;
            label7.Location = new Point(10, 350);
            this.Controls.Add(label7);

            text6 = new TextBox();
            text6.Width = 250;
            text6.Location = new Point(10, 375);
            this.Controls.Add(text6);

            Label label8 = new Label();
            label8.Text = "Тематика Праздника (При отсутствии введите \"-\")";
            label8.Width = 320;
            label8.Location = new Point(10, 400);
            this.Controls.Add(label8);

            text7 = new TextBox();
            text7.Width = 250;
            text7.Location = new Point(10, 425);
            this.Controls.Add(text7);

            Button button5 = new Button();
            button5.Text = "Далее";
            button5.Size = new Size(770, 100);
            button5.Location = new Point(10, 450);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            Label label9 = new Label();
            label9.Text = "Поле индивидуальных предпочтений и пожеланий (При отсутствии введите \"-\")";
            label9.Width = 450;
            label9.Location = new Point(350, 10);
            this.Controls.Add(label9);

            rich1 = new RichTextBox();
            rich1.Size = new Size(400, 400);
            rich1.Location = new Point(350, 35);
            this.Controls.Add(rich1);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            nazv = "День Рождения";
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Заведующая компания:";
            label1.Width = 250;
            label1.Location = new Point(10, 10);
            this.Controls.Add(label1);

            check1 = new CheckBox();
            check1.Text = "Желание обсудить детали с ведущим лично";
            check1.Width = 250;
            check1.Location = new Point(80, 30);
            this.Controls.Add(check1);

            radio1 = new RadioButton();
            radio1.Text = "Алпес";
            radio1.Location = new Point(10, 30);
            this.Controls.Add(radio1);

            radio2 = new RadioButton();
            radio2.Text = "Лейнар";
            radio2.Location = new Point(10, 50);
            this.Controls.Add(radio2);

            radio3 = new RadioButton();
            radio3.Text = "Дарвин";
            radio3.Location = new Point(10, 70);
            this.Controls.Add(radio3);

            Label label2 = new Label();
            label2.Text = "ФИО";
            label2.Width = 250;
            label2.Location = new Point(10, 100);
            this.Controls.Add(label2);

            text1 = new TextBox();
            text1.Width = 250;
            text1.Location = new Point(10, 125);
            this.Controls.Add(text1);

            Label label3 = new Label();
            label3.Text = "Серия/Номер Паспорта";
            label3.Width = 250;
            label3.Location = new Point(10, 150);
            this.Controls.Add(label3);

            text2 = new TextBox();
            text2.Width = 250;
            text2.Location = new Point(10, 175);
            this.Controls.Add(text2);

            Label label4 = new Label();
            label4.Text = "Контактный Номер Телефона";
            label4.Width = 250;
            label4.Location = new Point(10, 200);
            this.Controls.Add(label4);

            text3 = new TextBox();
            text3.Width = 250;
            text3.Location = new Point(10, 225);
            this.Controls.Add(text3);

            Label label5 = new Label();
            label5.Text = "Кол-во Человек";
            label5.Width = 250;
            label5.Location = new Point(10, 250);
            this.Controls.Add(label5);

            text4 = new TextBox();
            text4.Width = 250;
            text4.Location = new Point(10, 275);
            this.Controls.Add(text4);

            Label label6 = new Label();
            label6.Text = "ФИО \"виновника торжества\" (При отсутствии введите \"-\")";
            label6.Width = 320;
            label6.Location = new Point(10, 300);
            this.Controls.Add(label6);

            text5 = new TextBox();
            text5.Width = 250;
            text5.Location = new Point(10, 325);
            this.Controls.Add(text5);

            Label label7 = new Label();
            label7.Text = "Место проведения";
            label7.Width = 250;
            label7.Location = new Point(10, 350);
            this.Controls.Add(label7);

            text6 = new TextBox();
            text6.Width = 250;
            text6.Location = new Point(10, 375);
            this.Controls.Add(text6);

            Label label8 = new Label();
            label8.Text = "Тематика Праздника (При отсутствии введите \"-\")";
            label8.Width = 320;
            label8.Location = new Point(10, 400);
            this.Controls.Add(label8);

            text7 = new TextBox();
            text7.Width = 250;
            text7.Location = new Point(10, 425);
            this.Controls.Add(text7);

            Button button5 = new Button();
            button5.Text = "Далее";
            button5.Size = new Size(770, 100);
            button5.Location = new Point(10, 450);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            Label label9 = new Label();
            label9.Text = "Поле индивидуальных предпочтений и пожеланий (При отсутствии введите \"-\")";
            label9.Width = 450;
            label9.Location = new Point(350, 10);
            this.Controls.Add(label9);

            rich1 = new RichTextBox();
            rich1.Size = new Size(400, 400);
            rich1.Location = new Point(350, 35);
            this.Controls.Add(rich1);
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            nazv = "Выпускной";
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Заведующая компания:";
            label1.Width = 250;
            label1.Location = new Point(10, 10);
            this.Controls.Add(label1);

            check1 = new CheckBox();
            check1.Text = "Желание обсудить детали с ведущим лично";
            check1.Width = 250;
            check1.Location = new Point(80, 30);
            this.Controls.Add(check1);

            radio1 = new RadioButton();
            radio1.Text = "Алпес";
            radio1.Location = new Point(10, 30);
            this.Controls.Add(radio1);

            radio2 = new RadioButton();
            radio2.Text = "Лейнар";
            radio2.Location = new Point(10, 50);
            this.Controls.Add(radio2);

            radio3 = new RadioButton();
            radio3.Text = "Дарвин";
            radio3.Location = new Point(10, 70);
            this.Controls.Add(radio3);

            Label label2 = new Label();
            label2.Text = "ФИО";
            label2.Width = 250;
            label2.Location = new Point(10, 100);
            this.Controls.Add(label2);

            text1 = new TextBox();
            text1.Width = 250;
            text1.Location = new Point(10, 125);
            this.Controls.Add(text1);

            Label label3 = new Label();
            label3.Text = "Серия/Номер Паспорта";
            label3.Width = 250;
            label3.Location = new Point(10, 150);
            this.Controls.Add(label3);

            text2 = new TextBox();
            text2.Width = 250;
            text2.Location = new Point(10, 175);
            this.Controls.Add(text2);

            Label label4 = new Label();
            label4.Text = "Контактный Номер Телефона";
            label4.Width = 250;
            label4.Location = new Point(10, 200);
            this.Controls.Add(label4);

            text3 = new TextBox();
            text3.Width = 250;
            text3.Location = new Point(10, 225);
            this.Controls.Add(text3);

            Label label5 = new Label();
            label5.Text = "Кол-во Человек";
            label5.Width = 250;
            label5.Location = new Point(10, 250);
            this.Controls.Add(label5);

            text4 = new TextBox();
            text4.Width = 250;
            text4.Location = new Point(10, 275);
            this.Controls.Add(text4);

            Label label6 = new Label();
            label6.Text = "ФИО \"виновника торжества\" (При отсутствии введите \"-\")";
            label6.Width = 320;
            label6.Location = new Point(10, 300);
            this.Controls.Add(label6);

            text5 = new TextBox();
            text5.Width = 250;
            text5.Location = new Point(10, 325);
            this.Controls.Add(text5);

            Label label7 = new Label();
            label7.Text = "Место проведения";
            label7.Width = 250;
            label7.Location = new Point(10, 350);
            this.Controls.Add(label7);

            text6 = new TextBox();
            text6.Width = 250;
            text6.Location = new Point(10, 375);
            this.Controls.Add(text6);

            Label label8 = new Label();
            label8.Text = "Тематика Праздника (При отсутствии введите \"-\")";
            label8.Width = 320;
            label8.Location = new Point(10, 400);
            this.Controls.Add(label8);

            text7 = new TextBox();
            text7.Width = 250;
            text7.Location = new Point(10, 425);
            this.Controls.Add(text7);

            Button button5 = new Button();
            button5.Text = "Далее";
            button5.Size = new Size(770, 100);
            button5.Location = new Point(10, 450);
            button5.Click += new EventHandler(button5_Click);
            this.Controls.Add(button5);

            Label label9 = new Label();
            label9.Text = "Поле индивидуальных предпочтений и пожеланий (При отсутствии введите \"-\")";
            label9.Width = 450;
            label9.Location = new Point(350, 10);
            this.Controls.Add(label9);

            rich1 = new RichTextBox();
            rich1.Size = new Size(400, 400);
            rich1.Location = new Point(350, 35);
            this.Controls.Add(rich1);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            Label label1 = new Label();
            label1.Width = 300;
            label1.Text = "Итоговая Цена:";
            label1.Location = new Point(300, 150);
            this.Controls.Add(label1);

            

            int flag_cena=0, flag_box;
            if (nazv == "Свадьба") flag_cena = 5000;
            if (nazv == "Юбилей") flag_cena = 6000;
            if (nazv == "День Рождения") flag_cena = 9000;
            if (nazv == "Выпускной") flag_cena = 13000;
            int ID = 3;
            if (check1.Checked == true) flag_box = 1; else flag_box = 0;

            Label label2 = new Label();
            label2.Width = 300;
            label2.Location = new Point(320, 190);
            label2.Text = Convert.ToString(flag_cena);
            this.Controls.Add(label2);

            Button buttonEND = new Button();
            buttonEND.Size = new Size(200,200);
            buttonEND.Text = "Оплатить";
            buttonEND.Location = new Point(240, 250);
            buttonEND.Click += new EventHandler(button6_Click);
            this.Controls.Add(buttonEND);

            

            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            string CommandText = "INSERT INTO merop (`Company`, `FIO`, `Pasport`, `Tel_number`, `Kol-vo_chel`, `FIO_ubil`, `Mesto`, `Tema`, `Individ`, `Cena`, `Nazvan_Merop`, `ID_manager`, `Vstrecha`) VALUES (@Company, @FIO, @Pasport, @Tel_number, @Kol, @FIO_ubil, @Mesto, @Tema, @Individ, @Cena, @Nazvan_Merop, @ID_man, @Vstrecha)";
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);

            if (radio1.Checked)
            {
                myCommand.Parameters.Add("@Company", MySqlDbType.VarChar).Value = radio1.Text;
            }
            else
            if (radio2.Checked)
            {
                myCommand.Parameters.Add("@Company", MySqlDbType.VarChar).Value = radio2.Text;
            }
            else
            if (radio3.Checked)
            {
                myCommand.Parameters.Add("@Company", MySqlDbType.VarChar).Value = radio3.Text;
            }
            myCommand.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = text1.Text;

            myCommand.Parameters.Add("@Pasport", MySqlDbType.VarChar).Value = text2.Text;

            myCommand.Parameters.Add("@Tel_number", MySqlDbType.VarChar).Value = text3.Text;

            myCommand.Parameters.Add("@Kol", MySqlDbType.VarChar).Value = text4.Text;

            myCommand.Parameters.Add("@FIO_ubil", MySqlDbType.VarChar).Value = text5.Text;

            myCommand.Parameters.Add("@Mesto", MySqlDbType.VarChar).Value = text6.Text;

            myCommand.Parameters.Add("@Tema", MySqlDbType.VarChar).Value = text7.Text;

            myCommand.Parameters.Add("@Individ", MySqlDbType.VarChar).Value = rich1.Text;

            myCommand.Parameters.Add("@Cena", MySqlDbType.Int32).Value = flag_cena;

            myCommand.Parameters.Add("@Nazvan_Merop", MySqlDbType.VarChar).Value = nazv;

            myCommand.Parameters.Add("@ID_man", MySqlDbType.Int32).Value = ID;

            myCommand.Parameters.Add("@Vstrecha", MySqlDbType.Int32).Value = flag_box;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        private void button6_Click(object sender, System.EventArgs e)
        {
            this.Controls.Clear();
            MessageBox.Show("Спасибо за заказ!");
        }
    }
}
