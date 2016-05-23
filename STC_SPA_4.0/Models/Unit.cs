namespace com.stcs.spa.vo
{

	public class Unit : BaseVO
	{

		private int id;
		private string name, short_name, symbol;
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
		/// <returns> the short_name </returns>
		public virtual string Short_name
		{
			get
			{
				return short_name;
			}
			set
			{
				this.short_name = value;
			}
		}
		/// <returns> the symbol </returns>
		public virtual string Symbol
		{
			get
			{
				return symbol;
			}
			set
			{
				this.symbol = value;
			}
		}
	}

}