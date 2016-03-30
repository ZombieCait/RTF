using System;
using System.Collections.Generic;
using System.Linq;


class Film
{
    private string title { get; set; }
    private string genre { get; set; }
    private DateTime date { get; set; }
    private int raiting { get; set; }

    public Film(string t = "����� �� ��������", string g = "�����", string d = "10 9 1994", int r = 91)
    {
        genre = g;
        title = t;
        date = DateTime.Parse(d);
        raiting = r;
    }
    public Film(Film some)
    {
        genre = some.genre;
        title = some.title;
        date = some.date;
        raiting = some.raiting;
    }

    public void FiltreByName()
    {
        try
        {
            Console.WriteLine("������� ������� ����� ����������:");
            char key = Char.ToUpper(Console.ReadKey().KeyChar);
            if (key=='\r')
            {
                throw new ProgramException("\n�� ������ �� �����.");
            }
            if ((key<'�' || key>'�') &&( key<'0' || key>'9'))
            {
                throw new ProgramException("\n����� ������ ������� ����� ��� �����.");
            }
            while (true)
            {
                Console.WriteLine(
                    "\n1. ������������ �����\n2. ������ ���������\n3. LINQ- ������\n ��� ������ 0 ���  exit:");
                switch (Console.ReadLine())
                {
                    case "0":
                    case "exit":
                        return;
                    case "1":
                        IterFiltreByName(key);
                        break;
                    case "2":
                        LambdaFiltreByName(key);
                        break;
                    case "3":
                        LINQFiltreByName(key);
                        break;
                }
            }
        }
        catch{}
    }
    public void FiltreByPart()
    {
        try
        {
            Console.WriteLine("������� ����� ����� ��� ����������:");
            string part = Console.ReadLine().ToLower();
            if (part == "" || part == " ")
            {
                throw new ProgramException("\n�� ������ �� �����.");
            }
            while (true)
            {
                Console.WriteLine(
                    "\n1. ������������ �����\n2. ������ ���������\n3. LINQ- ������\n ��� ������ 0 ���  exit:");
                switch (Console.ReadLine())
                {
                    case "0":
                    case "exit":
                        return;
                    case "1":
                        IterFiltreByPart(part);
                        break;
                    case "2":
                        LambdaFiltreByPart(part);
                        break;
                    case "3":
                        LINQFiltreByPart(part);
                        break;
                }
            }
        }
        catch{}
    }
    public void FindElements()
    {
        Console.WriteLine("������� ��� � �������� ������ �����:");

        int startYear = Int32.Parse(Console.ReadLine());

        Console.WriteLine("��:");
        int endYear = Int32.Parse(Console.ReadLine());
        if (1940 > startYear && startYear > 2016 || endYear < 1940 && endYear > 2016 || startYear == null ||
            endYear == null)
        {
            Console.WriteLine("�� ����� ����� ����������");
            return;
        }
        if (startYear > endYear)
        {
            int temp = startYear;
            startYear = endYear;
            endYear = temp;
        }

        while (true)
        {
            Console.WriteLine("\n1. ������������ �����\n2. ������ ���������\n3. LINQ- ������\n ��� ������ 0 ���  exit:");
            switch (Console.ReadLine())
            {
                case "0":
                case "exit":
                    return;
                case "1":
                    IterFiltreByPart(startYear, endYear);
                    break;
                case "2":
                    LambdaFiltreByPart(startYear, endYear);
                    break;
                case "3":
                    LINQFiltreByPart(startYear, endYear);
                    break;
            }
        }
    }
    public void Sort()
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("\n1. ������������ �����\n2. ������ ���������\n3. LINQ- ������\n ��� ������ 0 ���  exit:");
            switch (Console.ReadLine())
            {
                case "0":
                case "exit":
                    return;
                case "1":
                    IterSort();
                    break;
                case "2":
                    LambdaSort();
                    break;
                case "3":
                    LINQSort();
                    break;
            }
        }
    }
    public void DoubleFiltre()
    {
        try
        {
            Console.WriteLine("������� ����� ����� ��� ����������:");
            string part = Console.ReadLine().ToLower();
            if (part == "" || part==" ")
            {
                throw new ProgramException("\n�� ������ �� �����.");
            }

            while (true)
            {
                Console.WriteLine(
                    "\n1. ������������ �����\n2. ������ ���������\n3. LINQ- ������\n ��� ������ 0 ���  exit:");
                switch (Console.ReadLine())
                {
                    case "0":
                    case "exit":
                        return;
                    case "1":
                        IterDoubleFiltre(part);
                        break;
                    case "2":
                        LambdaDoubleFiltre(part);
                        break;
                    case "3":
                        LINQDoubleFiltre(part);
                        break;
                }
            }
        }
        catch{}
    }


    private void LINQDoubleFiltre(string part)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        var selectedFilms = 
            from film in films
            where film.genre.ToLower().Contains(part) && film.raiting%3==0 && film.raiting%7==0
            select film;
        FiltredFilms = selectedFilms.ToList();
        PrintFiltredList(ref FiltredFilms, part);
    }
    private void LambdaDoubleFiltre(string part)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        FiltredFilms = films.Where(film => film.genre.ToLower().Contains(part) && film.raiting%3==0 && film.raiting%7==0).ToList();
        PrintFiltredList(ref FiltredFilms, part);
    }
    private void IterDoubleFiltre(string part)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        for (int i = 0; i < films.Count; i++)
        {
            if (films[i].genre.ToLower().Contains(part) && films[i].raiting%3==0 && films[i].raiting%7==0)
            {
                FiltredFilms.Add(films[i]);
            }
        }
        PrintFiltredList(ref FiltredFilms, part);
    }


    private void LINQSort()
    {
        List<Film> films = getList();
        IEnumerable<Film> sortedFilms =
            from film in films
            orderby film.title ascending, film.raiting descending 
            select film;
        Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", "�������� ������:", "����:", "��������:", "�������:");
        foreach (var film in sortedFilms)
        {
            Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", film.title, film.genre, film.date.Date.ToString("d"), film.raiting);
        }
        
    }
    private void LambdaSort()
    {
        List<Film> films = getList();
        var sortedFilms=films.OrderBy(film=>film.title).ThenByDescending(film=>film.raiting);
        Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", "�������� ������:", "����:", "��������:", "�������:");
        foreach (var film in sortedFilms)
        {
            Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", film.title, film.genre, film.date.Date.ToString("d"), film.raiting);
        }
    }
    private void IterSort()
    {
        List<Film> films = getList();
        for (int j = 0; j < films.Count; j++)
        {
            for (int i = 0; i < films.Count - j;)
            {
                if (i + 1 == films.Count) break;
                if (films[i].title.CompareTo(films[i + 1].title) == 1)
                {
                    Film temp = new Film(films[i + 1]);
                    films[i + 1] = films[i];
                    films[i] = temp;
                    i++;
                }
                else if (films[i].title.CompareTo(films[i + 1].title) == 0)
                {
                    if (films[i].raiting.CompareTo(films[i].raiting) == -1)
                    {
                        Film temp = new Film(films[i + 1]);
                        films[i + 1] = films[i];
                        films[i] = temp;
                        i++;
                    }
                    else i++;
                }
                else i++;
            }
        }
        /*films.Sort(delegate(Film film1, Film film2)
        {
            if (film1.title.CompareTo(film2.title) == 0)
            {
                if (film1.raiting.CompareTo(film2.raiting) == -1)
                    return 1;
                //else return -1;
            }
            else return film1.title.CompareTo(film2.title);
        });*/
        Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", "�������� ������:", "����:", "��������:", "�������:");
        foreach (var film in films)
        {
            Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", film.title, film.genre, film.date.Date.ToString("d"), film.raiting);
        } 
    }


    private void LINQFiltreByPart(int startYear, int endYear)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        var selectedFilm = from film in films
                           where film.date.Year < endYear&& film.date.Year>startYear
                           select film;
        FiltredFilms = selectedFilm.ToList();
        PrintFiltredList(ref FiltredFilms, startYear+"-"+endYear);
    }
    private void LambdaFiltreByPart(int startYear, int endYear)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        FiltredFilms = films.Where(film => film.date.Year < endYear && film.date.Year>startYear).ToList();
        PrintFiltredList(ref FiltredFilms, startYear + "-" + endYear);
    }
    private void IterFiltreByPart(int startYear, int endYear)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        for (int i = 0; i < films.Count; i++)
        {
            int filmYear = films[i].date.Year;
            if (filmYear> startYear && filmYear<endYear)
            {
                FiltredFilms.Add(films[i]);
            }
        }
        PrintFiltredList(ref FiltredFilms, startYear + "-" + endYear);
    }


    private void LINQFiltreByName(char key)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        var selectedFilm=  from film in films
            where film.title[0] < key
            select film;
        FiltredFilms=selectedFilm.ToList();
        PrintFiltredList(ref FiltredFilms, key.ToString());
    }
    private void LambdaFiltreByName(char key)
    {
        List<Film> films = getList();
        List<Film> FiltredFilms = new List<Film>();
        FiltredFilms = films.Where(film => film.title[0] < key).ToList();
        PrintFiltredList(ref FiltredFilms, key.ToString());

    }
    private void IterFiltreByName(char key)
    {
        List<Film> films = getList();
            List<Film> FiltredFilms = new List<Film>();
            for (int i = 0; i < films.Count; i++)
            {
                if (films[i].title[0] < key)
                {
                    FiltredFilms.Add(films[i]);
                }
            }
            PrintFiltredList(ref FiltredFilms, key.ToString());
    }


    private void LINQFiltreByPart(string part)
    {
            List<Film> films = getList();
            List<Film> FiltredFilms = new List<Film>();
            var selectedFilm = from film in films
                where film.title.ToLower().Contains(part)
                select film;
            FiltredFilms = selectedFilm.ToList();
            PrintFiltredList(ref FiltredFilms, part);
    }
    private void LambdaFiltreByPart(string part)
    {
            List<Film> films = getList();
            List<Film> FiltredFilms = new List<Film>();
            FiltredFilms = films.Where(film => film.title.Contains(part)).ToList();
            PrintFiltredList(ref FiltredFilms, part);
       }
    private void IterFiltreByPart(string part)
    {
        
            List<Film> films = getList();
            List<Film> FiltredFilms = new List<Film>();
            for (int i = 0; i < films.Count; i++)
            {
                if (films[i].title.Contains(part))
                {
                    FiltredFilms.Add(films[i]);
                }
            }
            PrintFiltredList(ref FiltredFilms, part);
    }



    private void PrintFiltredList(ref List<Film> filteredList, string key)
    {
        Console.Clear();
        Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", "�������� ������:", "����:", "��������:", "�������:");
        if (filteredList.Count == 0)
        {
        Console.WriteLine("�� ������ ������� ������ �� �������.");
            return;
        }
        Console.WriteLine("\n������ ��������������� �� {0}:", key);
        foreach (var film in filteredList)
        {
            Console.WriteLine("{0,30} {1,10} {2,10} {3,3}", film.title, film.genre, film.date.Date.ToString("d"), film.raiting);
        }
    }
    public static List<Film> getList()
    {
        List<Film> listFilms = new List<Film>();
        listFilms.Add(new Film());
        listFilms.Add(new Film("�������� ��� ������� �������", "�����", "19 11 1975", 89));
        listFilms.Add(new Film("12 ������������ ������", "�����","10 4 1957",  82));
        listFilms.Add(new Film("12 ������������ ������", "�����","10 4 1957", 63));
        listFilms.Add(new Film("�������� �����",  "�������", "30 1 1991", 84));
        listFilms.Add(new Film("�����������", "�����", "16 1 2014", 84));
        listFilms.Add(new Film("����� �� ��������","�����", "10 9 1994", 95));
        listFilms.Add(new Film("Ǹ����� ����", "�������", "6 12 1999", 84));
        listFilms.Add(new Film( "������ ��������", "���������","30 11 1993", 91));
        listFilms.Add(new Film( "�������", "���������","24 5 2002", 84));
        listFilms.Add(new Film( "�������", "���������","24 5 2002", 63));
        listFilms.Add(new Film( "������������ ������� �", "�����","30 10 1998", 84));
        listFilms.Add(new Film("������ ���������", "�������", "13 2 2010", 84));

        return listFilms;
    }
}