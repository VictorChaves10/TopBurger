using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopBurgers.Context;
using TopBurgers.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TopBurgers.Areas.admin.Servicos

{
    public class RelatorioVendasService
    {
        private readonly AppDbContext context;

        public RelatorioVendasService(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in context.Pedidos select obj;
            
            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.PedidoEnviado <= maxDate.Value);
            }

            return await resultado
                            .Include(l => l.PedidosItens)
                            .ThenInclude(l => l.Lanche)
                            .OrderByDescending(x => x.PedidoEnviado)
                            .ToListAsync();

        }
    }
}
