using System.Net;
using Autofac.Extras.Moq;
using Moq;
using SlackWriter.Core.Models;
using Xunit;

namespace SlackWriter.Tests
{
  public class WriteToSlackTests
  {
    [Fact]
    public void WriteToChannel_ReturnsCorrectSlackResponse()
    {
      //Given
      const string webhookSecret = "123abc";
      const string message = "HelloWorld";
      SlackResponse expected = new SlackResponse("{\"StatusCode\": 201,\"Content\": \"testing\",\"From\": \"John Doe\"}", true, HttpStatusCode.Created);

      //When
      using (AutoMock mock = AutoMock.GetLoose())
      {
        mock.Mock<ISlackActionHandler>()
            .Setup(x => x.PostMessageToChannel(webhookSecret, message))
            .Returns(expected);

        SlackMessager sut = mock.Create<SlackMessager>();

        SlackResponse actual = sut.SendMessage(webhookSecret, message);

        //Then
        mock.Mock<ISlackActionHandler>()
            .Verify(x => x.PostMessageToChannel(webhookSecret, message), Times.Exactly(1));

        Assert.Equal(expected.Content, actual.Content);
        Assert.Equal(expected.IsSuccessful, actual.IsSuccessful);
        Assert.Equal(expected.StatusCode, actual.StatusCode);
      }
    }
  }
}