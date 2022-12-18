// See https://aka.ms/new-console-template for more information
using FinalProject;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

UniversityDbContext dbContext = new UniversityDbContext();

var Address = dbContext.Addresses.FirstOrDefault(x => x.Id == 1);

Console.WriteLine(Address.Address1);

Console.WriteLine("Done!");