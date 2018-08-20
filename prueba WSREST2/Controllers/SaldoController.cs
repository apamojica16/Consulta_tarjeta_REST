using System;
using prueba_WSREST2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prueba_WSREST2.Controllers
{
    public class SaldoController : ApiController
    {

        Saldotarjeta[] ssaldo = new Saldotarjeta[]{
 new Saldotarjeta {id_tarjeta=1, saldo=2000},
 new Saldotarjeta {id_tarjeta=2, saldo=1000},
 new Saldotarjeta {id_tarjeta=3, saldo=6000}
        };

        public IEnumerable<Saldotarjeta> GetAllProducts()
        {
            return ssaldo;
        }

        public Saldotarjeta GetProduct(int id)
        {
            var product = (ssaldo.FirstOrDefault((p) => p.id_tarjeta == id));
            if (product == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return product;
        }
    }
}
