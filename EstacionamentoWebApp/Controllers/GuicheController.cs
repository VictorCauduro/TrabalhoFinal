﻿using EstacionamentoWebApp.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstacionamentoWebApp.Controllers
{
    public class GuicheController : Controller
    {
        private Facade f = new Facade();
       
        public GuicheController()
        {
    }
        // GET: Guiche
        public ActionResult ligaMotivo()
        {
            return View();
        }

        public ActionResult TicketEmitidoGuiche()
        {
            return View();
        }
        

        public ActionResult index()
        {
            return View();
        }

      




        ////public ViewResult Administrativo(string searchString, string sortOrder, int? SelectedDate)
        ////{
        ////    var tickets = f.getListaDeTickets();

        ////    //var meses = f.getMeses().OrderBy(m => m.nMes).ToList();

        ////    //ViewBag.SelectedDate = new SelectList(meses, "nMes", "NomeMes", SelectedDate);
        ////    //int nMes = SelectedDate.GetValueOrDefault();

        ////    //var vagas = f.getListaDeTickets().OrderBy(vl => vl.valor_pago).ToList()
        ////    //    .Where(t => !SelectedDate.HasValue || f.mes(t.dt_hr_saida) == nMes);

        ////    //if (!String.IsNullOrEmpty(searchString))
        ////    //{
        ////    //    vagas = vagas.Where(v => f.mes(v.dt_hr_saida) == f.NumeroMesPeloNome(searchString));
        ////    //}
        ////    return View(tickets);
        ////    //ViewBag.preco == sortOrder == "Valor" ? "valor_asc" : "valor_desc";
        ////}

    }
}