using Microsoft.AspNetCore.Http;

namespace InstaPhotoNet.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        //public int CalculateHours(this DateTime the DateTime)
        //{
        //    var hours = DateTime.Today.Hour - DateAdded
        //}
    }
}
