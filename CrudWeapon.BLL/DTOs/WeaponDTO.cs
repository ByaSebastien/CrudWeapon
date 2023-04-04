using CrudWeapon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWeapon.BLL.DTOs
{
    public class WeaponDTO
    {
        public string Name { get; set; }
        public WeaponType WeaponType { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Nom : {Name}\n" +
                   $"Type : {WeaponType}\n" +
                   $"Description : {Description}";
        }
    }
}
