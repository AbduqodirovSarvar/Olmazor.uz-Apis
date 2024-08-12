using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.TasksAndFunctionsToDoList.Commands
{
    public class CreateTasksAndFunctionsCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreateTasksAndFunctionsCommand, TaskOrFunction>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<TaskOrFunction> Handle(CreateTasksAndFunctionsCommand request, CancellationToken cancellationToken)
        {
            var tasksOrFunction = _mapper.Map<TaskOrFunction>(request);
            await _appDbContext.TasksAndFunctions.AddAsync(tasksOrFunction, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return tasksOrFunction;
        }
    }
}
