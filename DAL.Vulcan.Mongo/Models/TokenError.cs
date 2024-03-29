namespace DAL.Vulcan.Mongo.Models
{
    public class TokenError : TokenResult
    {
        public string ErrorMessage;
        public TokenError(string appName, string error) : base(appName: appName)
        {
            IsError = true;
            ErrorMessage = error;
        }
    }
}