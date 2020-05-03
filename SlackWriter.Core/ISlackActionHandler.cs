using SlackWriter.Core.Models;

namespace SlackWriter {
    public interface ISlackActionHandler {
        SlackResponse PostMessageToChannel (string webhookSecret, string message);
    }
}