using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[] {
            new ComicBook()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[] {
                    new Artist() {Name = "Mario", Role = "Singer" },
                    new Artist() {Name = "Princess Peach", Role = "Guitarist" },
                    new Artist() {Name = "Bowser", Role = "Drum Player" },
                    new Artist() {Name = "Toad", Role = "Singer" },
                    new Artist() {Name = "Yoshi", Role = "Composer" },
                },
                Favorite = true
            },
            new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHTML = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = true
            },
            new ComicBook()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHTML = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            }
        };
        
        public ComicBook GetComicBook(int id) {
            ComicBook comicBook = null;
            foreach (var _comicBook in _comicBooks) {
                if (_comicBook.Id == id) {
                    comicBook = _comicBook;
                    break;
                }
            }

            return comicBook;
        }
    }
}
