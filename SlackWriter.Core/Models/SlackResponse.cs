using System.Net;

namespace SlackWriter.Core.Models {
    public class SlackResponse {
        public SlackResponse (string content, bool isSuccessful, HttpStatusCode statusCode) {
            Content = content;
            IsSuccessful = isSuccessful;
            StatusCode = statusCode;
        }

        public string Content { get; set; }
        public bool IsSuccessful { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}