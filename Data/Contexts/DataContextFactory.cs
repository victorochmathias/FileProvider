﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
{
    var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
    optionsBuilder.UseSqlServer("Server=tcp:sqlserver-silicon-backend.database.windows.net,1433;Initial Catalog=files;Persist Security Info=False;User ID=SqlAdmin;Password=Bytmig123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    return new DataContext(optionsBuilder.Options);
}
}
