using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Components;
using ModelLayer;

namespace ApresentationLayer
{
   public partial class FormLogin : GenericForm
   {
      public User user;
      public FormLogin()
      {
         InitializeComponent();
         this.Text = "Login";
            this.txtLogin.Text = "3363";
            this.txtPassword.Text = "rtrcs";
      }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                user = new User() { LoginUser = txtLogin.Text, PasswordUser = txtPassword.Text };
                if (FormLoginHandler.ValidUser(user))
                    FormLoginHandler.ValidServerUser(user);

                FormMain fm = new FormMain(this);
                fm.ShowDialog();
            }
            catch (InvalidInputException iie) { MessageBox.Show(iie.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
