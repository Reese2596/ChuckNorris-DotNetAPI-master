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

namespace ChuckApiTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCategories();
        }

        /// <summary>
        /// Generate random joke onto empty labelbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RdmJokeBtn_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            TextBox.Text = joke.JokeText;
        }

        /// <summary>
        /// Add categories to the dropdown list.
        /// </summary>
        private async void PopulateCategories()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var category in categories)
            {
                CategoryCb.Items.Add(category);
            }
        }
    }
}
