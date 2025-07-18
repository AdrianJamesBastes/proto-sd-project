﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.BulletinManagement
{
    public partial class CreateBulletin : Form
    {
        public CreateBulletin()
        {
            InitializeComponent();
            this.Click += ForwardClick;
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += ForwardClick;
            }
        }

        private void ForwardClick(object sender, EventArgs e)
        {
            this.OnClick(e); // raises the UserControl's Click event
        }

        private void btnPublishBulletin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}