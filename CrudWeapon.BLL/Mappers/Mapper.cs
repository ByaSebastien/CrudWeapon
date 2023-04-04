using CrudWeapon.BLL.DTOs;
using CrudWeapon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWeapon.BLL.Mappers
{
    public static class Mapper
    {
        public static Weapon ToDAL(this WeaponDTO w)
        {
            return new Weapon()
            {
                Name = w.Name,
                Description = w.Description,
                WeaponType = w.WeaponType,
            };
        }
    }
}
