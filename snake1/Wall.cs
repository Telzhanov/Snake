using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Wall : GameObject
    {
        public Wall()
        {
            this.sign = '#';
            string fname = string.Format(@"C:\Users\сулпак\Desktop\PT_G1\level1.txt");
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    int colNumber = 0;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        for (int rowNumber = 0; rowNumber < line.Length; ++rowNumber)
                        {
                            if (line[rowNumber] == '#')
                            {
                                this.points.Add(new Point(rowNumber, colNumber));
                            }
                        }

                        colNumber++;
                    }
                }
            }
        }
    }
}