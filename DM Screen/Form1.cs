using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Screen
{

    public partial class DMScreen : Form
    {
        int NUMBER_OF_CAMPAIGNS;

        Button[] campaigns;
        public DMScreen()
        {
            String[] campaign = System.IO.File.ReadAllLines(@"C:\Users\Lucalel\source\repos\DM Screen\DM Screen\res\campaigns\campaigns.txt");
            NUMBER_OF_CAMPAIGNS = Int32.Parse(campaign[0]);
            InitializeComponent();
            buttonArray(10);
        }

        private void buttonArray(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                btn.Text = i.ToString();
                btn.Click += cmd_Campaign_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void cmd_Campaign_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lbl_1.Text = lbl_1.Text + btn.Text;
        }
    }
}
