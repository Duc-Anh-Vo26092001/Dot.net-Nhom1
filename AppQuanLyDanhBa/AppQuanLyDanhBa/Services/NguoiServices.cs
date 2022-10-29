using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyDanhBa.Services
{
    public class NguoiServices

    {
        public static List<NguoiViewModel> GetList()
        {
            var db = new AppQLDanhBa();
            var rs = db.Nguoi.Select(e => new NguoiViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                PhoneNumber=e.PhoneNumber,
                DiaChi = e.DiaChi,
                IDNhom= (int)e.IDNhom,
                
            }).ToList();

            return rs;

        }
        public static List<NguoiViewModel> GetList(int idNhom)
        {
            var db = new AppQLDanhBa();
            
            var rs = db.Nguoi.Where(e => e.IDNhom==idNhom).Select(e => new NguoiViewModel
            {
                ID = e.ID,
                TenGoi = e.TenGoi,
                Email = e.Email,
                PhoneNumber = e.PhoneNumber,
                IDNhom = (int)e.IDNhom,

            }).ToList();

            return rs;

        }
        public static KetQua AddLienLac(Nguoi ng)
        {
            var db = new AppQLDanhBa();

            var countNumberPhone = db.Nguoi.Where(e => e.PhoneNumber == ng.PhoneNumber || e.TenGoi == ng.TenGoi).Count();
            if (countNumberPhone == 0)
            {
                db.Nguoi.Add(ng);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
            else
            {
                return KetQua.Loi;
            }


        }
        public static KetQua RemoveLienLac(NguoiViewModel ng)
        {
             var db = new AppQLDanhBa();
            var nguoi = db.Nguoi.Where(e => e.ID == ng.ID).FirstOrDefault();
            db.Nguoi.Remove(nguoi);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }

}
