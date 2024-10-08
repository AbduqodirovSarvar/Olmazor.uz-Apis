﻿using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AboutToDoList.Commands
{
    public class UpdateAboutCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<UpdateAboutCommand, AboutViewModel>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<AboutViewModel> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var about = await _appDbContext.Abouts.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                   ?? throw new Exception("About not found");

            about.DescriptionRu = request?.DescriptionRu ?? about.DescriptionRu;
            about.DescriptionEn = request?.DescriptionEn ?? about.DescriptionEn;
            about.DescriptionUz = request?.DescriptionUz ?? about.DescriptionUz;
            about.DescriptionUzRu = request?.DescriptionUzRu ?? about.DescriptionUz;
            about.DescriptionKaa = request?.DescriptionKaa ?? about.DescriptionKaa;
            about.LocationId = request?.LocationId ?? about.LocationId;
            about.ReceptionTimeEn = request?.ReceptionTimeEn ?? about.ReceptionTimeEn;
            about.ReceptionTimeRu = request?.ReceptionTimeRu ?? about.ReceptionTimeRu;
            about.ReceptionTimeUz = request?.ReceptionTimeUz ?? about.ReceptionTimeUz;
            about.ReceptionTimeUzRu = request?.ReceptionTimeUzRu ?? about.ReceptionTimeUzRu;
            about.ReceptionTimeKaa = request?.ReceptionTimeKaa ?? about.ReceptionTimeKaa;

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<AboutViewModel>(about);
        }
    }
}
