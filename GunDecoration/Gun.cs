using System;

namespace GunDecoration
{
    public abstract class Gun : IGun
    {
        public virtual int AmmoCapacity {get; }

        public virtual float NoiseLevel {get; }

        public Gun(int ammoCapacity, float noiseLevel)
        {
            AmmoCapacity = ammoCapacity;
            NoiseLevel = noiseLevel;
        }

        public void Fire()
        {
            Console.WriteLine($"Ammo = {AmmoCapacity} | Noise= {NoiseLevel}");
        }
    }
}