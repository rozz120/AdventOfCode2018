using System;
using System.Collections.Generic;

namespace Advent_of_code_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            var characterCounts = new Dictionary<char, int>();
            int twiceRepeatedLetters = 0;
            int threeTimesRepeatedLetters = 0;

            var boxIds = new List<string>() { "bvhfawknyoqsudzrpgslecmtkj", "bpufawcnyoqxldzrpgsleimtkj", "bvhfawcnyoqxqdzrplsleimtkf", "bvhoagcnyoqxudzrpgsleixtkj", "bxvfgwcnyoqxudzrpgsleimtkj", "bvqfawcngoqxudzrpgsleiktkj", "bvhfawcnmoqxuyzrpgsleimtkp", "bvheawcnyomxsdzrpgsleimtkj", "bcdfawcnyoqxudzrpgsyeimtkj", "bvhpawcnyoqxudzrpgsteimtkz", "bxhfawcnyozxudzrpgsleimtoj", "bvhfdwcnyozxudzrposleimtkj", "bvpfawcnyotxudzrpgsleimtkq", "bvhfpwccyoqxudzrpgslkimtkj", "bvhfawcnyoqxudirpgsreimtsj", "bvhfawcnyoqxudzppgbleemtkj", "bvhzawcnyoqxudqrpgslvimtkj", "bvhfawclyoqxudirpgsleimtka", "bvhgawfnyoqxudzrpguleimtkj", "bvhfazcnytqxudzrpgslvimtkj", "bvhfawcnygxxudzrpgjleimtkj", "bxhfawcnyoqxudzipgsleimtxj", "bvhptwcnyoqxudzrpgsleimtmj", "bzhfawcgyooxudzrpgsleimtkj", "bvhjlwcnyokxudzrpgsleimtkj", "bvhfawcnyoqxudbrmgslesmtkj", "bvhfawcnysixudzwpgsleimtkj", "bvhflwcnymqxxdzrpgsleimtkj", "bvifawcnyoyxudzrpgsleimtvj", "bvhfawcnyofxudlrpgsheimtkj", "bvhbawcmyoqxudzrpggleimtkj", "bhhxgwcnyoqxudzrpgsleimtkj", "bvhfawgnyoqxbdzrpgsleimfkj", "bvhfawcnyoqxudcrngsleimykj", "bvhfawcnyofxudzrpgslebgtkj", "bvhfaocnybqxudzapgsleimtkj", "bvhxawcnyodxudzrpfsleimtkj", "bchfawcnyoqxudrrtgsleimtkj", "bvhfawcqyoqxudzdpgsltimtkj", "bvhfawknyoqxudzrpnsleimtbj", "cihfawcnyoqxudirpgsleimtkj", "bvlfawpnyoqxudzrpgslgimtkj", "bulfawcnyoqbudzrpgsleimtkj", "bvhfajcnyoqkudzrpgsoeimtkj", "bvhrakcnyoqxudzrpgsleimjkj", "bvbftwcnyoqxuvzrpgsleimtkj", "bvhfhwcnyoqxudzrpgslelmtbj", "bvhyawcntoqxudzrpgsleimtuj", "xvhuawcnyoqxuqzrpgsleimtkj", "pvhfawcnyoqxudzdpglleimtkj", "bvhfawsnyoqxudzrpgvlefmtkj", "bvhfawcnyoqxudzrpgepeiwtkj", "bvhfawcnyoqxudzrphsleittkr", "dvhfawcnyoqxudzrpkslzimtkj", "bvhfawpnyoqxudzrpgmlcimtkj", "bvhsawcnyzqxudzrpgsaeimtkj", "bdhfawcnyoqxudzrpasleiwtkj", "bvhfawbnyoqxpdbrpgsleimtkj", "mvhfawwnyoqxujzrpgsleimtkj", "bvafawcnyoyxudzrpgsleidtkj", "bvhyawcnyoqxudztpgzleimtkj", "besfawcnyoqxudzrpgsleimdkj", "bvhfawcnyoqxudrrpgsjeimjkj", "xvhfkwcnyoqxudzcpgsleimtkj", "bvhfawcnyeqdudzrpgzleimtkj", "bvhfuwcnybqxudzrpgsleimttj", "lvhfawcnyoqhudzdpgsleimtkj", "bvhfawcnyoqxudzrpgslevwtnj", "bvhfadcnzoqxxdzrpgsleimtkj", "bvsfawcnyoqxpdzrpgileimtkj", "bzhfaycnyoqxudzrpgsxeimtkj", "bwhfdwcnyoqxudzrpgsleimtkz", "bvhfawcnyoqxudzrpgsjlimtkm", "bvhfawcnyoqxudsrwgsleimtlj", "bbhfalynyoqxudzrpgsleimtkj", "bvhfawcnyeqxudzrpglleimtkr", "bvhfawnnboqxurzrpgsleimtkj", "yvhfawcnyoqxudzrpgslzimtpj", "bvhfjwcnyoqxqdxrpgsleimtkj", "bthfawcnyoqfudzrpgslhimtkj", "bvhfawchuoqxudzqpgsleimtkj", "bvhfawcndoqxudzrugsleimrkj", "bvhfawcnnoqxjdzrpgsleidtkj", "bvhpawcnyoqkudzrpgsleimtzj", "bvhfaiinyoqxudzopgsleimtkj", "bvhfawcnyxqxuizrigsleimtkj", "bvnfawcnyoqxudzqpgsleimbkj", "bvnfawcnyoeyudzrpgsleimtkj", "bvhfawcnyoqxudarpgsieimtoj", "bthcawcnyoqxudlrpgsleimtkj", "bvhfnwcnyozxudzrpgsleomtkj", "bpwfawcnyoqxudzrpgskeimtkj", "bvhfapcnyoqxudnrpgsxeimtkj", "bvhfdwcnyoqxubzrxgsleimtkj", "fvhfawcnyoqxjdzrpgsleirtkj", "bvhfawcneoqxudzrvzsleimtkj", "bvhaawcnyoqxudzrpgsleimtex", "bvhfawcnyojxudvrpgsleimckj", "bvlfawcnyoqxddzrpgsleimtko", "bvhfawclfoqxudzrpgsleiktkj", "bvhfawciyobxudzrpgkleimtkj", "bvhfpwcnyoqxudzrpgsqeimtkd", "bvhyawcnyyqxudzrkgsleimtkj", "bvhfawcncoqxudzrphsaeimtkj", "bvhfawmnyoqxudzrpgifeimtkj", "bvhfawcjyoqxudzjpgszeimtkj", "bohfawcnwoqxudzrpgsleimwkj", "bvhfaucnyoqxudzrpgfluimtkj", "bvhfawlnyoqgudzrpgwleimtkj", "bmhfawcnyoqxndzrpgsleymtkj", "bvhfawcngoqxudzrpzxleimtkj", "bihfawcnyoqxudrrpgsleimokj", "lvhfawcnylqxudzrpgsleintkj", "bvhfawcnyoqvugzrqgsleimtkj", "bvhfawcnyoqxudzgpgslqimtij", "bvhfawcnyoqludzrpgslnimtcj", "hvhfawcnyolxudzrpgsmeimtkj", "nvhfawcdkoqxudzrpgsleimtkj", "bvhfawcnyoqxkdzrggsneimtkj", "bvhfawnnyoqxudzrpgqleibtkj", "bvhfawyuyoqxudzrhgsleimtkj", "wvhfbwcnyoqxtdzrpgsleimtkj", "bvhfawcnyoqxedzzpgoleimtkj", "bvhfawcnioqxunzrpgsleimtnj", "bvhfawctyoqxudzrpgsldkmtkj", "bvhfawcnyonxudzrpgsleitpkj", "bvefawcnyoqaudzhpgsleimtkj", "bvhfawcnyxqxudzrpgslelmbkj", "bvhfamrnyoqxudzrpgsleimgkj", "bvhfaqcnyoqxudzrpgsaeimekj", "bvhfawcnyoqcidzrpgsleimvkj", "bvhfawcnnorxudzrpgsmeimtkj", "bvroawcnyoqxudzrpgsleiwtkj", "bvhfwwcnyoqxudzrpaslewmtkj", "bvsfawcnyoqxudzcpgszeimtkj", "bkhfmwcnyoqjudzrpgsleimtkj", "bvtfawcnyoqxudzrcgslecmtkj", "bvhfawcnypzxudzrpgsleimtkv", "bvhfawcnyoqzudzrfgtleimtkj", "bvhpawcnyoqxudhrpgsleimtko", "tvhfawcnyoqxudzxpfsleimtkj", "bvhfawccyofxudzrpqsleimtkj", "bvnfawtnyoqxuzzrpgsleimtkj", "bvhfamcnuwqxudzrpgsleimtkj", "bvhfawcfyoqxudjrpgsleimrkj", "bvhpalcnyoqxudzrpgslexmtkj", "bvhfawcnjsqxudzlpgsleimtkj", "bvhfafcnioqxydzrpgsleimtkj", "bvzfawcnyxqxudzgpgsleimtkj", "bvhzawcnyoqxudzrpgslewctkj", "bvhiawcnhoqrudzrpgsleimtkj", "bvhfawcnyoqxuszrggslenmtkj", "bvhfowcnyoqxudzrptseeimtkj", "behfawfnyoqxudzrpgsleimlkj", "lvhfawcnyoqxudsrpgvleimtkj", "bvhfawnnyaqxudzrpgsqeimtkj", "lvhfawcnfoqxvdzrpgsleimtkj", "svhxawcnyoqxudzrpqsleimtkj", "bvhfawqnfoqxudzrpgsleimkkj", "bvhfafcnyoqcudzrpgsleimtcj", "bvhfyfcntoqxudzrpgsleimtkj", "bvhfpwcnyoqxudzrpgsleimumj", "bvhfawccyoqxudzrqgrleimtkj", "bvhfawqnyoqxudzbpgsleimkkj", "bvhflwcnyoqxudzrpxsleemtkj", "bvhfawcnyoqxuezrpgslehrtkj", "bvhfawceyoqxudzrpgsleimswj", "bvhfawcncohgudzrpgsleimtkj", "bahfawcnyoqxgdzrpgsleamtkj", "yvhfawcnyoqxudzrppslrimtkj", "fvhfawcmyoqxudzrpgskeimtkj", "bvylawsnyoqxudzrpgsleimtkj", "bvhfswcnyyqxedzrpgsleimtkj", "fvrfawcnyoqxudzrpgzleimtkj", "bvhfawcnyoqxuvzrpgslermtks", "bvhkawccyoqxudzcpgsleimtkj", "bvhfaobnyoqxudzrprsleimtkj", "bvbfawcnyoqxudirpgsleimhkj", "bvhfawcnyoqxudzvpgsueimtgj", "bvhxawcnyoqxudzrpgsleimtgi", "svhfawcjyoqxuszrpgsleimtkj", "bvnfawcnyoeyudzrpgsldimtkj", "bvhfawcnyoqxuhzrpgsleimcki", "bvhfvwcnyoqxudzizgsleimtkj", "bvhfapznyohxudzrpgsleimtkj", "bvhfaelnyosxudzrpgsleimtkj", "xvhfawcnmoqxuhzrpgsleimtkj", "bjhfawcnyaqxutzrpgsleimtkj", "bvhfawcnyohxudzrpgslgnmtkj", "bvhfawcnyoqxudzrppsreimtkx", "fvhfapcnyoqyudzrpgsleimtkj", "qvhfafcnyoqxudorpgsleimtkj", "bvhfawcnyoqxedzrwgsleimtvj", "bvhfawgnyoqxudzupgqleimtkj", "bvhfowctyoqxudzrpgbleimtkj", "bvhwawcnyoqxudzapgslvimtkj", "bvhfadcnyoqxudzrugsleimtuj", "bvhfawcnyosxudzlpgsleamtkj", "bvhfawcnywqxuqzrpgsloimtkj", "bvhfawcnyoqxumzrpgvlfimtkj", "bvhfawcgyoqxbdzrpgsleomtkj", "bvhfahcnyoqwudzrfgsleimtkj", "gvbfawcnyrqxudzrpgsleimtkj", "svhfawcnyoqxudlrpgsleimtkx", "avhfafcnyoqxuhzrpgsleimtkj", "bvhfawcsyoqxuazrpgsleimtej", "bvofawcnyoqxudzrpgsteimtkf", "bvhfajcnyoqxudzqpgszeimtkj", "bvhfawcsyoqxudzrmgsleiktkj", "mvhfawcnyoqxudzrpgkluimtkj", "bvhfawcnhoqxudzrpgslwhmtkj", "bmhaawsnyoqxudzrpgsleimtkj", "bvhfawcnyoqxudzhpgsleimhyj", "bvhfxwcnyoqxsdzypgsleimtkj", "bvhpawcyyoqxuczrpgsleimtkj", "bvomawcnyovxudzrpgsleimtkj", "bvhfawcnjvqxudzrpgsleimtkt", "nvhfawcnyqqxudzrpgsleittkj", "bvhiawcnyzqxudzrpysleimtkj", "bvhdawcnyoqxukzrpgsleimtuj", "bvhfawcnyyxxudzrpgslzimtkj", "hvhfawcnyoqxudzupgslemmtkj", "byhfawknyoqxudzrpgsleimtkb", "bvhfawcnyoqxudzrpasleihakj", "bvafahcnyaqxudzrpgsleimtkj", "bkhfawcnyoqxudzrpgllepmtkj", "bghfawcnycqxuzzrpgsleimtkj", "bvhfawcnyoqxudzrbgeleimtkl", "bvhfascnyoqgudzrpgsveimtkj", "bvhfawnnyoqxudzrpgsleimtdl", "bvhqawcnyoqxudzrpgsleimgrj", "bvhsawdwyoqxudzrpgsleimtkj", "bvhfawcnyoqxudzrpgaleipttj", "bvhfawcnrlqxudzrbgsleimtkj", "bvhfdwcnyoqxudzqpcsleimtkj", "bvhfawcnyoqxudzopgslexmokj", "bvhfawcoyoqxudzrpghlewmtkj", "bvhfozcnykqxudzrpgsleimtkj", "bvhfawcnyoqxuvzrpgslrimtkr", "bvhfrncnyoqrudzrpgsleimtkj", "bvhfawcnyocxuizrpgslefmtkj", "bvhfawywyoqxudzrpgsleimxkj", "bvhfawcnyoqxugzrpgslrimtij", "bvtfawcnyoqxudzcpgsleimtfj", "bvhfawcnyoqxuzzspgsleimtkz", "bvhfawcnzoqxvdzrpgslsimtkj", "bvhfzwcnyoqxudzrpgslenmhkj", "bvhfkccnyoqxudzrpgzleimtkj", "bvhfawcnyoqzudzrpgslhimwkj", "bzhfawvnyooxudzrpgsleimtkj" };

            foreach (string boxId in boxIds)
            {
                var charArray = boxId.ToCharArray();
                foreach (char charcter in charArray)
                {
                    if (characterCounts.ContainsKey(charcter))
                    {
                        characterCounts.TryGetValue(charcter, out var value);

                        characterCounts.Remove(charcter);
                        value = value + 1;
                        characterCounts.Add(charcter, value);
                    }
                    else
                    {
                        characterCounts.Add(charcter, 1);
                    }

                }

                if (characterCounts.ContainsValue(2))
                {
                    twiceRepeatedLetters++;
                }
                if (characterCounts.ContainsValue(3))
                {
                    threeTimesRepeatedLetters++;
                }

            }

            Console.WriteLine(twiceRepeatedLetters * threeTimesRepeatedLetters);
        }
    }
}
