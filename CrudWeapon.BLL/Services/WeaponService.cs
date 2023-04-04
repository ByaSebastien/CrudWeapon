using CrudWeapon.BLL.DTOs;
using CrudWeapon.BLL.Mappers;
using CrudWeapon.DAL.Repositories;
using CrudWeapon.Models;

namespace CrudWeapon.BLL.Services
{
    public class WeaponService
    {
        private readonly WeaponRepository _weaponRepository;

        public WeaponService()
        {
            _weaponRepository = new WeaponRepository();
        }

        public void Add(WeaponDTO w)
        {
            _weaponRepository.Add(w.ToDAL());
        }
        public void Update(int id, WeaponDTO w)
        {
            Weapon oldWeapon = _weaponRepository.GetOne(w => w.Id == id);
            _weaponRepository.Update(oldWeapon.Id, w.ToDAL());
        }
        public void Delete(int id)
        {
            _weaponRepository.Delete(id);
        }
        public List<Weapon> GetAll()
        {
            return _weaponRepository.GetMany();
        }
        public List<Weapon> GetByType(WeaponType type)
        {
            return _weaponRepository.GetMany(w => w.WeaponType == type);
        }
        public Weapon GetById(int id)
        {
            return _weaponRepository.GetOne(w => w.Id == id);
        }
        public Weapon GetByName(string name)
        {
            return _weaponRepository.GetOne(w => w.Name == name);
        }
    }
}
