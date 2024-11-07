using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ConsoleApp1;

List<Movie> list = new List<Movie>(); // Film listesini tanımlıyoruz

while (true)
{
     // Kullanıcıdan Film Adını alıyoruz.
    Console.Write("Lütfen bir Film ismi giriniz ==> ");
    string film = Console.ReadLine();
    double IMDb;

    do
    {
        Console.Write("Lütfen bir IMDb puanı giriniz ==> "); // Kullanıcıdan IMDb puanını alıyoruz.

        if (double.TryParse(Console.ReadLine(), out IMDb) && IMDb >= 0 && IMDb <= 10)
        {
            break; // Geçerli bir değer girildiğinde döngüden çıkılır
        }
        Console.WriteLine("Lütfen Geçerli bir IMDb puanı giriniz");
    } while (true);

    list.Add(new Movie(film, IMDb)); // Film ismi ve IMDb puanı ile yeni bir film nesnesi oluşturduk 

    Console.Write("Başka bir film eklemek ister misiniz? (Evet/Hayır) ===> ");
    string devam = Console.ReadLine().ToLower();
    if (devam != "evet")
    {
        break; // eğer evet demezse döngüden çıkar
    }
}
Console.WriteLine("----------------------------------------------");

Console.WriteLine("***** Girilen Filmler *****");
foreach (var Movie in list)
{
    Console.WriteLine($"Film Adı : {Movie.MovieName} || IMDb Puanı : {Movie.MoviePuan}"); // Girilen tüm filmleri yazdırıyoruz.
}

Console.WriteLine("----------------------------------------------");
// IMDb puanı 4 ile 9 arasında olan filmler 
Console.WriteLine("****** 4 puan ile 9 puan Arasındaki Filmler ******");
foreach (var Movie in list)
{
    if (Movie.MoviePuan >= 4 && Movie.MoviePuan <= 9)
    {
        Console.WriteLine($"{Movie.MovieName} || IMDb Puanı : {Movie.MoviePuan}"); // IMDb puanı 4 ile 9 arasında olan filmleri yazdırıyoruz.
    }
}

Console.WriteLine("----------------------------------------------");

Console.WriteLine("****** 'A' Harfi İle Başlayan Filmler ******");
foreach (var movie in list)
{
    // Filmin ismi 'A' harfiyle başlıyorsa yazdıralım
    if (movie.MovieName.StartsWith("A", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Film Adı: {movie.MovieName} || IMDb Puanı: {movie.MoviePuan}"); // Filmin İlk harfi 'A' olan filmleri yazdırıyoruz.
    }
}