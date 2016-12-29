namespace DNT.Extensions
{
    public static class MoneyExtension
    {
        public static decimal ToRial(this decimal money)
        {
            return money * 10;
        }
    }
}
