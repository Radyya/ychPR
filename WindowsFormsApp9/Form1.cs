using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ychebka123DataSet.motherboard". При необходимости она может быть перемещена или удалена.
            this.motherboardTableAdapter.Fill(this.ychebka123DataSet.motherboard);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ychebka123DataSet._case". При необходимости она может быть перемещена или удалена.
            this.caseTableAdapter.Fill(this.ychebka123DataSet._case);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ychebka123DataSet.ram". При необходимости она может быть перемещена или удалена.
            this.ramTableAdapter1.Fill(this.ychebka123DataSet.ram);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ychebka123DataSet.gpu". При необходимости она может быть перемещена или удалена.
            this.gpuTableAdapter1.Fill(this.ychebka123DataSet.gpu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ychebka123DataSet.cpu". При необходимости она может быть перемещена или удалена.
            this.cpuTableAdapter1.Fill(this.ychebka123DataSet.cpu);
            this.ramTableAdapter.Fill(this.ychebkaDataSet.ram);
            this.gpuTableAdapter.Fill(this.ychebkaDataSet.gpu);
            this.cpuTableAdapter.Fill(this.ychebkaDataSet.cpu);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из textbox
                double value1 = double.Parse(textBox1.Text);
                double value2 = double.Parse(textBox2.Text);
                double value3 = double.Parse(textBox3.Text);
                double value4 = double.Parse(textBox4.Text);
                double value5 = double.Parse(textBox5.Text);

                // Вычисляем общую цену
                double totalPrice = value1 + value2 + value3 + value4 + value5;

                // Выводим общую цену в label
                label1.Text = "Общая цена сборки: " + totalPrice.ToString("F2");
                label1.Visible = true;
            }
            catch (FormatException)
            {
                // Если в textbox введено некорректное значение, выводим сообщение об ошибке
                label1.Text = "Введите корректные значения в поля для ввода.";
                label1.Visible = true;
            }
            catch (Exception ex)
            {
                // Обрабатываем другие исключения
                label1.Text = "Произошла ошибка: " + ex.Message;
                label1.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
