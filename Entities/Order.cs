namespace DominoAvancadoComEf.Entities
{
    public class Order
    {
        public Guid Id { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime? EndDate { get; private set; }
        public OrderStatus Status { get; private set; }
        public CreationMethod OrderCreationMethod { get; init; }

        // Ef Construtor
        private Order() { }

        public void Finish()
        {
            if (Status == OrderStatus.Finished)
            {
                throw new Exception("A ordem já foi finalizada");
            }
            EndDate = Utils.Utils.BrasiliaTimeNow();
            Status = OrderStatus.Finished;
        }

        public void Cancel()
        {
            if (OrderCreationMethod == CreationMethod.Planned)
            {
                throw new Exception("Ordem Planejada nao pode ser cancelada");
            }

            if (Status == OrderStatus.Canceled)
            {
                throw new Exception("A ordem já foi cancelada");
            }

            Status = OrderStatus.Canceled;
        }

        public static class CreateOrder
        {
            public static Order CreateManual(DateTime startDate)
            {

                if (startDate > Utils.Utils.BrasiliaTimeNow())
                {
                    throw new Exception("A data de início não pode ser no futuro");
                }

                return new Order()
                {
                    Id = Guid.NewGuid(),
                    StartDate = startDate,
                    Status = OrderStatus.Active,
                    OrderCreationMethod = CreationMethod.Manual
                };
            }

            public static Order CreatePlanned(DateTime startDate)
            {
                if (startDate < Utils.Utils.BrasiliaTimeNow())
                {
                    throw new Exception("A data de início não pode ser no passado");
                }

                return new Order()
                {
                    Id = Guid.NewGuid(),
                    StartDate = startDate,
                    Status = OrderStatus.Active,
                    OrderCreationMethod = CreationMethod.Planned
                };
            }
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

