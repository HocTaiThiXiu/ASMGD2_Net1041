using ASMGD2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASMGD2.Controllers
{
    public class SanPhamController : Controller
    {
        ASMGD2DbContext _db;
        public SanPhamController(ASMGD2DbContext db)
        {
            _db = db;
        }
        // GET: SanPhamController
        public ActionResult Index()
        {
            var listSp = _db.SanPhams.ToList();
            return View(listSp);
        }

        // GET: SanPhamController/Details/5
        public ActionResult Details(Guid id)
        {
            var detailSp = _db.SanPhams.Find(id);
            return View(detailSp);
        }

        // GET: SanPhamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPhamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sp, IFormFile imgFile )
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "IMG", imgFile.FileName);
            var stream = new FileStream(path,FileMode.Create);
            imgFile.CopyTo(stream);
            sp.ImgUrl = imgFile.FileName;
            _db.SanPhams.Add(sp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: SanPhamController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var EditItem = _db.SanPhams.Find(id);
            return View(EditItem);
        }

        // POST: SanPhamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id,SanPham sp , IFormFile imgFile)
        {
            var editSp = _db.SanPhams.Find(id);
            if (editSp == null)
            {
                return NotFound();
            }
            if (imgFile != null)
            {
                string fileName = Path.GetFileName(imgFile.FileName);
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "IMG", imgFile.Name);
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    imgFile.CopyTo(stream);
                }
                editSp.TenSP = fileName;
            }
            _db.SanPhams.Update(editSp);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: SanPhamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPhamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
