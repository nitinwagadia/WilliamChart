using Android.App;
using Android.Widget;
using Android.OS;
using Com.DB.Chart.Model;
using Com.DB.Chart.View;
using Android.Graphics;

namespace WilliamsonChartLibrarySample
{
	[Activity (Label = "WilliamsonChartLibrarySample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		
		int count = 1;
		string[] labels = {"Jan", "Feb", "Mar", "Apr", "Jun", "May", "Jul", "Aug", "Sep","Oct","Nov","Dec"};
		float[] values = {3.5f, 4.7f, 4.3f, 8f, 6.5f, 9.9f, 7f, 8.3f, 7.0f,0.5f, 1.0f, 2.0f};

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			LineChartView lineChartView = (LineChartView) FindViewById(Resource.Id.linechart);
			LineSet dataset = new LineSet(labels, values)	  			
			.SetFill (Color.ParseColor ("#2d374c"))
			.SetDotsColor (Color.ParseColor ("#ffc755"))
			.SetThickness (4);
			  			
			lineChartView.AddData(dataset);
			lineChartView.Show();		  			

		}
	}
}


