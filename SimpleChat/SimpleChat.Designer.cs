namespace MeiChat
{
    partial class SimpleChat
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Address = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpb_config = new System.Windows.Forms.GroupBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(121, 18);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(186, 19);
            this.Address.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(121, 43);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(186, 19);
            this.Port.TabIndex = 1;
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(333, 69);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(75, 23);
            this.btn_server.TabIndex = 2;
            this.btn_server.Text = "Server Start";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(593, 351);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Peer Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port :";
            // 
            // gpb_config
            // 
            this.gpb_config.Controls.Add(this.Port);
            this.gpb_config.Controls.Add(this.label1);
            this.gpb_config.Controls.Add(this.label2);
            this.gpb_config.Controls.Add(this.Address);
            this.gpb_config.Location = new System.Drawing.Point(14, 12);
            this.gpb_config.Name = "gpb_config";
            this.gpb_config.Size = new System.Drawing.Size(313, 80);
            this.gpb_config.TabIndex = 8;
            this.gpb_config.TabStop = false;
            this.gpb_config.Text = "Config";
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(108, 337);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(479, 19);
            this.txb_name.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(14, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(668, 232);
            this.listBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 19);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name :";
            // 
            // SimpleChat
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.gpb_config);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_server);
            this.Name = "SimpleChat";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimpleChat_FormClosing);
            this.gpb_config.ResumeLayout(false);
            this.gpb_config.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpb_config;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

