using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_vector_simulator
{
    partial class RouterForm : Form
    {
        public Router MyRouter;
        public RouterForm(Router router)
        {
            
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            MyRouter = router;
            this.Text = MyRouter.Id.ToString();
            //pathBindingSource.DataSource = MyRouter.Paths;
            dataGridView1.DataSource = MyRouter.Paths;
        }
        public void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = MyRouter.Paths;
        }

    }
}
