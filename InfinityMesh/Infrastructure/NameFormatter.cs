namespace InfinityMesh.Infrastructure
{
    public class NameFormatter : IFormatter
    {
        public string Format(string name)
        {
            switch (name.Trim())
            {
                case "DT":
                    return "Donald Trump";
                case "HC":
                    return "Hillary Clinton";
                case "JB":
                    return "Joe Biden";
                case "JFK":
                    return "John F. Kennedy";
                case "JR":
                    return "Jack Randall";
                default:
                    return "";
            }
        }
    }
}
