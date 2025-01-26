
namespace DominoAvancadoComEf.Entities
{
    public class Order
    {
        public Guid Id { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; private set; }
        public OrderStatus Status { get; set; }
        public CreationMethod OrderCreationMethod { get; init; } // Renamed to avoid conflict

        // Ef Construtor
        private Order() { }

        public Order(CreationMethod creationMethod)
        {
            if (creationMethod == CreationMethod.Manual)
            {
                if (StartDate > Utils.Utils.BrasiliaTimeNow())
                {
                    throw new Exception("A data de início não pode ser maior que a data atual");
                }
            }

            Id = Guid.NewGuid();
            StartDate = Utils.Utils.BrasiliaTimeNow();
            Status = OrderStatus.Active;
            OrderCreationMethod = creationMethod;
        }


        public enum OrderStatus
        {
            Active,
            Finished,
            Canceled
        }

        public enum CreationMethod
        {
            Planned,
            Manual
        }

    }
}
