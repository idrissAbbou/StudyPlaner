using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPlan
{
    public partial class Plan : UserControl
    {
        public Plan()
        {
            InitializeComponent();
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.DayOfWeek.ToString() ;
        }
    }
}
