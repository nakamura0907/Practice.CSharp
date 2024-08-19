namespace Practice.CSharp.Shared.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 統一したフォーマットで返す拡張メソッド
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToFormat(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
