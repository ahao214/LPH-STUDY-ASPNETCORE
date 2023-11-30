namespace E1
{
    public delegate void WaterDelegate();

    public class Water
    {
        public void WaterAction(WaterDelegate wd)
        {
            wd.Invoke();
        }

    }
}
