﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace ProyectoProgra6_APP.Models
{
    public class UserRole
    {

        public RestRequest? Request { get; set; }

        public int RolId { get; set; }

        public string? RolUsuario1 { get; set; }


        public async Task<List<UserRole>?> GetAllUserRolesAsync()
        {
            try
            {
                string RouterSufix = string.Format("RolUsuarios");

                string URL = Services.WebAPIConnection.ProductionURLPrefix + RouterSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                Request.AddHeader(Services.WebAPIConnection.ApiKeyName, Services.WebAPIConnection.ApiKeyValue);

                RestResponse response = await client.ExecuteAsync(Request);

                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<UserRole>>(response.Content);

                    return list;
                }
                else 
                {
                    return null;
                }
                

            }
            catch (Exception ex)
            {
                string ErrorMsg = ex.Message;
                throw;
            }

        }

    }
}
