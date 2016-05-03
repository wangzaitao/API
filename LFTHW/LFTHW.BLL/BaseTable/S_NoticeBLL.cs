using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_NoticeBLL : BaseBLL<S_Notice>, IS_NoticeBLL
    {
        private readonly IS_NoticeDAL _IS_NoticeDAL;
        public S_NoticeBLL()
            : base()
        {
            _IS_NoticeDAL = new S_NoticeDAL();
        }

        public bool Delete(int id) {
            return _IS_NoticeDAL.Delete(id);
        }

        public S_Notice GetById(int id)
        {
            return _IS_NoticeDAL.GetById(id);
        }
        public bool Update(S_Notice sNotice)
        {
            return _IS_NoticeDAL.Update(sNotice);
        }
    }
}

