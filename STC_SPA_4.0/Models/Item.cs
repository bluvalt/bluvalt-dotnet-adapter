using System;

namespace com.stcs.spa.vo
{

	public class Item : Base
	{

		private int id;
		private string meta_data, name, description;
		private DateTime created, modified;
		private Unit[] units;
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
		/// <returns> the units </returns>
		public virtual Unit[] Units
		{
			get
			{
				return units;
			}
			set
			{
				this.units = value;
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
	}

}