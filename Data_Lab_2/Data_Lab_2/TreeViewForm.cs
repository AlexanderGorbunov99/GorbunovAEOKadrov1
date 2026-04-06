using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data_Lab_2
{
    public partial class TreeViewForm : Form
    {
        SqlDataAdapter _adapterM, _adapterSL;
        SqlConnection _connection;
        public TreeViewForm (ref SqlDataAdapter adapterM,
            ref SqlDataAdapter adapterSL, ref SqlConnection connection )
        {
            _adapterSL = adapterSL;
            _adapterM = adapterM;
            _connection = connection;
            InitializeComponent();
            CreateTree();
        }
        private void CreateTree()
        {
            SqlDataReader readerSL, readerM;
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Издания и их подписчики");
            treeView1.Nodes.Add(rootNode);
            _connection.Open();
            readerM = _adapterM.SelectCommand.ExecuteReader();
            while (readerM.Read())
            {
                string magTitle = readerM[1].ToString();
                TreeNode magNode = new TreeNode(magTitle);
                rootNode.Nodes.Add(magNode);
                _adapterSL.SelectCommand.Parameters["@mag_title"].Value = magTitle;
                readerSL = _adapterSL.SelectCommand.ExecuteReader();
                while (readerSL.Read())
                { magNode.Nodes.Add("SubName: " + readerSL[0].ToString() +
                    "; Address: " + readerSL[1].ToString()); }
                readerSL.Close();
            }
            readerM.Close();
            _connection.Close();
            treeView1.ExpandAll();
        }
    }
}
