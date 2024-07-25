using HtmlAgilityPack;
namespace simpleWebScraper
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string? inputLink = Console.ReadLine();
            HttpClient client = new HttpClient();
            string html = await client.GetStringAsync(inputLink);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);

            var paragraphs = document.DocumentNode.SelectNodes("//p");

            foreach (var paragraph in paragraphs)
            {
                Console.WriteLine(paragraph.InnerText);
            }

        }
    }
}