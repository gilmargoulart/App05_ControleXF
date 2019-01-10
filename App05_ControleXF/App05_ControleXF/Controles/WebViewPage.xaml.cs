using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

        private void Button_IrPagina(object sender, EventArgs e)
        {
            webView.Source = txtEnderecoSite.Text;
        }

        private void Button_ProximaPagina(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
            
        }

        private void Button_VoltarPagina(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Carregando...";
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Pronto!";
        }
    }
}