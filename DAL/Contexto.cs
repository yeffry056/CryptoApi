using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CryptoApi.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Coins> Coins{ get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coins>().HasData(
                new Coins()
                {
                    MonedaId = 1,
                    Descripcion = "Bitcoin",
                    Valor = 20773,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/478/PNG/512/Bitcoin_46999.png"
                },
                 new Coins()
                {
                    MonedaId = 2,
                    Descripcion = "Ethereum",
                    Valor = 1199,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/2429/PNG/512/bitcoin_logo_icon_147311.png"
                },
                 new Coins()
                {
                    MonedaId = 3,
                    Descripcion = "Dogecoin",
                    Valor = 1053,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210980.png"
                },
                 new Coins()
                {
                    MonedaId = 4,
                    Descripcion = "Tether",
                    Valor = 0.999,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png"
                },
                 new Coins()
                {
                    MonedaId = 5,
                    Descripcion = "USD Coin",
                    Valor = 1.00,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/478/PNG/512/Bitcoin_46999.png"
                },
                 new Coins()
                {
                    MonedaId = 6,
                    Descripcion = "BNB",
                    Valor = 240.58,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/2596/PNG/512/bitcoin_icon_155751.png"
                },
                 new Coins()
                {
                    MonedaId = 7,
                    Descripcion = "Binance USD",
                    Valor = 1.00,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/1495/PNG/512/bitcoin_103281.png"
                },
                 new Coins()
                {
                    MonedaId = 8,
                    Descripcion = "XRP",
                    Valor = 0.3456,
                    ImageUrl ="https://cdn.icon-icons.com/icons2/1482/PNG/512/3bitcoin_102128.png"
                }
                 

            );
        }

    }
}