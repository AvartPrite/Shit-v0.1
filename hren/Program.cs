class Program{
    static void Main(){
        string color, action;
        DateTime dt = DateTime.Today;
        Console.WriteLine("Calendar v0.1");
        Console.WriteLine("1. Текущая дата\n2. Настройки цвета\n3. Меню");
        do{
            action = Console.ReadLine();
            
            switch(action){
                case "1":
                    Console.WriteLine($"\n{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}\n{dt.ToString("D")}");
                break;
                case "2":
                    Console.WriteLine(@"Выберите цвет шрифта(цифра):
                1. Жёлтый           6. Тёмно-серый         11. Серый
                2. Синий            7. Тёмно-зелёный       12. Зелёный
                3. Голубой          8. Тёмно-фиолетовый    13. Красный
                4. Тёмно-синий      9. Тёмно-красный       14. Фиолетовый
                5. Тёмно-голубой    10. Тёмно-жёлтый       15. Белый");
                color = Console.ReadLine();

                    switch (color){
                        case "1":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Готово\n");
                            break;

                        case "2":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Готово\n");
                            break;

                        case "3":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Готово\n");
                            break;

                        case "4":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Готово\n");
                            break;

                        case "5":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Готово\n");
                            break;

                        case "6":
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Готово\n");
                            break;

                        case "7":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Готово\n");
                            break;

                        case "8":
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Готово\n");
                            break;

                        case "9":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Готово\n");
                            break;

                        case "10":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Готово\n");
                            break;

                        case "11":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Готово\n");
                            break;

                        case "12":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Готово\n");
                            break;

                        case "13":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Готово\n");
                            break;

                        case "14":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Готово\n");
                            break;

                        case "15":
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Готово\n");
                            break;

                        default:
                            Console.WriteLine("Неккоректный ввод\n");
                            Console.WriteLine("1. Текущая дата\n2. Настройки цвета\n3. Меню");
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("1. Текущая дата\n2. Настройки цвета\n3. Меню");
                    break;
            }
            
            
        }
        while(action != "Выход");    
    }
}


