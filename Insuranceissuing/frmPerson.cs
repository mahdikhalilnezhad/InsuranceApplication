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
    public partial class frmPerson : Form
    {
        Person person = new Person(@"Data Source=(LocalDB)\MSSQLLocalDB;
                            AttachDbFilename=E:\C_sharp_practice\InsuranceApplication\Insuranceissuing\InsuranceDataBase.mdf;
                            Integrated Security=True");
        public frmPerson()
        {
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            showData();
        }

        void showData(string word = null)
        {
            dataGridViewPerson.DataSource = person.ReturnData(word);
        }
        

    }
}
