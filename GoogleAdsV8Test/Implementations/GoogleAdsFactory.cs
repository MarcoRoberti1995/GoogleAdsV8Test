namespace Implementations
{
    #region Includes

    using Google.Ads.GoogleAds.Lib;

    #endregion

    public class GoogleAdsFactory
    {
        #region Public Methods

        public GoogleAdsClient GetClient()
        {
            return new GoogleAdsClient();
        }

        #endregion
    }
}