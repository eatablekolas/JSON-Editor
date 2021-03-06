using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Tags
        {
            Category,
            Attribute,
            Subcategory
        }

        class NodeSorter : System.Collections.IComparer
        {
            public NodeSorter() { }

            public int Compare(object x, object y)
            {
                TreeNode nodeX = x as TreeNode;
                TreeNode nodeY = y as TreeNode;

                string tagX = nodeX.Tag.ToString();
                string tagY = nodeY.Tag.ToString();

                if (tagX.CompareTo(tagY) == 0)
                {
                    return string.Compare(nodeX.Text, nodeY.Text);
                }

                return tagX.CompareTo(tagY);
            }
        }

        const string PROGRAM_TITLE = "Edytor JSON";
        const string DEFAULT_CATEGORY_NAME = "Nowa kategoria";
        const string DEFAULT_SUBCATEGORY_NAME = "Nowa podkategoria";
        const string DEFAULT_ATTRIBUTE_NAME = "Nowa właściwość";

        NodeSorter nodeSorter = new NodeSorter();
        int attributeTypeIndex;

        Dictionary<string, Dictionary<string, object>> data = new Dictionary<string, Dictionary<string, object>>();

        private void createButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        void SaveNode(TreeNode node, TreeNode parentNode = null)
        {
            if (node.Tag.Equals(Tags.Attribute)) return;

            dynamic dataToSaveTo = data;
            int dataIndex = 0;
            string[] nodeNames = node.FullPath.Split('\\');
            string stuffToPrint = "";
            foreach (string nodeName in nodeNames)
            {
                if (dataIndex == nodeNames.Length - 1) break;

                stuffToPrint += " -> " + nodeName;
                dataToSaveTo = dataToSaveTo[nodeName];

                dataIndex++;
            }

            Console.WriteLine(stuffToPrint);

            dataToSaveTo.Add(node.Text, new Dictionary<string, object>());

            foreach (TreeNode subNode in node.Nodes)
            {
                SaveNode(subNode);
            }
        }

        void SaveTreeView()
        {
            data.Clear();

            foreach (TreeNode node in treeView1.Nodes)
            {
                SaveNode(node);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Text = PROGRAM_TITLE + " - " + saveFileDialog1.FileName;

            var jsonOptions = new JsonSerializerOptions();
            jsonOptions.WriteIndented = true;

            SaveTreeView();

            string json = JsonSerializer.Serialize(data, jsonOptions);

            File.WriteAllText(saveFileDialog1.FileName, json);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Text = PROGRAM_TITLE + " - " + openFileDialog1.FileName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 - bool, 1 - int, 2 - float, 3 - string
            attributeTypeIndex = comboBox1.SelectedIndex;

            boolBox.Visible = comboBox1.SelectedIndex == 0;
            numberBox.Visible = comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2;
            numberBox.DecimalPlaces = comboBox1.SelectedIndex == 1 ? 0 : 2;
            stringBox.Visible = comboBox1.SelectedIndex == 3;
        }

        bool CheckIfNodeNameIsFree(string nodeName, TreeNodeCollection nodeCollection)
        {
            foreach (TreeNode node in nodeCollection)
            {
                if (node.Text == nodeName)
                {
                    return false;
                }
            }

            return true;
        }

        string GetNodeName(string desiredName, TreeNodeCollection nodeCollection)
        {
            string nodeName = desiredName;
            int nodeCount = 0;
            bool nodeNameFound = CheckIfNodeNameIsFree(nodeName, nodeCollection);

            while (!nodeNameFound)
            {
                nodeName = desiredName + $" ({++nodeCount})";
                nodeNameFound = CheckIfNodeNameIsFree(nodeName, nodeCollection);
            }

            return nodeName;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            string nodeName = GetNodeName(DEFAULT_CATEGORY_NAME, treeView1.Nodes);
            TreeNode newNode = new TreeNode(nodeName);
            newNode.Tag = Tags.Category;

            treeView1.Nodes.Add(newNode);
        }

        void SwitchEditing(bool on)
        {
            toolPanel.Enabled = on;
            editWindow.Enabled = on;
            if (!on)
            {
                nameBox.Text = string.Empty;
            }
            attributeWindow.Enabled = false;
        }

        void SwitchAttributeEditing(bool on)
        {
            attributeWindow.Enabled = on;
            addAttributeButton.Enabled = !on;
            addSubcategoryButton.Enabled = !on;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;

            SwitchEditing(true);
            nameBox.Text = node.Text;

            if (node.Tag.Equals(Tags.Attribute))
            {
                SwitchAttributeEditing(true);
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = treeView1.HitTest(e.X, e.Y);
            if (hit.Node == null)
            {
                treeView1.SelectedNode = null;
                SwitchEditing(false);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;
            
            node.Remove();

            if (treeView1.SelectedNode == null)
            {
                SwitchEditing(false);
            }
            else
            {
                SwitchAttributeEditing(false);
            }
        }

        private void addSubcategoryButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;

            TreeNode subNode = new TreeNode(GetNodeName(DEFAULT_SUBCATEGORY_NAME, node.Nodes));
            subNode.Tag = Tags.Subcategory;

            node.Nodes.Add(subNode);
            node.Expand();
        }

        private void addAttributeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;

            TreeNode subNode = new TreeNode(GetNodeName(DEFAULT_ATTRIBUTE_NAME, node.Nodes), 1, 1);
            subNode.Tag = Tags.Attribute;

            node.Nodes.Add(subNode);
            node.Expand();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (treeView1.TreeViewNodeSorter != nodeSorter)
            {
                treeView1.TreeViewNodeSorter = nodeSorter;
            }

            treeView1.Sort();
            SwitchEditing(false);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;

            if (nameBox.Text != "")
            {
                node.Text = GetNodeName(nameBox.Text, node.Parent != null ? node.Parent.Nodes : treeView1.Nodes);
            }
            else
            {
                node.Text = DEFAULT_CATEGORY_NAME;
            }
        }
    }
}
