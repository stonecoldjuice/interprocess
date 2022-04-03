using Grpc.Core;
using Diagnosis;

class CommonPredictClient
{
    public void Request(string dicomFileName)
    {
        Channel channel = new Channel("127.0.0.1:30051", ChannelCredentials.Insecure);

        var client = new Predict.PredictClient(channel);
        String user = "me";

        var reply = client.Interpret(new HelloRequest { Name = user });
        Console.WriteLine("Greeting: " + reply.Message);

        channel.ShutdownAsync().Wait();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}