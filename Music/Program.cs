using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            var fichier = File.ReadAllLines(@"C:\Users\Administrateur\source\repos\Music\Music\SongCSV.csv");
            var data = fichier.Select(x => x.Split(',')).Skip(1).ToList();

            data.Select(x => x[17]).GroupBy(x => x, x => x, (album, _) => new Tuple<string, int>
            (
                album,
                album.Count()
            )).OrderBy(x => x.Item2).Select(x =>
            {
                Console.WriteLine(x.Item1 + ": " + x.Item2);
                return x;
            }).ToList();


            /*data.GroupBy(
                 x => x[2],
                 (album, reste) => new Tuple<string, int, List<string[]>>
                 (
                     album,
                     reste.Count(),
                     reste.ToList()
                 )
             ).OrderBy((x) => x.Item2).Select(x =>
             {
                 //Console.WriteLine("\t" + x.Item1 + ": " + x.Item2);
                 x.Item3.GroupBy(
                     x => x[17],
                     (annee, tous_les_albums) => new Tuple<string, int>(
                         annee,
                         tous_les_albums.Count()
                     )
                 ).Select(x =>
                 {
                     Console.WriteLine("\t" + x.Item1 + ": " + x.Item2);
                     return x;
                 }).ToList();

                 return x;
                 }).ToList(); */
        }
    }
}

//year : 18
//album ID : 2

/* col names
    var colNames = fichier.First().Split(',').ToList();
    colNames.ForEach(Console.WriteLine); */

/*
data.GroupBy(
    x => x[2],
    (album, reste) => new Tuple<string, int>
    (
        album,
        reste.Count()
    )
    ).Select(x =>
    {
        Console.WriteLine("\t" + x.Item1 + ": " + x.Item2);
        return x;
    }); ;
        }
    }
}*/