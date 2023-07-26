using BusinessLogic;

namespace TestProject;

[TestFixture]
public class SortingOperationTests
{
    [Test]
    public void Test_SortingOperation_Case1()
    {
        var input = "abaccadcc";
        var expected = "ccccaaabd";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case2()
    {
        var input = "xyzxy";
        var expected = "xxyyz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case3()
    {
        var input = "dulgvgzwqg";
        var expected = "gggdlquvwz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case4()
    {
        var input = "gxtjtmtywr";
        var expected = "tttgjmrwxy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case5()
    {
        var input = "hnlnxiupgt";
        var expected = "nnghilptux";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case6()
    {
        var input = "gzjotckivp";
        var expected = "cgijkoptvz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case7()
    {
        var input = "dpwwsdptae";
        var expected = "ddppwwaest";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case8()
    {
        var input = "pcscpilknb";
        var expected = "ccppbiklns";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case9()
    {
        var input = "btvyhhmflf";
        var expected = "ffhhblmtvy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case10()
    {
        var input = "artrtnqxcr";
        var expected = "rrrttacnqx";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case11()
    {
        var input = "nrtcmcoadn";
        var expected = "ccnnadmort";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case12()
    {
        var input = "fkdsgnekft";
        var expected = "ffkkdegnst";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case13()
    {
        var input = "wzenwebuau";
        var expected = "eeuuwwabnz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case14()
    {
        var input = "vokfxzynwl";
        var expected = "fklnovwxyz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case15()
    {
        var input = "neldfeyrxk";
        var expected = "eedfklnrxy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case16()
    {
        var input = "wqadfiodgs";
        var expected = "ddafgioqsw";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case17()
    {
        var input = "ykiuvzfcbc";
        var expected = "ccbfikuvyz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case18()
    {
        var input = "qakmc";
        var expected = "ackmq";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case19()
    {
        var input = "rrtbk";
        var expected = "rrbkt";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case20()
    {
        var input = "vaixn";
        var expected = "ainvx";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case21()
    {
        var input = "wmpnj";
        var expected = "jmnpw";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case22()
    {
        var input = "uproi";
        var expected = "iopru";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case23()
    {
        var input = "btska";
        var expected = "abkst";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case24()
    {
        var input = "ejqwr";
        var expected = "ejqrw";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case25()
    {
        var input = "elwlg";
        var expected = "llegw";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case26()
    {
        var input = "oaoiy";
        var expected = "ooaiy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case27()
    {
        var input = "hrqkn";
        var expected = "hknqr";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case28()
    {
        var input = "pzjim";
        var expected = "ijmpz";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case29()
    {
        var input = "njnfq";
        var expected = "nnfjq";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case30()
    {
        var input = "xyohs";
        var expected = "hosxy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case31()
    {
        var input = "xqycs";
        var expected = "cqsxy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case32()
    {
        var input = "beoax";
        var expected = "abeox";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case33()
    {
        var input = "afkso";
        var expected = "afkos";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case34()
    {
        var input = "bldit";
        var expected = "bdilt";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortingOperation_Case35()
    {
        var input = "gwrys";
        var expected = "grswy";
        var result = StringHelpers.SortingOperation(input);
        Assert.That(result, Is.EqualTo(expected));
    }


}