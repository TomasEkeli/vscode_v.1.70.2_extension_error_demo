namespace Project.Tests;

public class UnitTest1
{
    // step 0: shows 1 success in the test explorer
    [Fact]
    public void Success()
    {
        Assert.True(true);
    }

    // step 1: uncomment to show 1 success and one fail in the test explorer
    // [Fact]
    // public void Failure()
    // {
    //     Assert.False(true);
    // }
}

// step 2: uncomment to provoke crash of extension - recommenting will not get back to good state
// public class UnitTest2
// {
//     [Fact]
//     public void Failure()
//     {
//         Assert.True(false);
//     }
// }