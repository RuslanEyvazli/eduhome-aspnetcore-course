using BackendProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpiker> EventSpikers { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Reply> Replies { get; set; }

    }
}
