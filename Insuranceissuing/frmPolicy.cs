using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insuranceissuing
{
    public partial class frmPolicy : Form
    {
            Policy policy = new Policy(@"Data Source=(LocalDB)\MSSQLLocalDB;
                            AttachDbFilename=E:\C_sharp_practice\InsuranceApplication\Insuranceissuing\InsuranceDataBase.mdf;
                            Integrated Security=True");
        public frmPolicy()
        {
            InitializeComponent();
        }

        private void frmPolicy_Load(object sender, EventArgs e)
        {
            showData();
        }
        void showData(string word = null)
        {
            dataGridViewPolicy.DataSource = policy.ReturnData(word);
        }


    }
}
