using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОЖС_game
{
    public partial class CollectionP2 : Form
    {
        Thread openNextpage;
        public static int rndLoot;
        public CollectionP2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            openNextpage = new Thread(open);
            openNextpage.SetApartmentState(ApartmentState.STA);
            openNextpage.Start();
        }

        public void open()
        {
            Application.Run(new Collection());
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            this.Close();
            openNextpage = new Thread(open1);
            openNextpage.SetApartmentState(ApartmentState.STA);
            openNextpage.Start();
        }

        public void open1()
        {
            Application.Run(new CollectionP3());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
