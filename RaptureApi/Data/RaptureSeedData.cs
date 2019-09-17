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
                    Details = "Predicted the Earth's destruction in his book The New Millennium."
                    WhoGotRaptured = "Nobody",
                },
                new Rapture
                {
                    Id = 6,
                    RaptureStartDate = new DateTime(2008, 5, 31),
                    RaptureEndDate = new DateTime(2008, 5, 31),
                    Predictor = "Pyotr Kuznetsov",
                    Details = "Apocalypse. 31 Adults and 4 children hid in a cave to escape it. Kuznetsov was not one of them."
                    WhoGotRaptured = "2 adults died in the cave. Kuznetsov was committed.",
                    MonthOnly = true
                },
                new Rapture
                {
                    Id = 7,
                    RaptureStartDate = new DateTime(2010, 12, 31),
                    RaptureEndDate = new DateTime(2010, 12, 31),
                    Predictor = "Hermetic Order of the Golden Dawn",
                    Details = "Predicted the world would end."
                    WhoGotRaptured = "2 adults died in the cave. Kuznetsov was committed.",
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
                    Details = "Rapture and end of the world following the spiritual judgment in May"
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
                    Details = "A storm would take place and fire destroys most life on land. Jesus returns to comfort those in distress."
                    WhoGotRaptured = "Nobody."
                },
                new Rapture
                {
                    Id = 15,
                    RaptureStartDate = new DateTime(2014, 4, 1),
                    RaptureEndDate = new DateTime(2015, 9, 30),
                    Predictor = "John Hagee & Mark Biltz",
                    Details = "The Blood Moon Prophecy. The tetrad (four lunar eclipses over two years) represents the beginning of the Messianic End Times."
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
                    Details = "The rapture takes place and the world ends."
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
                });
        }
    }
}
