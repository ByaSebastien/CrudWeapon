using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWeapon.Models
{
    public enum WeaponType
    {
        Mitrailette,
        Pistolet,
        Revolver,
        Bazooka,
        ShotGun,
        Sniper
    }
    public class Weapon
    {
        public static int CurrentId = 4;
        public Weapon()
        {
            Id = CurrentId++;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public WeaponType WeaponType { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"ID : {Id}\n" +
                   $"Nom : {Name}\n" +
                   $"Type : {WeaponType}\n" +
                   $"Description : {Description}";
        }
    }
}
