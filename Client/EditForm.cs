using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorbunovAEOKadrov
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
        GorbunovOtdKadrDataSet _dataset;
        string _editMode = "";
        public EditForm(TableData tableData, ref GorbunovOtdKadrDataSet dataset, string editMode)
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
                if (tableName == "Otdel")
                {
                    DataModel dm = (DataModel)this._comboBoxes["ID"].SelectedItem;
                    int otd_ID = dm.ID;
                    IEnumerable<int> nomerOtdela = from Otdel in _dataset.Otdel
                                                   where Otdel.ID == otd_ID
                                                   select Otdel.nomerOtdela;
                    _textBoxes["nomerOtdela"].Text = nomerOtdela.FirstOrDefault().ToString();
                    IEnumerable<string> nazvanieOtdela = from Otdel in _dataset.Otdel
                                                  where Otdel.ID == otd_ID
                                                  select Otdel.nazvanieOtdela;
                    _textBoxes["nazvanieOtdela"].Text = nazvanieOtdela.FirstOrDefault();
                }
                else if (tableName == "Sotrudnik")
                {
                    DataModel dm = (DataModel)this._comboBoxes["ID"].SelectedItem;
                    int sotr_ID = dm.ID;
                    dm = (DataModel)this._comboBoxes["Otdel_ID"].SelectedItem;
                    if (dm == null)
                    {
                        return;
                    }
                    int otd_ID = dm.ID;
                    IEnumerable<int> TabelNomerSotr = from Sotrudnik in _dataset.Sotrudnik
                                                   where Sotrudnik.ID == sotr_ID && 
                                                   Sotrudnik.Otdel_ID == otd_ID
                                                   select Sotrudnik.TabelNomerSotr;
                    _textBoxes["TabelNomerSotr"].Text = TabelNomerSotr.FirstOrDefault().ToString();
                    IEnumerable<string> Familiya = from Sotrudnik in _dataset.Sotrudnik
                                                   where Sotrudnik.ID == sotr_ID &&
                                                   Sotrudnik.Otdel_ID == otd_ID
                                                   select Sotrudnik.Familiya;
                    _textBoxes["Familiya"].Text = Familiya.FirstOrDefault();
                    IEnumerable<string> Imya = from Sotrudnik in _dataset.Sotrudnik
                                                where Sotrudnik.ID == sotr_ID &&
                                                Sotrudnik.Otdel_ID == otd_ID
                                               select Sotrudnik.Imya;
                    _textBoxes["Imya"].Text = Imya.FirstOrDefault();
                    IEnumerable<string> Otchestvo = from Sotrudnik in _dataset.Sotrudnik
                                               where Sotrudnik.ID == sotr_ID &&
                                               Sotrudnik.Otdel_ID == otd_ID
                                                    select Sotrudnik.Otchestvo;
                    _textBoxes["Otchestvo"].Text = Otchestvo.FirstOrDefault();
                    IEnumerable<int> StazhRaboty = from Sotrudnik in _dataset.Sotrudnik
                                               where Sotrudnik.ID == sotr_ID &&
                                               Sotrudnik.Otdel_ID == otd_ID
                                                   select Sotrudnik.StazhRaboty;
                    _textBoxes["StazhRaboty"].Text =StazhRaboty.FirstOrDefault().ToString();
                    IEnumerable<string> PolSortudnika = from Sotrudnik in _dataset.Sotrudnik
                                                    where Sotrudnik.ID == sotr_ID &&
                                                    Sotrudnik.Otdel_ID == otd_ID
                                                        select Sotrudnik.PolSortudnika;
                    _textBoxes["PolSortudnika"].Text = PolSortudnika.FirstOrDefault();
                }
                else if (tableName == "Dety")
                {
                    DataModel dm = (DataModel)this._comboBoxes["ID"].SelectedItem;
                    int det_ID = dm.ID;
                    dm = (DataModel)this._comboBoxes["Sotrudnik_ID"].SelectedItem;
                    if (dm == null)
                    {
                        return;
                    }
                    int sotr_ID = dm.ID;
                    IEnumerable<string> NomerSvidORozh = from Dety in _dataset.Dety
                                                        where Dety.ID == det_ID &&
                                                        Dety.Sotrudnik_ID == sotr_ID
                                                        select Dety.NomerSvidORozh;
                    _textBoxes["NomerSvidORozh"].Text = NomerSvidORozh.FirstOrDefault();
                    IEnumerable<string> ImyaChildren = from Dety in _dataset.Dety
                                               where (Dety.ID == det_ID &&
                                               Dety.Sotrudnik_ID == sotr_ID)
                                               select Dety.ImyaChildren;
                    _textBoxes["ImyaChildren"].Text = ImyaChildren.FirstOrDefault();
                    IEnumerable<int> GodRozh = from Dety in _dataset.Dety
                                                  where (Dety.ID == det_ID &&
                                                  Dety.Sotrudnik_ID == sotr_ID)
                                                  select Dety.GodRozh;
                    _textBoxes["GodRozh"].Text = GodRozh.FirstOrDefault().ToString();
                    IEnumerable<string> Pol = from Dety in _dataset.Dety
                                               where (Dety.ID == det_ID &&
                                               Dety.Sotrudnik_ID == sotr_ID)
                                               select Dety.Pol;
                    _textBoxes["Pol"].Text = Pol.FirstOrDefault();

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
        //public EditForm()
        //{
        //    InitializeComponent();
        //}
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
            if ((_editMode == "Insert" && (tableName == "Sotrudnik" || (tableName == "Dety"))) || 
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
            if (tableName == "Otdel")
            {
                var query = from Otdel in _dataset.Otdel
                            select Otdel.ID;
                int id = 0;
                var qList = query.ToList();
                if (qList.Count != 0)
                {
                    id = qList.Max();
                }
                id++;
                values.Add(id.ToString());
            }
            else if (tableName == "Sotrudnik")
            {
                var query = from Sotrudnik in _dataset.Sotrudnik
                            select Sotrudnik.ID;
                int id = 0;
                var qList = query.ToList();
                if (qList.Count != 0)
                {
                    id = qList.Max();
                }
                id++;
                values.Add(id.ToString());
            }
            else if (tableName == "Dety")
            {
                var query = from Dety in _dataset.Dety
                            select Dety.ID;
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
            if (tableName == "Dety" && atr == "Sotrudnik_ID"
                    || tableName == "Sotrudnik" && atr == "ID")
            {
                var sotrs = _dataset.Sotrudnik.Select(p => new DataModel
                {
                    ID = p.ID,
                    Name = p.ID.ToString() + ": " + p.TabelNomerSotr.ToString()
                });
                data = sotrs.ToList();
            }
            else if (tableName == "Sotrudnik" && atr == "Otdel_ID"
                || tableName == "Otdel" && atr == "ID")
            {
                var otds = _dataset.Otdel.Select(p => new DataModel
                {
                    ID = p.ID,
                    Name = p.ID.ToString() + ": " + p.nomerOtdela.ToString()
                });
                data = otds.ToList();
            }
            else if (tableName == "Dety"  && atr == "ID")
            {
                var detys = _dataset.Dety.Select(p => new DataModel
                {
                    ID = p.ID,
                    Name = p.ID.ToString() + ": " + p.NomerSvidORozh.ToString()
                });
                data = detys.ToList();
            }
            return data;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (_tableData.tableName == "Otdel")
            {
                DataModel dm = (DataModel)_comboBoxes["ID"].SelectedItem;
                string ID = dm.ID.ToString();
                data.Add("ID", ID);
                data.Add("nomerOtdela", _textBoxes["nomerOtdela"].Text);
                data.Add("nazvanieOtdela", _textBoxes["nazvanieOtdela"].Text);                
            }
            else if (_tableData.tableName == "Sotrudnik")
            {                
                DataModel dm = (DataModel)_comboBoxes["ID"].SelectedItem;
                string sotr_ID = dm.ID.ToString();
                data.Add("ID", sotr_ID);
                data.Add("TabelNomerSotr", _textBoxes["TabelNomerSotr"].Text);
                data.Add("Familiya", _textBoxes["Familiya"].Text);
                data.Add("Imya", _textBoxes["Imya"].Text);
                data.Add("Otchestvo", _textBoxes["Otchestvo"].Text);
                data.Add("StazhRaboty", _textBoxes["StazhRaboty"].Text);
                data.Add("PolSortudnika", _textBoxes["PolSortudnika"].Text);
                dm = (DataModel)_comboBoxes["Otdel_ID"].SelectedItem;
                string otd_ID = dm.ID.ToString();
                data.Add("Otdel_ID", otd_ID);
            }
            else if (_tableData.tableName == "Dety")
            {
                DataModel dm = (DataModel)_comboBoxes["ID"].SelectedItem;
                string det_ID = dm.ID.ToString();
                data.Add("ID", det_ID);
                data.Add("NomerSvidORozh", _textBoxes["NomerSvidORozh"].Text);
                data.Add("ImyaChildren", _textBoxes["ImyaChildren"].Text);
                data.Add("GodRozh", _textBoxes["GodRozh"].Text);
                data.Add("Pol", _textBoxes["Pol"].Text);
                dm = (DataModel)_comboBoxes["Sotrudnik_ID"].SelectedItem;
                string sotr_ID = dm.ID.ToString();
                data.Add("Sotrudnik_ID", sotr_ID);
            }
            bool success = editData(_tableData.tableName, data);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    

        private void AddButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (_tableData.tableName == "Otdel")
            {                     
                data.Add("nomerOtdela", _textBoxes["nomerOtdela"].Text);
                data.Add("nazvanieOtdela", _textBoxes["nazvanieOtdela"].Text);
            }
            else if (_tableData.tableName == "Sotrudnik")
            {
                data.Add("TabelNomerSotr", _textBoxes["TabelNomerSotr"].Text);
                data.Add("Familiya", _textBoxes["Familiya"].Text);
                data.Add("Imya", _textBoxes["Imya"].Text);
                data.Add("Otchestvo", _textBoxes["Otchestvo"].Text);
                data.Add("StazhRaboty", _textBoxes["StazhRaboty"].Text);
                data.Add("PolSortudnika", _textBoxes["PolSortudnika"].Text);
                DataModel dm = (DataModel)_comboBoxes["Otdel_ID"].SelectedItem;
                string otd_id = dm.ID.ToString();
                data.Add("Otdel_ID", otd_id);
            }
            else if (_tableData.tableName == "Dety")
            {
                data.Add("NomerSvidORozh", _textBoxes["NomerSvidORozh"].Text);
                data.Add("ImyaChildren", _textBoxes["ImyaChildren"].Text);
                data.Add("GodRozh", _textBoxes["GodRozh"].Text);
                data.Add("Pol", _textBoxes["Pol"].Text);
                DataModel dm = (DataModel)_comboBoxes["Sotrudnik_ID"].SelectedItem;
                string sotr_id = dm.ID.ToString();
                data.Add("Sotrudnik_ID", sotr_id);
            }
            bool success = addData(_tableData.tableName, data);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
    public class DataModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
