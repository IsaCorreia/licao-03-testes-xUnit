namespace greet.Test;

public class UnitTest1
{
  [Theory(DisplayName = "Deve retornar 'Olá!'")]
  [InlineData("Olá!")]
  public void TestGreet(string expected)
  {
    var result = Class1.Greet();
    result.Should().Be(expected);
  }

  [Theory(DisplayName = "Deve retornar a soma de dois números.")]
  [InlineData(3, 3, 6)]
  [InlineData(-10, 3, -7)]
  [InlineData(77, 33, 110)]
  public void TestSum(int input1, int input2, int expected)
  {
    var result = Class1.Sum(input1, input2);
    result.Should().Be(expected);
  }
}