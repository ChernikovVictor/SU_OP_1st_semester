using System;
using System.ComponentModel;

namespace ConsoleApplication1
{
    public class MyClass
    {
        private string st;

        public string St
        {
            get { return st; }
            set { st = value; }
        }
        
        public MyClass(){}

        public MyClass(string st)
        {
            this.st = st;
        }

        public int AmtOfLetters()
        {
            int k = 0;
            foreach (char ch in st)
            {
                k = (char.IsLetter(ch)) ? k + 1 : k;
            }
            return k;
        }

        // получить слово из строки. fp - first position of letter, lp - last position of letter
        private void GetWord(ref int fp, ref int lp)
        {
            while (fp < st.Length && !char.IsLetter(st[fp]))
                fp++;
            lp = fp;
            while (lp < st.Length && char.IsLetter(st[lp]))
                lp++;
            lp--;
        }

        public double AverageLengthOfWord()
        {
            int k = 0, len = 0;
            int i = 0, j = 0;
            while (i < st.Length)
            {
                GetWord(ref i, ref j);
                if (j >= i)
                {
                    len += j - i + 1;
                    k++;
                }
                i = j + 1;
            }
            return k == 0 ? 0 : Convert.ToDouble(len) / Convert.ToDouble(k);
        }

        public void ReplaceWords(string old_word, string new_word)
        {
            int i = 0, j = 0;
            while (i < st.Length)
            {
                GetWord(ref i, ref j);
                if (j >= i && st.Substring(i, j - i + 1) == old_word)
                {
                    st = st.Remove(i, j - i + 1);
                    st = st.Insert(i, new_word);
                    i += new_word.Length;
                }
                else
                    i = j + 1;
            }
        }

        public int AmtOfSubstr(string subsrt)
        {
            int k = 0;
            for (int i = 0; i <= st.Length - subsrt.Length; i++)
                if (st.Substring(i, subsrt.Length) == subsrt)
                    k++;
            return k;
        }

        public bool IsPalindrome()
        {
            int i = 0, j = st.Length - 1;
            while (i < j)
            {
                while (i < j && !char.IsLetter(st[i]))
                    i++;
                while (j > i && !char.IsLetter(st[j]))
                    j--;
                if (char.ToLower(st[i]) != char.ToLower(st[j]))
                    return false;
                i++;
                j--;
            }
            return true;
        }

        public bool IsDate()
        {
            if (st.Length != 8 && st.Length != 10)
                return false;
            if (char.IsDigit(st[0]) && char.IsDigit(st[1]) && st[2] == '.' && char.IsDigit(st[3]) &&
                char.IsDigit(st[4]) && st[5] == '.' && char.IsDigit(st[6]) && char.IsDigit(st[7]))
            {
                if (st.Length == 10 && !(char.IsDigit(st[8]) && char.IsDigit(st[9])))
                    return false;
                if (char.GetNumericValue(st[3]) > 1)
                    return false;
                if (char.GetNumericValue(st[3]) == 1 && char.GetNumericValue(st[4]) > 2)
                    return false;
                if (char.GetNumericValue(st[0]) > 3)
                    return false;
                if (char.GetNumericValue(st[0]) == 3 && char.GetNumericValue(st[1]) > 1)
                    return false;
                if (char.GetNumericValue(st[3]) == 0 && char.GetNumericValue(st[4]) == 2 &&
                    char.GetNumericValue(st[0]) > 2)
                    return false;
                return true;
            }
            return false;
        }
    }
}