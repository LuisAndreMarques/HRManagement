using Epifania.Models;
using Microsoft.EntityFrameworkCore;

namespace Epifania.Core.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventManagement> EventsManagement { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ObjectiveManagement> ObjectivesManagement { get; set; }
        public DbSet<PersonalUserEvaluation> PersonalUsersEvaluation { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTeam> ProjectTeams { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamUserEvaluation> TeamUserEvaluations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
    }
}