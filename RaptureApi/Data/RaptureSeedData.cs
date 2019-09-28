using Microsoft.EntityFrameworkCore;
using RaptureApi.Models;
using System;

namespace RaptureApi.Data
{
    public class RaptureSeedData
    {
        public RaptureSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rapture>().HasData(
                new Rapture
                {
                    Id = 1,
                    RaptureStartDate = new DateTime(2001, 12, 31),
                    RaptureEndDate = new DateTime(2001, 12, 31),
                    Predictor = "Tynnetta Muhammad",
                    Details = "Predicted the world would end this year",
                    WhoGotRaptured = "Nobody",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 2,
                    RaptureStartDate = new DateTime(2003, 5, 27),
                    RaptureEndDate = new DateTime(2003, 5, 27),
                    Predictor = "Nancy Lieder",
                    Details = "Aliens in the Zeta Reticuli star system sent Lieder messages via a brain implant that a planet would enter the solar system and cause a pole shift.",
                    WhoGotRaptured = "Nobody"
                },
                new Rapture
                {
                    Id = 3,
                    RaptureStartDate = new DateTime(2003, 10, 30),
                    RaptureEndDate = new DateTime(2003, 11, 29),
                    Predictor = "Aum Shinrikyo",
                    Details = "World is destroyed by nuclear war.",
                    WhoGotRaptured = "Nobody",
                },
                new Rapture
                {
                    Id = 4,
                    RaptureStartDate = new DateTime(2006, 9, 12),
                    RaptureEndDate = new DateTime(2006, 9, 12),
                    Predictor = "House of Yahweh",
                    Details = "World is destroyed by nuclear war beginning 12th of September 2006.",
                    WhoGotRaptured = "Nobody"
                },
                new Rapture
                {
                    Id = 5,
                    RaptureStartDate = new DateTime(2007, 4, 29),
                    RaptureEndDate = new DateTime(2007, 4, 29),
                    Predictor = "Pat Robertson",
                    Details = "Predicted the Earth's destruction in his book The New Millennium.",
                    WhoGotRaptured = "Nobody",
                },
                new Rapture
                {
                    Id = 6,
                    RaptureStartDate = new DateTime(2008, 5, 31),
                    RaptureEndDate = new DateTime(2008, 5, 31),
                    Predictor = "Pyotr Kuznetsov",
                    Details = "Apocalypse. 31 Adults and 4 children hid in a cave to escape it. Kuznetsov was not one of them.",
                    WhoGotRaptured = "2 adults died in the cave. Kuznetsov was committed.",
                    MonthOnly = true
                },
                new Rapture
                {
                    Id = 7,
                    RaptureStartDate = new DateTime(2010, 12, 31),
                    RaptureEndDate = new DateTime(2010, 12, 31),
                    Predictor = "Hermetic Order of the Golden Dawn",
                    Details = "Predicted the world would end.",
                    WhoGotRaptured = "Nobody",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 8,
                    RaptureStartDate = new DateTime(2011, 5, 21),
                    RaptureEndDate = new DateTime(2011, 5, 21),
                    Predictor = "Harold Camping",
                    Details = "Spiritual judgment and devastating earthquakes",
                    WhoGotRaptured = "Nobody"
                },
                new Rapture
                {
                    Id = 9,
                    RaptureStartDate = new DateTime(2011, 9, 29),
                    RaptureEndDate = new DateTime(2011, 9, 29),
                    Predictor = "Ronald Weinland",
                    Details = "Jesus returns",
                    WhoGotRaptured = "Nobody"
                },
                new Rapture
                {
                    Id = 10,
                    RaptureStartDate = new DateTime(2011, 8, 1),
                    RaptureEndDate = new DateTime(2011, 10, 31),
                    Predictor = "Harold Camping",
                    Details = "Rapture and end of the world following the spiritual judgment in May",
                    WhoGotRaptured = "Nobody"
                },
                new Rapture
                {
                    Id = 11,
                    RaptureStartDate = new DateTime(2012, 5, 27),
                    RaptureEndDate = new DateTime(2012, 5, 27),
                    Predictor = "Ronald Weinland",
                    Details = "Revised date of Jesus' return following his failed 2011 prediction",
                    WhoGotRaptured = "Nobody"
                },
                new Rapture
                {
                    Id = 12,
                    RaptureStartDate = new DateTime(2012, 6, 30),
                    RaptureEndDate = new DateTime(2012, 6, 30),
                    Predictor = "José Luis de Jesús",
                    Details = "The world's governments and economies collapse and followers of Luis de Jesús would undergo a transformation to be able to fly and walk through walls",
                    WhoGotRaptured = "Nobody. No reported supernatural abilities."
                },
                new Rapture
                {
                    Id = 13,
                    RaptureStartDate = new DateTime(2012, 12, 21),
                    RaptureEndDate = new DateTime(2012, 12, 21),
                    Predictor = "Various",
                    Details = "The end of the Mesoamerican Long Count Calendar (Mayan Calendar). Predicted apocalypses include: the earth being destroyed by the asteroid Nibiru or some other interplanetary object, an alien invation or a supernova.",
                    WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
                    Id = 14,
                    RaptureStartDate = new DateTime(2013, 8, 23),
                    RaptureEndDate = new DateTime(2013, 8, 23),
                    Predictor = "Grigori Rasputin",
                    Details = "A storm would take place and fire destroys most life on land. Jesus returns to comfort those in distress.",
                    WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
                    Id = 15,
                    RaptureStartDate = new DateTime(2014, 4, 1),
                    RaptureEndDate = new DateTime(2015, 9, 30),
                    Predictor = "John Hagee & Mark Biltz",
                    Details = "The Blood Moon Prophecy. The tetrad (four lunar eclipses over two years) represents the beginning of the Messianic End Times.",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new Rapture
                {
                    Id = 16,
                    RaptureStartDate = new DateTime(2017, 9, 23),
                    RaptureEndDate = new DateTime(2017, 10, 15),
                    Predictor = "David Meade",
                    Details = "Nibiru would become visible in the sky and soon destroy the Earth.",
                    WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
                    Id = 17,
                    RaptureStartDate = new DateTime(2018, 4, 23),
                    RaptureEndDate = new DateTime(2018, 4, 23),
                    Predictor = "David Meade",
                    Details = "The rapture takes place and the world ends.",
                    WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
                    Id = 18,
                    RaptureStartDate = new DateTime(2019, 6, 9),
                    RaptureEndDate = new DateTime(2019, 6, 9),
                    Predictor = "Ronald Weinland",
                    Details = "Jesus returns.",
                    WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
                    Id = 19,
                    RaptureStartDate = new DateTime(2020, 12, 31),
                    RaptureEndDate = new DateTime(2020, 12, 31),
                    Predictor = "Jeane Dixon",
                    Details = "Armageddon takes place.",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 20,
                    RaptureStartDate = new DateTime(2021, 12, 31),
                    RaptureEndDate = new DateTime(2021, 12, 31),
                    Predictor = "F. Kenton Beshore",
                    Details = "Second coming of Jesus, with the rapture being in 2021 at the latest.",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 21,
                    RaptureStartDate = new DateTime(2026, 12, 31),
                    RaptureEndDate = new DateTime(2026, 12, 31),
                    Predictor = "Messiah Foundation International",
                    Details = "The world ends due to an asteroid colliding with Earth",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 22,
                    RaptureStartDate = new DateTime(2129, 12, 31),
                    RaptureEndDate = new DateTime(2129, 12, 31),
                    Predictor = "Said Nursî",
                    Details = "An abjad interpretation of a hadith expects the world's end to occur in 2129.",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 23,
                    RaptureStartDate = new DateTime(2239, 12, 31),
                    RaptureEndDate = new DateTime(3239, 12, 31),
                    Predictor = "Talmud, Orthodox Judaism",
                    Details = "The messiah will come within 6000 years of the creation of Adam, with the destruction of the world happening 1000 years later.",
                    YearOnly = true
                },
                new Rapture
                {
                    Id = 24,
                    RaptureStartDate = new DateTime(2280, 12, 31),
                    RaptureEndDate = new DateTime(2280, 12, 31),
                    Predictor = "Rashad Khalifa",
                    Details = "Predicts the world will end this year following reaseach of the Qu'ran.",
                    YearOnly = true
                },
                new Rapture
                {
	                Id = 25,
	                RaptureStartDate = new DateTime(1901, 12, 31),
	                RaptureEndDate = new DateTime(1901, 12, 31),
	                Predictor = "Catholic Apostolic Church",
	                Details = "Jesus would return before the last of the 12 founding members of the church died. The last member died in 1901.",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 26,
	                RaptureStartDate = new DateTime(1908, 4, 23),
	                RaptureEndDate = new DateTime(1908, 4, 23),
	                Predictor = "Michael Paget Baxter",
	                Details = "Apocalypse",
	                WhoGotRaptured = "Nobody.",
                },
                new Rapture
                {
	                Id = 27,
	                RaptureStartDate = new DateTime(1910, 12, 31),
	                RaptureEndDate = new DateTime(1910, 12, 31),
	                Predictor = "Camille Flammarion",
	                Details = "Halleys Comet would destroy all life on the planet. Comet Pills were sold to prevent against toxic gasses.",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 28,
	                RaptureStartDate = new DateTime(1892, 12, 31),
	                RaptureEndDate = new DateTime(1911, 12, 31),
	                Predictor = "Charles Piazzi Smyth",
	                Details = "Predicted the Second Coming, based off of the dimensions of the Great Pyramid of Giza.",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 29,
	                RaptureStartDate = new DateTime(1874, 10, 31),
	                RaptureEndDate = new DateTime(1914, 10, 31),
	                Predictor = "Charles Taze Russell",
	                Details = "The close of the battle of the great day of God Almighty.",
	                WhoGotRaptured = "Nobody.",
	                MonthOnly = true
                },
                new Rapture
                {
	                Id = 30,
	                RaptureStartDate = new DateTime(1915, 12, 31),
	                RaptureEndDate = new DateTime(1915, 12, 31),
	                Predictor = "John Chilembwe",
	                Details = "Predicted the Millennium would begin this year",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 31,
	                RaptureStartDate = new DateTime(1918, 12, 31),
	                RaptureEndDate = new DateTime(1918, 12, 31),
	                Predictor = "International Bible Students Association",
	                Details = "Christendom shall be cut off and glorification of the Little Flock (The Church) in the Spring of 1918",
	                WhoGotRaptured = "Nobody.",
	                MonthOnly = true
                },
                new Rapture
                {
	                Id = 32,
	                RaptureStartDate = new DateTime(1920, 12, 31),
	                RaptureEndDate = new DateTime(1920, 12, 31),
	                Predictor = "International Bible Students Association",
	                Details = "God destroys churches and church members by the millions. Governments disappear with anarchy prevailing.",
	                WhoGotRaptured = "Nobody.",
	                MonthOnly = true
                },
                new Rapture
                {
	                Id = 33,
	                RaptureStartDate = new DateTime(1925, 2, 13),
	                RaptureEndDate = new DateTime(1925, 2, 13),
	                Predictor = "Margaret Rowen",
	                Details = "The angel Gabriel appeared before Rowen and told her that the world would end at midnight on this date.",
	                WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
	                Id = 34,
	                RaptureStartDate = new DateTime(1926, 12, 31),
	                RaptureEndDate = new DateTime(1926, 12, 31),
	                Predictor = "Spencer Perceval",
	                Details = "The world is growing near apocalypse due to rampant immorality in Europe.",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 35,
	                RaptureStartDate = new DateTime(1935, 9, 30),
	                RaptureEndDate = new DateTime(1935, 9, 30),
	                Predictor = "Wilbur Glenn Voliva",
	                Details = "The world is going to go puff and disappear",
	                WhoGotRaptured = "Nobody.",
	                MonthOnly = true
                },
                new Rapture
                {
	                Id = 36,
	                RaptureStartDate = new DateTime(1936, 12, 31),
	                RaptureEndDate = new DateTime(1936, 12, 31),
	                Predictor = "Herbert W. Armstrong",
	                Details = "Rapture.",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 37,
	                RaptureStartDate = new DateTime(1941, 12, 31),
	                RaptureEndDate = new DateTime(1941, 12, 31),
	                Predictor = "Jehovah's Witnesses",
	                Details = "Prediction of the end",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 38,
	                RaptureStartDate = new DateTime(1943, 12, 31),
	                RaptureEndDate = new DateTime(1943, 12, 31),
	                Predictor = "Herbert W. Armstrong",
	                Details = "Revised date of the previous rapture.",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                },
                new Rapture
                {
	                Id = 39,
	                RaptureStartDate = new DateTime(1947, 12, 31),
	                RaptureEndDate = new DateTime(1947, 12, 31),
	                Predictor = "John Ballou Newbrough",
	                Details = "The destruction of all nations and the beginning of post-apocalyptic anarchy",
	                WhoGotRaptured = "Nobody.",
	                YearOnly = true
                });
        }
    }
}
