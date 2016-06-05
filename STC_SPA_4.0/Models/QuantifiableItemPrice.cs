namespace com.stcs.spa.vo
{

	/// <summary>
	/// Created by mroshan on 6/1/2016.
	/// </summary>
	public class QuantifiableItemPrice
	{

	   private QuantifiableItem quantifiable_item;
		private string currency;
		private long? price, min, max;

		public virtual QuantifiableItem Quantifiable_item
		{
			get
			{
				return quantifiable_item;
			}
			set
			{
				this.quantifiable_item = value;
			}
		}


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


		public virtual long? Price
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


		public virtual long? Min
		{
			get
			{
				return min;
			}
			set
			{
				this.min = value;
			}
		}


		public virtual long? Max
		{
			get
			{
				return max;
			}
			set
			{
				this.max = value;
			}
		}

	}

}