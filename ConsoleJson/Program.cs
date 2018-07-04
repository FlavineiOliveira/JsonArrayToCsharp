using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleJson.EntitiesFirebaseDB;
using Newtonsoft.Json;

namespace ConsoleJson
{
	class Program
	{
		static void Main(string[] args)
		{
			string result = "{ \"ContadorServicoId\":2,\"Servico1\":{ \"EnderecoClinica\":\"Avenida Guimarães\",\"NomeClinica\":\"Sorridents\",\"Orientacoes\":\"Ficar de jejum\",\"TipoCategoria\":\"Dentista\",\"TipoSubCategoria\":\"Cirurgião\",\"ValorServico\":100},\"Servico2\":{ \"EnderecoClinica\":\"Avenida Hum\",\"NomeClinica\":\"DenteClean\",\"Orientacoes\":\"Nenhuma orientação recomendada\",\"TipoCategoria\":\"Dentista\",\"TipoSubCategoria\":\"Cirurgião\",\"ValorServico\":90},}";

			//Contador tem que receber o valor do ContadorServicoId do Json
			int contadorId = 2;

			result = result.Replace("\":{", "\":[{").Replace("},", "}],");

			for (int id = 0; id <= contadorId; id++)
			{
				result = result.Replace("\"Servico" + id + "\":", "\"Servico\":");
			}

			//Apenas para acompanhamento de teste
			//Console.WriteLine("Result com Replace -> " + result);

			RootServicoParceiro teste = JsonConvert.DeserializeObject<RootServicoParceiro>(result);

			/* Apenas para acompanhamento de teste
			foreach (var item in teste.Servico)
			{
				Console.WriteLine("FOREACH == " + item.ValorServico.ToString());
			}
			*/

			Console.WriteLine("Resultado == " + teste);
			Console.ReadLine();
		}

	}
}
