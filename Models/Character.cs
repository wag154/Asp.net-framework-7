using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Character
    {
        public int ID {get; set;}
        // adding ? after string will make it nullable, this is "default value is
        public string Name {get; set;} = "Frodo";
        public int HitPoints {get; set;} = 100;
        public int Strength {get; set;} = 10;
        public int Defense  {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RpgClass Class {get; set;} = RpgClass.Knight;
    }
}