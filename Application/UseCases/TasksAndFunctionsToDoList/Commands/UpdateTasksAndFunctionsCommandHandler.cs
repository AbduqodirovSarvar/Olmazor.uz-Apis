using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.TasksAndFunctionsToDoList.Commands
{
    public class UpdateTasksAndFunctionsCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdateTasksAndFunctionsCommand, TaskOrFunction>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<TaskOrFunction> Handle(UpdateTasksAndFunctionsCommand request, CancellationToken cancellationToken)
        {
            var taskOrFunction = await _appDbContext.TasksAndFunctions.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                       ?? throw new Exception("Task or Function not found");

            taskOrFunction.NameRu = request.NameRu ?? taskOrFunction.NameRu;
            taskOrFunction.NameEn = request.NameEn ?? taskOrFunction.NameEn;
            taskOrFunction.NameUz = request.NameUz ?? taskOrFunction.NameUz;
            taskOrFunction.NameUzRu = request.NameUzRu ?? taskOrFunction.NameUzRu;
            taskOrFunction.DescriptionEn = request.DescriptionEn ?? taskOrFunction.DescriptionEn;
            taskOrFunction.DescriptionRu = request.DescriptionRu ?? taskOrFunction.DescriptionRu;
            taskOrFunction.DescriptionUz = request.DescriptionUz ?? taskOrFunction.DescriptionUz;
            taskOrFunction.DescriptionUzRu = request.DescriptionUzRu ?? taskOrFunction.DescriptionUzRu;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return taskOrFunction;
        }
    }
}
