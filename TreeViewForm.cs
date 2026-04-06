using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorbunovAEOKadrov
{
    public partial class TreeViewForm : Form
    {
        SqlDataAdapter _adapterM, _adapterSL;
        SqlConnection _connection1, _connection2;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public TreeViewForm(ref SqlDataAdapter adapterM,
            ref SqlDataAdapter adapterSL, ref SqlConnection connection1, ref SqlConnection connection2)
        {
            _adapterSL = adapterSL;
            _adapterM = adapterM;
            _connection1 = connection1;
            _connection2 = connection2;
            InitializeComponent();
            CreateTree();
        }
        private void CreateTree()
        {
            SqlDataReader readerSL, readerM;
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Отделы, сотрудники и дети сотрудников отделов");
            treeView1.Nodes.Add(rootNode);
            _connection1.Open();
            readerM = _adapterM.SelectCommand.ExecuteReader();
            while (readerM.Read())
            {
                string nazOtdela = readerM[1].ToString();
                TreeNode otdelNode = new TreeNode(nazOtdela);
                rootNode.Nodes.Add(otdelNode);
                _adapterSL.SelectCommand.Parameters["@nazvanie_otdela"].Value = nazOtdela;
                _connection2.Open();
                readerSL = _adapterSL.SelectCommand.ExecuteReader();
                while (readerSL.Read())
                {
                    otdelNode.Nodes.Add("Sotrudnik Info: " + readerSL[1].ToString() +
                    "; Children Info: " + readerSL[0].ToString());
                }
                readerSL.Close();
                _connection2.Close();
            }
            readerM.Close();
            _connection1.Close();
            treeView1.ExpandAll();
        }
    }
}
