﻿// <auto-generated />
using System;
using CryptoApi.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220628161858_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Coins", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "Bitcoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/478/PNG/512/Bitcoin_46999.png",
                            Valor = 20773.0
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Ethereum",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2429/PNG/512/bitcoin_logo_icon_147311.png",
                            Valor = 1199.0
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "Dogecoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/bitcoin_cryptocurrency_coin_money_icon_210980.png",
                            Valor = 1053.0
                        },
                        new
                        {
                            MonedaId = 4,
                            Descripcion = "Tether",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png",
                            Valor = 0.999
                        },
                        new
                        {
                            MonedaId = 5,
                            Descripcion = "USD Coin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/478/PNG/512/Bitcoin_46999.png",
                            Valor = 1.0
                        },
                        new
                        {
                            MonedaId = 6,
                            Descripcion = "BNB",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/2596/PNG/512/bitcoin_icon_155751.png",
                            Valor = 240.58000000000001
                        },
                        new
                        {
                            MonedaId = 7,
                            Descripcion = "Binance USD",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/1495/PNG/512/bitcoin_103281.png",
                            Valor = 1.0
                        },
                        new
                        {
                            MonedaId = 8,
                            Descripcion = "XRP",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/1482/PNG/512/3bitcoin_102128.png",
                            Valor = 0.34560000000000002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
