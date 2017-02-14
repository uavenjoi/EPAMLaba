using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Dictionary1._0
{
    class Program
    {
        //Все вычисления нужно помещать в отдельные методы. 
        static void Main(string[] args)
        {
            string str = Console.ReadLine();//входные данные

            Vychislenie vych = new Vychislenie();
            List<object> list = vych.Processing(str);//здесь уже нарезанная строка
            int i1 = 1;
            int i2 = 1;
            double d1 = 1;
            double d2 = 1;

            if (list[1].GetType() != typeof(Do))//проверка на наличие знака(+-*/) между значениями
            {
                throw new Exception("Ошибка синтаксиса");
            }

            if ((typeof(string) == list[0].GetType()) && (list[0].GetType() == list[2].GetType()))//если оба значения строки
            {
                Console.WriteLine(vych.SummaStr(list));
                Console.ReadLine();
            }
            if ((typeof(string) != list[0].GetType()) && (typeof(string) != list[2].GetType()))//если оба значения не стороки
            {
                //определяем конкретные типы значений и заполняем нужные
                if (list[0].GetType() == typeof(int))
                {
                    i1 = (int)list[0];
                    if (list[2].GetType() == typeof(int))
                    {
                        i2 = (int)list[2];
                    }
                    else d2 = (double)list[2];
                }
                else d1 = (double)list[0];
                if (list[2].GetType() == typeof(int))
                {
                    i2 = (int)list[2];
                }
                else d2 = (double)list[2];

                Do d = (Do)list[1];//процесс вычисления
                if (d == Do.Add)
                {
                    Console.WriteLine(i1 + i2 + d1 + d2 - 2);
                }
                d = (Do)list[1];
                if (d == Do.Division)
                {
                    Console.WriteLine(i1 - i2 - d1 - d2 + 2);
                }
                if (d == Do.Multipc)
                {
                    Console.WriteLine(i1 * i2 * d1 * d2);
                }
                if (d == Do.Subtr)
                {
                    Console.WriteLine(i1 / i2 / d1 / d2);
                }
            }
            else throw new Exception("Ошибка синтаксиса");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
enum Do 
{
    Add,Subtr,Multipc,Division
}
class Vychislenie
{
    List<object> list = new List<object>();//сюда помещаются нарезки входной строки
    public Dictionary<char,Do> actions = new Dictionary<char,Do> //создаем индикатор нужного действия
    {
        {'+',Do.Add },
        {'-',Do.Division},
        {'*',Do.Multipc},
        {'/',Do.Subtr}
    };

    //List<object> - если известно что на выходе будут строки то object писать не стоит
    //Такие методы нужно разделять на несколько отдельных. Всякие отдельные проверки можно было вынести в методы
    public List<object> Processing(string text)//массив уже определенных значений
    {
        Cursor cursor = new Cursor(text);
        Boolean b = true;
        string wer = string.Empty;
        double dou;//не самое удачное название. Лучше что нибудь вроде number  итд
        int e;
        while(!cursor.IsEnd())
        {
            char ch = cursor.NextCh();
            if (ch == '"') //выделение частей текста типа string
            {
                cursor.SavePos();
                char ch1 = ' ';
                while (!cursor.IsEnd() && ch1 != '"')
                {
                    ch1 = cursor.NextCh();
                }
                list.Add(cursor.GetSubStr().Trim('"'));
                continue;
            }
            if (actions.ContainsKey(ch))// нахождение знака(+-*/)
            {
                list.Add(actions[ch]);
                continue;
            }
            if (char.IsDigit(ch))
            {
                b = false;
                cursor.SavePos();
                while(!cursor.IsEnd() && (char.IsDigit(ch) || ch == ','))
                {
                    ch = cursor.NextCh();
                    if (ch == ',')//проверка на наличие двух ',' в одном числе
                    {
                        if (b) throw new Exception("Ошибка синтаксиса");
                        b = true;
                    }
                }
                if (!cursor.IsEnd()) cursor.OneBack();
                if (b == true)//проверка на double или int
                {
                    wer = cursor.GetSubStr();
                    dou = double.Parse(wer);
                    list.Add(dou);
                    continue;
                }
                wer = cursor.GetSubStr();
                e = int.Parse(wer);
                list.Add(e);
                continue;
            }
            if (!char.IsSeparator(ch))
            {
                throw new Exception("Ошибка синтаксиса");
            }
        }
        return list;
    }

    int e = 0;
    Boolean b1 = true;
    string stPri1 = string.Empty;
    string stPri2 = string.Empty;

    public string SummaStr(List<object> listok)//сложение строк
    {
        string ob;
        if(((Do)list[1]) != Do.Add)
        {
            throw new Exception("Между строками возможен только знак '+'");
        }
        ob = list[0] as string;
        ob += list[2] as string;
        return ob;
    }

    double dou1;//переменную лучше спрятать в методе
    //если нет особой неоходимости, лучше делать метод приватным
    public double PrivedenieDou(object obj)//преобразование object в double
    {
        if (e == 1)
        {
            dou1 = (double)list[0];
        } 
        if (e == 2)
        {
            dou1 = (double)list[2];
            e = 0;
        }
        e++;
        return dou1;
    }

    int int1;
    public int PrivedenieInt(object obj)//преобразование object в int
        {
            if (e == 1)
            {
                int1 = (int)list[0];
            }
            if (e == 2)
            {
                int1 = (int)list[2];
                e = 0;
            }
            e++;
        return int1;
    }
}
class Cursor //бегает по тексту
{
    string text;
    int index;
    int savePos;

    public Cursor(string text)//создаем курсор который бегает по тексту
    {
        this.text = text;
        index = -1;
    }
    public char NextCh()//шаг курсора +1
    {
        index++;
        return text[index];
    }
    public Boolean IsEnd()//проверка на окончание строки
    {
        return index >= text.Length - 1;
    }
    public void SavePos()//позиция окончания нужной части текста
    {
        savePos = index;
    }
    public string GetSubStr()//обрезание нужной части текста
    {
        return text.Substring(savePos, index - savePos + 1);
    }
    public void OneBack()//шаг курсора -1
    {
        index--;
    }
}
