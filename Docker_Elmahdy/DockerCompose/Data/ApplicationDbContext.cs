﻿using DockerCompose.Entities;
using Microsoft.EntityFrameworkCore;

namespace DockerCompose.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}
