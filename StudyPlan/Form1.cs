using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyPlan
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        addItems addItems = new addItems();
        Todo todo = new Todo();
        Plan plan = new Plan();
        public Form1()
        {

            InitializeComponent();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            timer.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(timer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItems.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(addItems);

        }

        private void addItems1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            todo.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(todo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plan.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(plan);
        }
    }
}
