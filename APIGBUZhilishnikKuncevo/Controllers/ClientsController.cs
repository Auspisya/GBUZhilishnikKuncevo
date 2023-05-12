using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using APIGBUZhilishnikKuncevo.Models;
using static System.Net.Mime.MediaTypeNames;

namespace APIGBUZhilishnikKuncevo.Controllers
{
    public class ClientsController : ApiController
    {
        private menshakova_publicUtilitiesEntities2 db = new menshakova_publicUtilitiesEntities2();

        // GET: api/Clients
        [ResponseType(typeof(ResponseClient))]
        public IHttpActionResult GetClient()
        {
            return Ok(db.Client.ToList().ConvertAll(p => new ResponseClient(p)));
        }

        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(int id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.id)
            {
                return BadRequest();
            }

            db.Entry(client).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clients
        [ResponseType(typeof(PostClient))]

        public IHttpActionResult PostClient(PostClient client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (client != null)
            {
                TIN objTIN = new TIN()
                {
                    tinNumber = client.tinNumber,
                    registrationDate = client.tinRegistrationDate,
                    whoRegistered = client.tinWhoRegistered
                };
                db.TIN.Add(objTIN);
                db.SaveChanges();

                int idRequestTIN = objTIN.id;

                StatusCode(HttpStatusCode.OK);

                SNILS objSNILS = new SNILS()
                {   
                    snilsNumber = client.snilsNumber,
                    registrationDate =client.snilsRegistrationDate
                };
                db.SNILS.Add(objSNILS);
                db.SaveChanges();

                int idRequestSNILS = objSNILS.id;

                Passport objPassport = new Passport()
                {
                    passportNumber = client.passportNumber,
                    passportSeries = client.passportSeries,
                    passportIssuedBy = client.passportIssuedBy,
                    dateOfIssue = client.dateOfIssue,
                    divisionCode = client.divisionCode,
                    placeOfBirth = client.placeOfBirth
                };
                db.Passport.Add(objPassport);
                db.SaveChanges();

                int idRequestPassport = objPassport.id;

                int idGender;

                if (client.genderName == "Мужской") { idGender = 2; } else { idGender = 1; }
                Client objClient = new Client()
                {
                    phoneNumber = client.phoneNumber,
                    passportId = idRequestPassport,
                    snilsId = idRequestSNILS,
                    tinId = idRequestTIN,
                    name = client.name,
                    surname = client.surname,
                    patronymic = client.patronymic,
                    genderId = idGender,
                    dateOfBirth = client.dateOfBirth
                };
                db.Client.Add(objClient);
                db.SaveChanges();
                return StatusCode(HttpStatusCode.OK);
            }
            else
                {
                    return StatusCode(HttpStatusCode.BadRequest);
                }
        }

            // DELETE: api/Clients/5
            [ResponseType(typeof(Client))]
            public IHttpActionResult DeleteClient(int id)
            {
                Client client = db.Client.Find(id);
                if (client == null)
                {
                    return NotFound();
                }

                db.Client.Remove(client);
                db.SaveChanges();

                return Ok(client);
            }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(int id)
        {
            return db.Client.Count(e => e.id == id) > 0;
        }
    }
}