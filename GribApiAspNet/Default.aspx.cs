using System;
using System.Web.UI;
using Grib.Api;

namespace GribApiAspNet
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (GribFile grib = new GribFile(Server.MapPath("~/Content/reduced_latlon_surface.grib2")))
			{
				Text.Text = String.Format("There are {0} grib messages.\n", grib.MessageCount);

				foreach (var msg in grib)
				{
					Text.Text = String.Format("   {0}\n", msg.ToString());
				}
			}
		}
	}
}