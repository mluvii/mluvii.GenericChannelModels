using mluvii.GenericChannelModels.Activity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.GenericChannelModels.Webhook
{
    public class GenericChannelIncomingActivity : GenericChannelActivity
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Conversation metadata will be used when a new session is created as a result of incoming activity in given conversation.
        /// </summary>
        public IDictionary<string, string> ConversationMetadata { get; set; }
    }
}
