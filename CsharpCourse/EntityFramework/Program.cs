using EF;
using Microsoft.EntityFrameworkCore;



DbContextOptionsBuilder<TestContext> optionsBuilder = new DbContextOptionsBuilder<TestContext>();
               optionsBuilder.UseSqlServer("Server=.\\LOCAL; Database=Test; User Id=jimcostdev; Password=123456;");

// Utilizamos using ya que este tiene un metodo Dispose() que cierra la conexion db 
using (TestContext context = new TestContext(optionsBuilder.Options))
{
    var teams = context.Teams.ToList();
    foreach (var team in teams)
    {
        Console.WriteLine(team.Name);
    }
}
