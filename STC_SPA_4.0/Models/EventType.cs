using Newtonsoft.Json;
namespace com.stcs.spa.vo
{
	public enum EventType
	{
        [JsonProperty("subscription.created")]
        SUBSCRIPTION_CREATED,
        [JsonProperty("subscription.canceled")]
        SUBSCRIPTION_CANCELED,
        [JsonProperty("subscription.upgraded")]
        SUBSCRIPTION_UPGRADED,
        [JsonProperty("subscription.downgraded")]
        SUBSCRIPTION_DOWNGRADED,
        [JsonProperty("subscription.addon.attached")]
        SUBSCRIPTION_ADDON_ATTACHED,
        [JsonProperty("subscription.addon.canceled")]
        SUBSCRIPTION_ADDON_CANCELED,
        [JsonProperty("subscription.user.added")]
        SUBSCRIPTION_USER_ADDED,
        [JsonProperty("subscription.user.removed")]
        SUBSCRIPTION_USER_REMOVED,
        [JsonProperty("webhook.test")]
        WEBHOOK_TEST,
		[JsonProperty("account.suspended")]
		ACCOUNT_SUSPENDED,
        [JsonProperty("account.resumed")]
		ACCOUNT_RESUMED,
        [JsonProperty("account.terminated")]
		ACCOUNT_TERMINATED,
        [JsonProperty("event.expired")]
		EVENT_EXPIRED
	}

}