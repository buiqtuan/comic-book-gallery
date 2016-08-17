﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicBookGallery.Models;
using ComicBookGallery.Data;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cbr = _comicBookRepository.GetComicBook((int)id);

            return View(cbr);
        }
    }
}
