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
    public partial class Collection : Form
    {
        Thread openNextpage;
        public Collection()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            this.Close();
            openNextpage = new Thread(open);
            openNextpage.SetApartmentState(ApartmentState.STA);
            openNextpage.Start();
        }
        public void open()
        {
            Application.Run(new CollectionP2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Местер мем \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Простейшие", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Больной на голову \n Класс: Безумцы \n Настроение: НЕИЗВЕСТНО \n Жизней = 1000 \n Сила: 500 \n Комбенации: RIP", "Легендарный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Персонаж: ФЛЕШка \n Класс: Мыслитель \n Настроение: Добри \n Жизней = 500 \n Сила: 250 \n Комбенации: Простейшие", "Удивительный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Детка забудь меня \n Класс: Мыслитель \n Настроение: Спокойнойствие \n Жизней = 500 \n Сила: 250 \n Комбенации: Простейшие", "Удивительный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж:Стильный диктатор \n Класс: Стиль \n Настроение: НЕИЗВЕСТНО \n Жизней = 1000 \n Сила: 500 \n Комбенации: RIP", "Легендарный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Сонное цаство \n Класс: Штиль \n Настроение: Спокойствие \n Жизней = 100 \n Сила: 50 \n Комбенации: Классовые", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Одинокий волк \n Класс: Миф \n Настроение: Нету \n Жизней = 10 \n Сила: 5 \n Комбенации: Нету", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Довольный муж \n Класс: Семейный \n Настроение: Радость \n Жизней = 1000 \n Сила: 500 \n Комбенации: Муж и жена-одна сатана", "Мифический персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Что отличает негра от раба \n Класс: Шутники \n Настроение: Смех \n Жизней = 100 \n Сила: 50 \n Комбенации: Классовые", "Удивительный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Красивый шрек \n Класс: Штиль \n Настроение: Радость \n Жизней = 100 \n Сила: 50 \n Комбенации: Классовые", "Обычный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Персонаж: Карл \n Класс: Штиль \n Настроение: Спакойствие \n Жизней = 500 \n Сила: 250 \n Комбенации: Классовые", "Легендарный персонаж", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
