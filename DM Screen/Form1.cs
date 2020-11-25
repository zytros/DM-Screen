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
        CampaignScreen cs = new CampaignScreen();
        int NUMBER_OF_CAMPAIGNS;
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

        }

        private void loadCampaigns()
        {
            cs.loadCampaignString();
            NUMBER_OF_CAMPAIGNS = Int32.Parse(cs.campaign[0]);
            for (int i = 0; i < NUMBER_OF_CAMPAIGNS; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                btn.Text = cs.campaign[i + 1];
                btn.Click += cmd_Campaign_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
;