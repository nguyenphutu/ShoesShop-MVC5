namespace ShoesShop.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoesShop.DAL.ShoeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ShoesShop.DAL.ShoeDbContext context)
        {
            var shoes = new List<Shoes>
            {
                new Shoes
                {
                    ShoeName = "Sneakers (Black)",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s1.jpg"
                },
                new Shoes
                {
                    ShoeName = "BELLA TOES",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s2.jpg"
                },
                new Shoes
                {
                    ShoeName = "CHIKKU LOAFERS",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s3.jpg"
                },
                new Shoes
                {
                    ShoeName = "SHUBERRY HEELS",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s4.jpg"
                },
                new Shoes
                {
                    ShoeName = "RED BELLIES",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s5.jpg"
                },
                new Shoes
                {
                    ShoeName = "CATWALK FLATS",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s6.jpg"
                },
                new Shoes
                {
                    ShoeName = "RUNNING SHOES",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s7.jpg"
                },
                new Shoes
                {
                    ShoeName = "SUKUN CASUALS",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s8.jpg"
                },
                new Shoes
                {
                    ShoeName = "BANK SNEAKERS",
                    Descriptions = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Infomations = "Lorem ipsum dolor sit amet, consectetur adipisicing elPellentesque vehicula augue eget nisl ullamcorper, molestie blandit ipsum auctor. Mauris volutpat augue dolor.Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab ore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. labore et dolore magna aliqua.",
                    Price = 650,
                    Sale = 20,
                    Types = Types.CasualShoes,
                    Size = Size.M,
                    ShoeTitle = "Shoe Rock Vision(SRV) Sneakers (Black)",
                    Image = "s9.jpg"
                }
            };

            shoes.ForEach(s => context.Shoes.AddOrUpdate(p=>p.ShoeName, s));
            context.SaveChanges();

            var imageShoes = new List<ImagesShoe>
            {
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "BELLA TOES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "BELLA TOES").ID,

                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "BELLA TOES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "BELLA TOES").ID,

                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "BELLA TOES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "BELLA TOES").ID,

                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "CHIKKU LOAFERS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "CHIKKU LOAFERS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "CHIKKU LOAFERS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "CHIKKU LOAFERS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "CHIKKU LOAFERS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "CHIKKU LOAFERS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "Sneakers (Black)"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "Sneakers (Black)").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "Sneakers (Black)"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "Sneakers (Black)").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "Sneakers (Black)"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "Sneakers (Black)").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "SHUBERRY HEELS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "SHUBERRY HEELS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "SHUBERRY HEELS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "SHUBERRY HEELS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "SHUBERRY HEELS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "SHUBERRY HEELS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "RED BELLIES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "RED BELLIES").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "RED BELLIES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "RED BELLIES").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "RED BELLIES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "RED BELLIES").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "CATWALK FLATS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "CATWALK FLATS").ID,
                },new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "CATWALK FLATS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "CATWALK FLATS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "CATWALK FLATS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "CATWALK FLATS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "RUNNING SHOES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "RUNNING SHOES").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "RUNNING SHOES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "RUNNING SHOES").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "RUNNING SHOES"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "RUNNING SHOES").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "SUKUN CASUALS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "SUKUN CASUALS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "SUKUN CASUALS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "SUKUN CASUALS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "SUKUN CASUALS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "SUKUN CASUALS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d1.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "BANK SNEAKERS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "BANK SNEAKERS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d2.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "BANK SNEAKERS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "BANK SNEAKERS").ID,
                },
                new ImagesShoe
                {
                    ImageURL = "d3.jpg",
                    Shoe = shoes.FirstOrDefault(s=>s.ShoeName == "BANK SNEAKERS"),
                    ShoeId = shoes.FirstOrDefault(s=>s.ShoeName == "BANK SNEAKERS").ID,
                }
            };
            imageShoes.ForEach(i => context.ImagesShoe.Add(i));
            context.SaveChanges();
            
        }
    }
}
