namespace com.stcs.spa.vo
{


    public class PlanItem : Base
    {

        private int id;
        private Item item;
        private Unit unit;
        private string quantity;
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
        public virtual string Quantity
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

        public virtual Item Item
        {
            get
            {
                return item;
            }
            set
            {
                this.item = value;
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