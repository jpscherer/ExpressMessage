using BusinessLayer;
using Components;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ApresentationLayer
{
    public partial class FormMain : GenericForm
    {
        private User _user;
        private FormLogin _LoginScreen;
        public FormMain(FormLogin pLoginScreen)
        {
            InitializeComponent();
            this.Text = "Main Screen";


            this._LoginScreen = pLoginScreen;

            this._user = this._LoginScreen.user;
            _LoginScreen.Hide();

            FormMainHandler.CreateRefreschControl(_user);

            this.lblMensagens.Text = string.Empty;
            this.lblUsers.Text = string.Empty;
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            try
            {
                FormMainHandler.SendMessage(_user, new ModelLayer.Message() { UserCodeDestination = txtUser.Text, MessageContent = txtMessage.Text });
                RefreschScreen();
                txtMessage.Text = string.Empty;
            }
            catch (InvalidInputException iie) { MessageBox.Show(iie.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            lblMensagens.Text = string.Empty;
            //RefreschScreen();
        }

        private void btnRefresch_Click(object sender, EventArgs e)
        {
            RefreschScreen();
        }

        private void RefreschScreen()
        {
            if(_user.MessagesList != null && _user.MessagesList.TrimEnd().TrimStart() != ":")
                lblMensagens.Text = string.Format("{0}\n\r", _user.MessagesList);

            lblUsers.Text = FormMainHandler.FormatUsersList(_user.UnformatedUserList);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _LoginScreen.Show();
        }
    }
}
