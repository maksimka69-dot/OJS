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
    public partial class Menu : Form
    {
        Thread openNextpage;
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            openNextpage = new Thread(open1);
            openNextpage.SetApartmentState(ApartmentState.STA);
            openNextpage.Start();
        }

        public void open1()
        {
            Application.Run(new Market());
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

        }
    }
}
