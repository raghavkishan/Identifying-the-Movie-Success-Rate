using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DeleteImage
{
    class Program
    {
        static void Main(string[] args)
        {


            using (CsvReader csv =
           new CsvReader(new StreamReader(@"C: \Users\SK106736\Desktop\chaitu\Education\DM-PROJ\UNFiltered\IMDB-Movie-Data.csv"), true))
            {
                int i = 0;
                int fieldCount = csv.FieldCount;
                Console.WriteLine(fieldCount);
                string[] headers = csv.GetFieldHeaders();
                //int recordlen = csv.

                double Rating_AVG = 6.814319809;
                double votes_avg = 193230.2518;
                double revenue_avg = 84.56455847;

                while (csv.ReadNextRecord())
                {

                        string genre = csv[2];
                        i = i + 1;


                    double rating = Convert.ToDouble(csv[8]);
                    double votes = Convert.ToDouble(csv[9]);
                    double revenue = Convert.ToDouble(csv[10]);


                    var csv1 = new StringBuilder();
                    var csv2 = new StringBuilder();
                    var csv3 = new StringBuilder();
                    Console.WriteLine(i);

                    if ((rating >= Rating_AVG))
                    {
                        var rat = 1;
                        var newLine = string.Format("{0}", rat);
                        csv1.AppendLine(newLine);

                        File.AppendAllText(csv[35], csv1.ToString());

                    }

                    else
                    {
                        var rat = 0;
                        var newLine = string.Format("{0}", rat);
                        csv1.AppendLine(newLine);

                        File.AppendAllText(csv[35], csv1.ToString());
                    }

                    if ((revenue >= revenue_avg))
                    {
                        var rev = 1;
                        var newLine = string.Format("{0}", rev);
                        csv2.AppendLine(newLine);

                        File.AppendAllText(csv[34], csv2.ToString());

                    }

                    else
                    {
                        var rev = 0;
                        var newLine = string.Format("{0}", rev);
                        csv2.AppendLine(newLine);

                        File.AppendAllText(csv[34], csv2.ToString());
                    }

                    if ((votes >= votes_avg))
                    {
                        var vot = 1;
                        var newLine = string.Format("{0}", vot);
                        csv3.AppendLine(newLine);

                        File.AppendAllText(csv[33], csv3.ToString());

                    }

                    else
                    {
                        var vot = 0;
                        var newLine = string.Format("{0}", vot);
                        csv3.AppendLine(newLine);

                        File.AppendAllText(csv[33], csv3.ToString());
                    }




                    if ((votes >= votes_avg) && (revenue >= revenue_avg) && (rating >= Rating_AVG))
                    {
                        var vot = 1;
                        var newLine = string.Format("{0}", vot);
                        csv1.AppendLine(newLine);

                        File.AppendAllText(csv[32], csv1.ToString());

                    }

                    else
                    {
                        var vot = 0;
                        var newLine = string.Format("{0}", vot);
                        csv1.AppendLine(newLine);

                        File.AppendAllText(csv[32], csv1.ToString());
                    }







                    Console.WriteLine(genre);

                    var csv100 = new StringBuilder();



                    if (genre.Contains("Action"))
                    {

                        Console.WriteLine("YES I'M");
                        var action = 1;
                        var newLine = string.Format("{0}", action);
                        csv100.AppendLine(newLine);

                        File.AppendAllText(csv[12], csv100.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var action = 0;
                        var newLine = string.Format("{0}", action);
                        csv100.AppendLine(newLine);

                        File.AppendAllText(csv[12], csv100.ToString());
                    }

                    var csv22 = new StringBuilder();
                    //adventure
                    if (genre.Contains("Adventure"))
                    {

                        Console.WriteLine("YES I'M");
                        var adventure = 1;
                        var newLine = string.Format("{0}", adventure);
                        csv22.AppendLine(newLine);

                        File.AppendAllText(csv[13], csv22.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var adventure = 0;
                        var newLine = string.Format("{0}", adventure);
                        csv22.AppendLine(newLine);

                        File.AppendAllText(csv[13], csv22.ToString());
                    }

                    //Animation
                    var csv33 = new StringBuilder();
                    if (genre.Contains("Animation"))
                    {

                        Console.WriteLine("YES I'M");
                        var animation = 1;
                        var newLine = string.Format("{0}", animation);
                        csv33.AppendLine(newLine);

                        File.AppendAllText(csv[14], csv33.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var animation = 0;
                        var newLine = string.Format("{0}", animation);
                        csv33.AppendLine(newLine);

                        File.AppendAllText(csv[14], csv33.ToString());
                    }

                    //Biography
                    var csv4 = new StringBuilder();
                    if (genre.Contains("Biography"))
                    {

                        Console.WriteLine("YES I'M");
                        var biography = 1;
                        var newLine = string.Format("{0}", biography);
                        csv4.AppendLine(newLine);

                        File.AppendAllText(csv[15], csv4.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var biography = 0;
                        var newLine = string.Format("{0}", biography);
                        csv4.AppendLine(newLine);

                        File.AppendAllText(csv[15], csv4.ToString());
                    }

                    //Comedy
                    var csv5 = new StringBuilder();
                    if (genre.Contains("Comedy"))
                    {

                        Console.WriteLine("YES I'M");
                        var Comedy = 1;
                        var newLine = string.Format("{0}", Comedy);
                        csv5.AppendLine(newLine);

                        File.AppendAllText(csv[16], csv5.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Comedy = 0;
                        var newLine = string.Format("{0}", Comedy);
                        csv5.AppendLine(newLine);

                        File.AppendAllText(csv[16], csv5.ToString());
                    }

                    //Crime
                    var csv6 = new StringBuilder();
                    if (genre.Contains("Crime"))
                    {

                        Console.WriteLine("YES I'M");
                        var Crime = 1;
                        var newLine = string.Format("{0}", Crime);
                        csv6.AppendLine(newLine);

                        File.AppendAllText(csv[17], csv6.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Crime = 0;
                        var newLine = string.Format("{0}", Crime);
                        csv6.AppendLine(newLine);

                        File.AppendAllText(csv[17], csv6.ToString());
                    }

                    //Drama
                    var csv7 = new StringBuilder();
                    if (genre.Contains("Drama"))
                    {

                        Console.WriteLine("YES I'M");
                        var Drama = 1;
                        var newLine = string.Format("{0}", Drama);
                        csv7.AppendLine(newLine);

                        File.AppendAllText(csv[18], csv7.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Drama = 0;
                        var newLine = string.Format("{0}", Drama);
                        csv7.AppendLine(newLine);

                        File.AppendAllText(csv[18], csv7.ToString());
                    }

                    //Family
                    var csv8 = new StringBuilder();
                    if (genre.Contains("Family"))
                    {

                        Console.WriteLine("YES I'M");
                        var Family = 1;
                        var newLine = string.Format("{0}", Family);
                        csv8.AppendLine(newLine);

                        File.AppendAllText(csv[19], csv8.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Family = 0;
                        var newLine = string.Format("{0}", Family);
                        csv8.AppendLine(newLine);

                        File.AppendAllText(csv[19], csv8.ToString());
                    }

                    //Fantasy
                    var csv9 = new StringBuilder();
                    if (genre.Contains("Fantasy"))
                    {

                        Console.WriteLine("YES I'M");
                        var Fantasy = 1;
                        var newLine = string.Format("{0}", Fantasy);
                        csv9.AppendLine(newLine);

                        File.AppendAllText(csv[20], csv9.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Fantasy = 0;
                        var newLine = string.Format("{0}", Fantasy);
                        csv9.AppendLine(newLine);

                        File.AppendAllText(csv[20], csv9.ToString());
                    }

                    //History
                    var csv10 = new StringBuilder();
                    if (genre.Contains("History"))
                    {

                        Console.WriteLine("YES I'M");
                        var History = 1;
                        var newLine = string.Format("{0}", History);
                        csv10.AppendLine(newLine);

                        File.AppendAllText(csv[21], csv10.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var History = 0;
                        var newLine = string.Format("{0}", History);
                        csv10.AppendLine(newLine);

                        File.AppendAllText(csv[21], csv10.ToString());
                    }

                    //Horror
                    var csv11 = new StringBuilder();
                    if (genre.Contains("Horror"))
                    {

                        Console.WriteLine("YES I'M");
                        var Horror = 1;
                        var newLine = string.Format("{0}", Horror);
                        csv11.AppendLine(newLine);

                        File.AppendAllText(csv[22], csv11.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Horror = 0;
                        var newLine = string.Format("{0}", Horror);
                        csv11.AppendLine(newLine);

                        File.AppendAllText(csv[22], csv11.ToString());
                    }

                    //Music
                    var csv12 = new StringBuilder();
                    if (genre.Contains("Music"))
                    {

                        Console.WriteLine("YES I'M");
                        var Music = 1;
                        var newLine = string.Format("{0}", Music);
                        csv12.AppendLine(newLine);

                        File.AppendAllText(csv[23], csv12.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Music = 0;
                        var newLine = string.Format("{0}", Music);
                        csv12.AppendLine(newLine);

                        File.AppendAllText(csv[23], csv12.ToString());
                    }

                    //Musical
                    var csv13 = new StringBuilder();
                    if (genre.Contains("Musical"))
                    {

                        Console.WriteLine("YES I'M");
                        var Musical = 1;
                        var newLine = string.Format("{0}", Musical);
                        csv13.AppendLine(newLine);

                        File.AppendAllText(csv[24], csv13.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Musical = 0;
                        var newLine = string.Format("{0}", Musical);
                        csv13.AppendLine(newLine);

                        File.AppendAllText(csv[24], csv13.ToString());
                    }

                    //Mystery
                    var csv14 = new StringBuilder();
                    if (genre.Contains("Mystery"))
                    {

                        Console.WriteLine("YES I'M");
                        var Mystery = 1;
                        var newLine = string.Format("{0}", Mystery);
                        csv14.AppendLine(newLine);

                        File.AppendAllText(csv[25], csv14.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Mystery = 0;
                        var newLine = string.Format("{0}", Mystery);
                        csv14.AppendLine(newLine);

                        File.AppendAllText(csv[25], csv14.ToString());
                    }

                    //Romance
                    var csv15 = new StringBuilder();
                    if (genre.Contains("Romance"))
                    {

                        Console.WriteLine("YES I'M");
                        var Romance = 1;
                        var newLine = string.Format("{0}", Romance);
                        csv15.AppendLine(newLine);

                        File.AppendAllText(csv[26], csv15.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Romance = 0;
                        var newLine = string.Format("{0}", Romance);
                        csv15.AppendLine(newLine);

                        File.AppendAllText(csv[26], csv15.ToString());
                    }

                    //Sci-Fi
                    var csv16 = new StringBuilder();
                    if (genre.Contains("Sci-Fi"))
                    {

                        Console.WriteLine("YES I'M");
                        var SciFi = 1;
                        var newLine = string.Format("{0}", SciFi);
                        csv16.AppendLine(newLine);

                        File.AppendAllText(csv[27], csv16.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var SciFi = 0;
                        var newLine = string.Format("{0}", SciFi);
                        csv16.AppendLine(newLine);

                        File.AppendAllText(csv[27], csv16.ToString());
                    }

                    //Sport
                    var csv17 = new StringBuilder();
                    if (genre.Contains("Sport"))
                    {

                        Console.WriteLine("YES I'M");
                        var Sport = 1;
                        var newLine = string.Format("{0}", Sport);
                        csv17.AppendLine(newLine);

                        File.AppendAllText(csv[28], csv17.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Sport = 0;
                        var newLine = string.Format("{0}", Sport);
                        csv17.AppendLine(newLine);

                        File.AppendAllText(csv[28], csv17.ToString());
                    }

                    //Thriller
                    var csv18 = new StringBuilder();
                    if (genre.Contains("Thriller"))
                    {

                        Console.WriteLine("YES I'M");
                        var Thriller = 1;
                        var newLine = string.Format("{0}", Thriller);
                        csv18.AppendLine(newLine);

                        File.AppendAllText(csv[29], csv18.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Thriller = 0;
                        var newLine = string.Format("{0}", Thriller);
                        csv18.AppendLine(newLine);

                        File.AppendAllText(csv[29], csv18.ToString());
                    }

                    //War
                    var csv19 = new StringBuilder();
                    if (genre.Contains("War"))
                    {

                        Console.WriteLine("YES I'M");
                        var War = 1;
                        var newLine = string.Format("{0}", War);
                        csv19.AppendLine(newLine);

                        File.AppendAllText(csv[30], csv19.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var War = 0;
                        var newLine = string.Format("{0}", War);
                        csv19.AppendLine(newLine);

                        File.AppendAllText(csv[30], csv19.ToString());
                    }

                    //Western
                    var csv20 = new StringBuilder();
                    if (genre.Contains("Western"))
                    {

                        Console.WriteLine("YES I'M");
                        var Western = 1;
                        var newLine = string.Format("{0}", Western);
                        csv20.AppendLine(newLine);

                        File.AppendAllText(csv[31], csv20.ToString());
                    }

                    else
                    {

                        Console.WriteLine("No I'm not");
                        var Western = 0;
                        var newLine = string.Format("{0}", Western);
                        csv20.AppendLine(newLine);

                        File.AppendAllText(csv[31], csv20.ToString());
                    }



                }


            }

            Console.Read();

        }



        
    }
}
