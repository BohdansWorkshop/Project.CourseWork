using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFrstTry
{
    public partial class UcEditVisitor : UserControl, IVisitorStorage
    {
        private readonly Visitor _editedItem;
        public UcEditVisitor(Visitor item)
        {
            InitializeComponent();
            RefillComboBox();         
            _editedItem = item;
            tbName.Text = item.Name;
            cbDestination.SelectedItem = (object)item.Destination;
        }
        public Visitor GetVisitor()
        {
            _editedItem.Name = tbName.Text.Trim();
            _editedItem.Destination = (VisitorDestination)cbDestination.SelectedItem;
            _editedItem.editedTime = DateTime.Now;
            return _editedItem;
        }

        private void RefillComboBox()
        {
            object[] elements = Enum.GetValues(typeof(VisitorDestination)).Cast<object>().ToArray();
            cbDestination.Items.AddRange(elements);
            cbDestination.SelectedIndex = 0;
        }
    }
}
