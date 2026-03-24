using ProtectedNamespaces.Robots;

namespace ProtectedNamespaces
{
    public class CombatRobot : BaseRobot
    {
        public CombatRobot(string modelName, int batteryLevel) : base(modelName, batteryLevel)
        {
        }

        public void ShowStatus()
        {
            Console.WriteLine($"ModelName: {ModelName}");
            Console.WriteLine($"BatterLevel: {BatteryLevel}");
        }
    }
}