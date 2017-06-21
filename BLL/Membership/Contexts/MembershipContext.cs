using Microsoft.EntityFrameworkCore;

namespace Web.TORCHx.Core.BLL.Membership
{
	public class MembershipContext : DbContext
	{
		public virtual DbSet<Application> Applications { get; set; }
		public virtual DbSet<Membership> Memberships { get; set; }
		public virtual DbSet<Profile> Profiles { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<UserRole> UserRoles { get; set; }
		public virtual DbSet<Path> Paths { get; set; }
		public virtual DbSet<PersonalizationAllUsers> PersonalizationAllUsers { get; set; }
		public virtual DbSet<PersonalizationPerUser> PersonalizationPerUser { get; set; }
		public virtual DbSet<SchemaVersion> SchemaVersions { get; set; }
		public virtual DbSet<Event> Events { get; set; }

		public MembershipContext(DbContextOptions<MembershipContext> options) : base(options)
        {
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Application>(entity => {
				entity.HasKey(e => e.ApplicationId)
					.HasName("PK__aspnet_Applicati__03317E3D");

				entity.HasIndex(e => e.ApplicationName)
					.HasName("UQ__aspnet_Applicati__0519C6AF")
					.IsUnique();

				entity.HasIndex(e => e.LoweredApplicationName)
					.HasName("UQ__aspnet_Applicati__0425A276")
					.IsUnique();

				entity.Property(e => e.ApplicationId).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<Membership>(entity => {
				entity.HasKey(e => e.UserId)
					.HasName("PK__aspnet_Membershi__182C9B23");

				entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
					.HasName("aspnet_Membership_index");

				entity.HasIndex(e => new { e.CreateDate, e.UserId })
					.HasName("UserId_CreatedDate");

				entity.Property(e => e.UserId).ValueGeneratedNever();

				entity.Property(e => e.PasswordFormat).HasDefaultValueSql("0");
			});

			modelBuilder.Entity<Path>(entity => {
				entity.HasKey(e => e.PathId)
					.HasName("PK__aspnet_Paths__49C3F6B7");

				entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
					.HasName("aspnet_Paths_index")
					.IsUnique();

				entity.Property(e => e.PathId).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<PersonalizationAllUsers>(entity => {
				entity.HasKey(e => e.PathId)
					.HasName("PK__aspnet_Personali__4F7CD00D");

				entity.Property(e => e.PathId).ValueGeneratedNever();
			});

			modelBuilder.Entity<PersonalizationPerUser>(entity => {
				entity.HasIndex(e => new { e.UserId, e.PathId })
					.HasName("aspnet_PersonalizationPerUser_ncindex2")
					.IsUnique();

				entity.Property(e => e.Id).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<Profile>(entity => {
				entity.HasKey(e => e.UserId)
					.HasName("PK__aspnet_Profile__2D27B809");

				entity.Property(e => e.UserId).ValueGeneratedNever();
			});

			modelBuilder.Entity<Role>(entity => {
				entity.HasKey(e => e.RoleId)
					.HasName("PK__aspnet_Roles__36B12243");

				entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
					.HasName("aspnet_Roles_index1")
					.IsUnique();

				entity.Property(e => e.RoleId).HasDefaultValueSql("newid()");
			});

			modelBuilder.Entity<SchemaVersion>(entity => {
				entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
					.HasName("PK__aspnet_SchemaVer__0DAF0CB0");
			});

			modelBuilder.Entity<User>(entity => {
				entity.HasKey(e => e.UserId)
					.HasName("PK__aspnet_Users__07F6335A");

				entity.HasIndex(e => e.UserName)
					.HasName("missing_index_26994_26993");

				entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
					.HasName("aspnet_Users_Index2");

				entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
					.HasName("aspnet_Users_Index")
					.IsUnique();

				entity.Property(e => e.UserId).HasDefaultValueSql("newid()");

				entity.Property(e => e.IsAnonymous).HasDefaultValueSql("0");
			});

			modelBuilder.Entity<UserRole>(entity => {
				entity.HasKey(e => new { e.UserId, e.RoleId })
					.HasName("PK__aspnet_UsersInRo__3A81B327");

				entity.HasIndex(e => e.RoleId)
					.HasName("aspnet_UsersInRoles_index");
			});

			modelBuilder.Entity<Event>(entity => {
				entity.HasKey(e => e.EventId)
					.HasName("PK__aspnet_WebEvent___6477ECF3");
			});
		}
	}
}
