using System;

namespace com.stcs.spa.vo
{

	[Serializable]
	public class Customer
	{

		private const long serialVersionUID = 1L;


		private long? id;
		private string name, phone;

		private long? bluvaltCustomerId;

		public virtual long? Id
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
		public virtual string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				this.phone = value;
			}
		}
		public override string ToString()
		{
			return "Customer [id=" + id + ", name=" + name + ", phone=" + phone + "]";
		}


		/// <returns> the bluvaltCustomerId </returns>
		public virtual long? SdpCustomerId
		{
			get
			{
				return bluvaltCustomerId;
			}
			set
			{
				this.bluvaltCustomerId = value;
			}
		}




	}

}