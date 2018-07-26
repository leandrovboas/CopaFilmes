﻿using AutoMapper;
using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Leandrovboas.CopaFilmes.Mvc.Controllers.Api
{
    [RoutePrefix("v1/Campeonato/api/")]
    public class CampeonatoApiController : ApiController
    {
        private readonly ICampeonatoServicoApp _servicoApp;

        public CampeonatoApiController(ICampeonatoServicoApp servicoApp)
        {
            _servicoApp = servicoApp;
        }

        [HttpPost]
        [Route("IniciarCampeonato/{listaFilmes}")]
        public async Task<IHttpActionResult> IniciarCampeonatoAsync(List<Filme> listaFilmes)
        {
            if (listaFilmes == null || listaFilmes.Count != 16) return BadRequest("Lista de Filmes invalida para realizar essa operação, verifique a quantirade de filmes obrigatórios");

            var resultado = _servicoApp.RealizarCampeonato(listaFilmes);
            if (resultado != null)
            {
                var model = Mapper.Map<CampeonatoViewModel>(resultado);
                return Ok(model);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
