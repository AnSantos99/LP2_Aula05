using System;

namespace GunDecoration
{
    public abstract class GunDecorator : IGun
    {
        private IGun decoratorGun;

        public virtual int AmmoCapacity => decoratorGun.AmmoCapacity;

        public virtual float NoiseLevel => decoratorGun.NoiseLevel;

        public void Fire()
        {
            Console.WriteLine($"Ammo = {AmmoCapacity} | Noise= {NoiseLevel}");
        }

        public GunDecorator(IGun decoratorGun)
        {
            this.decoratorGun = decoratorGun;
        }
    }
}