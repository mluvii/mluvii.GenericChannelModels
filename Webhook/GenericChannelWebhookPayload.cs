namespace mluvii.GenericChannelModels.Webhook
{
    /// <summary>
    /// Received by mluvii webhook.
    /// </summary>
    public class GenericChannelWebhookPayload
    {
        /// <summary>
        /// Array of activities.
        /// Activities are sorted by <see cref="GenericChannelIncomingActivity.Timestamp"/> before forwarding them to a mluvii session.
        /// </summary>
        public GenericChannelIncomingActivity[] Activities { get; set; }
    }
}
