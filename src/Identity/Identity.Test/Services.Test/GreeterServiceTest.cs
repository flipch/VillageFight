using System;
using System.Threading.Tasks;
using FakeItEasy;
using Grpc.Core;
using Identity.Server;
using Identity.Server.Services;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Identity.Test.Services.Test
{
    public class GreeterServiceTest
    {
        private GreeterService GreeterService { get; }
        private ServerCallContext ServerCallContext { get; }

        public GreeterServiceTest()
        {
            GreeterService = new GreeterService(A.Fake<ILogger<GreeterService>>());
            ServerCallContext = A.Fake<ServerCallContext>();
        }

        [Fact]
        public async Task SayHelloReturnsHelloReply()
        {
            var hello = new HelloRequest() {Name = "Felipe"};
            var result = await GreeterService.SayHello(hello, ServerCallContext);
            
            Assert.NotNull(result);
            Assert.Equal($"Hello {hello.Name}", result.Message);
        }
    }
}