using System;

namespace ConsoleApp1
{
    enum Cellste
    {  //地图类型
        地雷,
        跳跃,
        抽奖,
        暂停,
        方块
    }
    struct Vector2
    {
        public int x, y;
    }
    struct Cell
    {
        //地图(棋盘)
        //地图单元格的数组
        //		地图单元格
        //			位置：
        //			图标：▲∞★‖■
        //			类型：地雷，跳跃，抽奖，暂停，方块
        /*行为：
         *      初始化地图，给每个位置赋予一个属性
        */
        public Vector2 position;
        public string icon;
        public Cellste cellste;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cell[] map = new Cell[55];
            SetMapDate(map);
            for (int i = 0; i < 11; i++)
            {
                Console.SetCursorPosition(map[i].position.x*2, map[i].position.y);
                Console.Write(map[i].icon);
            }
        }
        static void SetMapDate(Cell[] map)
        {
            Vector2 starPos = new Vector2();
            starPos.x = 5;
            starPos.y = 5;
            map[0].position = starPos;
            map[0].icon = "■";
            for (int i = 1; i <10; i++)
            {
                map[i].position.x = map[i - 1].position.x + 1;
                map[i].position.y = map[i - 1].position.y;
                map[i].icon = map[i - 1].icon;
            }
            for (int i = 10; i < 15; i++)
            {
                map[i].position.x = map[i - 1].position.x + 1;
                map[i].position.y = map[i - 1].position.y;
                map[i].icon = map[i - 1].icon;
            }
        }

    }
}
