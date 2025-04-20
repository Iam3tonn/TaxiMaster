namespace ТаксиМастер
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnEditDriver = new System.Windows.Forms.Button();
            this.btnTrips = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelDrivers = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Location = new System.Drawing.Point(1, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(856, 183);
            this.pnlLogo.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(110, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(625, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 946);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(1, 870);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(211, 61);
            this.btnAddDriver.TabIndex = 3;
            this.btnAddDriver.Text = "Добавить водителя";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnEditDriver
            // 
            this.btnEditDriver.Location = new System.Drawing.Point(218, 870);
            this.btnEditDriver.Name = "btnEditDriver";
            this.btnEditDriver.Size = new System.Drawing.Size(251, 61);
            this.btnEditDriver.TabIndex = 4;
            this.btnEditDriver.Text = "Редактировать водителя";
            this.btnEditDriver.UseVisualStyleBackColor = true;
            this.btnEditDriver.Click += new System.EventHandler(this.btnEditDriver_Click);
            // 
            // btnTrips
            // 
            this.btnTrips.Location = new System.Drawing.Point(475, 870);
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.Size = new System.Drawing.Size(181, 61);
            this.btnTrips.TabIndex = 5;
            this.btnTrips.Text = "История поездок";
            this.btnTrips.UseVisualStyleBackColor = true;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(662, 870);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(195, 61);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Обновить список";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 182);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(464, 26);
            this.txtSearch.TabIndex = 7;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(12, 188);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(123, 20);
            this.lbSearch.TabIndex = 8;
            this.lbSearch.Text = "Поиск по ФИО:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(623, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(234, 42);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelDrivers
            // 
            this.panelDrivers.AutoScroll = true;
            this.panelDrivers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDrivers.Location = new System.Drawing.Point(1, 228);
            this.panelDrivers.Name = "panelDrivers";
            this.panelDrivers.Size = new System.Drawing.Size(888, 636);
            this.panelDrivers.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 968);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.panelDrivers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTrips);
            this.Controls.Add(this.btnEditDriver);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Список водителей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnEditDriver;
        private System.Windows.Forms.Button btnTrips;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel panelDrivers;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

