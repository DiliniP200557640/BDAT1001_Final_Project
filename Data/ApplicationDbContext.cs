using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;

namespace ContactManager.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }
    public DbSet<Contact> Contact { get; set; }
}

