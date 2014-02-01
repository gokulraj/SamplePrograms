namespace GWZohoCRM
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.linkLabelTFA = new System.Windows.Forms.LinkLabel();
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.linkLabelCancel = new System.Windows.Forms.LinkLabel();
            this.gbSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelTFA
            // 
            resources.ApplyResources(this.linkLabelTFA, "linkLabelTFA");
            this.linkLabelTFA.Name = "linkLabelTFA";
            this.linkLabelTFA.TabStop = true;
            // 
            // gbSignIn
            // 
            this.gbSignIn.Controls.Add(this.linkLabelCancel);
            this.gbSignIn.Controls.Add(this.buttonSignIn);
            this.gbSignIn.Controls.Add(this.labelPassword);
            this.gbSignIn.Controls.Add(this.textBoxEmail);
            this.gbSignIn.Controls.Add(this.labelEmail);
            this.gbSignIn.Controls.Add(this.textBoxPassword);
            this.gbSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.gbSignIn, "gbSignIn");
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.TabStop = false;
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.Name = "labelEmail";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.Name = "textBoxEmail";
            // 
            // labelPassword
            // 
            resources.ApplyResources(this.labelPassword, "labelPassword");
            this.labelPassword.Name = "labelPassword";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.buttonSignIn, "buttonSignIn");
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // linkLabelCancel
            // 
            resources.ApplyResources(this.linkLabelCancel, "linkLabelCancel");
            this.linkLabelCancel.Name = "linkLabelCancel";
            this.linkLabelCancel.TabStop = true;
            this.linkLabelCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // SignIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelTFA);
            this.Controls.Add(this.gbSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelTFA;
        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.LinkLabel linkLabelCancel;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;

    }
}

