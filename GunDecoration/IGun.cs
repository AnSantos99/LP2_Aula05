namespace GunDecoration
{
    public interface IGun
    {
        int AmmoCapacity {get; }

        float NoiseLevel { get; }

        void Fire();
    }
}