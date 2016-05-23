using System;

namespace com.stcs.spa.vo
{


	public class Addon : BaseVO
	{

		private int id, maximum_allowed_subscriptions, quantity, service_id;
		private string name, description, meta_data;
		private DateTime created, modified;
		private Item Item_Renamed;
		private Unit unit;
		private Price price;
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
		/// <returns> the maximum_allowed_subscriptions </returns>
		public virtual int Maximum_allowed_subscriptions
		{
			get
			{
				return maximum_allowed_subscriptions;
			}
			set
			{
				this.maximum_allowed_subscriptions = value;
			}
		}
		/// <returns> the quantity </returns>
		public virtual int Quantity
		{
			get
			{
				return quantity;
			}
			set
			{
				this.quantity = value;
			}
		}
		/// <returns> the service_id </returns>
		public virtual int Service_id
		{
			get
			{
				return service_id;
			}
			set
			{
				this.service_id = value;
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
		/// <returns> the item </returns>
		public virtual Item Item
		{
			get
			{
				return Item_Renamed;
			}
			set
			{
				Item_Renamed = value;
			}
		}
		/// <returns> the unit </returns>
		public virtual Unit Unit
		{
			get
			{
				return unit;
			}
			set
			{
				this.unit = value;
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