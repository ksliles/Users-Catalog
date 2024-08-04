﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Liles.Models;
using WinFormsApp_Liles.Reposities;

namespace WinFormsApp_Liles
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private int clientID = 0;

        public void EditClient(Client client)
        {
            this.Text = "Edit Client";
            this.lbTitle.Text = "Edit Client";

            this.lbId.Text = "" + client.id;
            this.tbFirstName.Text = client.firstname;
            this.tbLastName.Text = client.lastname;
            this.tbEmail.Text = client.email;
            this.tbPhone.Text = client.phone;
            this.tbAddress.Text = client.address;

            this.clientID = client.id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.id = this.clientID;
            client.firstname = this.tbFirstName.Text;
            client.lastname = this.tbLastName.Text;
            client.email = this.tbEmail.Text;
            client.phone = this.tbPhone.Text;
            client.address = this.tbAddress.Text;

            var repo = new ClientRepository();

            if(client.id == 0)
            {
                repo.CreateClient(client);
            }
            else
            {
                repo.UpdateClient(client);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
