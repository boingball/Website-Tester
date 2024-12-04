//Copyright(c) 2024, Darren Banfi
//All rights reserved.
//
//This source code is licensed under the BSD-style license found in the
//LICENSE file in the root directory of this source tree. 
namespace Website_Tester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            urlBox = new TextBox();
            label1 = new Label();
            webHTTP = new Microsoft.Web.WebView2.WinForms.WebView2();
            webHTTPS = new Microsoft.Web.WebView2.WinForms.WebView2();
            webHTTP2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webHTTPS2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)webHTTP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webHTTPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webHTTP2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webHTTPS2).BeginInit();
            SuspendLayout();
            // 
            // urlBox
            // 
            urlBox.Location = new Point(63, 12);
            urlBox.Name = "urlBox";
            urlBox.Size = new Size(333, 23);
            urlBox.TabIndex = 0;
            urlBox.TextChanged += urlBox_TextChanged;
            urlBox.KeyDown += urlBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "URL";
            // 
            // webHTTP
            // 
            webHTTP.AllowExternalDrop = true;
            webHTTP.CreationProperties = null;
            webHTTP.DefaultBackgroundColor = Color.White;
            webHTTP.Location = new Point(29, 41);
            webHTTP.Name = "webHTTP";
            webHTTP.Size = new Size(663, 378);
            webHTTP.Source = new Uri("http://localhost", UriKind.Absolute);
            webHTTP.TabIndex = 2;
            webHTTP.ZoomFactor = 1D;
            // 
            // webHTTPS
            // 
            webHTTPS.AllowExternalDrop = true;
            webHTTPS.CreationProperties = null;
            webHTTPS.DefaultBackgroundColor = Color.White;
            webHTTPS.Location = new Point(718, 41);
            webHTTPS.Name = "webHTTPS";
            webHTTPS.Size = new Size(694, 378);
            webHTTPS.Source = new Uri("http://localhost", UriKind.Absolute);
            webHTTPS.TabIndex = 3;
            webHTTPS.ZoomFactor = 1D;
            // 
            // webHTTP2
            // 
            webHTTP2.AllowExternalDrop = true;
            webHTTP2.CreationProperties = null;
            webHTTP2.DefaultBackgroundColor = Color.White;
            webHTTP2.Location = new Point(29, 425);
            webHTTP2.Name = "webHTTP2";
            webHTTP2.Size = new Size(663, 392);
            webHTTP2.Source = new Uri("http://localhost", UriKind.Absolute);
            webHTTP2.TabIndex = 4;
            webHTTP2.ZoomFactor = 1D;
            // 
            // webHTTPS2
            // 
            webHTTPS2.AllowExternalDrop = true;
            webHTTPS2.CreationProperties = null;
            webHTTPS2.DefaultBackgroundColor = Color.White;
            webHTTPS2.Location = new Point(718, 425);
            webHTTPS2.Name = "webHTTPS2";
            webHTTPS2.Size = new Size(694, 392);
            webHTTPS2.Source = new Uri("http://localhost", UriKind.Absolute);
            webHTTPS2.TabIndex = 5;
            webHTTPS2.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.Location = new Point(415, 14);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(636, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "http://url";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1345, 22);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "https://url";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(606, 425);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "http://www.url";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1321, 425);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "https://www.url";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 829);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(webHTTPS2);
            Controls.Add(webHTTP2);
            Controls.Add(webHTTPS);
            Controls.Add(webHTTP);
            Controls.Add(label1);
            Controls.Add(urlBox);
            Name = "Form1";
            Text = "Website Testing";
            ((System.ComponentModel.ISupportInitialize)webHTTP).EndInit();
            ((System.ComponentModel.ISupportInitialize)webHTTPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)webHTTP2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webHTTPS2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlBox;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webHTTP;
        private Microsoft.Web.WebView2.WinForms.WebView2 webHTTPS;
        private Microsoft.Web.WebView2.WinForms.WebView2 webHTTP2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webHTTPS2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
