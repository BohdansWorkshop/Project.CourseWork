using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFrstTry
{
    public partial class MainForm : Form
    {
        private readonly VisitorsDbContext _context;

        public MainForm()
        {
         
            InitializeComponent();
            _context = new VisitorsDbContext();
            RefillListView();
        }

        private void RefillListView()
        {
            lvVisitors.Items.Clear();
            List<Visitor> Visitor = _context.Visitors.AsNoTracking().ToList();
            int visitorsCount = _context.Visitors.Count();
    
            for (int i = 0; i < visitorsCount; i++)
            {
                
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(Visitor[i].Name);
                item.SubItems.Add(Visitor[i].Destination.ToString());
                item.SubItems.Add(Visitor[i].CreateDate.ToString());
                item.SubItems.Add(Visitor[i].editedTime.ToString());
                item.SubItems.Add(Visitor[i].Id.ToString());
               
                lvVisitors.Items.Add(item);
            }
        }

        private void createVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Registration create = new Registration(_context);
            if (create.ShowDialog() == DialogResult.OK)
            {
                RefillListView();
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedVisitorCount = lvVisitors.SelectedItems.Count;
            if (selectedVisitorCount != 0)
            {
                ListViewItem selectedVisitor = lvVisitors.SelectedItems[0];
                Guid selectedId = Guid.Parse(selectedVisitor.SubItems[5].Text);
                Visitor visitor = _context.Visitors.First(x => x.Id == selectedId);

                Registration editForm = new Registration(visitor, _context);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefillListView();
                }
            }
        }

        private void removeVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isVisitorExists = _context.Visitors.Any();
            if (isVisitorExists)
            {
                int selectedVisitor = lvVisitors.SelectedItems.Count;
                if (selectedVisitor != 0)
                {
                    ListViewItem selectedItem = lvVisitors.SelectedItems[0];
                    Guid selectedId = Guid.Parse(selectedItem.SubItems[5].Text);
                    DeleteVisitor(GetVisitorById(selectedId));
                    RefillListView();
                }
            }
        }

        private Visitor GetVisitorById(Guid selectedId)
        {
            return _context.Visitors.First(x => x.Id == selectedId);
        }

        private void DeleteVisitor(Visitor chosenVisitor)
        {
            _context.Visitors.Remove(chosenVisitor);
            _context.SaveChanges();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var box = new AboutBox().ShowDialog();
        }

        private void importTocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open)))
                {
                    List<string> visitors = new List<string>();
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        visitors.Add(sr.ReadLine());
                    }

                    visitors.RemoveAt(visitors.Count - 1);

                    foreach (var animalItem in visitors)
                    {
                        var collection = animalItem.Split(',');
                        Visitor animal = new Visitor()
                        {
                            Name = collection[1],
                            Destination = (VisitorDestination)Enum.Parse(typeof(VisitorDestination), collection[2])
                        };
                        _context.Visitors.Add(animal);

                    }
                    sr.Close();
                }
                _context.SaveChanges();

                RefillListView();
            }
        }

        private void exportTocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_context.Visitors.Any())
            {
                MessageBox.Show("There are no animals, cannot create file!");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create)))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("#,Name,Size");
                    foreach (ListViewItem item in lvVisitors.Items)
                    {
                        sb.AppendLine($"{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text}");
                    }
                    sw.WriteLine(sb.ToString());
                    sw.Close();
                }

                MessageBox.Show("Saved");
            }
        }
        private void lvVisitors_Resize(object sender, EventArgs e)
        {
            ListView item = (ListView)sender;
            Size parentSize = item.Parent.Size;
            item.Columns[1].Width = parentSize.Width - 255;
        }
    }
}
