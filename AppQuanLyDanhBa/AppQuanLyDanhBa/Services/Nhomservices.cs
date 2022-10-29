using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyDanhBa.Services
{
    public class Nhomservices
    {
        public static List<NhomViewModel> GetList()
        {
            var db = new AppQLDanhBa();
;
            var rs = db.Nhom.Select(e => new NhomViewModel
            {
                ID = (int)e.ID,
                TenNhom = e.TenNhom,
            }).ToList();
            return rs;

        }

        public static KetQua AddNhom(Nhom nh)
        {
            var db = new AppQLDanhBa();
            int count = db.Nhom.Where(e => e.TenNhom == nh.TenNhom).Count();
            if (count > 0)
            {
                return KetQua.Loi;
            }

            else
            {
                db.Nhom.Add(nh);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua RemoveNhom(NhomViewModel n)
        {
            var db = new AppQLDanhBa();
            var nguoi = db.Nguoi.Where(e => e.ID == n.ID).Count();
            var nhom = db.Nhom.Where(e => e.ID == n.ID).FirstOrDefault();
            if (nguoi > 0)
            {
                return KetQua.Loi;

            }
            db.Nhom.Remove(nhom);
            db.SaveChanges();
            return KetQua.ThanhCong;


        }
    }
}
