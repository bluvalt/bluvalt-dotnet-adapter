using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace com.stcs.spa.vo
{

    public class Event
    {

        private string id, api_version;
        [JsonConverter(typeof(StringEnumConverter))]
        private EventType type;
        private EventService service;
        private EventData data;


        /// <returns> the id </returns>
        public virtual string Id
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

        /// <returns> the api_version </returns>
        public virtual string Api_version
        {
            get
            {
                return api_version;
            }
            set
            {
                this.api_version = value;
            }
        }
        /// <returns> the serviceId </returns>
        public virtual EventService Service
        {
            get
            {
                return service;
            }
            set
            {
                this.service = value;
            }
        }


        /// <returns> the data </returns>
        public virtual EventData Data
        {
            get
            {
                return data;
            }
            set
            {
                this.data = value;
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