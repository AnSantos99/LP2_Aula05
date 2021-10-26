namespace GunDecoration
{
    public class GunSilencer : GunDecorator
    {
        public GunSilencer(IGun decoratedGun) : base (decoratedGun)
        {}
        public override float NoiseLevel => base.NoiseLevel * 0.2f;
    }
}