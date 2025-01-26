namespace DominoAvancadoComEf.Entities
{
    public class OrderPlanned : Order
    {
        public static class CreateOrder
        {
            public static Order Create(DateTime startDate)
            {
                if (startDate < Utils.Utils.BrasiliaTimeNow())
                {
                    throw new Exception("A data de início não pode ser no passado");
                }

                return new OrderPlanned()
                {
                    Id = Guid.NewGuid(),
                    StartDate = startDate,
                    Status = OrderStatus.Active,
                    OrderCreationMethod = CreationMethod.Planned
                };
            }
        }
    }
}
