using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Pensao
{
    class Students
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public Students(int id){
            Id = id;

        }
        public bool CheckOccupied(int n){
            int aux = n;
            if (n == aux)
            {
                return true; 
            }
            return false;
        }
        public override string ToString(){
            return "NumberRoom: " + Id;
                
        }
    }
}
