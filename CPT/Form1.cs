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
using System.Xml;
using System.Xml.Serialization;

namespace CPT
{
    public partial class Form1 : Form
    {
        private List<Parcel> SelectedParcels = new List<Parcel>();
        private List<Build> SelectedBuilds = new List<Build>();
        private List<Construction> SelectedConstructions = new List<Construction>();
        private List<SpatialDataEntity> SelectedSpatialDataEntities = new List<SpatialDataEntity>();
        private List<Bound> SelectedBounds = new List<Bound>();
        private List<Zone> SelectedZones = new List<Zone>();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// В данном методе происходит сохранение отмеченных ранее сущностей в treeView1
        /// в xml документ
        /// </summary>
        private void сохранитьВXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlEntitiesWrap xmlEntitiesWrapper = new XmlEntitiesWrap()
                {
                    Parcels = SelectedParcels.Count > 0 ? SelectedParcels : null,
                    Builds = SelectedBuilds.Count > 0 ? SelectedBuilds : null,
                    Constructions = SelectedConstructions.Count > 0 ? SelectedConstructions : null,
                    SpatialDataEntities = SelectedSpatialDataEntities.Count > 0 ? SelectedSpatialDataEntities : null,
                    Bounds = SelectedBounds.Count > 0 ? SelectedBounds : null,
                    Zones = SelectedZones.Count > 0 ? SelectedZones : null
                };

                XmlSerializer xmlSerializer;
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xmlSerializer = new XmlSerializer(typeof(XmlEntitiesWrap));
                    xmlSerializer.Serialize(fs, xmlEntitiesWrapper);
                    fs.Close();
                }

                toolStripStatusLabel1.Text = "Сохранение завершено. " + DateTime.Now;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.Init();

            GetEntitiesInTreeView(Data.Parcels, treeView1.Nodes.Add("Parcels").Nodes);

            TreeNode objectRealtyTreeNode = new TreeNode("ObjectRealty");
            treeView1.Nodes.Add(objectRealtyTreeNode);
            GetEntitiesInTreeView(Data.Builds.ToArray(), objectRealtyTreeNode.Nodes);
            GetEntitiesInTreeView(Data.Constructions.ToArray(), objectRealtyTreeNode.Nodes);

            GetEntitiesInTreeView(Data.SpatialData, treeView1.Nodes.Add("SpatialData").Nodes);
            GetEntitiesInTreeView(Data.Bounds, treeView1.Nodes.Add("Bounds").Nodes);
            GetEntitiesInTreeView(Data.Zones, treeView1.Nodes.Add("Zones").Nodes);
        }

        /// <summary>
        /// Метод добавляет ноды с идентификаторами сущностей в соответстующий нод treeNodeCollection
        /// </summary>
        /// <param name="entityList">Множество сущностей</param>
        /// <param name="treeNodeCollection">Нод, в который будут вноситься изменения</param>
        private void GetEntitiesInTreeView(IEntity[] entityList, TreeNodeCollection treeNodeCollection)
        {
            foreach (var entity in entityList)
            {
                treeNodeCollection.Add(new TreeNodeWithEntity(entity.Id, entity));
            }
        }

        /// <summary>
        /// Метод добавляет и удаляет отмеченные в treeView1 сущности в соответствующие списки, 
        /// чтобы потом можно было их выгрузить в xml документ
        /// </summary>
        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node as TreeNodeWithEntity;
            if (node is null) return;

            if (!e.Node.Checked)
            {
                if (node.entity is Parcel) SelectedParcels.Add((Parcel)node.entity);
                else if (node.entity is Build) SelectedBuilds.Add((Build)node.entity);
                else if (node.entity is SpatialDataEntity) SelectedSpatialDataEntities.Add((SpatialDataEntity)node.entity);
                else if (node.entity is Construction) SelectedConstructions.Add((Construction)node.entity);
                else if (node.entity is SpatialDataEntity) SelectedSpatialDataEntities.Add((SpatialDataEntity)node.entity);
                else if (node.entity is Bound) SelectedBounds.Add((Bound)node.entity);
                else if (node.entity is Zone) SelectedZones.Add((Zone)node.entity);
            }
            else
            {
                if (node.entity is Parcel) SelectedParcels.Remove((Parcel)node.entity);
                else if (node.entity is Build) SelectedBuilds.Remove((Build)node.entity);
                else if (node.entity is SpatialDataEntity) SelectedSpatialDataEntities.Remove((SpatialDataEntity)node.entity);
                else if (node.entity is Construction) SelectedConstructions.Remove((Construction)node.entity);                
                else if (node.entity is SpatialDataEntity) SelectedSpatialDataEntities.Remove((SpatialDataEntity)node.entity);
                else if (node.entity is Bound) SelectedBounds.Remove((Bound)node.entity);
                else if (node.entity is Zone) SelectedZones.Remove((Zone)node.entity);
            }
        }

        /// <summary>
        /// Метод выводит в richTextBox1 информацию о выбранной сущности
        /// </summary>
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (!(e.Node is TreeNodeWithEntity)) return;

            var node = (TreeNodeWithEntity)e.Node;
            if (node.entity is IShowable)
            {
                ((IShowable)node.entity).Show(info => richTextBox1.Text = info);
            }                
        }
    }
}
