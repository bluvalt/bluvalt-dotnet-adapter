using System;

namespace com.stcs.spa.vo
{

	public class Bundle : Base
	{

		private int id, price;
		private string name, description, meta_data;
		private DateTime created, modified;
		private Plan[] plans;
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
		/// <returns> the price </returns>
		public virtual int Price
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
		/// <returns> the name </returns>
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
		/// <returns> the description </returns>
		public virtual string Description
		{
			get
			{
				return description;
			}
			set
			{
				this.description = value;
			}
		}
		/// <returns> the meta_data </returns>
		public virtual string Meta_data
		{
			get
			{
				return meta_data;
			}
			set
			{
				this.meta_data = value;
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
		/// <returns> the plans </returns>
		public virtual Plan[] Plans
		{
			get
			{
				return plans;
			}
			set
			{
				this.plans = value;
			}
		}

	}

}