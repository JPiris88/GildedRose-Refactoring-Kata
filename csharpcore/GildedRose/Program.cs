using GildedRose;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new StandardItem (name: "+5 Dexterity Vest", sellIn: 10, quality: 20),
                new AgedBrie (name: "Aged Brie", sellIn: 2, quality: 0),
                new StandardItem (name: "Elixir of the Mongoose", sellIn: 5, quality: 7),
                new Sulfuras (name: "Sulfuras, Hand of Ragnaros", sellIn: 0, quality: 80),
                new Sulfuras (name: "Sulfuras, Hand of Ragnaros", sellIn: -1, quality: 80),
                new BackstagePasses
                (
                    name: "Backstage passes to a TAFKAL80ETC concert",
                    sellIn: 15,
                    quality: 20
                ),
                new BackstagePasses
                (
                    name: "Backstage passes to a TAFKAL80ETC concert",
                    sellIn: 10,
                    quality: 49
                ),
                new BackstagePasses
                (
                    name: "Backstage passes to a TAFKAL80ETC concert",
                    sellIn: 5,
                    quality: 49
                ),
                // this conjured item does not work properly yet
                new StandardItem (name: "Conjured Mana Cake", sellIn: 3, quality: 6)
            };

            var app = new GildedRose();


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality(Items);
            }
        }
    }
}
