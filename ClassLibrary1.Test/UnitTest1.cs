namespace ClassLibrary1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();

            Assert.True(class1.GetString() == "Hello");
        }
    }
}