namespace TestProject
{
    public class UnitTest1  // �����׼�
    {
        [Fact]
        public void Test1() // ��������
        {
            //1����������
            //2�����Բ���
            //3���ڴ����

            MyClass myClass = new();
            var result = myClass.Sum(1, 2);
            Assert.Equal(3, result);


        }
    }
}