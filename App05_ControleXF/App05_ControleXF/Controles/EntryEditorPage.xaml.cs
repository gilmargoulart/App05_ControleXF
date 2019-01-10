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
	public partial class EntryEditorPage : ContentPage
	{
		public EntryEditorPage ()
		{
			InitializeComponent ();

            txtIdade.TextChanged += delegate (object sender, TextChangedEventArgs e)
            {
                lblDuplicar.Text = e.NewTextValue;
            };

            txtComentario.Completed += delegate (object sender, EventArgs e)
            {
                if (txtComentario.Text != null && txtComentario != null)
                {
                    lblQtdChars.Text = txtComentario.Text.Length.ToString();
                }
            };
		}
	}
}