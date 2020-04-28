using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiButtonGenerator
{
    public partial class ApiTesterFrm : Form
    {
        public ApiTesterFrm()
        {
            InitializeComponent();
        }

        private async void RdmJokeBtn_Click(object sender, EventArgs e)
        {
            Joke norrisJoke = await ChuckNorrisClient.GetRandomJokes();
            Txtbox.Text = norrisJoke.JokeText;
        }
    }
}
