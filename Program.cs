using System;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool TryAgain = true;
            do
            {
                char YN;
                bool YesNo = false;
                Console.WriteLine("Please input base nucleotide of DNA :");
                string HalfBaseNucleotide = Console.ReadLine();
                if (IsValidSequence(HalfBaseNucleotide) == true)
                {
                    Console.WriteLine("Current half DNA sequence : " + HalfBaseNucleotide);
                    Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                    do
                    {
                        YN = char.Parse(Console.ReadLine());
                        if (YN == 'Y' || YN == 'N')
                        {
                            YesNo = true;
                            if (YN == 'Y')
                            {
                                Console.WriteLine("Replicated half DNA sequence : " + ReplicateSeqeunce(HalfBaseNucleotide));
                            }
                            else
                            {
                                Console.WriteLine("Skip");
                            }
                        }
                        else
                        {
                            YesNo = false;
                            Console.WriteLine("Please input Y or N.");
                        }
                    } while (YesNo == false);
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                }
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                do
                {
                    YN = char.Parse(Console.ReadLine());
                    if (YN == 'Y' || YN == 'N')
                    {
                        YesNo = true;
                        if (YN == 'Y')
                        {
                            TryAgain = true;
                        }
                        else
                        {
                            TryAgain = false;
                            Console.WriteLine("END");
                        }
                    }
                    else
                    {
                        YesNo = false;
                        Console.WriteLine("Please input Y or N.");
                    }
                } while (YesNo == false);
            } while (TryAgain == true);
        }

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
    }
}
