using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe
{
    class Program
    {
        #region Funkcje pomocnicze

        #region Funkcja prezentująca zawartość tablicy jednowymiarowej.
        static void printTable(int[] table)
        {
            Console.WriteLine();
            foreach (int i in table)
                Console.Write(i + " ");
        }
        #endregion

        #region Funkcja prezentująca zawartość tablicy dwuwymiarowej.
        static void printTable2D(int[,] table2D)
        {
            Console.WriteLine();
            for (int i = 0; i < table2D.GetLength(0); i++)
            {
                for (int j = 0; j < table2D.GetLength(1); j++)
                    Console.Write(" " + table2D[i, j]);
                Console.WriteLine();
            }
        }
        #endregion

        #region Funkcja porządkująca tablicę.
        static void display2Darray(int[,] table2D)
        {
            for (int i = 0; i < table2D.GetLength(0); i++)
            {
                for (int j = 0; j < table2D.GetLength(1); j++)
                {
                    Console.Write(" {0,-2}", table2D[i, j]);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Funkcja resetująca tablicę.
        static void resetArray(ref int[] table)
        {
            table = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
        #endregion

        #endregion

        #region ✓1.1 Funkcja zwracająca maksymalny element tablicy.
        static int getMaxValue(int[] table)
        {
            int max = table[0];
            for (int i = 1; i < table.Length; i++)
            {
                if (table[i] > max)
                    max = table[i];
            }
            return max;
        }
        #endregion

        #region ✓1.2 Funkcja zwracająca maksymalny element tablicy, jedynie dla parzystych indeksów.
        static int getMaxValueUnderParityIndex(int[] table)
        {
            int max = table[0];
            for (int i = 0; i < table.Length; i += 2)
            {
                if (table[i] > max)
                {
                    max = table[i];
                }
            }
            return max;
        }
        #endregion

        #region ✓1.3 Funkcja zwracająca indeks, znajduje element maksymalny.
        static int whereIsMaxValue(int[] table)
        {
            int index = 0;
            int max = table[0];
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > max)
                {
                    max = table[i];
                    index = i;
                }
            }
            return index;
        }
        #endregion

        #region ✓1.4 Funkcja zwracjąca, wartość minimalną albo maksymalną tablicy, w zależności od 2 parametru, przekazanej jej jako 1 argument wywołania.
        static int getValue(int[] table, bool min_or_max)
        {
            int mom = table[0];
            if (min_or_max) // minimalna wartość tablicy
            {
                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i] < mom)
                        mom = table[i];
                }
            }
            else // maksymalna wartość tablicy
            {
                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i] > mom)
                        mom = table[i];
                }
            }
            return mom;
        }
        #endregion

        #region ✓1.5 Funkcja zwracająca sumę elementów tablicy.
        static int getSumOfValues(int[] table)
        {
            int suma = 0;
            for (int i = 0; i < table.Length; i++)
            {
                suma += table[i];
            }
            return suma;
        }
        #endregion]

        #region ✓1.6 Funkcja rotująca cyklicznie o 1 element tablicy.
        static int rotateTable(int[] table)
        {
            int oe = table[table.Length - 1]; // oe - ostatni element tablicy
            for (int i = table.Length - 1; i > 0; i--)
                table[i] = table[i - 1];
            table[0] = oe;
            return 0;
        }
        #endregion

        #region ✓1.7 Funkcja zwracająca dziesiętną reprezentację przekazanego jej parametru tablicowego.
        static int getDecimalValue(int[] table)
        {
            int wynik = 0;
            for (int i = table.Length - 1; i >= 0; i--)
                wynik += table[i] * (int)Math.Pow(2, table.Length - 1 - i);
            return wynik;
        }
        #endregion

        #region ✓1.8 Funkcja transponująca tablicę dwuwymiarowa.
        static int transposeTable(int[,] table2D)
        {
            int tmp;
            for (int i = 0; i < table2D.GetLength(0); i++)
                for (int j = i; j < table2D.GetLength(1); j++)
                {
                    tmp = table2D[i, j];
                    table2D[i, j] = table2D[j, i];
                    table2D[j, i] = tmp;
                }
            return 0;
        }
        #endregion

        #region ✓1.9 Funkcja zwracająca średnią arytmetyczną.
        static float getArithAverage(int[] table)
        {
            int suma = 0;
            int ilosc = table.Length;
            for (int i = 0; i < table.Length; i++)
            {
                suma += table[i];
            }
            return suma / ilosc;

        }
        #endregion

        #region ✓1.10 Funkcja, która przekształca elementy tablicy, tak, aby stanowiły lustrzane odbicie tablicy oryginalnej.
        static void makeMirrorTable(int[] table)
        {
            for (int i = 0; i < table.Length / 2; i++)
            {
                int tmp = table[i];
                table[i] = table[table.Length - 1 - i];
                table[table.Length - 1 - i] = tmp;
            }
        }
        #endregion

        #region ✓1.11 Funkcja, która zamienia miejscami elementy maksymalny i minimalny tablicy.
        static void exchangeMinMax(int[] table)
        {
            int min = table[0];
            int minIndex = 0;
            int max = table[0];
            int maxIndex = 0;

            for (int i = 0; i < table.Length; i++)
            {
                if (max < table[i])
                {
                    max = table[i];
                    maxIndex = i;
                }
                else
            if (min > table[i])
                {
                    min = table[i];
                    minIndex = i;
                }
            }
            table[maxIndex] = min;
            table[minIndex] = max;
        }
        #endregion

        #region ✓1.12 Funkcja, która zeruje elementy tablicy, które są podzielne przez 3 bez reszty.
        static void insertZeros(int[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] % 3 == 0)
                {
                    table[i] = 0;
                }
            }
        }
        #endregion

        #region *1.13 Funkcja, która wykonuje działanie ExOR.
        static void doExORTable(int[] binaryTable)
        {
            int[] tmp = binaryTable;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (binaryTable[i + 1] != binaryTable[i - 1]) tmp[i] = 1; //jesli nie sa takie same
                else tmp[i] = 0; // jesli sa takie same
            }
        }
        #endregion

        #region ✓1.14 Funkcja, która uczyni z zadanej tablicy macierz jednostkową.
        static void makeIdentity(int[,] table2D)
        {
            for (int i = 0; i < table2D.GetLength(0); i++)
            {
                for (int j = 0; j < table2D.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        table2D[i, j] = 1;
                    }
                    else
                        table2D[i, j] = 0;
                }
            }
        }

        #endregion

        #region ✓1.15 Funkcja, która wypełni tablicę dwuwymiarową, tak aby stanowiła zapis tabliczki mnożenia.
        static void makeMatrixProduct(int[,] table2D)
        {
            for (int i = 0; i < table2D.GetLength(0); i++)
            {
                for (int j = 0; j < table2D.GetLength(1); j++)
                {
                    table2D[0, j] = j + 1;
                    table2D[i, 0] = i + 1;
                }
            }
            for (int i = 1; i < table2D.GetLength(0); i++)
            {
                for (int j = 1; j < table2D.GetLength(1); j++)
                {
                    table2D[i, j] = table2D[0, j] * table2D[i, 0];
                }
            }
        }


        #endregion

        #region ✓1.16 Funkcja, która zwraca sumę elementów wiersza i kolumny.
        static int getRowColSum(int[,] table2D, int row, int col)
        {
            int suma = 0;
            for (int i = 0; i < table2D.GetLength(0); i++)
            {
                suma += table2D[row, i];
                suma += table2D[i, col];
            }
            return suma;
        }
        #endregion

        #region ✓2.1 Funkcja sprawdzająca, czy parametr jej wywołania, zawiera palindrom.
        static bool isPalindrome(string text)
        {
            string tmp = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                tmp += text[i];
            }
            if (tmp == text)
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region ✓2.2 Funkcja usuwająca wszystkie białe znaki z tekstu.
        static string trimSpaces(string text)
        {
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    tmp += text[i];
                }
            }
            return tmp;
        }
        #endregion

        #region ✓2.3 Funkcja przekształcaja tekst na jego lustrzane odbicie.
        static string reverseText(string text)
        {
            string tmp = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                tmp += text[i];
            }
            return tmp;
        }
        #endregion

        #region ✓2.4 Funkcja zamieniająca wszystkie początkowe litery wyrazów na duże.
        static string toUpper(string text)
        {
            string tmp = "";
            string pom = "";
            for (int i = 0; i < text.Length; i++)
            {
                pom = "";
                pom += text[i];
                if (i == 0) tmp += pom.ToUpper();
                else
                if (text[i - 1] == ' ')
                {
                    tmp += pom.ToUpper();
                }
                else
                    tmp += pom;
            }
            return tmp;
        }
        #endregion

        #region ✓2.5 Funkcja usuwająca z tekstu określony wyraz - tekst jako pierwszy, a cyfry jako drugi parametr.
        static string deleteFromString(string text, int number)
        {
            string delete = ""; // usuwany element
            int parametr = 0;
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && i == 0)
                {
                    parametr++;
                    if (number == parametr)
                    {
                        delete += text[i];
                    }
                    else
                        tmp += text[i];
                }
                else if (text[i] == ' ' && text[i + 1] != ' ')
                {
                    parametr++;
                    if (number != parametr)
                        tmp += " ";
                }
                else if (number == parametr)
                {
                    delete += text[i];
                }
                else
                {
                    tmp += text[i];
                }
            }
            text = tmp;
            return delete;
        }
        #endregion

        #region ✓2.6 Funkcja, która zwraca wartość liczbową parametru wywołania typu string.
        static long extractNumberFromString(string text)
        {
            long tmp = Convert.ToInt64(text);
            return tmp;
        }
        #endregion

        #region ✓2.7 Funkcja dwuparametrową, gdzie pierwszy z nich jest tekstowo częsią całkowitą, drugi ułamkową liczby rzeczywistej.
        static float extractNumberFromString(string integral, string fractional)
        {
            float calkowita = Convert.ToSingle(integral);
            float ulamkowa = Convert.ToSingle(fractional) / (float)Math.Pow(10, fractional.Length);
            return calkowita + ulamkowa;
        }
        #endregion

        #region ✓2.8 Funkcja zliczająca liczbę samogłosek w tekście.
        static int extractNumberOfVowels(string text)
        {
            int samogloski = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'y' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    samogloski++;
                }
            }
            return samogloski;
        }
        #endregion

        #region ✓2.9 Funkcja zwracająca pierwsze wystąpienie poszukiwanego znaku w tekście.
        static int getCharIndex(string text, char mark)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == mark) return i;
            }
            return -1;
        }
        #endregion

        #region ✓2.10 Funkcja zwracająca liczbę wyrazów zawartych w tekście.
        static int getWordsNumber(string text)
        {
            int ilosc = 0;
            if (text.Length == 0)
                return 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != ' ' && i == 0)
                {
                    ilosc++;
                }
                if (text[i] == ' ' && text[i + 1] != ' ')
                {
                    ilosc++;
                }
            }
            return ilosc;
        }
        #endregion

        #region ✓2.11 Funkcja, która na podstawie analizy tekstu, identyﬁkowała płeć osoby.
        static bool isMale(string text)
        {
            if (text[text.Length - 1] == 'a')
                return false;
            else
                return true;
        }

        #endregion

        #region ✓2.12 Funkcja, która umieszcza znaki spacji w tekście, przy każdym wyrazie rozpoczynającą się wielką literą.
        static string insertSpaces(string text)
        {
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Convert.ToInt16(text[i]) < 97 && i > 0)
                {
                    tmp += " " + text[i];
                }
                else
                    tmp += text[i];
            }
            return tmp;
        }
        #endregion

        #region ✓2.13 Funkcja, która wprowadzająca do tekstu wyraz, wpisując numer spacji, po której wyraz należy umiejscowić.
        static string insertWord(string text, string word, int spaceIndex)
        {
            string tmp = "";
            int numer = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    numer++;
                    if (numer == spaceIndex)
                    {
                        tmp += " " + word + " ";
                    }
                    else
                        tmp += ' ';
                }
                else
                    tmp += text[i];
            }
            return tmp;
        }
        #endregion

        #region ✓2.14 Funkcja zamieniająca wszystkie wielkie litery, na ich małe odpowiedniki.
        static string toLower(string text)
        {
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ((char)text[i] >= 'A' && (char)text[i] <= 'Z')
                {
                    tmp += (char)(text[i] + 'Z' - 'A' + 7);
                }
                else
                {
                    tmp += text[i];
                }
            }

            return tmp;

        }
        #endregion

        #region *2.15 Funkcja, która dokonuje konwersji liczby zapisanej w postaci tekstu, do wartości liczby całkowitej.
        static int convertFromStringToNumber(string number)
        {
            int liczba = 0;
            for (int i = 0; i < number.Length; i++)
            {
                liczba += ((int)number[i] - 48) * (int)Math.Pow(10, number.Length - 1 - i);
            }
            return liczba;
        }
        #endregion

        #region ✓2.16 Funkcja kodującą tekst szyfrem Cezara.
        static string caeserCipher(string text)
        {
            char[] tmp = text.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                char litera = tmp[i];
                bool duzy = false;
                if (litera <= 'Z' && litera >= 'A') duzy = true;
                litera = (char)(litera + 2);
                if (duzy)
                {
                    if (litera > 'Z')
                    {
                        litera = (char)(litera - 26);
                    }
                    else if (litera < 'A')
                    {
                        litera = (char)(litera + 26);
                    }
                }
                else
                {
                    if (litera > 'z')
                    {
                        litera = (char)(litera - 26);
                    }
                    else if (litera < 'a')
                    {
                        litera = (char)(litera + 26);
                    }
                }
                tmp[i] = litera;
            }
            return new string(tmp);
        }
        #endregion

        #region ✓3.1 Funkcja zwracająca wartość potęgi liczby 2.
        static long powerOfTwo(int exp)
        {
            long potega = 1;
            for (int i = 0; i < exp; i++)
            {
                potega *= 2;
            }
            return potega;
        }
        #endregion

        #region ✓3.2 Funkcja zwracająca wartość potęgi liczby, przekazanej jako jej pierwszy parametr.
        static long powerOfNumber(int number, int exp)
        {
            long potega = 1;
            for (int i = 0; i < exp; i++)
            {
                potega *= number;
            }
            return potega;
        }
        #endregion

        #region ✓3.3 Funkcja do konwersji systemu liczenia z dwójkowego na dziesiętny.
        static int convertToDecimal(string binary)
        {
            int dziesietna = 0;
            int pom = 0;
            int binaryInt = Convert.ToInt16(binary);
            while (pom < binary.Length)
            {
                int ostatnia = binaryInt % 10;
                binaryInt = binaryInt / 10;
                if (ostatnia != 0)
                {
                    dziesietna += (int)Math.Pow(2, pom);
                }
                pom++;
            }
            return dziesietna;
        }
        #endregion

        #region *3.4 Funkcja, która zwraca iloczyn logiczny dwóch argumentów boolowskich. 
        static int makeMulti(bool val1, bool val2)
        {
            int val1Int = Convert.ToInt16(val1); //convert argumentu 1
            int val2Int = Convert.ToInt16(val2); //convert argumentu 2
            return val1Int * val2Int;
        }
        #endregion

        #region ✓3.5 Funkcja, która zwraca wartość n-tego elementu skończonego ciągu arytmetycznego.
        static float getNElementValue(float a1, float a2, int an)
        {
            float r = a2 - a1;
            float wynik = a1 + (an - 1) * r;
            return wynik;
        }
        #endregion

        #region ✓3.6 Funkcja, która zwraca sumę elementów skończonego ciągu arytmetycznego dla pewnego n.
        static float getSumOfElements(float a1, float a2, int n)
        {
            float r = a2 - a1;
            float wynik = ((2 * a1 + (n - 1) * r) / 2) * n;
            return wynik;
        }
        #endregion

        #region *3.7 Funkcja rekurencyjną, obliczającą n-ty element ciągu Fibonacciego.
        static long fibo(int n) // static float fibo ( float f0 , float f2 , int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return fibo(n - 1) + fibo(n - 2);
        }
        #endregion

        #region ✓3.8 Funkcja, która sprawdza czy parametr przekazany w jej wywołaniu jest liczbą pierwszą.
        static bool checkPrimary(int number)
        {
            bool cp = true; // cp - "czy liczba" jest pierwsza
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) cp = false;
            }
            return cp;
        }
        #endregion

        #region ✓3.9 Funkcja, która zwraca sumę logiczną dwóch argumentów boolowskich bez użycia operacji sumy logicznej.
        static bool makeLogicSum(bool val1, bool val2)
        {
            int val1Int = Convert.ToInt16(val1); // convert argumentu 1
            int val2Int = Convert.ToInt16(val2); // convert argumentu 2
            int suma = val1Int + val2Int;
            return suma > 0;
        }
        #endregion

        #region ✓3.10 Funkcja, która zwraca informacje o liczbie pierwiastków równania kwadratowego.
        static int getRootsNumber(float a, float b, float c)
        {
            float delta = (b * b) - 4 * a * c; // liczymy deltę funkcji
            if (delta < 0)
                return 0; // brak miejsc zerowych
            else if (delta == 0)
                return 1; // miejsce zerowe 1
            else
                return 2; // miejsce zerowe 2
        }
        #endregion

        #region ✓3.11 Funkcja zwracająca wartość silni dla parametru n rekurencyjnie.
        static long factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * factorial(n - 1);
        }
        #endregion

        #region ✓3.12 Funkcja, zwracająca moduł wartości parametru jej wywołania.
        static float absoluteValue(float number)
        {
            if (number > 0) return number;
            else
                return -number;
        }
        #endregion

        #region ✓3.13 Funkcja zwracająca część całkowitą liczby rzeczywistej przekazanej jej przez parametr.
        static int getIntegerFromReal(float number)
        {
            return (int)number;
        }
        #endregion

        #region ✓3.14 Funkcja zwracająca liczbę cyfr dziesiętnych liczby przekazanej jej jako parametr wywołania.
        static int getDecimalDigits(int number)
        {
            int licznik = 1;
            while (number / 10 > 0)
            {
                licznik++;
                number /= 10;
            }
            return licznik;
        }
        #endregion

        #region ✓3.15 Funkcja zwracająca odwrotność liczby przekazanej jej przez parametr.
        static double inverseNumber(double number)
        {
            if (number == 0)
            {
                Console.WriteLine("Niestety przez 0 nie można dzielić.");
                return 0;
            }
            else
                return 1 / number;
        }
        #endregion

        #region ✓3.16 Funkcja zwracająca liczbę przeciwną do liczby przekazanej jej przez parametr.
        static int reverseNumber(int number)
        {
            return -number;
        }
        #endregion

        static void Main(string[] args)
        {
            #region 1.1 - 1.16 Main
            int[] table = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] binary = { 1, 0, 1, 1 };
            int[,] table2D = new int[10, 10];
            for (int i = 0; i < table2D.GetLength(0); i++)
            {
                for (int j = 0; j < table2D.GetLength(1); j++)
                {
                    table2D[i, j] = i * table2D.GetLength(0) + j;
                }
            }

            Console.WriteLine("Tablica binarna: ");
            printTable(binary);
            Console.WriteLine();
            Console.WriteLine("\nWyznaczenie wartości dziesiętnej elementów binarnych tablicy −> " + getDecimalValue(binary));

            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nTablica jednowymiarowa: ");
            printTable(table);

            Console.WriteLine();
            Console.WriteLine("\nTablica rotująca cyklicznie o 1 element tablicy: ");
            rotateTable(table);
            printTable(table);

            Console.WriteLine();
            Console.WriteLine("\nOdbicie lustrzane tablicy:");
            resetArray(ref table);
            makeMirrorTable(table);
            printTable(table);

            Console.WriteLine();
            Console.WriteLine("\nZamiana elementu tablicy najmniejszego z największym:");
            resetArray(ref table);
            exchangeMinMax(table);
            printTable(table);

            Console.WriteLine();
            Console.WriteLine("\nWyzerowane elementy tablicy, które są podzielne przez 3 bez reszty:");
            resetArray(ref table);
            insertZeros(table);
            printTable(table);

            //Console.WriteLine();
            //Console.WriteLine("\nFunkcja ExOR dla tablicy binarnej:");
            //doExORTable(binary);
            //printTable(binary);

            Console.WriteLine("\n_____________________________________________________________________________________________________________");
            Console.WriteLine("\nSuma elementow tablicy −> " + getSumOfValues(table));
            Console.WriteLine("\nElement minimalny tablicy −> " + getValue(table, true));
            Console.WriteLine("\nElement maksymalny tablicy −> " + getValue(table, false));
            Console.WriteLine("\nElement maksymalny znajduje sie w tablicy pod indeksem −> " + whereIsMaxValue(table));
            Console.WriteLine("\nElement maksymlany dla parzystego indeksu tablicy −> " + getMaxValueUnderParityIndex(table));
            Console.WriteLine("\nElement maksymalny tablicy − > " + getMaxValue(table));
            Console.WriteLine("\nŚrednia artymaetyczna tablicy -> " + getArithAverage(table));

            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nTablica dwuwymiarowa: ");
            Console.WriteLine();
            display2Darray(table2D);

            Console.WriteLine();
            Console.WriteLine("\nTablica dwuwymiarowa transponowana: ");
            Console.WriteLine();
            transposeTable(table2D);
            display2Darray(table2D);

            Console.WriteLine();
            Console.WriteLine("\nZamiana tablicy dwuwymiarowej na macierz jednostkową:");
            Console.WriteLine();
            makeIdentity(table2D);
            display2Darray(table2D);

            Console.WriteLine();
            Console.WriteLine("\nZamiana talbicy dwuwymiarowej na tabliczkę mnożenia:");
            Console.WriteLine();
            makeMatrixProduct(table2D);
            display2Darray(table2D);

            Console.WriteLine("\nSuma elementów wiersza i kolumny tablicy dwuwymiarowej -> " + getRowColSum(table2D, 0, 0));
            #endregion

            #region 2.1 - 2.16 Main
            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nCzy podane słowo ('kajak') jest palindromem?");
            if (isPalindrome("kajak"))
            {
                Console.WriteLine("Tak, jest to palindrom!");
            }
            else
                Console.WriteLine("Niestety, nie jest.");

            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nCzy 'Karol' to męskie imię? " + isMale("Karol"));

            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nNazwa uczelni od tyłu -> " + reverseText("WSEI"));
            Console.WriteLine("\nUsuwanie spacji w zdaniu -> " + trimSpaces("Kto by chciał usuwać spacje ?"));
            Console.WriteLine("\nWstawianie spacji w odpowiednie miesjca w zdaniu -> " + (insertSpaces("StudenciNaszejUczelniZawszePilnieSięUczą") + "."));
            Console.WriteLine("\nKorekta wielkości liter na małe -> " + toLower("CieKAWe jak poradzi SOBie Student Z tYm zadanieM? śWieTNie sOBie pOraDził."));
            Console.WriteLine("\nKorekta pierwszych liter z małych na duże -> " + toUpper("wyższa szkoła ekonomii i informatyki"));
            Console.WriteLine("\nWstawienie przysłówka 'pilnie' jako drugie słowo -> " + insertWord("Student WSEI uczy się programować.", "pilnie", 2));
            Console.WriteLine("_____________________________________________________________________________________________________________");

            Console.WriteLine("\nLiczba 3.1415 to -> {0}", extractNumberFromString("3", "1415"));
            Console.WriteLine("\nWartość liczbowa typu string -> " + extractNumberFromString("1997"));
            Console.WriteLine("\nKonwersja liczby zapisanej w postaci tekstu, do wartości liczby całkowitej -> " + convertFromStringToNumber("1234"));

            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nDane jest zdanie: 'Stół z powyławymanymi nogami'.");
            Console.WriteLine("a) Podaj ile jest samogłosek w zdaniu.");
            Console.WriteLine("b) Podaj ile liter 'a' jest w zdaniu.");
            Console.WriteLine("c) Podaj ile jest słow w zdaniu.");
            Console.WriteLine("d) Podaj trzeci wyraz zdania.");
            Console.WriteLine("\na) Ilość samogłosek w podanym zdaniu -> {0} ", extractNumberOfVowels("Stół z powyławymanymi nogami."));
            Console.WriteLine("b) Ilość liter 'a' w podanym zdaniu wynosi -> " + getCharIndex("Stół z powyławymanymi nogami.", 'a'));
            Console.WriteLine("c) Ilość słów w zdaniu -> " + getWordsNumber("Stół z powyławymanymi nogami."));
            Console.WriteLine("d) Trzecim wyrazem zdania jest -> " + deleteFromString("Stół z powyławymanymi nogami.", 3));

            Console.WriteLine("_____________________________________________________________________________________________________________");
            Console.WriteLine("\nPrzykłady kodowania szyfrem cezara: ");
            Console.WriteLine("\nWSEImobile -> " + caeserCipher("WSEImobile"));
            Console.WriteLine("StudenciInformatyki -> " + caeserCipher("StudenciInformatyki"));
            Console.WriteLine("ABCDEFGHIJKLMNOPRSTUWXYZ -> " + caeserCipher("ABCDEFGHIJKLMNOPRSTUWXYZ"));
            Console.WriteLine("_____________________________________________________________________________________________________________");
            #endregion

            #region 3.1 - 3.16 Main
            Console.WriteLine("\nDany jest ciąg arytmetyczny (3, 7, n). \na) Oblicz wartosć n-tego elementu ciągu. \nb) Oblicz sumę elementów tego ciągu.");
            Console.WriteLine("\na) Wartosć n-tego elementu ciągu wynosi -> " + getNElementValue(3, 7, 3));
            Console.WriteLine("b) Suma elementów tego ciągu wynosi -> " + getSumOfElements(3, 7, 3));
            Console.WriteLine("_____________________________________________________________________________________________________________");

            Console.WriteLine("\nDana jest funkcja f(x) = 2x^2 + 4x + 1. \nIle ma miejsc zerowych?");
            Console.WriteLine("\nFunkcja ma " + getRootsNumber(2, 4, 1) + " miejsca zerowe.");
            Console.WriteLine("_____________________________________________________________________________________________________________");

            Console.WriteLine("\nWartość liczby 2 do potęgi 10 wynosi -> " + powerOfTwo(10));
            Console.WriteLine("\nWartość liczby 3 do potęgi 6 wynosi -> " + powerOfNumber(3, 6));
            Console.WriteLine("\nLiczba 1001 w systemie dziesiętnym wynosi -> " + convertToDecimal("1001"));
            Console.WriteLine("\nIloczyn logiczny dwóch argumentów boolowskich -> " + makeMulti(true, false));
            Console.WriteLine("\nWartość 9! wynosi -> " + factorial(9));
            Console.WriteLine("\nWartość bezwzględna liczby -9 wynosi -> " + absoluteValue(-9));
            Console.WriteLine("\nDziewiąty element ciągu Fibbonaciego wynosi -> " + fibo(9));
            Console.WriteLine("\nCzęść całkowita liczby 20.16 -> " + getIntegerFromReal(20.16f));
            Console.WriteLine("\nIle cyfr ma liczba 2016? -> " + getDecimalDigits(2016));
            Console.WriteLine("\nOdrotność liczby 4 wynosi -> " + inverseNumber(4));
            Console.WriteLine("\nPrzeciwność liczby 9 wynosi -> " + reverseNumber(9));
            Console.WriteLine("\nCzy 5 jest liczbą pierwszą? {0}", string.Format("{0}", checkPrimary(5)));
            Console.WriteLine("\nSuma logiczna dwóch argumentów boolowskich -> " + makeLogicSum(true, false));
            #endregion

            Console.ReadKey();
        }
    }
    //Copyright © by:              Karol Bronowski
    //Code of the laboratory:      inf1A/1/IE/S
    //Number of album:             10502
}