﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV1.Entities;
using ProyectoPAV1.DataAccessLayer;


namespace ProyectoPAV1.BusinessLayer
{
    class PerfilService
    {
        private PerfilDao oPerfilDao;
        public PerfilService()
        {
            oPerfilDao = new PerfilDao();
        }
        public IList<Perfil> ObtenerTodos()
        {
            return oPerfilDao.GetAll();
        }
        internal IList<Perfil> ConsultarConFiltros(String condiciones)
        {
            return oPerfilDao.GetByFilters(condiciones);
        }

        internal object ObtenerPerfil(string perfil)
        {
            //SIN PARAMETROS
            return oPerfilDao.GetPerfil(perfil);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }

        internal bool CrearPerfil(Perfil oPerfil)
        {
            return oPerfilDao.Create(oPerfil);
        }
        internal bool ActualizarPerfil(Perfil oPerfilSelected)
        {
            return oPerfilDao.Update(oPerfilSelected);
        }
        internal bool ModificarEstadoPerfil(Perfil oPerfilSelected)
        {
            return oPerfilDao.Delete(oPerfilSelected);
            //throw new NotImplementedException();
        }
    }
}
