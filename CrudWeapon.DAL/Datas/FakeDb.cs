using CrudWeapon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWeapon.DAL.Datas
{
    public static class FakeDb
    {
        public static List<Weapon> Weapons = new List<Weapon>()
        {
            new Weapon()
            {
                Name = "357 Magnum",
                Description = "Arrête les camions",
                WeaponType = WeaponType.Revolver
            },
            new Weapon()
            {
                Name = "SIG P210",
                Description = "Arme militaire suisse",
                WeaponType = WeaponType.Pistolet
            },
            new Weapon()
            {
                Name = "Cigma2",
                Description = "Anti blindé",
                WeaponType = WeaponType.Bazooka
            }
        };
    }
}
