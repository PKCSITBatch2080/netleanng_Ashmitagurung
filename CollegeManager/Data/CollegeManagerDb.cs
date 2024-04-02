using Microsoft.EntityFrameWorkCore;

public class collegeManagerDb: DbContext{

    public Dbset<CollegeProgram> CollegeProgram{get: set;}
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source: CollegeManager.db")
        //ConnectionString
    }
}