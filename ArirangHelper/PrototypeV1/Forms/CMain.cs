namespace PrototypeV1.Forms
{
    public partial class CMain : Form
    {
        public CMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.MenuItem_EXIT.Click += (o, e) => this.Close();
        }
    }
}
