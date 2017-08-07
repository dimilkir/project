namespace App9
{
    class BananaFarmer
    {

        public decimal BagsOfFeed { get; private set; }

        int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        
        int numberOfBananas;

        public BananaFarmer(int numberOfBananas, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfBananas = numberOfBananas;
        }

        public int NumberOfBananas
        {
            get
            {
                return numberOfBananas;
            }
            set
            {
                numberOfBananas = value;
                BagsOfFeed = (decimal) numberOfBananas / FeedMultiplier;
            }
        }



    }
}
