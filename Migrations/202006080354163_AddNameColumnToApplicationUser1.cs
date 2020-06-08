namespace HuynhNhatKhang__Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToApplicationUser1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "LectureID", newName: "LecturerID");
            RenameIndex(table: "dbo.Courses", name: "IX_LectureID", newName: "IX_LecturerID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerID", newName: "IX_LectureID");
            RenameColumn(table: "dbo.Courses", name: "LecturerID", newName: "LectureID");
        }
    }
}
