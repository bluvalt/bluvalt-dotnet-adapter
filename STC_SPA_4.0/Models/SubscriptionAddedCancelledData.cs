﻿using System;
using System.Collections.Generic;

namespace com.stcs.spa.vo
{





	public class SubscriptionAddedCancelledData : EventData
	{

		private long? id;
		private string status, cancel_reason;
		private DateTime start, canceled_at, created;
		private Customer customer;
		private Price price;
		private Plan plan;
		private long?[] admin_users;
		private string[] admin_users_usernames;
		private IDictionary<string, IDictionary<string, string>> extra_fields;
		/// <returns> the id </returns>
		public virtual long Id
		{
			get
			{
				return id.Value;
			}
			set
			{
				this.id = value;
			}
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
		/// <returns> the admin_users </returns>
		public virtual long?[] Admin_users
		{
			get
			{
				return admin_users;
			}
			set
			{
				this.admin_users = value;
			}
		}
		/// <returns> the admin_users_usernames </returns>
		public virtual string[] Admin_users_usernames
		{
			get
			{
				return admin_users_usernames;
			}
			set
			{
				this.admin_users_usernames = value;
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





	}



}