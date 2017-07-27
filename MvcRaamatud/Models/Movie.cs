using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models
{
public class Movie
{
    public int ID
    {
        get;
        set;
    }
        //Здесь я изменил название Title на Raamatu nimi.
    [Display(Name = "Raamatu nimi")]
    public string Title
    {
        get;
        set;
    }
        //Здесь я изменил название ReleaseDate на Esmakordselt avaldatud.
        [Display(Name = "Esmakordselt avaldatud")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate
    {
        get;
        set;
    }
        //здесь я изменил название Genre на Autor.
    [Display(Name = "Autor")]
    public string Genre
    {
        get;
        set;
    }
        //Здесь я изменил название Price на Hind.
    [Display(Name = "Hind")]
    public decimal Price
    {
        get;
        set;
    }
}

public class MovieDBContext : DbContext
{
    public DbSet<Movie> Movies
    {
        get;
        set;
    }
}
}