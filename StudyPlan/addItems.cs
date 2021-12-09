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
    public partial class addItems : UserControl
    {
        const string itemCue = "Add an item";
        const string categoryCue = "Category";
        StudyContext context = new StudyContext();
        List<Subject> subjects;
        public addItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject s = new Subject();
            var val = 0;
            if(int.TryParse(txtId.Text, out val)) s.Id = int.Parse(txtId.Text);
            s.Item = textBox1.Text;
            s.Category = txtCategory.Text;
            s.TotalHours = 0;

            var subjectExist = context.subjects.Where(es => es.Id == s.Id).FirstOrDefault();
            if (subjectExist == null)
            {
                context.subjects.Add(s);
            } else
            {
                subjectExist.Item = s.Item;
                subjectExist.Category = s.Category;
            }
            
            context.SaveChanges();
            populateListView();
            showItemHint();

        }

        private void addItems_Load(object sender, EventArgs e)
        {
            showItemHint();
            showCategoryHint();
            populateListView();
            CalculateTotalHours();
        }
        private void CalculateTotalHours()
        {
            var total = context.subjects.Sum(s => s.TotalHours);
            TimeSpan time = TimeSpan.FromSeconds(total);
            totalHoursLabel.Text = String.Format("Total Hours: {3}D:{0}H:{1}M:{2}S", time.Hours, time.Minutes, time.Seconds, time.Days);
        }
        private void populateListView()
        {
            listView1.Items.Clear();
            subjects = context.subjects.Select(s => s).ToList();
            foreach (var s in subjects)
            {
                ListViewItem item = new ListViewItem();
                item.Text = s.Item.Substring(0, 1).ToUpper() + s.Item.Substring(1, s.Item.Length - 1);
                item.SubItems.Add(s.Category.Substring(0,1).ToUpper() + s.Category.Substring(1,s.Category.Length - 1));
                TimeSpan span = TimeSpan.FromSeconds(s.TotalHours);
                item.SubItems.Add(String.Format("{3}d:{0:D2}h:{1:D2}m:{2:D2}s", span.Hours, span.Minutes, span.Seconds, span.Days));
                item.SubItems.Add(s.Id.ToString());
                listView1.Items.Add(item);
            }
        }

        private void showItemHint()
        {
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = itemCue;
        }

        private void showCategoryHint()
        {
            txtCategory.ForeColor = Color.Gray;
            txtCategory.Text = categoryCue;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == itemCue) textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
            using (SolidBrush foreBrush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {

            if (txtCategory.Text == categoryCue) txtCategory.Clear();
            txtCategory.ForeColor = Color.Black;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                txtCategory.Text = item.SubItems[1].Text;
                txtId.Text = item.SubItems[3].Text;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                var subjectExist = context.subjects.Where(es => es.Item == item.Text).FirstOrDefault();
                context.subjects.Remove(subjectExist);
                context.SaveChanges();
            }
            populateListView();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            subjects = context.subjects.Select(s => s).OrderByDescending(s => s.TotalHours).ToList();
            foreach (var s in subjects)
            {
                ListViewItem item = new ListViewItem();
                item.Text = s.Item.Substring(0, 1).ToUpper() + s.Item.Substring(1, s.Item.Length - 1);
                item.SubItems.Add(s.Category.Substring(0, 1).ToUpper() + s.Category.Substring(1, s.Category.Length - 1));
                TimeSpan span = TimeSpan.FromSeconds(s.TotalHours);
                item.SubItems.Add(String.Format("{3}d:{0:D2}h:{1:D2}m:{2:D2}s", span.Hours, span.Minutes, span.Seconds, span.Days));

                item.SubItems.Add(s.Id.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
