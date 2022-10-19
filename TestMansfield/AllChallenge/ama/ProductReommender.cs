namespace AllChallenge.ama
{


    /*
    
    A: B C
    B: A D
    C: A B
    D: C B A
    

    A: B C D
    B: A D C
    C: A B C
    D: C B A
    
    */


    public class ProductRecommender
    {
        public static Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static HashSet<string> visited = new HashSet<string>();
        public static void Suggestions(Product p, Dictionary<string, Product> res, Product s)
        {
            if (visited.Contains(p.ProductId))
                return;
            else
                visited.Add(p.ProductId);

            foreach (var item in p.Suggestions)
            {
                if (!res.ContainsKey(item) && item != p.ProductId && item != s.ProductId)
                {
                    res.Add(item, products[item]);
                }
                Suggestions(products[item], res, s);
            }

        }

    }

    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;

        public IList<string> Suggestions { get; set; } = new List<string>();

    }
}
