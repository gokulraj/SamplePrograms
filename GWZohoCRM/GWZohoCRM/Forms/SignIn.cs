using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GWZohoCRM.Classes;

namespace GWZohoCRM
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Labels();
        }

        private void Load_Labels()
        {
            this.Text = Resource.Resource.SignIn;
            this.gbSignIn.Text = Resource.Resource.SignIn;
            this.labelEmail.Text = Resource.Resource.EmailAddress;
            this.labelPassword.Text = Resource.Resource.Password;
            this.buttonSignIn.Text = Resource.Resource.SignIn;
            this.linkLabelCancel.Text = Resource.Resource.Cancel;
            this.linkLabelTFA.Text = Resource.Resource.TFAEnable;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            AccessToCRM acc = new AccessToCRM();
            String signResult = acc.loginToCRM(this.textBoxEmail.Text, this.textBoxPassword.Text);

            MessageBox.Show(signResult);
        }
    }
}
