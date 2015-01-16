using System;
using System.Windows.Forms;

namespace DeltaUpdate
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowResult()
        {
            // Enable checkbox if disabled.
            if (!cb_loopSounder.Enabled)
                cb_loopSounder.Enabled = true;
            
            // Display software and action text.
            if (rb_singleGroup.Checked && !cb_loopSounder.Checked)
            {
                tb_Software.Text = "Alle versjoner, bortsett fra 2.40";
                tb_Action.Text = "Ingen\r\nHvis 2.40, oppgrader til 2.81";
            }
            else if (rb_singleGroup.Checked && cb_loopSounder.Checked)
            {
                tb_Software.Text = "T.o.m 2.30 og f.o.m 2.80";
                tb_Action.Text = "Oppgrader 2.40 - 2.71 til 2.81";
            }
            else if (rb_mulipleGroup.Checked && !cb_loopSounder.Checked)
            {
                tb_Software.Text = "T.o.m 2.10 og f.o.m 2.50";
                tb_Action.Text = "Oppgrader 2.20 - 2.40 til 2.81";
            }
            else if (rb_mulipleGroup.Checked && cb_loopSounder.Checked)
            {
                tb_Software.Text = "T.o.m 2.10 og f.o.m 2.80";
                tb_Action.Text = "Oppgrader 2.20 - 2.71 til 2.81";
            }
            else
            {
                tb_Software.Text = "";
                tb_Action.Text = "";
            }
        }

        private void rb_singleGroup_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_singleGroup.Checked)
                ShowResult();
        }

        private void rb_mulipleGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mulipleGroup.Checked)
                ShowResult();
        }

        private void cb_loopSounder_CheckedChanged(object sender, EventArgs e)
        {
            ShowResult();
        }
    }
}
