namespace com.stcs.spa.vo
{



	public class SubscriptionUserAddedRemovedData : EventData
	{

		private long? id, subscription, user;
		private bool admin;
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
		/// <returns> the subscription </returns>
		public virtual long? Subscription
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
		/// <returns> the user </returns>
		public virtual long? User
		{
			get
			{
				return user;
			}
			set
			{
				this.user = value;
			}
		}
		/// <returns> the admin </returns>
		public virtual bool Admin
		{
			get
			{
				return admin;
			}
			set
			{
				this.admin = value;
			}
		}



	}



}