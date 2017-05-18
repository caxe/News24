using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News24.Models
{
	public class Article
	{
		public string Author { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public string UrlToImage { get; set; }
		public DateTime PublishedAt { get; set; }
	}

	public partial class Rootobject
	{
		public Article[] Articles { get; set; }
	}
}
