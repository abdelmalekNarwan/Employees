using Grpc.Core;
using GrpcService.Protos;

namespace GrpcService.Services
{
    public class EmployeeSErvice : Employee.EmployeeBase
    {
        public EmployeeSErvice()
        {
            
        }

        public override Task<EmployeeDto> GetEmployeeInfo(EmployeeinputDto request, ServerCallContext context)
        {
            return base.GetEmployeeInfo(request, context);
        }
    }
}
