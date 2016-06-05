using System;
using System.Collections.Generic;

namespace com.stcs.spa.vo
{


    public class Plan : Base
    {

        private int id;
        private string name, description;
        private DateTime created, modified;
        private string initial_price;
        private Feature[] features;
        private Price[] prices;
        private PlanItem[] plan_item;
        private IDictionary<string, string> metadata;
        private Type type;
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
        /// <returns> the description </returns>
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



        /// <returns> the created </returns>
        public virtual DateTime Created
        {
            get
            {
                return created;
            }
            set
            {
                this.created = value;
            }
        }
        /// <returns> the modified </returns>
        public virtual DateTime Modified
        {
            get
            {
                return modified;
            }
            set
            {
                this.modified = value;
            }
        }
        /// <returns> the initial_price </returns>
        public virtual string Initial_price
        {
            get
            {
                return initial_price;
            }
            set
            {
                this.initial_price = value;
            }
        }
        /// <returns> the features </returns>

        public virtual Feature[] Features
        {
            get
            {
                return features;
            }
            set
            {
                this.features = value;
            }
        }
        /// <returns> the prices </returns>

        public virtual Price[] Prices
        {
            get
            {
                return prices;
            }
            set
            {
                this.prices = value;
            }
        }
        /// <returns> the plan_item </returns>
        public virtual PlanItem[] Plan_item
        {
            get
            {
                return plan_item;
            }
            set
            {
                this.plan_item = value;
            }
        }
        /* (non-Javadoc)
		 * @see java.lang.Object#toString()
		 */

        public virtual IDictionary<string, string> Metadata
        {
            get
            {
                return metadata;
            }
            set
            {
                this.metadata = value;
            }
        }


        public virtual Type getType()
        {
            return type;
        }

        public virtual void setType(Type type)
        {
            this.type = type;
        }

        public enum Type
        {
            @base,
            addon
        }
    }

}