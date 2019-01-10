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
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pode capturar o objeto de duas maneiras:
            Picker obj = (Picker)sender;
            // Ou através do x:name no xaml.
            // pickerSelector.SelectedItem

            lblResultado.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();

        }
    }
}