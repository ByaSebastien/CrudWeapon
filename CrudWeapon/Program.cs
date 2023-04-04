using CrudWeapon;
using CrudWeapon.BLL.DTOs;
using CrudWeapon.BLL.Services;
using CrudWeapon.DAL.Datas;
using CrudWeapon.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        WeaponService weaponService = new WeaponService();
        StringBuilder mainMenu = new StringBuilder();
        mainMenu.AppendLine("1 : Lister");
        mainMenu.AppendLine("2 : Rechercher");
        mainMenu.AppendLine("3 : Rechercher par catégories");
        mainMenu.AppendLine("4 : Ajouter");
        mainMenu.AppendLine("5 : Modifier");
        mainMenu.AppendLine("6 : Supprimer");
        mainMenu.AppendLine("0 : Quitter");

        int choix;
        do
        {
            Console.Clear();
            Console.WriteLine(mainMenu);

            do
            {
            } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 0 || choix > 6);

            Console.Clear();

            switch (choix)
            {
                case 0:
                    Console.WriteLine("Au Revoir");
                    break;
                case 1:
                    List<Weapon> weapons = weaponService.GetAll();
                    foreach (Weapon weapon in weapons)
                    {
                        Console.WriteLine(weapon);
                        Console.WriteLine("________________________________________");
                    }
                    break;
                case 2:
                    Utils.Search(weaponService);
                    break;
                case 3:
                    foreach (WeaponType type in Enum.GetValues<WeaponType>())
                    {
                        Console.WriteLine($"{(int)type + 1} : {type}");
                    }
                    do
                    {
                    } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 6);
                    WeaponType weaponType = (WeaponType)(choix - 1);
                    List<Weapon> weaponList = weaponService.GetByType(weaponType);
                    foreach (Weapon weapon in weaponList)
                    {
                        Console.WriteLine(weapon);
                        Console.WriteLine("_______________________________________________");
                    }
                    break;
                case 4:
                    WeaponDTO newWeapon = Utils.WeaponForm();
                    weaponService.Add(newWeapon);
                    Console.WriteLine("Vous avez bien ajouté l'arme");
                    break;
                case 5:
                    int id = Utils.Search(weaponService);
                    try
                    {
                        WeaponDTO weapon = Utils.WeaponForm();
                        weaponService.Update(id, weapon);
                    }catch(KeyNotFoundException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Erreur");
                    }
                    break;
                case 6:
                    int tempId = Utils.Search(weaponService);
                    weaponService.Delete(tempId);
                    Console.WriteLine("Livre supprimé");
                    break;
            }
            Console.ReadKey();
        } while (choix != 0);
    }
}