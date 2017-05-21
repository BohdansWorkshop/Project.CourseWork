using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFrstTry
{
    public partial class Registration : Form
    {
        private readonly ElementState _state;
        private readonly VisitorsDbContext _context;
        public Registration(Visitor item, VisitorsDbContext context)
        {
            _context = context;
            InitializeComponent();
            var control = new UcEditVisitor(item);
            splitContainer1.Panel1.Controls.Add(control);
            splitContainer1.Panel1.Controls[0].Dock = DockStyle.Fill;
            _state = ElementState.Edit;
            this.Text = $"Edit visitor {item.Name}";
        }
        public Registration(VisitorsDbContext context)
        {
            _context = context;
            InitializeComponent();
            _state = ElementState.New;
            var control = new UcCreateVisitor(_context);   
            splitContainer1.Panel1.Controls.Add(control);
            splitContainer1.Panel1.Controls[0].Dock = DockStyle.Fill;

            this.Text = "Create new visitor";
        }

        //private void Registration_Load(object sender, EventArgs e)
        //{
        // VisitorDestination[] elements = Enum.GetValues(typeof (VisitorDestination)).Cast<VisitorDestination>().ToArray();
        //    cbDestination.Items.AddRange(elements.Cast<object>().ToArray());
        //    cbDestination.SelectedIndex = 0;
        //}


        private void btOk_Click(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var editedVisitor = ((IVisitorStorage)splitContainer1.Panel1.Controls[0]).GetVisitor();
                _context.Visitors.AddOrUpdate(editedVisitor);
                _context.SaveChanges();
            }
        }
    }
}
