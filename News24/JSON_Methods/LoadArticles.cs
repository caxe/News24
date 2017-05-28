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
	public static class LoadArticles
	{
		public static Article[] Articles;

		public static Article[] LoadSourceArticles(string id)
		{
			var url = "https://newsapi.org/v1/articles?source=" + id + "&apiKey=f8f2e6af1ae64bbaa75a982a2e6a6a38";
			using (var webClient = new WebClient())
			{
				var json = webClient.DownloadString(url);
				var article = JsonConvert.DeserializeObject<ArticleObjects>(json);
				var articles = article.Articles;
				Articles = articles.ToArray();
			}
			return Articles;
		}

		public static string[] LoadSourceArticleTitle(string id)
		{
			string[] articlesTitle;
			var url = "https://newsapi.org/v1/articles?source=" + id + "&apiKey=f8f2e6af1ae64bbaa75a982a2e6a6a38";
			using (var webClient = new WebClient())
			{
				var json = webClient.DownloadString(url);
				var article = JsonConvert.DeserializeObject<ArticleObjects>(json);
				articlesTitle = article.Articles.Select(tempArticle => tempArticle.Title).ToArray();
			}
			return articlesTitle;
		}

		public static SelectList LoadSourceArticlesList(string id, object selectedArticle = null)
		{
			var listArticles = LoadSourceArticleTitle(id);
			return new SelectList(listArticles);
		}
	}
}