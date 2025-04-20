namespace ТаксиМастер
{
    partial class DriverForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbLicense = new System.Windows.Forms.Label();
            this.lbExpiry = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRating = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(570, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(236, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 26);
            this.txtName.TabIndex = 1;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(236, 53);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(331, 26);
            this.dtpBirth.TabIndex = 2;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(236, 85);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(331, 26);
            this.txtLicense.TabIndex = 3;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(236, 117);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(331, 26);
            this.dtpExpiry.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(236, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(331, 26);
            this.txtAddress.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(236, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(331, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(236, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(236, 245);
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(331, 26);
            this.numRating.TabIndex = 8;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.lbRating);
            this.pnlAdd.Controls.Add(this.lbEmail);
            this.pnlAdd.Controls.Add(this.lbPhone);
            this.pnlAdd.Controls.Add(this.lbAddress);
            this.pnlAdd.Controls.Add(this.lbExpiry);
            this.pnlAdd.Controls.Add(this.lbLicense);
            this.pnlAdd.Controls.Add(this.lbBirth);
            this.pnlAdd.Controls.Add(this.lbName);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Controls.Add(this.numRating);
            this.pnlAdd.Controls.Add(this.dtpBirth);
            this.pnlAdd.Controls.Add(this.txtEmail);
            this.pnlAdd.Controls.Add(this.txtLicense);
            this.pnlAdd.Controls.Add(this.txtPhone);
            this.pnlAdd.Controls.Add(this.dtpExpiry);
            this.pnlAdd.Controls.Add(this.txtAddress);
            this.pnlAdd.Location = new System.Drawing.Point(12, 12);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(570, 285);
            this.pnlAdd.TabIndex = 9;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(3, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "label1";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(3, 58);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(51, 20);
            this.lbBirth.TabIndex = 10;
            this.lbBirth.Text = "label2";
            // 
            // lbLicense
            // 
            this.lbLicense.AutoSize = true;
            this.lbLicense.Location = new System.Drawing.Point(3, 88);
            this.lbLicense.Name = "lbLicense";
            this.lbLicense.Size = new System.Drawing.Size(51, 20);
            this.lbLicense.TabIndex = 11;
            this.lbLicense.Text = "label3";
            // 
            // lbExpiry
            // 
            this.lbExpiry.AutoSize = true;
            this.lbExpiry.Location = new System.Drawing.Point(3, 122);
            this.lbExpiry.Name = "lbExpiry";
            this.lbExpiry.Size = new System.Drawing.Size(51, 20);
            this.lbExpiry.TabIndex = 12;
            this.lbExpiry.Text = "label4";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(3, 152);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 20);
            this.lbAddress.TabIndex = 13;
            this.lbAddress.Text = "label5";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(3, 184);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(51, 20);
            this.lbPhone.TabIndex = 14;
            this.lbPhone.Text = "label6";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 216);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "label7";
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(3, 247);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(51, 20);
            this.lbRating.TabIndex = 16;
            this.lbRating.Text = "label8";
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 360);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.btnSave);
            this.Name = "DriverForm";
            this.Text = "Добавление/редактирование";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbExpiry;
        private System.Windows.Forms.Label lbLicense;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}