using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App05_ControleXF.Modelo;

namespace App05_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa() { Nome = "José", Idade="32" });
            pessoas.Add(new Pessoa() { Nome = "Maria", Idade="25" });
            pessoas.Add(new Pessoa() { Nome = "Felipe", Idade="28" });
            pessoas.Add(new Pessoa() { Nome = "João", Idade="33" });
            pessoas.Add(new Pessoa() { Nome = "Mariana", Idade="21" });

            listaPessoas.ItemsSource = pessoas;
        }
	}
}