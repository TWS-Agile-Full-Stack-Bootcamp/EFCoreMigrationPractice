
# hint
* MySql Connection string: `server=localhost;user=root;database=db;password=*****;`
* run below command to add migration `dotnet ef migrations add InitialCreate`

* run below command to run migration `dotnet ef database update`
* Use below code to method of `Configure` in file `Startup.cs` to migrate database automatically
```

using (var scope = app.ApplicationServices.CreateScope())
{
    using (var context = scope.ServiceProvider.GetService<CompanyDBContext>())
    {
        context.Database.Migrate();
    }
}
```


