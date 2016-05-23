using System;

namespace com.stcs.spa.vo
{


	public class Plan : BaseVO
	{

		private int id;
		private string name, description, meta_data;
		private DateTime created, modified;
		private string initial_price;
		private Feature[] features;
		private Price[] prices;
		private PlanItem[] plan_items;
		/// <returns> the id </returns>
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @org.codehaus.jackson.annotate.JsonIgnore public int getId()
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
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @org.codehaus.jackson.annotate.JsonIgnore public String getMeta_data()
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
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @org.codehaus.jackson.annotate.JsonIgnore public java.util.Date getCreated()
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
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @org.codehaus.jackson.annotate.JsonIgnore public java.util.Date getModified()
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
		/// <returns> the initial_price </returns>
		public virtual string Initial_price
		{
			get
			{
				return initial_price;
			}
			set
			{
				this.initial_price = value;
			}
		}
		/// <returns> the features </returns>
		public virtual Feature[] Features
		{
			get
			{
				return features;
			}
			set
			{
				this.features = value;
			}
		}
		/// <returns> the prices </returns>

		public virtual Price[] Prices
		{
			get
			{
				return prices;
			}
			set
			{
				this.prices = value;
			}
		}
		/// <returns> the plan_items </returns>
		public virtual PlanItem[] Plan_items
		{
			get
			{
				return plan_items;
			}
			set
			{
				this.plan_items = value;
			}
		}
		/* (non-Javadoc)
		 * @see java.lang.Object#toString()
		 */





	}

}