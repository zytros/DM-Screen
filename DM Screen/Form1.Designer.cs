
namespace DM_Screen
{
    partial class DMScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmd_addNewCampaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 607);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmd_addNewCampaign
            // 
            this.cmd_addNewCampaign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_addNewCampaign.Location = new System.Drawing.Point(1069, 12);
            this.cmd_addNewCampaign.Name = "cmd_addNewCampaign";
            this.cmd_addNewCampaign.Size = new System.Drawing.Size(143, 23);
            this.cmd_addNewCampaign.TabIndex = 2;
            this.cmd_addNewCampaign.Text = "Add new Campaign";
            this.cmd_addNewCampaign.UseVisualStyleBackColor = true;
            this.cmd_addNewCampaign.Click += new System.EventHandler(this.cmd_addNewCampaign_Click);
            // 
            // DMScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.cmd_addNewCampaign);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DMScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DM Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button cmd_addNewCampaign;
    }
}

