namespace ApresentationLayer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntSend = new System.Windows.Forms.Button();
            this.lblMensagens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntClear = new System.Windows.Forms.Button();
            this.bgReceive = new System.Windows.Forms.GroupBox();
            this.gbSend = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnRefresch = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bgReceive.SuspendLayout();
            this.gbSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntSend
            // 
            this.bntSend.Location = new System.Drawing.Point(87, 204);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(75, 23);
            this.bntSend.TabIndex = 1;
            this.bntSend.Text = "Enviar";
            this.bntSend.UseVisualStyleBackColor = true;
            this.bntSend.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.Location = new System.Drawing.Point(6, 51);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(35, 13);
            this.lblMensagens.TabIndex = 3;
            this.lblMensagens.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensagens";
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(181, 204);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 5;
            this.bntClear.Text = "Limpar";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // bgReceive
            // 
            this.bgReceive.Controls.Add(this.bntClear);
            this.bgReceive.Controls.Add(this.label2);
            this.bgReceive.Controls.Add(this.lblMensagens);
            this.bgReceive.Location = new System.Drawing.Point(262, 4);
            this.bgReceive.Name = "bgReceive";
            this.bgReceive.Size = new System.Drawing.Size(262, 248);
            this.bgReceive.TabIndex = 6;
            this.bgReceive.TabStop = false;
            // 
            // gbSend
            // 
            this.gbSend.Controls.Add(this.txtMessage);
            this.gbSend.Controls.Add(this.txtUser);
            this.gbSend.Controls.Add(this.lblUsers);
            this.gbSend.Controls.Add(this.lbl1);
            this.gbSend.Controls.Add(this.bntSend);
            this.gbSend.Location = new System.Drawing.Point(4, 4);
            this.gbSend.Name = "gbSend";
            this.gbSend.Size = new System.Drawing.Size(246, 247);
            this.gbSend.TabIndex = 7;
            this.gbSend.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(8, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(48, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Usuários";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(8, 51);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(35, 13);
            this.lblUsers.TabIndex = 5;
            this.lblUsers.Text = "label2";
            // 
            // btnRefresch
            // 
            this.btnRefresch.Location = new System.Drawing.Point(199, 284);
            this.btnRefresch.Name = "btnRefresch";
            this.btnRefresch.Size = new System.Drawing.Size(121, 36);
            this.btnRefresch.TabIndex = 8;
            this.btnRefresch.Text = "Atualizar";
            this.btnRefresch.UseVisualStyleBackColor = true;
            this.btnRefresch.Click += new System.EventHandler(this.btnRefresch_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(6, 177);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(57, 20);
            this.txtUser.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(69, 177);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(171, 20);
            this.txtMessage.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 348);
            this.Controls.Add(this.btnRefresch);
            this.Controls.Add(this.gbSend);
            this.Controls.Add(this.bgReceive);
            this.Name = "FormMain";
            this.Text = "Message Express - Message Express - Message Express - FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.bgReceive.ResumeLayout(false);
            this.bgReceive.PerformLayout();
            this.gbSend.ResumeLayout(false);
            this.gbSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.Label lblMensagens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.GroupBox bgReceive;
        private System.Windows.Forms.GroupBox gbSend;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnRefresch;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtUser;
    }
}