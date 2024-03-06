using System.ComponentModel.DataAnnotations;

namespace mluvii.GenericChannelModels.Activity
{
    public class GenericChannelActivity
    {
        [Required]
        public string ConversationId { get; set; }

        [Required]
        public GenericChannelActivityType Type { get; set; }

        /// <summary>
        /// Html content containing only whitelisted elements.
        /// Used with:
        /// <ul>
        /// <li><see cref="GenericChannelActivityType.ChatMessage"/></li>
        /// </ul>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Used with:
        /// <ul>
        /// <li><see cref="GenericChannelActivityType.OperatorJoined"/></li>
        /// <li><see cref="GenericChannelActivityType.OperatorLeft"/></li>
        /// </ul>
        /// </summary>
        public int OperatorUserId { get; set; }

        /// <summary>
        /// <inheritdoc cref="OperatorUserId"/>
        /// </summary>
        public string OperatorUserFullName { get; set; }

        /// <summary>
        /// <inheritdoc cref="OperatorUserId"/>
        /// </summary>
        public string OperatorPfp { get; set; }
    }
}
