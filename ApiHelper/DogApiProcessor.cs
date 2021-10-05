using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiHelper
{
    public class DogApiProcessor
    {

        public static async Task<List<string>> LoadBreedList()
        {
            ///TODO : À compléter LoadBreedList
            /// Attention le type de retour n'est pas nécessairement bon
            /// J'ai mis quelque chose pour avoir une base
            /// TODO : Compléter le modèle manquant

            return new List<string>();
        }

        public static async Task<DogModel> GetImageUrl(string breed)
        {
            string url;
            //url = $"https://dog.ceo/api/breed/{breed}/images/random";
            url = $"https://dog.ceo/api/breeds/image/random";

            using (HttpResponseMessage response = await
            ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DogModel dog = await response.Content.ReadAsAsync<DogModel>();
                    return dog;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
