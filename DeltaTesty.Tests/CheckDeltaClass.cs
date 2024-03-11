namespace DeltaTesty.Tests
{
    public class CheckDeltaClass
    {
        [Theory]
        [InlineData(16, 4)]
        [InlineData(25, 5)]
        public void CheckMathSqrt(int NumberToSqrt, int CorrectValue)
        {
            Delta delta = new Delta();

            var rFD = delta.GetSqrt(NumberToSqrt);

            Assert.Equal(CorrectValue, rFD);
        }

        [Theory]
        [InlineData(1, 1, 5, -19)]
        [InlineData(1, 5, 5, 5)]
        [InlineData(4, 5, 5, -55)]
        public void CheckDelta(int a, int b, int c, double correct)
        {
            Delta delta = new Delta();

            var d = delta.GetDelta(a, b, c);

            Assert.Equal(correct, d);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(-1, null)]
        public void CheckDeltaValue(int d, bool? correct)
        {
            Delta delta = new Delta();

            var dC = delta.CheckDelta(d);

            Assert.Equal(correct, dC);
        }


        [Theory]
        [InlineData(1, 5, 5, -1.38)]
        [InlineData(1, 8, 5, -0.68)]
        public void CheckX1(int a, int b, int c, double? correct)
        {
            Delta delta = new Delta();

            var d = delta.GetDelta(a, b, c);
            var dC = delta.GetX1(a, b, d);

            Assert.Equal(correct, dC);
        }

        [Theory]
        [InlineData(1, 5, 5, -3.62)]
        [InlineData(1, 8, 5, -7.32)]
        public void CheckX2(int a, int b, int c, double? correct)
        {
            Delta delta = new Delta();

            var d = delta.GetDelta(a, b, c);
            var dC = delta.GetX2(a, b, d);

            Assert.Equal(correct, dC);
        }
        [Theory]
        [InlineData(4, 4, 1, -0.5)]
        public void CheckX0(int a, int b, int c, double? correct)
        {
            Delta delta = new Delta();

            var dC = delta.GetX0(a, b);

            Assert.Equal(correct, dC);
        }


        [Theory]
        [InlineData(4, 4.8)]
        public void CheckGetSqrt(int a, double b)
        {
            Delta delta = new Delta();

            var da = delta.GetSqrt(a);
            var db = delta.GetSqrt(b);

            Assert.Equal(da, db);
        }
        [Theory]
        [InlineData(4.8)]
        [InlineData(4.2)]
        public void CheckFlooring(double b)
        {
            Delta delta = new Delta();

            var da = Math.Round(b);
            var db = (int)(b);

            Assert.Equal(da, db);
        }
    }
}