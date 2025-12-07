namespace {{ cookiecutter.project_name }}.Tests;

[TestClass]
public sealed class Test1 {
    [TestMethod]
    public void TestMethod1() {
        var message = Program.GetMessage();
        Assert.AreEqual("Hello, World!", message);
    }
}
