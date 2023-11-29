namespace TheShop.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }


        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Your request is not valid. Please check the provided data.",
                401 => "You do not have the necessary permissions to access this resource.",
                404 => "The requested resource could not be found. Please verify the URL.",
                500 => "An internal server error occurred. Our team has been notified.",
                _ => null
            };
        }
    }


}
