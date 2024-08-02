using RetailWay.Types.Elements;
using RetailWay.Types.Enums;

namespace RetailWay.Types
{
    public struct Position
    {
        public string Name;
        public decimal Quantity;
        public MeasureUnit MeasureUnit;
        public CalculationMethod Calculation;
        public TaxType Tax;
        public SubjectType Type;
        public int Price;
        public int Total;
        public Codes Codes;

        /// <summary>
        /// Уменьшение количества позиции
        /// </summary>
        public static Position operator - (Position pos, decimal quantity)
        {
            pos.Quantity -= quantity;
            return pos;
        }

        /// <summary>
        /// Увеличение количества позиции
        /// </summary>
        public static Position operator +(Position pos, decimal quantity)
        {
            pos.Quantity += quantity;
            return pos;
        }

        public static bool operator ==(Position l, Position r) =>
            l.Name == r.Name && l.Total == r.Total && l.Quantity == r.Quantity;

        public static bool operator !=(Position l, Position r) => !(l==r);
    }
}
