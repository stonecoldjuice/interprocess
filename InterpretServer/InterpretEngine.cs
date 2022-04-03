using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpretApi;
using Grpc.Core;

class InterpretEngine : Interpret.InterpretBase
{
    // Server side handler of the SayHello RPC
    public override Task<InterpretReply> Interpretation(InterpretRequest request, ServerCallContext context)
    {
        return Task.FromResult(new InterpretReply { Message = "Write predicts :" + request.Name });
    }
}
