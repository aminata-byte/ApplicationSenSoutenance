using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSenSoutenance.Models.data
{
    public class BdSenSoutenanceInitializer
    : CreateDatabaseIfNotExists<BdSenSoutenanceContext>
    {
        protected override void Seed(BdSenSoutenanceContext context)
        {
            context.departements.AddRange(new[]
            {
            new Departement { LibelleDepartement = "Informatique" },
            new Departement { LibelleDepartement = "Mathématiques" },
            new Departement { LibelleDepartement = "Physique" },
            new Departement { LibelleDepartement = "Chimie" },
            new Departement { LibelleDepartement = "Biologie" },
            new Departement { LibelleDepartement = "Génie Civil" },
            new Departement { LibelleDepartement = "Génie Électrique" },
            new Departement { LibelleDepartement = "Génie Mécanique" },
            new Departement { LibelleDepartement = "Économie" },
            new Departement { LibelleDepartement = "Gestion" }
        });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
