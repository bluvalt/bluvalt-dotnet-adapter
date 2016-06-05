namespace com.stcs.spa.vo
{

    public class Feature : Base
    {

        private int id;
        private Item item;

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


    }

}