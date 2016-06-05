using System;

namespace com.stcs.spa.vo
{

	public class Price : Base
	{

		private int id, period, amount;
		private string type, period_unit, currency;
		private DateTime created, modified;
		/// <returns> the id </returns>
		public virtual int Id
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
		/// <returns> the period </returns>
		public virtual int Period
		{
			get
			{
				return period;
			}
			set
			{
				this.period = value;
			}
		}
		/// <returns> the amount </returns>
		public virtual int Amount
		{
			get
			{
				return amount;
			}
			set
			{
				this.amount = value;
			}
		}
		/// <returns> the type </returns>
		public virtual string Type
		{
			get
			{
				return type;
			}
			set
			{
				this.type = value;
			}
		}
		/// <returns> the period_unit </returns>
		public virtual string Period_unit
		{
			get
			{
				return period_unit;
			}
			set
			{
				this.period_unit = value;
			}
		}
		/// <returns> the currency </returns>
		public virtual string Currency
		{
			get
			{
				return currency;
			}
			set
			{
				this.currency = value;
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
		/// <returns> the modified </returns>
		public virtual DateTime Modified
		{
			get
			{
				return modified;
			}
			set
			{
				this.modified = value;
			}
		}


	}

}