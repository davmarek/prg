namespace ProtectedNamespaces.Robots;

public class BaseRobot
{
   public string ModelName;
   protected int BatteryLevel;

   public BaseRobot(string modelName, int batteryLevel)
   {
      ModelName = modelName;
      BatteryLevel = batteryLevel;
   }
}
