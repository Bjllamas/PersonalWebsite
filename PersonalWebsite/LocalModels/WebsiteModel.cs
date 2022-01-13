namespace PersonalWebsite.LocalModels
{
    public class WebsiteModel
    {
        
        public string ImageURL { get; set; }
        
        public WebsiteModel(string ImageURL)
        {
            this.ImageURL = ImageURL;
        }

        public WebsiteModel()
        {
        }
    }
}
