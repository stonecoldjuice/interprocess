using Grpc.Core;
using InterpretApi;

public class InterpretTerminal
{
    Channel _channel;

    public InterpretTerminal(string ipAddress)
    {
        _channel = new Channel("127.0.0.1:30051", ChannelCredentials.Insecure);
    }

    ~InterpretTerminal()
    {
        _channel.ShutdownAsync().Wait();
    }

    public string Request()
    {
        var client = new Interpret.InterpretClient(_channel);
        String fileName = @"c:\images\dicom\test.dcm";
        var reply = client.Interpretation(new InterpretRequest { Name = fileName });
        return reply.Message;
    }
}