namespace com.stcs.spa.vo
{

	/// <summary>
	/// Created by mroshan on 6/1/2016.
	/// </summary>
	public class SubscriptionQuantifiableItemPrice
	{

		private QuantifiableItemPrice quantifiable_item_price;
		private long? quantity;

		public virtual QuantifiableItemPrice Quantifiable_item_price
		{
			get
			{
				return quantifiable_item_price;
			}
			set
			{
				this.quantifiable_item_price = value;
			}
		}


		public virtual long? Quantity
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

	}

}