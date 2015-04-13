namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chap4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Budget = c.Decimal(nullable: false, storeType: "money"),
                        StartDate = c.DateTime(nullable: false),
                        InstructorID = c.Int(),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InstructorID);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorID = c.Int(nullable: false),
                        Location = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.InstructorID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.CourseInstructor",
                c => new
                    {
                        CourseID = c.Int(nullable: false),
                        InstructorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseID, t.InstructorID })
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.InstructorID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.InstructorID);
            
            //AddColumn("dbo.Courses", "DepartmentID", c => c.Int(nullable: false));
            // Create  a department for course to point to.
            Sql("INSERT INTO dbo.Departments (Name, Budget, StartDate) VALUES ('Temp', 0.00, GETDATE())");
            //  default value for FK points to department created above.
            AddColumn("dbo.Courses", "DepartmentID", c => c.Int(nullable: false, defaultValue: 1));

            AlterColumn("dbo.Courses", "Title", c => c.String(maxLength: 50));
            AddForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
            CreateIndex("dbo.Courses", "DepartmentID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CourseInstructor", new[] { "InstructorID" });
            DropIndex("dbo.CourseInstructor", new[] { "CourseID" });
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorID" });
            DropIndex("dbo.Departments", new[] { "InstructorID" });
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropForeignKey("dbo.CourseInstructor", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.CourseInstructor", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.OfficeAssignments", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.Departments", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            AlterColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "DepartmentID");
            DropTable("dbo.CourseInstructor");
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.Instructors");
            DropTable("dbo.Departments");
        }
    }
}
