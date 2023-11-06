using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcService_Product_Server;

namespace GrpcService_Server.Services
{
    public class ProductService:ProductManager.ProductManagerBase
    {
        public override Task<ProductReply> GetProductByID(ProductRequest request, ServerCallContext context)
        {
            int pid =request.Pid;

            return base.GetProductByID(request, context);
        }


        public override Task<AllProductsReply> GetProductAll(Empty request, ServerCallContext context)
        {
            return base.GetProductAll(request, context);
        }

    }
}
