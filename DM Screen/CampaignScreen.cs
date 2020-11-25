using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Screen
{
    class CampaignScreen
    {
        public String[] campaign;
        public void loadCampaignString()
        {
            campaign = System.IO.File.ReadAllLines(@"res\campaigns\campaigns.txt");
        }
    }
}
