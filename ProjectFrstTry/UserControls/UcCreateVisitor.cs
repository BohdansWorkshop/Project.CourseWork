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
    public partial class UcCreateVisitor : UserControl, IVisitorStorage
    {
        private readonly VisitorsDbContext _context;
        public UcCreateVisitor(VisitorsDbContext context)
        {
            InitializeComponent();
            RefillComboBox();
            _context = context;
            RefillVisitorTypes();
        }
        private void RefillVisitorTypes()
        {
            //Создаем список корневых елементов дерева и записываем в него те элементы
            //которые в базе данных не имеют родительского элемента 
            List<VisitorType> coreNodes = _context.VisitorTypes.Where(x => x.Parent == null).ToList();
            //проходим по списку корневых элементов
            foreach (var node in coreNodes)
            {
                //создаем элемент дерева
                TreeNode coreNode = new TreeNode(node.Name);
                //записываем в тег элемента его айди в базе 
                //(для последующей идентификации выбраного элемента на форме)
                coreNode.Tag = node.Id;
                //Вызываем рекурсивную функцыю для заполнения ветвей и листов дерева
                RecursionFillTreeViewNodes(_context.VisitorTypes.ToList(), node.Id, coreNode);
                //добавляем к контролу tvAnimalTypes созданный ранее элемент дерева
                tvVisitorTypes.Nodes.Add(coreNode);
            }
        }
        private void RefillComboBox()
        {
            //получаем все элементы енама AnimalSize
            object[] elements = Enum.GetValues(typeof(VisitorDestination)).Cast<object>().ToArray();
            //добавляем значение энама в выпадающий список
            cbDestination.Items.AddRange(elements);
            //выбираем в выпадающем списке первый элемент
            cbDestination.SelectedIndex = 0;
        }
  
        private void RecursionFillTreeViewNodes(List<VisitorType> visitorTypes, Guid parentId, TreeNode parentNode)
        {
            //Получаем список всех дочерних типов для текущего типа
            List<VisitorType> childTypes = visitorTypes.Where(x => x.Parent?.Id == parentId).ToList();
            //проходим по списку дочерних типов
            foreach (var visitorType in childTypes)
            {
                //создаем елемент дерева для текущего типа
                TreeNode currentNode = new TreeNode(visitorType.Name);
                //записываем в тег элемента его айди в базе 
                //(для последующей идентификации выбраного элемента на форме)
                currentNode.Tag = visitorType.Id;

                //проверяем есть ли типы для которых текущий тип является родительским
                if (visitorTypes.Any(x => x.Parent?.Id == visitorType.Id))
                {
                    //если есть - рекурсивно вызываем функцию для заполнения элемента дерева
                    RecursionFillTreeViewNodes(visitorTypes, visitorType.Id, currentNode);
                }
                //добавляем к родительскому элементу дерева текущий элемент
                parentNode.Nodes.Add(currentNode);
            }
        }
        public Visitor GetVisitor()
        {//сделай проверку на нал для tvVisitorTypes.SelectedNode
            if (tvVisitorTypes.SelectedNode == null)
            {
                tvVisitorTypes.SelectedNode.Tag = tvVisitorTypes.TopNode;
            }
            var a = new Visitor
            {
                Name = tbName.Text,
                Destination = (VisitorDestination)cbDestination.SelectedItem,
                CreateDate = dtpCreateDate.Value,
                Type = _context.VisitorTypes.Find(tvVisitorTypes.SelectedNode.Tag),
                editedTime = dtpCreateDate.Value,
            };
            return a;
        }
    }
}
