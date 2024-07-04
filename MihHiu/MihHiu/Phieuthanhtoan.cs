using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihHiu
{
    public partial class Phieuthanhtoan : Form
    {
        public Phieuthanhtoan()
        {
            InitializeComponent();
        }

        private void Phieuthanhtoan_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Now;
            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);
        }

    }
}

