using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace UltimateInvoicing
{
    public class UltimateInvoicingContext : DbContext
    {
        public UltimateInvoicingContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
