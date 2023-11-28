using Masa.BuildingBlocks.Ddd.Domain.Entities.Full;

namespace Video.Service.Domain.System.Aggregates
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Roles : FullAggregateRoot<int,long>
    {
        /// <summary>
        /// 角色排序
        /// </summary>
        public int sort;
        /// <summary>
        /// 名称
        /// </summary>
        public string name;
        /// <summary>
        /// 角色描述
        /// </summary>
        public string description;
        /// <summary>
        /// 默认角色不允许删除
        /// </summary>
        public bool isDefault;
        /// <summary>
        /// 是否正常使用的
        /// </summary>
        public bool isActive = true;

        /// <summary>
        /// 角色排序
        /// </summary>
        public int Sort { get => sort; set => sort = value; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// 角色描述
        /// </summary>
        public string Description { get => description; set => description = value; }

        /// <summary>
        /// 默认角色不允许删除
        /// </summary>
        public bool IsDefault { get => isDefault; private set => isDefault = value; }
        /// <summary>
        /// 是否正常使用的
        /// </summary>
        public bool IsActive { get => isActive; private set => isActive = value; }


        public Roles()
        {

        }

        public Roles(int sort, string name, string description, bool isDefault)
        {
            UpdateName(name);
            Sort = sort;
            Description = description;
            IsDefault = isDefault;
            IsActive = true;
        }


        public void UpdateName(string name)
        {
            if (name.IsNullOrWhiteSpace())
            {
                throw new UserFriendlyException("角色名称不能为空");
            }
            Name = name;
        }
    }
}
