namespace com.stcs.spa.vo
{


	public class PlanItem : BaseVO
	{

		private int id, quantity;
		private Item Item_Renamed;
		private Unit unit;
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

	}



}