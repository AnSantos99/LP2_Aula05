using System;

namespace GunDecoration
{
    public class GunClip : GunDecorator
    {

        public GunClip(IGun decoratedGun) : base (decoratedGun)
        {}
        public override int AmmoCapacity => 
            (int)(base.AmmoCapacity * 1.5f);
    }
}