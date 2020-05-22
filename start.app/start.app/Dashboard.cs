using start.app.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start.app
{
    public partial class Dashboard : Form
    {
        private bool isCollapse = true;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void timerManagerDropDown_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                btnManagement.Image = Resources.collapse;
                panelManagementMenu.Height += 10;
                if (panelManagementMenu.Size == panelManagementMenu.MaximumSize)
                {
                    timerManagerDropDown.Stop();
                    isCollapse = false;
                }
            } 
            else
            {
                btnManagement.Image = Resources.expand;
                panelManagementMenu.Height -= 10;
                if (panelManagementMenu.Size == panelManagementMenu.MinimumSize)
                {
                    timerManagerDropDown.Stop();
                    isCollapse = true;
                }
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            timerManagerDropDown.Start();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            LihatBarang childForm = new LihatBarang();

            childForm.TopLevel = false;

            childForm.Parent = this;

            childForm.StartPosition = FormStartPosition.Manual;

            childForm.Location = new Point(193, 56);

            childForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
