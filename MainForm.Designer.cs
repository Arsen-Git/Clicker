namespace TcpChat
{
    partial class TCPchat
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
            this.ChkServer = new System.Windows.Forms.CheckBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkServer
            // 
            this.ChkServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkServer.AutoSize = true;
            this.ChkServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChkServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChkServer.Location = new System.Drawing.Point(683, 18);
            this.ChkServer.Name = "ChkServer";
            this.ChkServer.Size = new System.Drawing.Size(86, 29);
            this.ChkServer.TabIndex = 0;
            this.ChkServer.Text = "Server";
            this.ChkServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkServer.UseVisualStyleBackColor = true;
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConnect.Location = new System.Drawing.Point(12, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(124, 39);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnClick
            // 
            this.BtnClick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClick.Enabled = false;
            this.BtnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClick.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnClick.Location = new System.Drawing.Point(142, 110);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(630, 442);
            this.BtnClick.TabIndex = 6;
            this.BtnClick.Text = "Click";
            this.BtnClick.UseVisualStyleBackColor = true;
            this.BtnClick.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(142, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to Clicker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelResult.Location = new System.Drawing.Point(142, 54);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(309, 53);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Your result: 0";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(12, 57);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(124, 492);
            this.TxtLog.TabIndex = 10;
            // 
            // labelTop
            // 
            this.labelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTop.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTop.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTop.Location = new System.Drawing.Point(457, 54);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(315, 53);
            this.labelTop.TabIndex = 11;
            this.labelTop.Text = "Top result: 0";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCPchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClick);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.ChkServer);
            this.Name = "TCPchat";
            this.Text = "Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TCPchat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkServer;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Label labelTop;
    }
}

