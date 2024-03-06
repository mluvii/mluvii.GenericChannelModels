using System.Collections.Generic;

namespace mluvii.GenericChannelModels.Registration
{
    public class GenericChannelWebhookRegistrationModel
    {
        public string Url { get; set; }

        public IDictionary<string, string> Headers { get; set; }
    }
}
