namespace PlayerApp
{
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }

        public void ShowInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }
}