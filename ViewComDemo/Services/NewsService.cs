using ViewComDemo.Models;

namespace ViewComDemo.Services
{
	public class NewsService
	{
		public List<News> GetNews()
		{
			return new List<News>
			{
				new News { Id = 1, Title = "Haber 1", Description = "Haber 1 açıklaması", PublishedDate = DateTime.Now.AddDays(-1) },
				new News { Id = 2, Title = "Haber 2", Description = "Haber 2 açıklaması", PublishedDate = DateTime.Now.AddDays(-2) },
				new News { Id = 3, Title = "Haber 3", Description = "Haber 3 açıklaması", PublishedDate = DateTime.Now.AddDays(-3) }
			};
		}
	}
}
