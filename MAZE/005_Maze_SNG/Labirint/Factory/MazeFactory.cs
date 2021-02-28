using System;


namespace Labirint
{
    // Класс MazeFactory создает компоненты лабиринта.
    class MazeFactory
    {
        static MazeFactory instance = null;

        public static MazeFactory Instance()
        {
            if (instance == null)
            {
                string mazeStyle = "standard"; // нужен метод string GetEnv("MAZESTYLE");


                if (string.Compare(mazeStyle, "bombed") == 0) // 0 - совпадают, 1 - не совпадают
                {
                    instance = new BombedMazeFactory();
                }
                else if (string.Compare(mazeStyle, "enchanted") == 0)
                {
                    instance = new EnchantedMazeFactory();
                }
                else // По умолчанию.
                {
                    instance = new MazeFactory();
                }
            }
            return instance;
        }

        protected MazeFactory()
        {
        }

        // Создание лабиринта.
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        // Создание стенв.
        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        // Создание комнаты.
        public virtual Room MakeRoom(int number)
        {
            return new Room(number);
        }

        // Создание двери.
        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
