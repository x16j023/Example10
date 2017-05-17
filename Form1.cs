using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example10
{
    public partial class 年齢判定 : Form
    {
        public 年齢判定()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            int age = int.Parse(tbxAge.Text);
             if (age == 60)
                lblresult.Text = "還暦です";
             else if (age >= 20)
                lblresult.Text = "成人です";
            
             else
                lblresult.Text = "未成年です";
        }
    }
}
