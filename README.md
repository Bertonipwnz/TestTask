<div align="center">
  <h1 align="center">Budget Planner</h1>
</div>

<details>
  <summary>Content</summary>
  <ol>
    <li>
      <a href="#what-is-it">What is it?</a>
    </li>
     <li>
       <a href="#hod-does-it-work">How does it work?</a>
    </li>
    <li>
      <a href="#built-with">Built With</a>
    </li>
    <li>
      <a href="#installation">Installation</a>
    </li>
    <li>
      <a href="#possible-error">Possible errors</a>
    </li>
    <li>
      <a href="#contacts">Constacts</a>
    </li>
  </ol>
</details>

## What is it?
<p>
    This is a project created for planning and tracking budget written using the list below:
</p>
<ul>
  <li>[UWP]</li>
  <li>[EF]</li>
  <li>[SQLite]</li>
  <li>[MVVM]</li>
</ul>
<p align="right">(<a href="#top">Back to top</a>)</p>


## How does it work?
<p>The application displays your current balance, allows you to add new expenses or income in 
the form of transactions and displays the history of transactions in the form of a list.</p>
<p align="right">(<a href="#top">Back to top</a>)</p>

## Built With
<ul>
  <li>Universal Windows Platform(UWP)
    <ul type="circle"><li>Target version = Windows 10, version 1903 (10.0; build 18362) </li>
      <li>Minimal version = Windows 10 Creators Update (10.0; build 15063) </li>
      <li>Microsoft.NETCore.UWP v6.2.13 </li>
    </ul>
      </li>
  <li>Entity Framework(EF)
    <ul type="circle"><li>Micrisoft.EntityFrameworkCore.SQlite v1.0.0 </li>
      <li>Micrisoft.EntityFrameworkCore.Tools v1.0.0 </li>
    </ul>
      </li>
</ul>
<p align="right">(<a href="#top">back to top</a>)</p>

## Installation
1. Create project UWP with Target Version - Windows 10, version 1903 (10.0; build 18362) and Minimal Version - Windows 10 Creators Update (10.0; build 15063)
2. In NuGet Package Manager install: Microsoft.EntityFrameworkCore.Sqlite (v1.0.0), Microsoft.EntityFrameworkCore.Tools (v1.0.0), Microsoft.NETCore.UniversalWindowsPlatform (v6.2.13)
3. Create Model your tables 
4. Create "NameModelContext" to communication with the database and add next code:
```
        public DbSet<Namemodels> Namemodels { get; set; }
        public static string DbFilePath { get; set; }

        //Доступ к файлу бд в корневой папке
        public async Task GetFilePathDB()
        {
            StorageFile file;
            try
            {   //Если файл уже существуют используем его
                file = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync("Namedatabase.db");
            }
            catch
            {
                //Иначе копируем с папки приложения
                StorageFile Importedfile = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Namedatabase.db"));
                file = await Importedfile.CopyAsync(ApplicationData.Current.LocalFolder);
            }
            DbFilePath = file.Path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            Task.Run(() => GetFilePathDB());
            //Указываем на базу, которую используем
            options.UseSqlite($"Data Source =Namedatabase.db");
            base.OnConfiguring(options);
        }
```
5. In the package manage console, we write next code for migration:
```
Add-Migration InitialMigration
//InitialMigration - NameMigration
//command Remove Migration - delete last migration
```
6. Complete
<p align="right">(<a href="#top">back to top</a>)</p>

## Possible Errors
if you received an error: "SQLite Error 1 : no such table: (*name table)" <br>
 Then add to your code in "NameModelContext":
  ```
  public void "NameModelContext"()
  {
      Database.EnsureCreated();
  }
  ```
<p align="right">(<a href="#top">back to top</a>)</p>

## Contacts
Project Link: https://github.com/Bertonipwnz/TestTask

