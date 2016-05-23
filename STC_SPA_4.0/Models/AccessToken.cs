namespace com.stcs.spa.vo
{

	public class AccessToken
	{

		private string access_token, token_type, scope, expires_in;

		/// <returns> the access_token </returns>
		public virtual string Access_token
		{
			get
			{
				return access_token;
			}
			set
			{
				this.access_token = value;
			}
		}


		/// <returns> the token_type </returns>
		public virtual string Token_type
		{
			get
			{
				return token_type;
			}
			set
			{
				this.token_type = value;
			}
		}


		/// <returns> the scope </returns>
		public virtual string Scope
		{
			get
			{
				return scope;
			}
			set
			{
				this.scope = value;
			}
		}


		/// <returns> the expires_in </returns>
		public virtual string Expires_in
		{
			get
			{
				return expires_in;
			}
			set
			{
				this.expires_in = value;
			}
		}


	}

}