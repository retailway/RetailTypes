using RetailWay.Types.Elements;
using RetailWay.Types.Enums;
using System;

namespace RetailWay.Types
{
    public struct Receipt
    {
        public int Id;
        public string StorageId;
        public string Cashier;
        public string FiscalSign;
        public bool DoRoundTotal;
        public DateTime Date;
        public OperationType Operation;
        public Position[] Positions;
        public Payment Payment;

        public Receipt Clone()
        {
            return new Receipt()
            {
                Id = Id,
                StorageId = StorageId,
                Cashier = Cashier,
                FiscalSign = FiscalSign,
                DoRoundTotal = DoRoundTotal,
                Date = Date,
                Operation = Operation,
                Positions = (Position[])Positions.Clone(),
                Payment = new Payment(Payment.CashSum, Payment.EcashSum)
            };
        }
    }
}
