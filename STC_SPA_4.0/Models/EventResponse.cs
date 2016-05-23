namespace com.stcs.spa.vo
{

	public class EventResponse
	{


		private string eventID, status, ref_number, message;
		private EventType type;
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


		public virtual string Ref_number
		{
			get
			{
				return ref_number;
			}
			set
			{
				this.ref_number = value;
			}
		}


		public virtual string Message
		{
			get
			{
				return message;
			}
			set
			{
				this.message = value;
			}
		}


		public override string ToString()
		{
			return "{ \"status\":\"" + status + "\", \"ref_number\":\"" + ref_number + "\", \"message\":\"" + message + "\"}";
		}

		/// <returns> the eventID </returns>
		public virtual string EventID
		{
			get
			{
				return eventID;
			}
			set
			{
				this.eventID = value;
			}
		}


		/// <returns> the type </returns>
		public virtual EventType Type
		{
			get
			{
				return type;
			}
			set
			{
				this.type = value;
			}
		}





	}

}