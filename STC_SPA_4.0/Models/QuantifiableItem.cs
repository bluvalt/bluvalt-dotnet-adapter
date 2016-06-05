namespace com.stcs.spa.vo
{

	/// <summary>
	/// Created by mroshan on 6/1/2016.
	/// </summary>
	public class QuantifiableItem
	{
		private string name, description;
		private Unit unit;

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