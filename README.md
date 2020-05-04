# SlackWriter

A REST Client wrapper for POSTing text messages to a Slack Channel from a bot.

```cs
string webhookSecret = "<YOUR-WEBHOOK-SECRET>";
SlackResponse response = slackClient.WriteToChannel (webhookSecret, "Hello World!");
```

## Requirements and Webhook Secret
- A Slack Account.  Go create one before continuing.
- Activate Incoming Webhooks
  - Go to [https://api.slack.com/apps](https://api.slack.com/apps)
  - Click on your app.  If you don't have an app, create one.
  - Click on `Incoming Webhooks`
  - Set this feature to `On`
- Copy your Webhook Secret
  - Click `Add New Webhook to Workspace` to add to a workspace.  You can skip this if you've already added your bot to a workspace.
  - Look inside the `Sample curl request to post to channel` section, copy the code after /services/.  This is your WebHookSecret.

## Limitations
- Slack limits messages up to 40,000 characters as of August 2018.  Make sure your String is below this threshold. 
  - Reference: [Slack Message Length Limits](https://api.slack.com/changelog/2018-04-truncating-really-long-messages)
