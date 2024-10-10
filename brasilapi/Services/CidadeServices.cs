using brasilapi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace brasilapi.Services
{
    public class CidadeServices
    {
        private HttpClient httpclient;
        private Cidade cidade;
        private List<Cidade> cidades;
        private JsonSerializerOptions options;

        public CidadeServices()
        {
            httpclient = new HttpClient();
            options = new JsonSerializerOptions();
        }

        public async Task<ObservableCollection<Cidade>> getCidades()
        {
            Uri uri = new Uri("https://brasilapi.com.br/api/cptec/v1/cidade");
            ObservableCollection<Cidade> cidades = new ObservableCollection<Cidade>();

            try
            {
                HttpResponseMessage response = await httpclient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    cidades = JsonSerializer.Deserialize<ObservableCollection<Cidade>>(content, options);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return cidades;
        }
}
}
