using System;
using System.Collections.Generic;

namespace com.stcs.spa.vo
{





	public class SubscriptionData : EventData
	{

		private long? id, base_subscription, override_price, items_price;
		private string status, cancel_reason, name;
		private DateTime start, canceled_at, created, end_date;
		private Customer customer;
		private Price price;
		private Plan plan;
		private IDictionary<string, IDictionary<string, string>> extra_fields;

		/// <returns> the id </returns>
		public virtual long getId()
		{
			return id.Value;
		}
		/// <param name="id"> the id to set </param>
		public virtual void setId(long id)
		{
			this.id = id;
		}
		/// 
		/// <summary>
		/// /** </summary>
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
		/// <returns> the customer </returns>
		public virtual Customer Customer
		{
			get
			{
				return customer;
			}
			set
			{
				this.customer = value;
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
		/// <returns> the plan </returns>
		public virtual Plan Plan
		{
			get
			{
				return plan;
			}
			set
			{
				this.plan = value;
			}
		}

		/// <returns> the extra_fields </returns>
		public virtual IDictionary<string, IDictionary<string, string>> Extra_fields
		{
			get
			{
				return extra_fields;
			}
			set
			{
				this.extra_fields = value;
			}
		}


		public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name = value;
			}
		}




		public virtual DateTime End_date
		{
			get
			{
				return end_date;
			}
			set
			{
				this.end_date = value;
			}
		}


		public virtual long? Items_price
		{
			get
			{
				return items_price;
			}
			set
			{
				this.items_price = value;
			}
		}


		public virtual long? Override_price
		{
			get
			{
				return override_price;
			}
			set
			{
				this.override_price = value;
			}
		}


		public virtual void setId(long? id)
		{
			this.id = id;
		}

		public virtual long? Base_subscription
		{
			get
			{
				return base_subscription;
			}
			set
			{
				this.base_subscription = value;
			}
		}

	}



}