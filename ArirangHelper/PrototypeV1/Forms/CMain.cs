using PrototypeV1.Forms.Dialog;

namespace PrototypeV1.Forms
{
    public partial class CMain : Form
    {
        public CMain()
        {
            InitializeComponent();
            this.Text = "프로토타입";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.MenuItem_EXIT.Click += (o, e) => this.Close();
            this.Load += CMain_Load;
        }

        private void CMain_Load(object sender, EventArgs e)
        {
            this.MenuItem_AddAlarm.Click += MenuItem_AddAlarm_Click;
        }

        private void MenuItem_AddAlarm_Click(object sender, EventArgs e)
        {
            new AlarmCreator().ShowDialog();
        }
    }
}