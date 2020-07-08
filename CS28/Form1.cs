using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IDatabase product = new Products();
            IDatabase order = new Orders();

            List<IDatabase> databases = new List<IDatabase>();
            databases.Add(product);
            databases.Add(order);

            foreach (var val in databases)
            {
                val.Save();
            }
        }
    }
}
