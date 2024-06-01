namespace Assertions.UnitTests;

[TestClass]
public class AssertionsUnitTest
{
    [TestMethod]
    public void AssertNotNull_NullObject_ShouldReturnFalse()
    {
        Object obj = null;
        var ret = Assertion.AssertNotNull(obj);
        Assert.IsFalse(ret);
    }

    [TestMethod]
    public void AssertNotEmpty_FilledList_ShouldReturnTrue()
    {
        List<string> list = new List<string>();
        list.Add("new string");
        var ret = Assertion.AssertNotEmpty(list);
        Assert.IsTrue(ret);
    }

    [TestMethod]
    public void AssertNotEmpty_FilledString_ShouldReturnTrue()
    {
        string str = "string has a value";
        var ret = Assertion.AssertNotEmpty(str);
        Assert.IsTrue(ret);
    }

    [TestMethod]
    public void AssertNotEmpty_EmptyString_ShouldReturnFalse()
    {
        string str = "";
        var ret = Assertion.AssertNotEmpty(str);
        Assert.IsFalse(ret);
    }

    [TestMethod]
    public void AssertNotEmpty_NullString_ShouldReturnFalse()
    {
        string str = null;
        var ret = Assertion.AssertNotEmpty(str);
        Assert.IsFalse(ret);
    }

    [TestMethod]
    public void AssertNotNull_Instantiate_ShouldReturnTrue()
    {
        object obj = new object();
        var ret = Assertion.AssertNotNull(obj);
        Assert.IsTrue(ret);
    }
    
    [TestMethod]
    public void AssertEqualTypes_DifferentTypes_ShouldReturnFalse()
    {
        List<string> stringList = new List<string>();
        int zero = 0;
        var ret = stringList.AssertEqualTypes(zero.GetType());
        Assert.IsFalse(ret);
    }
    
    [TestMethod]
    public void AssertEqualTypes_EqualTypes_ShouldReturnTrue()
    {
        int zero = 0;
        int one = 1;
        var ret = zero.AssertEqualTypes(one.GetType());
        Assert.IsTrue(ret);
    }

    [TestMethod]
    public void AssertEqualTypes_NullValue_ShouldReturnFalse()
    {
        string str = "str";
        var ret = str.AssertEqualTypes(null);
        Assert.IsFalse(ret);
    }

    [TestMethod]
    public void AssetDecimalValueGreaterThan_EqualValues_ShouldReturnFalse()
    {
        decimal zero = 0.000M;
        var ret = zero.AssertDecimalGreaterThan(0M);
        Assert.IsFalse(ret);
    }

    [TestMethod]
    public void AssetDecimalValueGreaterThan_RightValueGreathenLeftValue_ShouldReturnTrue()
    {
        decimal one = 1.000M;
        var ret = one.AssertDecimalGreaterThan(0M);
        Assert.IsTrue(ret);
    }

    [TestMethod]
    public void AssetDecimalValueGreaterThan_LeftValueGreathenRightValue_ShouldReturnFalse()
    {
        decimal one = 1.000M;
        var ret = one.AssertDecimalGreaterThan(3M);
        Assert.IsFalse(ret);
    }
}
