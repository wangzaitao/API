namespace LFTHW.Model
{
    public class PageQueryParam
    {
        private int _page;
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
        public int size
        {
            get
            {
                if (_size < 1) return 20;
                else return _size;
            }
            set { _size = value; }
        }
        public int total { get; set; }
        public bool isDesc { get; set; }
    }
}
