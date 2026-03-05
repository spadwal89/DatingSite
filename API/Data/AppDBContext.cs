using System;
using API.Entities;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users{get ;set;}
}
