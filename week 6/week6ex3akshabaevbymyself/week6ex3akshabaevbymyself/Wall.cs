using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week6ex3akshabaevbymyself
{
    public class Wall:Gameobject
    {
        enum GameLevel
        {
            First,Second,Third
        }
        GameLevel gamelevel = GameLevel.First;

        public Wall(char sign, ConsoleColor color):base(0, 0, sign, color)
        {
            body = new List<Point>();
        }
        public void LoadLevel()
        {
            body = new List<Point>();
            string FileName = "C:/Users/Шаихислам/source/repos/week6akshabaevex/ex3/ex3/level1.txt";
            if(gamelevel == GameLevel.Second)
            {
                FileName = "C:/Users/Шаихислам/source/repos/week6akshabaevex/ex3/ex3/level2.txt";
            }
            if(gamelevel == GameLevel.Third)
            {
                FileName = "C:/Users/Шаихислам/source/repos/week6akshabaevex/ex3/ex3/level3.txt";
            }

            StreamReader sr = new StreamReader(FileName);
            string[] rows = sr.ReadToEnd().Split('\n');
            for(int i = 0; i < rows.Length; i++)
                for(int j = 0; j < rows[i].Length; j++)
                    if(rows[i][j] == '*')
                        body.Add(new Point(j, i));
         }

        public void NextLevel()
        {
            if (gamelevel == GameLevel.First)
                gamelevel = GameLevel.Second;
            else if (gamelevel == GameLevel.Second)
                gamelevel = GameLevel.Third;
            LoadLevel();
        }
    }
}
