//Copyright(c) 2024, Darren Banfi
//All rights reserved.
//
//This source code is licensed under the BSD-style license found in the
//LICENSE file in the root directory of this source tree. 
namespace Website_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the Go button's click event
                button1.PerformClick();

                // Prevent the beep sound (optional)
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stop existing navigation
            webHTTP.CoreWebView2.Stop();
            webHTTPS.CoreWebView2.Stop();
            webHTTP2.CoreWebView2.Stop();
            webHTTPS2.CoreWebView2.Stop();

            string cleanHTML = "<body> Waiting for test </body>";

            // Clear existing navigation
            webHTTP.CoreWebView2.NavigateToString(cleanHTML);
            webHTTPS.CoreWebView2.NavigateToString(cleanHTML);
            webHTTP2.CoreWebView2.NavigateToString(cleanHTML);
            webHTTPS2.CoreWebView2.NavigateToString(cleanHTML);

            // Get the URL and strip "https://www." if it starts with it
            string url = urlBox.Text;
            if (url.StartsWith("https://www."))
            {
                url = url.Substring("https://www.".Length);
            }
            else if (url.StartsWith("http://www."))
            {
                url = url.Substring("http://www.".Length);
            }
            else if (url.StartsWith("https://"))
            {
                url = url.Substring("https://".Length);
            }
            else if (url.StartsWith("http://"))
            {
                url = url.Substring("http://".Length);
            }
            else if (url.StartsWith("www."))
            {
                url = url.Substring("www.".Length);
            }

            // Build the new URLs
            string httpurl = "http://" + url;
            string httpsurl = "https://" + url;
            string httpwurl = "http://www." + url;
            string httpswurl = "https://www." + url;

            // Navigate to the URLs
            webHTTP.CoreWebView2.Navigate(httpurl);
            webHTTPS.CoreWebView2.Navigate(httpsurl);
            webHTTP2.CoreWebView2.Navigate(httpwurl);
            webHTTPS2.CoreWebView2.Navigate(httpswurl);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
