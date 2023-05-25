using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projekcik
{
    public class WordOperation
    {
        public string[] allWords = { "dzienciol", "kapibara", "kot", "pies", "homik" };

        string fileName = "words.csv";
        public char blind = '*';
        public string word = "";
        public int wordLen;
        public char[] usWordCh;
        public string usWordS;
        public string haslo;
        public int errMax = 11;
        public int errCount = 0;
        public char[] errCh;
        public string errS = "";
        public bool game, win, charFound;

        public WordOperation()
        {
            allWords = File.ReadAllLines(fileName);

            Random rand = new Random();
            int allWordsLen = allWords.Length;
            int random = rand.Next(allWordsLen);
            word = allWords[random];
            wordLen = word.Length;
            usWordCh = new char[wordLen];

            for(int i = 0; i < wordLen; i++)
            {
                usWordCh[i] = blind;
            }
            haslo = new String(usWordCh);
            errMax = 11;
            errCount = 0;
            errCh = new char[errMax];
            game = true;
        }
        /*public void Play(string s)
        {
            char c;
            if (s.Length > 0)
            {
                c = s[0];
            }
            else return;

            charFound = false;
            win = false;

            for(int i = 0; i < wordLen; i++)
            {
                if(c == word.ElementAt(i))
                {
                    usWordCh[i] = c;
                    charFound = true;
                }
            }

            bool errCharFound = false;

            if (!charFound)
            {
                errCount += 1;
                for(int i = 0; i < errCh.Length; i++)
                {
                    if(errCh[i] == c)
                    {
                        errCharFound = true;
                        break;
                    }
                }
                if (!errCharFound)
                {
                    for(int i = 0; i < errCh.Length; i++)
                    {
                        if (errCh[i] == 0)
                        {
                            errCh[i] = c;
                            break;
                        }
                    }
                }
            }
            for(int i = 0; i < wordLen; i++)
            {
                if (usWordCh[i] == blind)
                {
                    win = false;
                    break;
                }
                win = true;
            }

            usWordS = new String(usWordCh);
            errS = new String(errCh);

            if(errCount == errMax)
            {
                game = false;
            }
            if (win)
            {
                game = false;
            }
        }*/
    }
}
