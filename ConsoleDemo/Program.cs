using Microsoft.EntityFrameworkCore;

var context = new DemoContext();

var cu = context.CourseUnits.Where(x => x.Name == "Math")
    .SingleOrDefault();

var studentCU = context.StudentCourseUnits
    .Where(x => x.Id == 1)
    .Include(x => x.Student)
    .Include(x => x.CourseUnit)
    .FirstOrDefault();

var student = studentCU.Student;


Console.ReadKey();


static void nitDb()
{
    var context = new DemoContext();

    var studentTJ = new Student
    {
        CreatedOn = DateTime.UtcNow,
        DoB = DateTime.MinValue,
        FirstName = "john",
        OtherNames = "tuza",
        Id = 1
    };
    var studentMS = new Student
    {
        CreatedOn = DateTime.UtcNow,
        DoB = DateTime.MinValue,
        FirstName = "Mbabazi",
        OtherNames = "S",
        Id = 2
    };


    context.Students.Add(studentTJ);
    context.Students.Add(studentMS);


    var mathCU = new CourseUnit
    {
        CreatedOn = DateTime.UtcNow,
        Name = "Math",
        Weight = 4,
        Id = 1
    };
    var physicsCU = new CourseUnit
    {
        CreatedOn = DateTime.UtcNow,
        Name = "Physics",
        Weight = 4,
        Id = 2
    };

    context.CourseUnits.Add(mathCU);
    context.CourseUnits.Add(physicsCU);


    var tjMathRp = new StudentCourseUnit
    {
        StudentId = studentTJ.Id,
        CourseUnitId = mathCU.Id,
        CreatedOn = DateTime.Now,
        Id = 1
    };
    context.StudentCourseUnits.Add(tjMathRp);

    var tjPhysicsRp = new StudentCourseUnit
    {
        StudentId = studentTJ.Id,
        CourseUnitId = physicsCU.Id,
        CreatedOn = DateTime.Now,
        Id = 2
    };
    context.StudentCourseUnits.Add(tjPhysicsRp);

    var MsMathRp = new StudentCourseUnit
    {
        StudentId = studentMS.Id,
        CourseUnitId = mathCU.Id,
        CreatedOn = DateTime.Now,
        Id = 3
    };
    try
    {
        context.StudentCourseUnits.Add(MsMathRp);

        var counter = context.SaveChanges();
        if (counter > 0)
        {
            Console.WriteLine("All inserted to DB");
        }
        else
        {
            Console.WriteLine("Failed to add");
        }
    }
    catch (Exception ex)
    {

        throw;
    }
}