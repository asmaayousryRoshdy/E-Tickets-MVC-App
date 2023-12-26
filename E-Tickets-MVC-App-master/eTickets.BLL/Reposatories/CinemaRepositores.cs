﻿using eTickets.BLL.Interfaces;
using eTickets.BLL.Repositories;
using eTickets.DAL.Context;
using eTickets.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTickets.BLL.Reposatories
{
    public class CinemaRepositores : GenericRepository<Cinema>, ICinemaRepositores
    {
        private readonly MvcETicketsAppDbContext _context;

        public CinemaRepositores(MvcETicketsAppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
