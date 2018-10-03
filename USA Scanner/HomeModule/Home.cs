using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace USA_Scanner.HomeModule
{
    public partial class Home : DevExpress.XtraEditors.XtraUserControl
    {
        public Home()
        {
            InitializeComponent();
            LoadCountry();
            LoadStates();
            LoadSaveOptions();
            teNameSearch.ReadOnly = teCitySearch.ReadOnly = true;
            gridControl1.DataSource = new List<PersonalDetails>();
        }

        private void LoadSaveOptions()
        {
            var optionSave = HomeStatic.Instance.saveOptions;
            leSaveOptions.Properties.DataSource = optionSave;
            leSaveOptions.Properties.DisplayMember = "Key";
            leSaveOptions.Properties.ValueMember = "Value";
            leSaveOptions.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Value"));
            leSaveOptions.EditValue = optionSave[0].Value;
        }

        private void LoadStates()
        {
            var stateSource = HomeStatic.Instance.states;
            leStates.Properties.DataSource = stateSource;
            leStates.Properties.DisplayMember = "Key";
            leStates.Properties.ValueMember = "Value";
            leStates.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Value"));
            leStates.EditValue = stateSource[0].Value;
        }

        private void LoadCountry()
        {
            var countrySource = HomeStatic.Instance.country;
            leCountry.Properties.DataSource = countrySource;
            leCountry.Properties.DisplayMember = "Key";
            leCountry.Properties.ValueMember = "Value";
            leCountry.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Value"));
            leCountry.EditValue = countrySource[0].Value;
        }

        private void ckSearch_CheckedChanged(object sender, EventArgs e)
        {
            teNameSearch.ReadOnly = teCitySearch.ReadOnly = !ckSearch.Checked;

        }

        private void ckAutoSave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}