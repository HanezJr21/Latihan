using System;
using System.Web;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Latihan.Interface;
using Latihan.Models;
using Latihan.Queries;
using Dapper;
using Newtonsoft.Json;
using System.Text;

namespace Latihan.Repository
{
    public class MenuRepository : IMenu
    {
        private readonly ILogger<MenuRepository> _logger;
        private readonly IConfiguration _configuration;
        private readonly RepositoryBase _repoBase;
        public MenuRepository(ILogger<MenuRepository> logger, IConfiguration configuration, RepositoryBase repoBase)
        {
            _logger = logger;
            _configuration = configuration;
            _repoBase = repoBase;
        }
        public List<Menu> GetMenuList()
        {
            var result = new List<Menu>();
            using (var db = _repoBase.GetDbConnection())
            {
                var resTemp = db.Query<Menu>(string.Format(MenuQuery.qGetMenuList));
                foreach (var item in resTemp)
                {
                    var itemNew = item;
                    itemNew.namaMakanan = item.namaMakanan;
                    itemNew.hargaMakanan = item.hargaMakanan;
                    result.Add(itemNew);
                }
            }
            return result;
        }
    }
}
