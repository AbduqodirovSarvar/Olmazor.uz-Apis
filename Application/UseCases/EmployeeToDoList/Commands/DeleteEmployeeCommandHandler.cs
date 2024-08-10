using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeToDoList.Commands
{
    public class DeleteEmployeeCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _appDbContext.Employees.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                        ?? throw new Exception("Employee not found");
            _appDbContext.Employees.Remove(employee);

            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
