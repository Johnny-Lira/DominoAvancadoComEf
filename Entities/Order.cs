namespace DominoAvancadoComEf.Entities
{
    public abstract class Order
    {
        public Guid Id { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; protected set; }
        public OrderStatus Status { get; protected set; }
        public CreationMethod OrderCreationMethod { get; init; }

        // Ef Construtor
        protected Order() { }

        public void Finish()
        {
            if (Status == OrderStatus.Finished)
            {
                throw new Exception("A ordem já foi finalizada");
            }
            EndDate = Utils.Utils.BrasiliaTimeNow();
            Status = OrderStatus.Finished;
        }
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

