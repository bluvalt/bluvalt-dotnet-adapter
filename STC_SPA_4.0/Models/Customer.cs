using System;

namespace com.stcs.spa.vo
{

    [Serializable]
    public class Customer : EventData
    {

        private const long serialVersionUID = 1L;


        private long? id;
        private string name;

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


    }

}