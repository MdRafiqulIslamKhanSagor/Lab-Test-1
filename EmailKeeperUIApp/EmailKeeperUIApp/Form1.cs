﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailKeeperUIApp
{
    public partial class EmailKeeperForm : Form
    {
        public EmailKeeperForm()
        {
            InitializeComponent();
        }
        List<string> emailList = new List<string>();
        List<string> searchEmailList =new List<string>();

        private void addEmailButton_Click(object sender, EventArgs e)
        {

  
            if (addEmailTextBox.Text == "")
            {
                MessageBox.Show("Insert a Velid Email Addess");

            }
            else
            {
                
           
            try
            {
                var emails = new System.Net.Mail.MailAddress(addEmailTextBox.Text);


                   
                emailList.Add(addEmailTextBox.Text);
                searchEmailList.Add(addEmailTextBox.Text);
                  addEmailTextBox.Clear();

                  foreach (var email in emailList)
                   {

                      addEmailListBox.Items.Add(email);
                   }

                  emailList.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Insert a Velid Email Addess");
            }

        }
        }

        private void searchEmailButton_Click(object sender, EventArgs e)
        {
            searchEmailListBox.Items.Clear();

            string search = searchEmailTextBox.Text;


            if (!String.IsNullOrEmpty(search))
            {
                foreach (var item in searchEmailList)
                {
                    if (item.Contains(search))
                    {
                        searchEmailListBox.Items.Add(item);
                    }
                    else
                    {
                        break;
                    }
               
                }

               

            }
            else
            {
                MessageBox.Show("This Data Is Not Available");
            }


        }
    }
}
