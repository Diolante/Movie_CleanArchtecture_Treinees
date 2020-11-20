using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Movie.Application.Dtos
{
    [ExcludeFromCodeCoverage] // não entra na cobertura de teste
    public class DirectorsDto
    {
        [JsonProperty("id")]
        public int codigo { get; set; }

        [JsonProperty("name")]
        public string nome { get; set; }

        [JsonProperty("quant")]
        public int quantidade_filmes { get; set; }
    }
}
