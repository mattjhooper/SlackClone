namespace SlackClone.Domain
{
    public class SlackMessage
    {
        private string[] icons = {"oi oi-thumb-up","oi oi-thumb-down", "oi oi-rain", "oi oi-sun" };


        private readonly Dictionary<string, int> _reactions;

        public SlackMessage()
        {
            _reactions = new Dictionary<string,int>();

            foreach(var icon in icons)
            {
                _reactions[icon] = 0;
            }
        }
        
        public string PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public string Message { get; set; }

        public Dictionary<string, int> Reactions => _reactions;
    }
}

