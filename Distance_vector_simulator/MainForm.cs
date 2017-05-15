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
            try
            {
                int id = int.Parse(textBoxRouterId.Text);
                RouterForm rf = new RouterForm(Net.AddRouter(id));
                RoutersForms.Add(rf);
                rf.Show();
                textBoxRouterId.Text = (id + 1).ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonRemoveRouter_Click(object sender, EventArgs e)
        {
            try
            {
                Net.RemoveRouter(int.Parse(textBoxRouterId.Text));
                RouterForm rf = (RouterForm)RoutersForms.First(x => x.Text == textBoxRouterId.Text);
                rf.Close();
                RoutersForms.Remove(rf);
                RefreshRouters();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            try
            {
                Net.AddLink(int.Parse(textBoxRouterId1.Text), int.Parse(textBoxRouterId2.Text), int.Parse(textBoxWeight.Text));
                RefreshRouters();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonRemoveLink_Click(object sender, EventArgs e)
        {
            try
            {
                Net.RemoveLink(int.Parse(textBoxRouterId1.Text), int.Parse(textBoxRouterId2.Text));
                RefreshRouters();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonChangeWeight_Click(object sender, EventArgs e)
        {
            try
            {
                Net.ChangeWeight(int.Parse(textBoxRouterId1.Text), int.Parse(textBoxRouterId2.Text), int.Parse(textBoxWeight.Text));
                RefreshRouters();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void RefreshRouters()
        {
            try
            {
                foreach (RouterForm rf in RoutersForms)
                {
                    rf.RefreshGrid();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonIteration_Click(object sender, EventArgs e)
        {
            try
            {
                Net.DoIteration();
                RefreshRouters();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
