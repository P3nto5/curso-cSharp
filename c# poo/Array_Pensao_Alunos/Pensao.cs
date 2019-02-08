using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Pensao_Alunos
{
    class Pensao
    {
        public int numberRoom { get; set; }
        public string nameStudent { get; set; }

        public bool checkOccupied( params int[] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                for (int j = i; j < room.Length; j++)
                {
                    if(room[i] == room[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
