using mluvii.GenericChannelModels.Activity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mluvii.GenericChannelModels.Webhook
{
    public class GenericChannelIncomingActivity : GenericChannelActivity
    {
        /// <summary>
        /// Internal id of the activity. Not used by mluvii session but can be useful for debugging.
        /// </summary>
        [Required]
        public string Id { get; set; }

        /// <summary>
        /// Time of the activity. Activities are sorted by timestamp before forwarding them to a mluvii session.
        /// </summary>
        [Required]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Conversation metadata will be used when a new session is created as a result of incoming activity in given conversation.
        /// </summary>
        public IDictionary<string, string> ConversationMetadata { get; set; }
    }
}
