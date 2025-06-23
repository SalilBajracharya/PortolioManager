using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioManager.Api.Entities;

namespace PortfolioManager.Api.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<ProjectTab> ProjectTabs { get; set; }
        public DbSet<UserProjects> UserProjects { get; set; }
        public DbSet<UserTechStacks> UserTechStacks { get; set; }
        public DbSet<ExperienceTab> ExperienceTabs { get; set; }
        public DbSet<UserExperience> UserExperiences { get; set; }
        public DbSet<EducationTab> EducationTabs { get; set; }
        public DbSet<UserEducation> UserEducations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //<UserDetails> model builder
            builder.Entity<UserDetails>()
                .HasKey(ud => ud.Recid);

            builder.Entity<UserDetails>()
                .HasOne(ud => ud.User)
                .WithOne()
                .HasForeignKey<UserDetails>(ud => ud.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            //<Project Tab> model builder
            builder.Entity<ProjectTab>()
                .HasKey(ud => ud.Recid);

            builder.Entity<ProjectTab>()
                .HasOne(ud => ud.User)
                .WithOne()
                .HasForeignKey<ProjectTab>(ud => ud.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            //<UserProjects> model builder
            builder.Entity<UserProjects>()
                .HasKey(up => up.Recid);

            builder.Entity<UserProjects>()
                .HasOne(up => up.ProjectTab)
                .WithMany()
                .HasForeignKey(up => up.ProjectTabId)
                .OnDelete(DeleteBehavior.Cascade);

            //<UserTechStacks> model builder
            builder.Entity<UserTechStacks>()
                .HasKey(uts => uts.Recid);

            builder.Entity<UserTechStacks>()
                .HasOne(uts => uts.User)
                .WithOne()
                .HasForeignKey<UserTechStacks>(uts => uts.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            //<ExperienceTab> model builder
            builder.Entity<ExperienceTab>()
                .HasKey(et => et.Recid);

            builder.Entity<ExperienceTab>()
                .HasOne(et => et.User)
                .WithOne()
                .HasForeignKey<ExperienceTab>(et => et.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            //<UserExperience> model builder
            builder.Entity<UserExperience>()
                .HasKey(ue => ue.Recid);

            builder.Entity<UserExperience>()
                .HasOne(ue => ue.ExperienceTab)
                .WithMany()
                .HasForeignKey(ue => ue.ExperienceTabId)
                .OnDelete(DeleteBehavior.Cascade);

            //<EducationTab> model builder
            builder.Entity<EducationTab>()
                .HasKey(ue => ue.Recid);

            builder.Entity<EducationTab>()
                .HasOne(ue => ue.User)
                .WithMany()
                .HasForeignKey(ue => ue.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            //<UserEducation> model builder
            builder.Entity<UserEducation>()
                .HasKey(ue => ue.Recid);

            builder.Entity<UserEducation>()
                .HasOne(ue => ue.EducationTab)
                .WithMany()
                .HasForeignKey(ue => ue.EducationTabId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
