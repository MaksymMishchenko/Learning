namespace PlayerApp
{
    interface IWeapon
    {
        int Damage { get; }
        void Fire();
    }
}