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
                new StandardItem (name: new ItemName("+5 Dexterity Vest"), sellIn: new ItemSellIn(10), quality: new ItemQuality(20)),
                new AgedBrie (sellIn: new ItemSellIn(2), quality: new ItemQuality(0)),
                new StandardItem (name: new ItemName("Elixir of the Mongoose"), sellIn: new ItemSellIn(5), quality: new ItemQuality(7)),
                new Sulfuras (sellIn: new ItemSellIn(0), quality: new ItemQuality(80)),
                new Sulfuras (sellIn: new ItemSellIn(-1), quality: new ItemQuality(80)),
                new BackstagePasses
                (
                    sellIn: new ItemSellIn( 15),
                    quality: new ItemQuality( 20)
                ),
                new BackstagePasses
                (
                    sellIn: new ItemSellIn(10),
                    quality: new ItemQuality(49)
                ),
                new BackstagePasses
                (
                    sellIn: new ItemSellIn(5),
                    quality: new ItemQuality(49)
                ),
                // this conjured item does not work properly yet
                new Conjured (sellIn: new ItemSellIn(3), quality: new ItemQuality(6))
            };

            var app = new GildedRose();


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name.Value + ", " + Items[j].SellIn.Value + ", " + Items[j].Quality.Value);
                }
                Console.WriteLine("");
                app.UpdateQuality(Items);
            }
        }
    }
}
