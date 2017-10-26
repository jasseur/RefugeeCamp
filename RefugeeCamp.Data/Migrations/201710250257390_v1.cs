namespace RefugeeCamp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DateAppointment = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        AppointmentType = c.String(),
                        DateRgistration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.DoctorId, t.PatientId, t.DateAppointment })
                .ForeignKey("dbo.Staffs", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Refugees", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.DoctorId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        HireDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Gender = c.Int(nullable: false),
                        Contact_PhoneNumber = c.String(nullable: false),
                        Contact_Adress = c.String(nullable: false),
                        Contact_Email = c.String(nullable: false),
                        Role = c.Int(nullable: false),
                        Specialty = c.String(),
                        Notes = c.String(),
                        TeachingField = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Diagnostics",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Disease_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.PatientId, t.DoctorId, t.Date })
                .ForeignKey("dbo.Diseases", t => t.Disease_Id)
                .ForeignKey("dbo.Staffs", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Refugees", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId)
                .Index(t => t.Disease_Id);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Classification_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classifications", t => t.Classification_Id)
                .Index(t => t.Classification_Id);
            
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Refugees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MaritalStatus = c.String(),
                        BirthDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        RegistrationDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Notes = c.String(),
                        LevelId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Family_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Families", t => t.Family_Id)
                .ForeignKey("dbo.Levels", t => t.LevelId)
                .Index(t => t.LevelId)
                .Index(t => t.Family_Id);
            
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Shelter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shelters", t => t.Shelter_Id)
                .Index(t => t.Shelter_Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Object = c.String(),
                        Body = c.String(),
                        DateReport = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Refugee_Id = c.Int(),
                        Staff_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Refugees", t => t.Refugee_Id)
                .ForeignKey("dbo.Staffs", t => t.Staff_Id)
                .Index(t => t.Refugee_Id)
                .Index(t => t.Staff_Id);
            
            CreateTable(
                "dbo.DistributionRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateDistribution = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Shelter_Id = c.Int(),
                        Staff_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shelters", t => t.Shelter_Id)
                .ForeignKey("dbo.Staffs", t => t.Staff_Id)
                .Index(t => t.Shelter_Id)
                .Index(t => t.Staff_Id);
            
            CreateTable(
                "dbo.Lots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ArrivalDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ExpiryDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        SentFrom = c.String(),
                        Picture = c.String(),
                        DistributionRecord_Id = c.Int(),
                        TypeLot_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DistributionRecords", t => t.DistributionRecord_Id)
                .ForeignKey("dbo.Supplies", t => t.TypeLot_Id)
                .Index(t => t.DistributionRecord_Id)
                .Index(t => t.TypeLot_Id);
            
            CreateTable(
                "dbo.Supplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TypeSupply = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Demands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Unit = c.String(),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Supply_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Supplies", t => t.Supply_Id)
                .Index(t => t.Supply_Id);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        DrugId = c.Int(nullable: false),
                        PrescriptionId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Instruction = c.String(),
                        Duration = c.Int(nullable: false),
                        prescription_PatientId = c.Int(),
                        prescription_DoctorId = c.Int(),
                        prescription_Date = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.DrugId, t.PrescriptionId, t.Date })
                .ForeignKey("dbo.Supplies", t => t.DrugId, cascadeDelete: true)
                .ForeignKey("dbo.Prescriptions", t => new { t.prescription_PatientId, t.prescription_DoctorId, t.prescription_Date })
                .Index(t => t.DrugId)
                .Index(t => new { t.prescription_PatientId, t.prescription_DoctorId, t.prescription_Date });
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Note = c.String(),
                    })
                .PrimaryKey(t => new { t.PatientId, t.DoctorId, t.Date })
                .ForeignKey("dbo.Staffs", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Refugees", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Shelters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Classsrooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Finish = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ClassroomName = c.String(),
                        ClassroomDescription = c.String(),
                        Teacher_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.Teacher_Id)
                .ForeignKey("dbo.Refugees", t => t.Student_Id)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        LevelId = c.Int(nullable: false, identity: true),
                        LevelName = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LevelId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        LevelId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Levels", t => t.LevelId)
                .Index(t => t.LevelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Refugees", "LevelId", "dbo.Levels");
            DropForeignKey("dbo.Courses", "LevelId", "dbo.Levels");
            DropForeignKey("dbo.Classsrooms", "Student_Id", "dbo.Refugees");
            DropForeignKey("dbo.Reports", "Staff_Id", "dbo.Staffs");
            DropForeignKey("dbo.Classsrooms", "Teacher_Id", "dbo.Staffs");
            DropForeignKey("dbo.DistributionRecords", "Staff_Id", "dbo.Staffs");
            DropForeignKey("dbo.Families", "Shelter_Id", "dbo.Shelters");
            DropForeignKey("dbo.DistributionRecords", "Shelter_Id", "dbo.Shelters");
            DropForeignKey("dbo.Lots", "TypeLot_Id", "dbo.Supplies");
            DropForeignKey("dbo.Treatments", new[] { "prescription_PatientId", "prescription_DoctorId", "prescription_Date" }, "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.Refugees");
            DropForeignKey("dbo.Prescriptions", "DoctorId", "dbo.Staffs");
            DropForeignKey("dbo.Treatments", "DrugId", "dbo.Supplies");
            DropForeignKey("dbo.Demands", "Supply_Id", "dbo.Supplies");
            DropForeignKey("dbo.Lots", "DistributionRecord_Id", "dbo.DistributionRecords");
            DropForeignKey("dbo.Reports", "Refugee_Id", "dbo.Refugees");
            DropForeignKey("dbo.Refugees", "Family_Id", "dbo.Families");
            DropForeignKey("dbo.Diagnostics", "PatientId", "dbo.Refugees");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Refugees");
            DropForeignKey("dbo.Diagnostics", "DoctorId", "dbo.Staffs");
            DropForeignKey("dbo.Diagnostics", "Disease_Id", "dbo.Diseases");
            DropForeignKey("dbo.Diseases", "Classification_Id", "dbo.Classifications");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Staffs");
            DropIndex("dbo.Courses", new[] { "LevelId" });
            DropIndex("dbo.Classsrooms", new[] { "Student_Id" });
            DropIndex("dbo.Classsrooms", new[] { "Teacher_Id" });
            DropIndex("dbo.Prescriptions", new[] { "DoctorId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropIndex("dbo.Treatments", new[] { "prescription_PatientId", "prescription_DoctorId", "prescription_Date" });
            DropIndex("dbo.Treatments", new[] { "DrugId" });
            DropIndex("dbo.Demands", new[] { "Supply_Id" });
            DropIndex("dbo.Lots", new[] { "TypeLot_Id" });
            DropIndex("dbo.Lots", new[] { "DistributionRecord_Id" });
            DropIndex("dbo.DistributionRecords", new[] { "Staff_Id" });
            DropIndex("dbo.DistributionRecords", new[] { "Shelter_Id" });
            DropIndex("dbo.Reports", new[] { "Staff_Id" });
            DropIndex("dbo.Reports", new[] { "Refugee_Id" });
            DropIndex("dbo.Families", new[] { "Shelter_Id" });
            DropIndex("dbo.Refugees", new[] { "Family_Id" });
            DropIndex("dbo.Refugees", new[] { "LevelId" });
            DropIndex("dbo.Diseases", new[] { "Classification_Id" });
            DropIndex("dbo.Diagnostics", new[] { "Disease_Id" });
            DropIndex("dbo.Diagnostics", new[] { "DoctorId" });
            DropIndex("dbo.Diagnostics", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Levels");
            DropTable("dbo.Classsrooms");
            DropTable("dbo.Shelters");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Treatments");
            DropTable("dbo.Demands");
            DropTable("dbo.Supplies");
            DropTable("dbo.Lots");
            DropTable("dbo.DistributionRecords");
            DropTable("dbo.Reports");
            DropTable("dbo.Families");
            DropTable("dbo.Refugees");
            DropTable("dbo.Classifications");
            DropTable("dbo.Diseases");
            DropTable("dbo.Diagnostics");
            DropTable("dbo.Staffs");
            DropTable("dbo.Appointments");
        }
    }
}
