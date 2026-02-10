namespace Iterator.collection
{
    public class Novel
    {
        private string title;
        private string author;
        private string category;
        private string status;
        private int views;

        public Novel(string title, string author, string category, string status, int views)
        {
            this.title = title;
            this.author = author;
            this.category = category;
            this.status = status;
            this.views = views;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetStatus()
        {
            return status;
        }

        public int GetViews()
        {
            return views;
        }

        public override string ToString()
        {
            return "Novel " +
                   "title: '" + title + '\'' +
                   ", author: '" + author + '\'' +
                   ", category: '" + category + '\'' +
                   ", status: '" + status + '\'' +
                   ", views: " + views;
        }
    }
}