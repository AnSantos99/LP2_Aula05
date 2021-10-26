using System;

namespace GunDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            IGun shotGun= new ShotGun();
            IGun maschineGun = new MachineGun();

            IGun shotGunAll = new GunClip(new GunSilencer(shotGun));
            

            maschineGun.Fire();
            shotGun.Fire();
            shotGunAll.Fire();

        }
    }
}
