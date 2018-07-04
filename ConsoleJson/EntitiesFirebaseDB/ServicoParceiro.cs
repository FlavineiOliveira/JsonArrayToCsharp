using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJson.EntitiesFirebaseDB
{
	public class Servico
	{
		//[JsonProperty(PropertyName = "EnderecoClinica")]
		public string EnderecoClinica { get; set; }

		//[JsonProperty(PropertyName = "NomeClinica")]
		public string NomeClinica { get; set; }

		//[JsonProperty(PropertyName = "Orientacoes")]
		public string Orientacoes { get; set; }

		//[JsonProperty(PropertyName = "TipoCategoria")]
		public string TipoCategoria { get; set; }

		//[JsonProperty(PropertyName = "TipoSubCategoria")]
		public string TipoSubCategoria { get; set; }

		//[JsonProperty(PropertyName = "ValorServico")]
		public int ValorServico { get; set; }
	}

	public class RootServicoParceiro
	{
		//[JsonProperty(PropertyName = "ContadorServicoId")]
		public int ContadorServicoId { get; set; }

		//[JsonProperty(PropertyName = "Servico")]
		public List<Servico> Servico { get; set; }

	}
}
