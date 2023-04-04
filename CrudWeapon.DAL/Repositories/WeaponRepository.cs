using CrudWeapon.DAL.Datas;
using CrudWeapon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWeapon.DAL.Repositories
{
    public class WeaponRepository
    {
        public void Add(Weapon w)
        {
            FakeDb.Weapons.Add(w);
        }
        public void Update(int id, Weapon w)
        {
            Weapon? oldWeapon = FakeDb.Weapons.SingleOrDefault(w => w.Id == id);

            if (oldWeapon is null)
                throw new KeyNotFoundException("Arme non existante");

            oldWeapon.Name = w.Name;
            oldWeapon.Description = w.Description;
            oldWeapon.WeaponType = w.WeaponType;
        }
        public void Delete(int id)
        {
            Weapon? weapon = FakeDb.Weapons.SingleOrDefault(w => w.Id == id);

            if (weapon is null)
                throw new KeyNotFoundException("Arme non existante");

            FakeDb.Weapons.Remove(weapon);
        }

        public List<Weapon> GetMany(Func<Weapon, bool> predicate = null)
        {
            if (predicate == null)
                return FakeDb.Weapons;
            return FakeDb.Weapons.Where(predicate).ToList();
        }

        public Weapon GetOne(Func<Weapon, bool> predicate)
        {
            Weapon? weapon = FakeDb.Weapons.SingleOrDefault(predicate);

            if (weapon is null)
                throw new KeyNotFoundException("Arme non existante");

            return weapon;
        }
    }
}
