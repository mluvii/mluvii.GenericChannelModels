using mluvii.GenericChannelModels.Activity;
using System;
using System.ComponentModel.DataAnnotations;

namespace mluvii.GenericChannelModels.Webhook
{
    public class GenericChannelIncomingActivity : GenericChannelActivity
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public DateTimeOffset Timestamp { get; set; }
    }
}
