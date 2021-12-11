namespace PlayerApp
{
    interface IWeapon: IHasInfo
    {
        int Damage { get; }
        void Fire();
    }
}