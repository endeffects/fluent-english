using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
	public class VerbTests
	{
		[Fact]
		public void EsAfterY()
		{
			var verb = Verb.Create("worry");
			verb.PersonNumber = VerbPersonNumber.ThirdSingular;
			Assert.Equal("worries", verb.GetV1(SentenceState.None));
		}

		[Fact]
		public void EsAfterYAfterVovel()
		{
			var verb = Verb.Create("play");
			verb.PersonNumber = VerbPersonNumber.ThirdSingular;
			Assert.Equal("plays", verb.GetV1(SentenceState.None));
		}

		[Fact]
		public void IngAfterIe()
		{
			var verb = Verb.Create("lie");
			Assert.Equal("lying", verb.GetVIng());
		}
	}
}