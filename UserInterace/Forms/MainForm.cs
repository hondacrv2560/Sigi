using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterace.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Login from login form");
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Post post = listbox.SelectedItem;
            GoodDetails goodDetails = new GoodDetails(post);
            goodDetails.Show();
        }
    }
}
