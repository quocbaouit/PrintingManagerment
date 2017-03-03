using PrintingManager.Data.Configuration;
using PrintingManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingManager.Data
{
    public class PrintingEntities : DbContext
    {
        public PrintingEntities() : base("StoreEntities") { }

        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<T__Remind> T__Remind { get; set; }
        public DbSet<T_CommodityDictionary> T_CommodityDictionary { get; set; }
        public DbSet<T_Customer> T_Customer { get; set; }
        public DbSet<T_ErrorLog> T_ErrorLog { get; set; }
        public DbSet<T_Feature> T_Feature { get; set; }
        public DbSet<T_Machine> T_Machine { get; set; }
        public DbSet<T_Material> T_Material { get; set; }
        public DbSet<T_MaterialType> T_MaterialType { get; set; }
        public DbSet<T_Menu> T_Menu { get; set; }
        public DbSet<T_MenuCategory> T_MenuCategory { get; set; }
        public DbSet<T_Notification> T_Notification { get; set; }
        public DbSet<T_Order> T_Order { get; set; }
        public DbSet<T_Organization> T_Organization { get; set; }
        public DbSet<T_Partner> T_Partner { get; set; }
        public DbSet<T_PaymentVoucher> T_PaymentVoucher { get; set; }
        public DbSet<T_Permission> T_Permission { get; set; }
        public DbSet<T_Position> T_Position { get; set; }
        public DbSet<T_Product> T_Product { get; set; }
        public DbSet<T_ProductType> T_ProductType { get; set; }
        public DbSet<T_Quittance> T_Quittance { get; set; }
        public DbSet<T_ReceiptVoucher> T_ReceiptVoucher { get; set; }
        public DbSet<T_RoLe> T_RoLe { get; set; }
        public DbSet<T_RolePermission> T_RolePermission { get; set; }
        public DbSet<T_Staff> T_Staff { get; set; }
        public DbSet<T_StockIn> T_StockIn { get; set; }
        public DbSet<T_StockInDetail> T_StockInDetail { get; set; }
        public DbSet<T_User> T_User { get; set; }
        public DbSet<T_UserRole> T_UserRole { get; set; }
        public DbSet<T_Timing> T_Timing { get; set; }
        public DbSet<T_OrderDetail> T_OrderDetail { get; set; }
        public DbSet<T_UserProduct> T_UserProduct { get; set; }
        public DbSet<T_StandardSale> T_StandardSale { get; set; }
        public DbSet<T_ElementFormular> T_ElementFormular { get; set; }
        public DbSet<T_Formular> T_Formular { get; set; }
        public DbSet<T_FormularDetail> T_FormularDetail { get; set; }
        public DbSet<T_UserFormular> T_UserFormular { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GadgetConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());

            modelBuilder.Configurations.Add(new RemindConfiguration());
            modelBuilder.Configurations.Add(new CommodityDictionaryConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ErrorLogConfiguration());
            modelBuilder.Configurations.Add(new FeatureConfiguration());
            modelBuilder.Configurations.Add(new MachineConfiguration());

            modelBuilder.Configurations.Add(new MaterialConfiguration());
            modelBuilder.Configurations.Add(new MaterialTypeConfiguration());
            modelBuilder.Configurations.Add(new MenuConfiguration());
            modelBuilder.Configurations.Add(new MenuCategoryConfiguration());
            modelBuilder.Configurations.Add(new NotificationConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());

            modelBuilder.Configurations.Add(new OrganizationConfiguration());
            modelBuilder.Configurations.Add(new PartnerConfiguration());
            modelBuilder.Configurations.Add(new PaymentVoucherConfiguration());
            modelBuilder.Configurations.Add(new PermissionConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());

            modelBuilder.Configurations.Add(new ProductTypeConfiguration());
            modelBuilder.Configurations.Add(new QuittanceConfiguration());
            modelBuilder.Configurations.Add(new ReceiptVoucherConfiguration());
            modelBuilder.Configurations.Add(new RoLeConfiguration());
            modelBuilder.Configurations.Add(new RolePermissionConfiguration());
            modelBuilder.Configurations.Add(new StaffConfiguration());

            modelBuilder.Configurations.Add(new StockInConfiguration());
            modelBuilder.Configurations.Add(new StockInDetailConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserRoleConfiguration());
            modelBuilder.Configurations.Add(new TimingConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());

            modelBuilder.Configurations.Add(new UserProductConfiguration());
            modelBuilder.Configurations.Add(new StandardSaleConfiguration());
            modelBuilder.Configurations.Add(new ElementFormularConfiguration());
            modelBuilder.Configurations.Add(new FormularConfiguration());
            modelBuilder.Configurations.Add(new FormularDetailConfiguration());
            modelBuilder.Configurations.Add(new UserFormularConfiguration());

        }
    }
}
