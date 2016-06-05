using System;

namespace com.stcs.spa.vo
{

	public class Service : Base
	{

		private int id;
		private string name, description, meta_data, status, url;
		private DateTime created, modified;
		private Item[] items;
		private Feature[] featurs;
		private Plan[] plans;
		private Bundle[] bundles;
		
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
		/// <returns> the url </returns>
		public virtual string Url
		{
			get
			{
				return url;
			}
			set
			{
				this.url = value;
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
		/// <returns> the items </returns>
		public virtual Item[] Items
		{
			get
			{
				return items;
			}
			set
			{
				this.items = value;
			}
		}
		/// <returns> the featurs </returns>
		public virtual Feature[] Featurs
		{
			get
			{
				return featurs;
			}
			set
			{
				this.featurs = value;
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
		/// <returns> the bundles </returns>
		public virtual Bundle[] Bundles
		{
			get
			{
				return bundles;
			}
			set
			{
				this.bundles = value;
			}
		}
		


	}

}