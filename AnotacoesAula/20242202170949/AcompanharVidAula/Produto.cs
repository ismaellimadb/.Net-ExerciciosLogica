﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AcompanharVidAula
{
	internal class Produto
	{
		public string Nome;
		public double Preco;
		public int Quantidade;

		public double ValorTotalEmEstoque()
		{
			return Preco * Quantidade;
		}

		public override string ToString()
		{
			return Nome
				+ ", $ "
				+ Preco.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Quantidade
				+ " unidades, Total: $ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
