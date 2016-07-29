﻿using AngularMVCAuthentication.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVCAuthentication
{

    public class ModelContext : IdentityDbContext<ApplicationUser>
    {
        public ModelContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ModelContext Create()
        {
            return new ModelContext();
        }

        public System.Data.Entity.DbSet<Evento> Eventoes { get; set; }

    }
}