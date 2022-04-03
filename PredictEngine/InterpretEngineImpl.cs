using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interpret;
using Grpc.Core;

class InterpretEngineService : Interpret.InterpretBase
{
    // Server side handler of the SayHello RPC
    public override Task<PredictReply> Measure(PredictRequest request, ServerCallContext context)
    {
        return Task.FromResult(new PredictReply { Message = "Hello " + request.Name });
    }
}
