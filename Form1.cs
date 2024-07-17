using CefSharp;
using CefSharp.Handler;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Decibel_Notepad
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser ChromiumEngine;
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeChromium()
        {
            // Создание Chromium.
            var settings = new CefSettings
            {
                // Включаем поддержку File System Access API
                CommandLineArgsDisabled = false
            };

            // Добавляем флаги для поддержки File System Access API
            settings.CefCommandLineArgs.Add("enable-experimental-web-platform-features", "1");
            settings.CefCommandLineArgs.Add("enable-blink-features", "FileSystemAccessAPI");

            Cef.Initialize(settings);

            ChromiumEngine = new ChromiumWebBrowser("file:///Decibel/Decibel.Html")
            {

            };

            // Добавление браузера в панель.
            ChromiumPanel.Controls.Add(ChromiumEngine);
            ChromiumEngine.Dock = DockStyle.Fill;
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowsStateCounter.Text.Contains("False"))
            {
                this.WindowState = FormWindowState.Maximized;
                WindowsStateCounter.Text = "True";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                WindowsStateCounter.Text = "False";
            }
        }

        private void WindowLogo_Click(object sender, EventArgs e)
        {

        }
    }
    public class CustomRequestHandler : RequestHandler
    {
        protected override bool OnQuotaRequest(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, long newSize, IRequestCallback callback)
        {
            if (!callback.IsDisposed)
            {
                callback.Continue(true);
                return true;
            }
            return false;
        }

        protected override bool OnCertificateError(IWebBrowser chromiumWebBrowser, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
        {
            callback.Continue(true);
            return true;
        }

        protected override void OnRenderViewReady(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            // Можно добавить код, который будет выполнен, когда рендеринг готов
        }

        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return new CustomResourceRequestHandler();
        }

        protected override bool OnSelectClientCertificate(IWebBrowser chromiumWebBrowser, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
        {
            // Можно добавить код для выбора клиентского сертификата
            return false;
        }

        protected override bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
        {
            return false;
        }

        protected override bool OnOpenUrlFromTab(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
        {
            return false;
        }
    }

    public class CustomResourceRequestHandler : ResourceRequestHandler
    {
        protected override CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            // Логика перед загрузкой ресурса
            return CefReturnValue.Continue;
        }

        protected override void OnResourceLoadComplete(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
        {
            // Логика после завершения загрузки ресурса
        }

        protected override void OnResourceRedirect(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, ref string newUrl)
        {
            // Логика при перенаправлении ресурса
        }
    }
}
