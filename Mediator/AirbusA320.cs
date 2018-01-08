namespace Mediator
{
    /// <summary>
    /// Самолет модели Airbus A320.
    /// </summary>
    public class AirbusA320 : Aircraft
    {
        /// <summary>
        /// Создать экземпляр самолета Airbus A320.
        /// </summary>
        /// <param name="name">Имя самолета.</param>
        public AirbusA320(string name) : base(name)
        {
            _max_fuel = 14400;
            Fuel = _max_fuel;
            Consumption = 3;
            Speed = 811;
        }
    }
}
