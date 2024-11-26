using Vives.Presentation.Authentication;

namespace PeopleManager.Ui.BlazorApp.Stores
{
    public class TokenStore: IBearerTokenStore
    {
        public string GetToken()
        {
            return string.Empty;
        }

        public void SetToken(string token)
        {
            
        }
    }
}
