using BookLibrary.UI.FedAchServiceReference;

namespace BookLibrary.UI.Models
{
    public class FedAchStart
    {
        public void StartService(string searchValue)
        {
            FedACHList fedACHList = new FedACHList();
            FedACHSoapClient client = new FedACHSoapClient();

            client.getACHByName(searchValue, out fedACHList);
            //client.getACHByName("Peter", out fedACHList);
        }
    }
}
