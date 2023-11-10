namespace TestProject
{
    public class UnitTest1  // 测试套件
    {
        [Fact]
        public void Test1() // 测试用例
        {
            //1、测试条件
            //2、测试步骤
            //3、期待结果

            MyClass myClass = new();
            var result = myClass.Sum(1, 2);
            Assert.Equal(3, result);


        }
    }
}