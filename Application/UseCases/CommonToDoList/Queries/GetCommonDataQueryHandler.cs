using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CommonToDoList.Queries
{
    public class GetCommonDataQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetCommonDataQuery, CommonViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<CommonViewModel> Handle(GetCommonDataQuery request, CancellationToken cancellationToken)
        {
            var slidesTask = _appDbContext.Slides.ToListAsync(cancellationToken);
            var contactsTask = _appDbContext.Contacts.ToListAsync(cancellationToken);

            await Task.WhenAll(slidesTask, contactsTask);

            return new CommonViewModel()
            {
                Slides = slidesTask.Result,
                Contacts = contactsTask.Result
            };

        }
    }
}
