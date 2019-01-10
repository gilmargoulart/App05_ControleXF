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
	public partial class SearchBarPage : ContentPage
	{
        List<String> empresasTI;

        public SearchBarPage ()
		{
			InitializeComponent ();

            empresasTI = new List<string>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Apple");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");
            empresasTI.Add("SpaceX");

            PreencherEmpresas(empresasTI);
        }

        private void PreencherEmpresas(List<String> empresasTI)
        {
            listResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                listResult.Children.Add(new Label() { Text = emp });
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar_Buscar(e.NewTextValue);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            SearchBar_Buscar(searchBar.Text);
        }

        private void SearchBar_Buscar(string termoBusca)
        {
            if (termoBusca.Length > 0)
            {
                var resultado = empresasTI.Where(a => a.Contains(termoBusca)).ToList<String>();
                PreencherEmpresas(resultado);
            }
        }
    }
}