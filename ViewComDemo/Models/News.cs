namespace ViewComDemo.Models
{

	public class News
	{
		public int Id { get; set; } = 1;
		public string Title { get; set; } = "Baslık";
		public string Description { get; set; } = "Açıklama";
		public DateTime PublishedDate { get; set; } = DateTime.Now;
	}
}
