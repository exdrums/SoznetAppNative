using NetMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetMobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MemberListPage : ContentPage
	{
		public MemberListPage ()
		{
			InitializeComponent ();
            BindingContext = new MemberListViewModel() { Navigation = this.Navigation };
		}
	}
}