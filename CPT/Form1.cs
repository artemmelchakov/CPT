using CPT.Models;
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
using System.Xml.Serialization;

namespace CPT
{
    public partial class Form1 : Form
    {
        private List<TreeNode> checkedNodesInTreeView1 = new List<TreeNode>();
        public Form1()
        {
            InitializeComponent();
        }

        private List<IEntity> GetEntitiesFromCheckedNodes()
        {
            List<IEntity> entities = new List<IEntity>();
            foreach (TreeNode headerNode in treeView1.Nodes)
            {
                foreach (TreeNodeWithEntity node in headerNode.Nodes)
                {
                    if (node.Checked)
                    {
                        entities.Add(node.entity);
                    }
                }
            }
            return entities;
        }

        private void сохранитьВXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<IEntity> entities = GetEntitiesFromCheckedNodes();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ArrayOfEntities arrayOfEntities = new ArrayOfEntities(entities);
                Data.Serialize(saveFileDialog.FileName, arrayOfEntities);                               
                toolStripStatusLabel1.Text = "Сохранение завершено. " + DateTime.Now;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Init();
            GetEntitiesInTreeView(Data.Parcels, treeView1.Nodes.Add("Parcels").Nodes);
        }

        private void GetEntitiesInTreeView(IEntity[] entityList, TreeNodeCollection treeNodeCollection)
        {
            foreach (var entity in entityList)
            {
                treeNodeCollection.Add(new TreeNodeWithEntity(entity.GetId(), entity));
            }
        }
    }
}
