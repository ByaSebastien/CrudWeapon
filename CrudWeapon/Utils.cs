using CrudWeapon.BLL.DTOs;
using CrudWeapon.BLL.Services;
using CrudWeapon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWeapon
{
    public static class Utils
    {
        public static int Search(WeaponService weaponService)
        {
            int choix;

            StringBuilder searchMenu = new StringBuilder();
            searchMenu.AppendLine("1 : Rechercher par Id");
            searchMenu.AppendLine("2 : Rechercher par nom");
            Console.WriteLine(searchMenu);
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 3);

            Console.Clear();

            switch (choix)
            {
                case 1:
                        Console.Write("Id : ");
                        int id = int.Parse(Console.ReadLine());
                        Weapon weapon = weaponService.GetById(id);
                        Console.WriteLine(weapon);
                        return weapon.Id;
                case 2:
                        Console.Write("Nom : ");
                        string name = Console.ReadLine();
                        Weapon weaponn = weaponService.GetByName(name);
                        Console.WriteLine(weaponn);
                        return weaponn.Id;
                default:
                    throw new KeyNotFoundException();
            }
        }
        public static WeaponDTO WeaponForm()
        {
            int choix;
            foreach (WeaponType type in Enum.GetValues<WeaponType>())
            {
                Console.WriteLine($"{(int)type + 1} : {type}");
            }
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 6);
            Console.WriteLine("Nom : ");
            string nom = Console.ReadLine();
            string description = Console.ReadLine();
            return new WeaponDTO()
            {
                Name = nom,
                Description = description,
                WeaponType = (WeaponType)(choix - 1)
            };
        }
    }
}
