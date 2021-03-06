using System.Security.Cryptography;
using IoTManager.DAL.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;


namespace IoTManager.DAL.DbContext
{
    public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //Three complex models
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Gateway> Gateway { get; set; }
        
        
        //Eleven easy models
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DeviceState> DeviceState { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<Factory> Factory { get; set; }
        public virtual DbSet<GatewayState> GatewayState { get; set; }
        public virtual DbSet<GatewayType> GatewayType { get; set; }
        public virtual DbSet<PageElement> PageElement { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Workshop> Workshop { get; set; }

            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /**********************
            Device Model Builder
            ***********************/
            
            //Bind Device Model to Table
            modelBuilder.Entity<Device>()
                .ToTable("device");
            
            //Primary Key
            modelBuilder.Entity<Device>()
                .HasKey(d => d.Id);
            
            //City
            modelBuilder.Entity<Device>()
                .Property<int>("CityId");
            modelBuilder.Entity<Device>()
                .HasOne(d => d.City)
                .WithMany()
                .HasForeignKey(d => d.CityId);
            
            //Factory
            modelBuilder.Entity<Device>()
                .Property<int>("FactoryId");
            modelBuilder.Entity<Device>()
                .HasOne(d => d.Factory)
                .WithMany()
                .HasForeignKey(d => d.FactoryId);

            //Workshop
            modelBuilder.Entity<Device>()
                .Property<int>("WorkshopId");
            modelBuilder.Entity<Device>()
                .HasOne(d => d.Workshop)
                .WithMany()
                .HasForeignKey(d => d.WorkshopId);

            //DeviceState
            modelBuilder.Entity<Device>()
                .Property<int>("DeviceStateId");
            modelBuilder.Entity<Device>()
                .HasOne(d => d.DeviceState)
                .WithMany()
                .HasForeignKey(d => d.DeviceStateId);

            //DeviceType
            modelBuilder.Entity<Device>()
                .Property<int>("DeviceTypeId");
            modelBuilder.Entity<Device>()
                .HasOne(d => d.DeviceType)
                .WithMany()
                .HasForeignKey(d => d.DeviceTypeId);

            //Department
            modelBuilder.Entity<Device>()
                .Property<int>("DepartmentId");
            modelBuilder.Entity<Device>()
                .HasOne(d => d.Department)
                .WithMany()
                .HasForeignKey(d => d.DepartmentId);
            
            
            /**********************
            Gateway Model Builder
            ***********************/
            
            //Bind Gateway Model to Table
            modelBuilder.Entity<Gateway>()
                .ToTable("gateway");
            
            //Primary Key
            modelBuilder.Entity<Gateway>()
                .HasKey(g => g.Id);
            
            //GatewayType
            modelBuilder.Entity<Gateway>()
                .Property<int>("GatewayTypeId");
            modelBuilder.Entity<Gateway>()
                .HasOne(g => g.GatewayType)
                .WithMany()
                .HasForeignKey(g => g.GatewayTypeId);

            //City
            modelBuilder.Entity<Gateway>()
                .Property<int>("CityId");
            modelBuilder.Entity<Gateway>()
                .HasOne(g => g.City)
                .WithMany()
                .HasForeignKey(g => g.CityId);
            
            //Factory
            modelBuilder.Entity<Gateway>()
                .Property<int>("FactoryId");
            modelBuilder.Entity<Gateway>()
                .HasOne(g => g.Factory)
                .WithMany()
                .HasForeignKey(g => g.FactoryId);
            
            //Workshop
            modelBuilder.Entity<Gateway>()
                .Property<int>("WorkshopId");
            modelBuilder.Entity<Gateway>()
                .HasOne(g => g.Workshop)
                .WithMany()
                .HasForeignKey(g => g.WorkshopId);
            
            //GatewayState
            modelBuilder.Entity<Gateway>()
                .Property<int>("GatewayStateId");
            modelBuilder.Entity<Gateway>()
                .HasOne(g => g.GatewayState)
                .WithMany()
                .HasForeignKey(g => g.GatewayStateId);
            
            //Department
            modelBuilder.Entity<Gateway>()
                .Property<int>("DepartmentId");
            modelBuilder.Entity<Gateway>()
                .HasOne(g => g.Department)
                .WithMany()
                .HasForeignKey(g => g.DepartmentId);
            
            
            /**********************
            User Model Builder
            ***********************/
            
            //Bind User Model to Table
            modelBuilder.Entity<User>()
                .ToTable("user");
            
            //Primary Key
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            
            //Department
            modelBuilder.Entity<User>()
                .Property<int>("DepartmentId");
            modelBuilder.Entity<User>()
                .HasOne(u => u.Department)
                .WithMany()
                .HasForeignKey(u => u.DepartmentId);
            
            
            /**********************
            City Model Builder
            ***********************/
            
            //Bind City Model to Table
            modelBuilder.Entity<City>()
                .ToTable("city");
            
            //Primary Key
            modelBuilder.Entity<City>()
                .HasKey(c => c.Id);
            
            
            /**********************
            Factory Model Builder
            ***********************/
            //Bind Factory Model to Table
            modelBuilder.Entity<Factory>()
                .ToTable("factory");
            
            //Primary Key
            modelBuilder.Entity<Factory>()
                .HasKey(f => f.Id);
            
            
            /**********************
            Workshop Model Builder
            ***********************/
            //Bind Workshop Model to Table
            modelBuilder.Entity<Workshop>()
                .ToTable("workshop");
            
            //Primary Key
            modelBuilder.Entity<Workshop>()
                .HasKey(w => w.Id);
            
            
            /**********************
            DeviceState Model Builder
            ***********************/
            //Bind DeviceState Model to Table
            modelBuilder.Entity<DeviceState>()
                .ToTable("deviceState");
            
            //Primary Key
            modelBuilder.Entity<DeviceState>()
                .HasKey(ds => ds.Id);
            
            
            /**********************
            DeviceType Model Builder
            ***********************/
            //Bind DeviceType Model to Table
            modelBuilder.Entity<DeviceType>()
                .ToTable("deviceType");
            
            //Primary Key
            modelBuilder.Entity<DeviceType>()
                .HasKey(dt => dt.Id);
            
            
            /**********************
            GatewayState Model Builder
            ***********************/
            //Bind GatewayState to Table
            modelBuilder.Entity<GatewayState>()
                .ToTable("gatewayState");

            //Primary Key
            modelBuilder.Entity<GatewayState>()
                .HasKey(gs => gs.Id);
            
            
            /**********************
            GatewayState Model Builder
            ***********************/
            //Bind GatewayType to Table
            modelBuilder.Entity<GatewayType>()
                .ToTable("gatewayType");
            
            //Primary Key
            modelBuilder.Entity<GatewayType>()
                .HasKey(gt => gt.Id);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(@"Server=127.0.0.1;port=3306;Database=iotmanager;
                            User ID=jackjack59;password=jackjack123;SslMode=None");
            }
        }
    }
}