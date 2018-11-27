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
    public partial class GoodDetails : Form
    {
        public GoodDetails()
        {
            InitializeComponent();

        }

        private void GoodDetails_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = post;
        }
    }
}
