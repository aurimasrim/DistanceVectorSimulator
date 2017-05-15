using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Distance_vector_simulator
{
    public partial class MainForm : Form
    {
        Network Net;
        List<Form> RoutersForms;
        public MainForm()
        {
            InitializeComponent();
            Net = new Network();
            RoutersForms = new List<Form>();
        }

        private void buttonAddRouter_Click(object sender, EventArgs e)
        {
            RouterForm rf = new RouterForm(Net.AddRouter(int.Parse(textBoxRouterId.Text)));
            RoutersForms.Add(rf);
            rf.Show();
        }

        private void buttonRemoveRouter_Click(object sender, EventArgs e)
        {
            Net.RemoveRouter(int.Parse(textBoxRouterId.Text));
            RouterForm rf = (RouterForm)RoutersForms.First(x => x.Text == textBoxRouterId.Text);
            rf.Close();
            RoutersForms.Remove(rf);
            RefreshRouters();
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            Net.AddLink(int.Parse(textBoxRouterId1.Text), int.Parse(textBoxRouterId2.Text), int.Parse(textBoxWeight.Text));
            RefreshRouters();
        }

        private void buttonRemoveLink_Click(object sender, EventArgs e)
        {
            Net.RemoveLink(int.Parse(textBoxRouterId1.Text), int.Parse(textBoxRouterId2.Text));
            RefreshRouters();
        }

        private void buttonChangeWeight_Click(object sender, EventArgs e)
        {
            Net.ChangeWeight(int.Parse(textBoxRouterId1.Text), int.Parse(textBoxRouterId2.Text), int.Parse(textBoxWeight.Text));
            RefreshRouters();
        }
        private void RefreshRouters()
        {
            foreach (RouterForm rf in RoutersForms)
            {
                rf.RefreshGrid();
            }
        }

        private void buttonIteration_Click(object sender, EventArgs e)
        {
            Net.DoIteration();
            RefreshRouters();
        }
    }
}
