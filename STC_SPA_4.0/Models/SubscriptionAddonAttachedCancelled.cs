using System;

namespace com.stcs.spa.vo
{


	public class SubscriptionAddonAttachedCancelled : EventData
	{

		private long? id;
		private string status, cancel_reason;
		private DateTime start, canceled_at, created;
		private SubscriptionAddedCancelledData subscription;
		private Addon addon;
		private Price price;
		/// <returns> the id </returns>
		public virtual long? Id
		{
			get
			{
				return id;
			}
			set
			{
				this.id = value;
			}
		}
		/// <returns> the status </returns>
		public virtual string Status
		{
			get
			{
				return status;
			}
			set
			{
				this.status = value;
			}
		}
		/// <returns> the cancel_reason </returns>
		public virtual string Cancel_reason
		{
			get
			{
				return cancel_reason;
			}
			set
			{
				this.cancel_reason = value;
			}
		}
		/// <returns> the start </returns>
		public virtual DateTime Start
		{
			get
			{
				return start;
			}
			set
			{
				this.start = value;
			}
		}
		/// <returns> the canceled_at </returns>
		public virtual DateTime Canceled_at
		{
			get
			{
				return canceled_at;
			}
			set
			{
				this.canceled_at = value;
			}
		}
		/// <returns> the created </returns>
		public virtual DateTime Created
		{
			get
			{
				return created;
			}
			set
			{
				this.created = value;
			}
		}
		/// <returns> the subscription </returns>
		public virtual SubscriptionAddedCancelledData Subscription
		{
			get
			{
				return subscription;
			}
			set
			{
				this.subscription = value;
			}
		}
		/// <returns> the addon </returns>
		public virtual Addon Addon
		{
			get
			{
				return addon;
			}
			set
			{
				this.addon = value;
			}
		}
		/// <returns> the price </returns>
		public virtual Price Price
		{
			get
			{
				return price;
			}
			set
			{
				this.price = value;
			}
		}
	}

}