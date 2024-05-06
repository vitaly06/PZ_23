namespace Sadikov_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hardware> hardwares = new List<Hardware>();
            Monitor monitor = new Monitor();

            for (int i = 1; i < 4; i++)
            {
                hardwares.Add(new Hardware(i));
            }

            foreach (Hardware hardware in hardwares)
            {
                hardware.CritChargeLevelEvent += monitor.HardwareOff;
            }

            for (int i = 0; i < 10; i++)
            {
                hardwares[0].OnPower();
                hardwares[1].OnPower();
                hardwares[2].OnPower();
            }
        }
    }
}