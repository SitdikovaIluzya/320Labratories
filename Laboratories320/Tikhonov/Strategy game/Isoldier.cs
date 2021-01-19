namespace Laboratories320.Tikhonov.Strategy_game
{
    internal interface Isoldier
    {
        int HitPoints { get; set; }
        int ArmorClass { get; set; }
        int Speed { get; set; }
        int Damage { get; set; }
        void melee_attack();
    }
}