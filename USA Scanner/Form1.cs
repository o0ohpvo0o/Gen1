using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using USA_Scanner.HomeModule;
using USA_Scanner.SettingModule;

namespace USA_Scanner
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeModuleTo<T>() where T: XtraUserControl
        {
            SplashScreenManager.ShowForm(FindForm(),typeof(WaitForm1));
            panelControl1.Controls.Clear();
            var newModule = Activator.CreateInstance<T>();
            panelControl1.Controls.Add(newModule);
            SplashScreenManager.CloseForm(false);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Home>();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Settings>();
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {

        }
    }
}
