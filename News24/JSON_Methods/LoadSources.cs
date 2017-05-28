using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using News24.Models;
using Newtonsoft.Json;

namespace News24.JSON_Methods
{
	public static class LoadSources
	{
		public static string[] IdStrings;

		public static string[] LoadSourceId()
		{
			const string url = "https://newsapi.org/v1/sources?language=en";
			using (var webClient = new WebClient())
			{
				var json = webClient.DownloadString(url);
				var source = JsonConvert.DeserializeObject<SourceObjects>(json);
				IdStrings = source.Sources.Select(tempSource => tempSource.Id).ToArray();
			}
			return IdStrings;
		}

		public static SelectList LoadSourceList(object selectedSource = null)
		{
			var listSources = LoadSourceId();
			return new SelectList(listSources);
		}
	}
}