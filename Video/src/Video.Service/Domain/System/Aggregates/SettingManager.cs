namespace Video.Service.Domain.System.Aggregates
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingManager : Entity<long>
    {
        private string name;
        private string value;
        /// <summary>
        /// 扩展参数
        /// </summary>
        public string Name { get => name; private set => name = value; }
        /// <summary>
        /// 请求耗时(ms)
        /// </summary>
        public string Value { get => value; private set => this.value = value; }

        protected SettingManager()
        {

        }

        public SettingManager(string name, string value)
        {
            Name = name;
            Value = value;

        }
    }
}
