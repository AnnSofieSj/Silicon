﻿namespace Silicon_AspNetMVC.Models.Sections
{
    public class CoursesModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Price { get; set; }
        public string? DiscountPrice { get; set; }
        public string? CourseImage { get; set; }
        public string? Rating { get; set; }
        public string? Reviews { get; set; }
        public string? Views { get; set; }
        public string? Likes { get; set; }
        public string? ViewHours { get; set; }
        public string? AuthorName { get; set; }
    }
}
