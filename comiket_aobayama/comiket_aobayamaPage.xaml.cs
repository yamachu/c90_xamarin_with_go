using Xamarin.Forms;

namespace comiket_aobayama
{
	public partial class comiket_aobayamaPage : ContentPage
	{
		public comiket_aobayamaPage()
		{
			InitializeComponent();

			this.FindByName<Button>("NativeButton").Clicked += (sender, e) => {
				this.FindByName<Label>("NativeResult").Text = GoAobayama.callCLibrary("You");
			};
		}
	}
}

