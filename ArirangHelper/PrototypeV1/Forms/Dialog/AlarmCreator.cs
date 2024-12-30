using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrototypeV1.Controllers;

namespace PrototypeV1.Forms.Dialog
{
    public partial class AlarmCreator : Form
    {
        public AlarmCreator()
        {
            InitializeComponent();
            this.Load += AlarmCreator_Load;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void AlarmCreator_Load(object sender, EventArgs e)
        {
            SyncClientInfo();            
        }

        private void SyncClientInfo()
        {
            var processes = ProcessController.Instance.GetEveClients();
            foreach (var process in processes)
            {
                string charName = ParseCharacterName(process.MainWindowTitle);
                this.comboBox_ClientTarget.Items.Add(charName);
            }
        }

        private string ParseCharacterName(string value)
        {
            if (!value.Contains("-"))
                return "Please Refresh - UnknownClient";

            return value.Split("-")[1].Trim();
        }
    }
}
