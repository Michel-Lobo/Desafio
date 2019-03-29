using AutoMapper;
using DesafioWeb.ViewModels;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioWeb.App_Start
{
    public class ConfigMap
    {

        public ConfigMap()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Cliente, ClienteVM>();
                config.CreateMap<ClienteVM, Cliente>();

                config.CreateMap<PorteEmpresa, PorteEmpresaVM>();
                config.CreateMap<PorteEmpresaVM, PorteEmpresa>();
                
            });
        }
    }
}