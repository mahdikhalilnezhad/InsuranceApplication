namespace Insuranceissuing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerson frmPerson = new frmPerson();
            frmPerson.ShowDialog();
        }

        private void policyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPolicy frmPolicy = new frmPolicy();
            frmPolicy.ShowDialog();
        }
    }
}