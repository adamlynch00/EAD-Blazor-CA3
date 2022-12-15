namespace Actors
{
	public class Country
	{
		public string name { get; set; }
		public string code { get; set; }
		public string timezone { get; set; }
	}

	public class Image
	{
		public string medium { get; set; }
		public string original { get; set; }
	}

	public class Links
	{
		public Self self { get; set; }
	}

	public class Actor
	{
		public int id { get; set; }
		public string url { get; set; }
		public string name { get; set; }
		public Country country { get; set; }
		public string birthday { get; set; }
		public object deathday { get; set; }
		public string gender { get; set; }
		public Image image { get; set; }
		public int updated { get; set; }
		public Links _links { get; set; }
	}

	public class Self
	{
		public string href { get; set; }
	}


}
