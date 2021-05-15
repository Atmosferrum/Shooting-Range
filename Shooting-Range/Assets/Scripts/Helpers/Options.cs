public struct Options 
{
    static int difficulty; // Опция Сложности
    static int ost; // Опция Саундтрэка
    
    // ПОЛУЧЕНИЕ и УСТАНОВКА Сложности
    public static int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
    }

    // ПОЛУЧЕНИЕ и УСТАНОВКА Сацндтрэка
    public static int OST
    {
        get { return ost; }
        set { ost = value; }
    }
}
