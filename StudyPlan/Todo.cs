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
    public partial class Todo : UserControl
    {
        public Todo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            
        }
    }
}
