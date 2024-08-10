﻿using Application.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UserToDoList.Queries
{
    public class GetCurrentUserQuery : IRequest<UserViewModel>
    {
        public GetCurrentUserQuery() { }
    }
}
