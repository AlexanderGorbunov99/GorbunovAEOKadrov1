using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System;

namespace Data_Lab_2
{
    public partial class EditForm : Form
    {
        public delegate bool AddData(string tableName, Dictionary<string, string> data);
        public delegate bool EditData(string tableName, Dictionary<string, string> data);
        public AddData addData;
        public EditData editData;
        Dictionary<string, ComboBox> _comboBoxes;
        Dictionary<string, TextBox> _textBoxes;
        TableData _tableData;
        lab2_db_KiselevDataSet _dataset;
        string _editMode = "";
        public EditForm(TableData tableData, ref lab2_db_KiselevDataSet dataset, string editMode)
        {
            InitializeComponent();
            _tableData = tableData;
            _dataset = dataset;
            _editMode = editMode;
            _comboBoxes = new Dictionary<string, ComboBox>();
            _textBoxes = new Dictionary<string, TextBox>();
            ChangeAppearence();
            if (_editMode == "Update")
            {
                FillFields(_tableData.tableName);
            }
        }
        void ChangeAppearence()
        {
            if (_editMode == "Insert")
            {
                AddButton.Enabled = true;
                AddButton.Visible = true;
            }
            else if (_editMode == "Update")
            {
                UpdateButton.Enabled = true;
                UpdateButton.Visible = true;
            }
            int x = 26, y = 69;
            int heightOffset = 26;
            foreach (string header in _tableData.colHeaders)
            {
                Label lb = new Label();
                lb.Text = header;
                lb.Location = new Point(x, y);
                lb.Name = $"{header}Label";
                Controls.Add(lb);
                this.Height += heightOffset;
                y += heightOffset;
                if (header.Contains("ID"))
                {
                    ComboBox cb = new ComboBox();
                    cb.Location = new Point(x, y);
                    cb = SetValues(_tableData.tableName, header, cb);
                    cb.Name = $"{header}CB";
                    _comboBoxes.Add(header, cb);
                    Controls.Add(cb);
                }
                else
                {
                    TextBox tb = new TextBox();
                    tb.Location = new Point(x, y);
                    tb.Name = $"{header}TB";
                    _textBoxes.Add(header, tb);
                    Controls.Add(tb);
                }
                this.Height += heightOffset;
                y += heightOffset;
            }
        }
        void FillFields(string tableName)
        {
            try
            {
                if (tableName == "Subscriber")
                {
                    DataModel dm = (DataModel)this._comboBoxes["ID"].SelectedItem;
                    int sub_id = dm.ID;
                    IEnumerable<string> subname = from Subscriber in _dataset.Subscriber
                                                  where Subscriber.ID == sub_id
                                                  select Subscriber.SubName;
                    _textBoxes["SubName"].Text = subname.FirstOrDefault();
                    IEnumerable<string> address = from Subscriber in _dataset.Subscriber
                                                  where Subscriber.ID == sub_id
                                                  select Subscriber.Address;
                    _textBoxes["Address"].Text = address.FirstOrDefault();
                }
                else if (tableName == "Magazine")
                {
                    DataModel dm = (DataModel)this._comboBoxes["ID"].SelectedItem;
                    int mag_id = dm.ID;
                    IEnumerable<int> zipcode = from Magazine in _dataset.Magazine
                                               where Magazine.ID == mag_id
                                               select Magazine.Zipcode;
                    _textBoxes["Zipcode"].Text = zipcode.FirstOrDefault().ToString();
                    IEnumerable<string> title = from Magazine in _dataset.Magazine
                                                where Magazine.ID == mag_id
                                                select Magazine.Title;
                    _textBoxes["Title"].Text = title.FirstOrDefault();
                    IEnumerable<double> cost = from Magazine in _dataset.Magazine
                                               where Magazine.ID == mag_id
                                               select Magazine.Cost;
                    _textBoxes["Cost"].Text = cost.FirstOrDefault().ToString();
                }
                else if (tableName == "Subscriber_has_magazine")
                {
                    DataModel dm = (DataModel)this._comboBoxes["Subscriber_ID"].SelectedItem;
                    int sub_id = dm.ID;
                    dm = (DataModel)this._comboBoxes["Magazine_ID"].SelectedItem;
                    if (dm == null)
                    {
                        return;
                    }
                    int mag_id = dm.ID;
                    IEnumerable<byte> amount = from Subscriber_has_magazine in _dataset.Subscriber_has_magazine
                                               where (Subscriber_has_magazine.Subscriber_ID == sub_id &&
                                               Subscriber_has_magazine.Magazine_ID == mag_id)
                                               select Subscriber_has_magazine.Amount;
                    _textBoxes["Amount"].Text = amount.FirstOrDefault().ToString();
                }
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.Append("Ошибка при заполнении полей.\n");
                errorMessage.Append
                    ("Message: " + ex.Message + "\n" +
                    "Source: " + ex.Source + "\n");
                MessageBox.Show(errorMessage.ToString());
            }
        }
        private void SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FillFields(_tableData.tableName);
        }
        ComboBox ChoosePK(string tableName, string atr, ComboBox cb)
        {
            if (_editMode == "Insert")
            {
                cb.SelectedIndex = 0;
            }
            else if (_editMode == "Update")
            {
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    DataModel dm = (DataModel)cb.Items[i];
                    int id = dm.ID;
                    if (id == _tableData.pkValues[atr])
                    {
                        cb.SelectedIndex = i;
                        break;
                    }
                }
            }
            return cb;
        }
        ComboBox SetValues(string tableName, string atr, ComboBox cb)
        {
            if ((_editMode == "Insert" && tableName == "Subscriber_has_magazine")||
                (_editMode == "Update"))
            {
                cb.ValueMember = "ID";
                cb.DisplayMember = "Name";
                cb.BindingContext = new BindingContext();
                cb.DataSource = GetValues(tableName, atr);
            }
            else
            {
                cb.DataSource = GetValues(tableName);
                cb.Enabled = false;
            }  
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cb.Items.Count != 0)
            {
                cb = ChoosePK(tableName, atr, cb);
                if (_editMode == "Update")
                {
                    cb.SelectedIndexChanged += new System.EventHandler(SelectedIndexChanged);
                }
            }
            return cb;
        }
        List<string> GetValues(string tableName)
        {
            List<string> values = new List<string>();
            if (tableName == "Subscriber")
            {
                var query = from Subscriber in _dataset.Subscriber
                            select Subscriber.ID;
                int id = 0;
                var qList = query.ToList();
                if (qList.Count!=0)
                {
                    id = qList.Max();
                }
                id++;
                values.Add(id.ToString());
            }
            else if (tableName == "Magazine")
            {
                var query = from Magazine in _dataset.Magazine
                            select Magazine.ID;
                int id = 0;
                var qList = query.ToList();
                if (qList.Count != 0)
                {
                    id = qList.Max();
                }
                id++;
                values.Add(id.ToString());
            }
            return values;
        }
        List<DataModel> GetValues(string tableName, string atr)
        {
            List<DataModel> data = new List<DataModel>();
            if (tableName == "Subscriber_has_magazine" && atr == "Subscriber_ID"
                    || tableName == "Subscriber" && atr == "ID")
            {
                var subs = _dataset.Subscriber.Select(p => new DataModel
                {
                    ID = p.ID,
                    Name = p.ID.ToString() + ": " + p.SubName
                });
                data = subs.ToList();
            }
            else if (tableName == "Subscriber_has_magazine" && atr == "Magazine_ID"
                || tableName == "Magazine" && atr == "ID")
            {
                var mags = _dataset.Magazine.Select(p => new DataModel
                {
                    ID = p.ID,
                    Name = p.ID.ToString()+": "+p.Title
                });
                data = mags.ToList();
            }
            return data;
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (_tableData.tableName == "Subscriber")
            {
                data.Add("SubName", _textBoxes["SubName"].Text);
                data.Add("Address", _textBoxes["Address"].Text);
            }
            else if (_tableData.tableName == "Magazine")
            {
                data.Add("Zipcode", _textBoxes["Zipcode"].Text);
                data.Add("Title", _textBoxes["Title"].Text);
                data.Add("Cost", _textBoxes["Cost"].Text);
            }
            else if (_tableData.tableName == "Subscriber_has_magazine")
            {
                DataModel dm = (DataModel)_comboBoxes["Subscriber_ID"].SelectedItem;
                string sub_id = dm.ID.ToString();
                data.Add("Subscriber_ID", sub_id);
                dm = (DataModel)_comboBoxes["Magazine_ID"].SelectedItem;
                string mag_id = dm.ID.ToString();
                data.Add("Magazine_ID", mag_id);
                data.Add("Amount", _textBoxes["Amount"].Text);
            }
            bool success = addData(_tableData.tableName, data);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (_tableData.tableName == "Subscriber")
            {
                DataModel dm = (DataModel)_comboBoxes["ID"].SelectedItem;
                string sub_id = dm.ID.ToString();
                data.Add("ID", sub_id);
                data.Add("SubName", _textBoxes["SubName"].Text);
                data.Add("Address", _textBoxes["Address"].Text);
            }
            else if (_tableData.tableName == "Magazine")
            {
                DataModel dm = (DataModel)_comboBoxes["ID"].SelectedItem;
                string mag_id = dm.ID.ToString();
                data.Add("ID", mag_id);
                data.Add("Zipcode", _textBoxes["Zipcode"].Text);
                data.Add("Title", _textBoxes["Title"].Text);
                data.Add("Cost", _textBoxes["Cost"].Text);
            }
            else if (_tableData.tableName == "Subscriber_has_magazine")
            {
                DataModel dm = (DataModel)_comboBoxes["Subscriber_ID"].SelectedItem;
                string sub_id = dm.ID.ToString();
                data.Add("Subscriber_ID", sub_id);
                dm = (DataModel)_comboBoxes["Magazine_ID"].SelectedItem;
                string mag_id = dm.ID.ToString();
                data.Add("Magazine_ID", mag_id);
                data.Add("Amount", _textBoxes["Amount"].Text);
            }
            bool success = editData(_tableData.tableName, data);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
    public class DataModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
