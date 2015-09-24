using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Cah.Models;
using Cah.Models.Extensions;

namespace Cah.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CahService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CahService1.svc or CahService1.svc.cs at the Solution Explorer and start debugging.
    public class CahService1 : ICahService1
    {

        public bool CreateCardSet(CardSet cardSet)
        {
            if (cardSet.IsValid())
            {
                
            }
        }
    }
}
