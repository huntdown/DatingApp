namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string messages, string detail)
        {
            StatusCode = statusCode;
            Messages = messages;
            Detail = detail;
        }

        public int StatusCode { get; set; } 
        public string Messages { get; set; }
        public string Detail { get; set; }
    }
}