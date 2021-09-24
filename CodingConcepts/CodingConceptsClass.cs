namespace CodingConcepts
{
    class CodingConceptsClass
    {
        private string title;
        private string info;
        private string image;
        private string linkInfo;

        public string Title { get => title; set => title = value; }
        public string Info { get => info; set => info = value; }
        public string Image { get => image; set => image = value; }
        public string LinkInfo { get => linkInfo; set => linkInfo = value; }

        public CodingConceptsClass(string title, string info, string image, string linkInfo)
        {
            this.Title = title;
            this.Info = info;
            this.Image = image;
            this.LinkInfo = linkInfo;
        }
    }
}
