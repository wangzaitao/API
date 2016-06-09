namespace LTHW.Model
{
    public class PageQueryParam
    {
        private int _page;

        /// <summary>
        /// 页码
        /// </summary>
        public int page
        {
            get
            {
                if (_page < 1) return 1;
                else return _page;
            }
            set { _page = value; }
        }
        private int _size;
        /// <summary>
        /// 页大小
        /// </summary>
        public int size
        {
            get
            {
                if (_size < 1) return 20;
                else return _size;
            }
            set { _size = value; }
        }
        /// <summary>
        /// 总记录数
        /// </summary>
        public int total { get; set; }
        /// <summary>
        /// 是否倒序
        /// </summary>
        public bool isDesc { get; set; }
    }
}
