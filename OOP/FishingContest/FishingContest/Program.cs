using TextFile;

namespace FishingContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Association association = new Association();
            try
            {
                TextFileReader reader = new TextFileReader("inputs/contests.txt");

                reader.ReadLine(out string line);
                char[] separators = new char[] { ' ', '\t' };
                string[] tokens = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string fishername in tokens)
                {
                    association.Join(fishername);   // horgasz beleptetese
                }

                while (reader.ReadLine(out string filename))
                {
                    TextFileReader innerReader = new TextFileReader($"inputs/{filename}");

                    innerReader.ReadLine(out line);
                    string[] contestStr = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    Contest contest = association.Organize(contestStr[0], DateTime.Parse(contestStr[1]));   // verseny megszervezese

                    innerReader.ReadLine(out line);
                    string[] fisherNames = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string fisherName in fisherNames)
                    {
                        Fisher? fisher = association.Search(fisherName);
                        if (fisher != null) contest.SignUp(fisher);   // a szovetseg egy tagja jelentkezik a versenyre
                    }

                    while (innerReader.ReadString(out string fisherName))
                    {
                        innerReader.ReadString(out string timeStr);
                        DateTime time = DateTime.Parse(timeStr);
                        innerReader.ReadString(out string fish);
                        innerReader.ReadDouble(out double weight);

                        Fisher? fisher = association.Search(fisherName);
                        if (fisher != null)
                        {
                            switch (fish)
                            {
                                case "ponty": fisher.Catch(time, Carp.Instance(), weight, contest); break;
                                case "keszeg": fisher.Catch(time, Bream.Instance(), weight, contest); break;
                                case "harcsa": fisher.Catch(time, Catfish.Instance(), weight, contest); break;
                            }
                        }
                    }
                }

                if (association.BestContest(out Contest? bestContest) && bestContest != null) Console.WriteLine($"A legjobb verseny: {bestContest.place}");
                else Console.WriteLine("Nincs olyan verseny, ahol mindenki fogott harcsat.");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("A megadott fajl nem talalhato!");
            }
        }
    }
}
