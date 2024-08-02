namespace RetailWay.Types.Enums
{
    /// <summary>
    /// 1 - Приход (Продажа)<br/>
    /// 2 - Возврат<br/>
    /// 4 - Чек-корреции<br/>
    /// </summary>
    public enum OperationType
    {
        Outcome,
        Income,
        ReturnOutcome,
        ReturnIncome,
        CorrOutcome,
        CorrIncome,
        CorrReturnOutcome,
        CorrReturnIncome,

        Return = 2,
        Corr = 4
    }

    public static partial class Utils
    {
        public static OperationType ToOperation(this (bool corr, bool ret, bool income) src) =>
            (OperationType)((src.corr ? 4 : 0) | (src.ret ? 2 : 0) | (src.income ? 1 : 0));
    }
}