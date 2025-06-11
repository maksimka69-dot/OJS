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
    public partial class Main_Menu : Form
    {
        Thread openNextpage;
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            this.Close();
            openNextpage = new Thread(open);
            openNextpage.SetApartmentState(ApartmentState.STA);
            openNextpage.Start();
        }

        public void open()
        {
            Application.Run(new Menu());
        }
    }
}
