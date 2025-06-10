using System.Collections;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using Dsw2025Ej14.Api.Domain;
using System.Security.Cryptography;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {
       


        private List<Product> productos;

        public PersistenciaEnMemoria() { }

      /*  public <Product> GetProducts()
            {
            return _products.where(Product=> p.isActive);
            }
      */
        private List<Product> LoadProducts()
        {
            var json = await File.ReadAllText("products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];

        }
    } 
        
    
}

    

