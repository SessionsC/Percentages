using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percentages
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
           
            Playbutton.Visible = false;
            Leaderboard.Visible = false;
            lblleader.Visible = false;

            
        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
            this.Hide();
                

        }

        private void LoadLeaderBoard(object sender, EventArgs e)
        {
            LeaderBoard LeaderWindow = new LeaderBoard();
            LeaderWindow.Show();
            this.Hide();
        }
    }
}
