namespace Mediator
{
    /// <summary>
    /// Самолет модели Boeing 737.
    /// </summary>
    public class Boeing737 : Aircraft
    {
        /// <summary>
        /// Создать экземпляр самолета Boeing 737.
        /// </summary>
        /// <param name="name">Имя самолета.</param>
        public Boeing737(string name) : base(name)
        {
            _max_fuel = 13399;
            Fuel = _max_fuel;
            Consumption = 2;
            Speed = 817;
        }
    }
}
