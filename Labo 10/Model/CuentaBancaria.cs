namespace Labo_10.Model
{
    public class CuentaBancaria
    {
        public readonly string _owner;
        public readonly double _balance;

        public CuentaBancaria(string owner = "Unnamed", double balance = 0)
        {
            _owner = owner;
            _balance = balance;
        }
    }
}