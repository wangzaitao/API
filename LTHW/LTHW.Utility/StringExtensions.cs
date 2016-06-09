namespace LFTHW.Utility
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 返回web引用路径格式
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ToWebPath(this string path)
        {
            return path.Replace("\\", "/");
        }
    }
}
