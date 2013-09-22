namespace PacketLoggerGUI
{
    partial class Form1
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
            this.lstbx_Server = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbx_Client = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.lblClientPacket = new System.Windows.Forms.TextBox();
            this.lblClientASCII = new System.Windows.Forms.TextBox();
            this.lblServerPacket = new System.Windows.Forms.TextBox();
            this.lblServerASCII = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstbx_Server
            // 
            this.lstbx_Server.FormattingEnabled = true;
            this.lstbx_Server.Location = new System.Drawing.Point(13, 35);
            this.lstbx_Server.Name = "lstbx_Server";
            this.lstbx_Server.Size = new System.Drawing.Size(367, 238);
            this.lstbx_Server.TabIndex = 0;
            this.lstbx_Server.SelectedIndexChanged += new System.EventHandler(this.lstbx_Server_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client";
            // 
            // lstbx_Client
            // 
            this.lstbx_Client.FormattingEnabled = true;
            this.lstbx_Client.Location = new System.Drawing.Point(400, 35);
            this.lstbx_Client.Name = "lstbx_Client";
            this.lstbx_Client.Size = new System.Drawing.Size(365, 238);
            this.lstbx_Client.TabIndex = 2;
            this.lstbx_Client.SelectedIndexChanged += new System.EventHandler(this.lstbx_Client_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 447);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(97, 447);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server Packet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ASCII";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Client Packet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ASCII";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 13;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(400, 447);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(315, 20);
            this.txtConvert.TabIndex = 18;
            // 
            // lblClientPacket
            // 
            this.lblClientPacket.Location = new System.Drawing.Point(97, 273);
            this.lblClientPacket.Multiline = true;
            this.lblClientPacket.Name = "lblClientPacket";
            this.lblClientPacket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblClientPacket.Size = new System.Drawing.Size(648, 37);
            this.lblClientPacket.TabIndex = 19;
            // 
            // lblClientASCII
            // 
            this.lblClientASCII.Location = new System.Drawing.Point(97, 316);
            this.lblClientASCII.Multiline = true;
            this.lblClientASCII.Name = "lblClientASCII";
            this.lblClientASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblClientASCII.Size = new System.Drawing.Size(648, 37);
            this.lblClientASCII.TabIndex = 20;
            // 
            // lblServerPacket
            // 
            this.lblServerPacket.Location = new System.Drawing.Point(97, 357);
            this.lblServerPacket.Multiline = true;
            this.lblServerPacket.Name = "lblServerPacket";
            this.lblServerPacket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblServerPacket.Size = new System.Drawing.Size(648, 37);
            this.lblServerPacket.TabIndex = 21;
            // 
            // lblServerASCII
            // 
            this.lblServerASCII.Location = new System.Drawing.Point(97, 399);
            this.lblServerASCII.Multiline = true;
            this.lblServerASCII.Name = "lblServerASCII";
            this.lblServerASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblServerASCII.Size = new System.Drawing.Size(648, 37);
            this.lblServerASCII.TabIndex = 22;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(400, 478);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 23;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(305, 478);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter0
            // 
            this.txtFilter0.Location = new System.Drawing.Point(16, 480);
            this.txtFilter0.Name = "txtFilter0";
            this.txtFilter0.Size = new System.Drawing.Size(283, 20);
            this.txtFilter0.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.txtFilter0);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblServerASCII);
            this.Controls.Add(this.lblServerPacket);
            this.Controls.Add(this.lblClientASCII);
            this.Controls.Add(this.lblClientPacket);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbx_Client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbx_Server);
            this.Name = "Form1";
            this.Text = "NWN Packet Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbx_Client;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.TextBox lblClientPacket;
        private System.Windows.Forms.TextBox lblClientASCII;
        private System.Windows.Forms.TextBox lblServerPacket;
        private System.Windows.Forms.TextBox lblServerASCII;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter0;
    }
}

