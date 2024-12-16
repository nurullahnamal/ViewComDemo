using Microsoft.AspNetCore.Mvc;
using ViewComDemo.Services;

namespace ViewComDemo.ViewComponents
{
	public class NewsViewComponent : ViewComponent
	{
		private readonly NewsService _newsService;

		public NewsViewComponent()
		{
			_newsService = new NewsService();
		}

		public IViewComponentResult Invoke()
		{
			var news = _newsService.GetNews();
			return View(news);
		}
	}
}
