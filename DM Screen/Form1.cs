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
        String[] campaign;
        public DMScreen()
        {
            InitializeComponent();
            loadCampaigns();
        }

        

        private void cmd_Campaign_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void cmd_addNewCampaign_Click(object sender, EventArgs e)
        {
            CreateCampaign c = new CreateCampaign();
            c.ShowDialog();

            int n = Int32.Parse(campaign[0]) + 1;
            campaign[0] = n.ToString();
        }

        private void loadCampaigns()
        {
            campaign = System.IO.File.ReadAllLines(@"res\campaigns\campaigns.txt");
            NUMBER_OF_CAMPAIGNS = Int32.Parse(campaign[0]);
            for (int i = 0; i < NUMBER_OF_CAMPAIGNS; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                btn.Text = campaign[i + 1];
                btn.Click += cmd_Campaign_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
;