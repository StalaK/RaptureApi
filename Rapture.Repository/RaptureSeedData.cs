﻿using Microsoft.EntityFrameworkCore;
using Rapture.Common.Models;

namespace Rapture.Repository
{
    public class RaptureSeedData
    {
        internal RaptureSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaptureModel>().HasData(
                new RaptureModel
                {
                    Id = 1,
                    RaptureStartDate = new DateTime(2001, 12, 31),
                    RaptureEndDate = new DateTime(2001, 12, 31),
                    Predictor = "Tynnetta Muhammad",
                    Details = "Predicted the world would end this year",
                    WhoGotRaptured = "Nobody",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 2,
                    RaptureStartDate = new DateTime(2003, 5, 27),
                    RaptureEndDate = new DateTime(2003, 5, 27),
                    Predictor = "Nancy Lieder",
                    Details = "Aliens in the Zeta Reticuli star system sent Lieder messages via a brain implant that a planet would enter the solar system and cause a pole shift.",
                    WhoGotRaptured = "Nobody"
                },
                new RaptureModel
                {
                    Id = 3,
                    RaptureStartDate = new DateTime(2003, 10, 30),
                    RaptureEndDate = new DateTime(2003, 11, 29),
                    Predictor = "Aum Shinrikyo",
                    Details = "World is destroyed by nuclear war.",
                    WhoGotRaptured = "Nobody",
                },
                new RaptureModel
                {
                    Id = 4,
                    RaptureStartDate = new DateTime(2006, 9, 12),
                    RaptureEndDate = new DateTime(2006, 9, 12),
                    Predictor = "House of Yahweh",
                    Details = "World is destroyed by nuclear war beginning 12th of September 2006.",
                    WhoGotRaptured = "Nobody"
                },
                new RaptureModel
                {
                    Id = 5,
                    RaptureStartDate = new DateTime(2007, 4, 29),
                    RaptureEndDate = new DateTime(2007, 4, 29),
                    Predictor = "Pat Robertson",
                    Details = "Predicted the Earth's destruction in his book The New Millennium.",
                    WhoGotRaptured = "Nobody",
                },
                new RaptureModel
                {
                    Id = 6,
                    RaptureStartDate = new DateTime(2008, 5, 31),
                    RaptureEndDate = new DateTime(2008, 5, 31),
                    Predictor = "Pyotr Kuznetsov",
                    Details = "Apocalypse. 31 Adults and 4 children hid in a cave to escape it. Kuznetsov was not one of them.",
                    WhoGotRaptured = "2 adults died in the cave. Kuznetsov was committed.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 7,
                    RaptureStartDate = new DateTime(2010, 12, 31),
                    RaptureEndDate = new DateTime(2010, 12, 31),
                    Predictor = "Hermetic Order of the Golden Dawn",
                    Details = "Predicted the world would end.",
                    WhoGotRaptured = "Nobody",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 8,
                    RaptureStartDate = new DateTime(2011, 5, 21),
                    RaptureEndDate = new DateTime(2011, 5, 21),
                    Predictor = "Harold Camping",
                    Details = "Spiritual judgment and devastating earthquakes",
                    WhoGotRaptured = "Nobody"
                },
                new RaptureModel
                {
                    Id = 9,
                    RaptureStartDate = new DateTime(2011, 9, 29),
                    RaptureEndDate = new DateTime(2011, 9, 29),
                    Predictor = "Ronald Weinland",
                    Details = "Jesus returns",
                    WhoGotRaptured = "Nobody"
                },
                new RaptureModel
                {
                    Id = 10,
                    RaptureStartDate = new DateTime(2011, 8, 1),
                    RaptureEndDate = new DateTime(2011, 10, 31),
                    Predictor = "Harold Camping",
                    Details = "Rapture and end of the world following the spiritual judgment in May",
                    WhoGotRaptured = "Nobody"
                },
                new RaptureModel
                {
                    Id = 11,
                    RaptureStartDate = new DateTime(2012, 5, 27),
                    RaptureEndDate = new DateTime(2012, 5, 27),
                    Predictor = "Ronald Weinland",
                    Details = "Revised date of Jesus' return following his failed 2011 prediction",
                    WhoGotRaptured = "Nobody"
                },
                new RaptureModel
                {
                    Id = 12,
                    RaptureStartDate = new DateTime(2012, 6, 30),
                    RaptureEndDate = new DateTime(2012, 6, 30),
                    Predictor = "José Luis de Jesús",
                    Details = "The world's governments and economies collapse and followers of Luis de Jesús would undergo a transformation to be able to fly and walk through walls",
                    WhoGotRaptured = "Nobody. No reported supernatural abilities."
                },
                new RaptureModel
                {
                    Id = 13,
                    RaptureStartDate = new DateTime(2012, 12, 21),
                    RaptureEndDate = new DateTime(2012, 12, 21),
                    Predictor = "Various",
                    Details = "The end of the Mesoamerican Long Count Calendar (Mayan Calendar). Predicted apocalypses include: the earth being destroyed by the asteroid Nibiru or some other interplanetary object, an alien invation or a supernova.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 14,
                    RaptureStartDate = new DateTime(2013, 8, 23),
                    RaptureEndDate = new DateTime(2013, 8, 23),
                    Predictor = "Grigori Rasputin",
                    Details = "A storm would take place and fire destroys most life on land. Jesus returns to comfort those in distress.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 15,
                    RaptureStartDate = new DateTime(2014, 4, 1),
                    RaptureEndDate = new DateTime(2015, 9, 30),
                    Predictor = "John Hagee & Mark Biltz",
                    Details = "The Blood Moon Prophecy. The tetrad (four lunar eclipses over two years) represents the beginning of the Messianic End Times.",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 16,
                    RaptureStartDate = new DateTime(2017, 9, 23),
                    RaptureEndDate = new DateTime(2017, 10, 15),
                    Predictor = "David Meade",
                    Details = "Nibiru would become visible in the sky and soon destroy the Earth.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 17,
                    RaptureStartDate = new DateTime(2018, 4, 23),
                    RaptureEndDate = new DateTime(2018, 4, 23),
                    Predictor = "David Meade",
                    Details = "The rapture takes place and the world ends.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 18,
                    RaptureStartDate = new DateTime(2019, 6, 9),
                    RaptureEndDate = new DateTime(2019, 6, 9),
                    Predictor = "Ronald Weinland",
                    Details = "Jesus returns.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 19,
                    RaptureStartDate = new DateTime(2020, 12, 31),
                    RaptureEndDate = new DateTime(2020, 12, 31),
                    Predictor = "Jeane Dixon",
                    Details = "Armageddon takes place.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 20,
                    RaptureStartDate = new DateTime(2021, 12, 31),
                    RaptureEndDate = new DateTime(2021, 12, 31),
                    Predictor = "F. Kenton Beshore",
                    Details = "Second coming of Jesus, with the rapture being in 2021 at the latest.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 21,
                    RaptureStartDate = new DateTime(2026, 12, 31),
                    RaptureEndDate = new DateTime(2026, 12, 31),
                    Predictor = "Messiah Foundation International",
                    Details = "The world ends due to an asteroid colliding with Earth",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 22,
                    RaptureStartDate = new DateTime(2129, 12, 31),
                    RaptureEndDate = new DateTime(2129, 12, 31),
                    Predictor = "Said Nursî",
                    Details = "An abjad interpretation of a hadith expects the world's end to occur in 2129.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 23,
                    RaptureStartDate = new DateTime(2239, 12, 31),
                    RaptureEndDate = new DateTime(3239, 12, 31),
                    Predictor = "Talmud, Orthodox Judaism",
                    Details = "The messiah will come within 6000 years of the creation of Adam, with the destruction of the world happening 1000 years later.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 24,
                    RaptureStartDate = new DateTime(2280, 12, 31),
                    RaptureEndDate = new DateTime(2280, 12, 31),
                    Predictor = "Rashad Khalifa",
                    Details = "Predicts the world will end this year following reaseach of the Qu'ran.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 25,
                    RaptureStartDate = new DateTime(1901, 12, 31),
                    RaptureEndDate = new DateTime(1901, 12, 31),
                    Predictor = "Catholic Apostolic Church",
                    Details = "Jesus would return before the last of the 12 founding members of the church died. The last member died in 1901.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 26,
                    RaptureStartDate = new DateTime(1908, 4, 23),
                    RaptureEndDate = new DateTime(1908, 4, 23),
                    Predictor = "Michael Paget Baxter",
                    Details = "Apocalypse",
                    WhoGotRaptured = "Nobody.",
                },
                new RaptureModel
                {
                    Id = 27,
                    RaptureStartDate = new DateTime(1910, 12, 31),
                    RaptureEndDate = new DateTime(1910, 12, 31),
                    Predictor = "Camille Flammarion",
                    Details = "Halleys Comet would destroy all life on the planet. Comet Pills were sold to prevent against toxic gasses.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 28,
                    RaptureStartDate = new DateTime(1911, 12, 31),
                    RaptureEndDate = new DateTime(1911, 12, 31),
                    Predictor = "Charles Piazzi Smyth",
                    Details = "Predicted the Second Coming, based off of the dimensions of the Great Pyramid of Giza.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 29,
                    RaptureStartDate = new DateTime(1874, 10, 31),
                    RaptureEndDate = new DateTime(1914, 10, 31),
                    Predictor = "Charles Taze Russell",
                    Details = "The close of the battle of the great day of God Almighty.",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 30,
                    RaptureStartDate = new DateTime(1915, 12, 31),
                    RaptureEndDate = new DateTime(1915, 12, 31),
                    Predictor = "John Chilembwe",
                    Details = "Predicted the Millennium would begin this year",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 31,
                    RaptureStartDate = new DateTime(1918, 12, 31),
                    RaptureEndDate = new DateTime(1918, 12, 31),
                    Predictor = "International Bible Students Association",
                    Details = "Christendom shall be cut off and glorification of the Little Flock (The Church) in the Spring of 1918",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 32,
                    RaptureStartDate = new DateTime(1920, 12, 31),
                    RaptureEndDate = new DateTime(1920, 12, 31),
                    Predictor = "International Bible Students Association",
                    Details = "God destroys churches and church members by the millions. Governments disappear with anarchy prevailing.",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 33,
                    RaptureStartDate = new DateTime(1925, 2, 13),
                    RaptureEndDate = new DateTime(1925, 2, 13),
                    Predictor = "Margaret Rowen",
                    Details = "The angel Gabriel appeared before Rowen and told her that the world would end at midnight on this date.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 34,
                    RaptureStartDate = new DateTime(1926, 12, 31),
                    RaptureEndDate = new DateTime(1926, 12, 31),
                    Predictor = "Spencer Perceval",
                    Details = "The world is growing near apocalypse due to rampant immorality in Europe.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 35,
                    RaptureStartDate = new DateTime(1935, 9, 30),
                    RaptureEndDate = new DateTime(1935, 9, 30),
                    Predictor = "Wilbur Glenn Voliva",
                    Details = "The world is going to go puff and disappear",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 36,
                    RaptureStartDate = new DateTime(1936, 12, 31),
                    RaptureEndDate = new DateTime(1936, 12, 31),
                    Predictor = "Herbert W. Armstrong",
                    Details = "Rapture.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 37,
                    RaptureStartDate = new DateTime(1941, 12, 31),
                    RaptureEndDate = new DateTime(1941, 12, 31),
                    Predictor = "Jehovah's Witnesses",
                    Details = "Prediction of the end",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 38,
                    RaptureStartDate = new DateTime(1943, 12, 31),
                    RaptureEndDate = new DateTime(1943, 12, 31),
                    Predictor = "Herbert W. Armstrong",
                    Details = "Revised date of the previous rapture.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 39,
                    RaptureStartDate = new DateTime(1947, 12, 31),
                    RaptureEndDate = new DateTime(1947, 12, 31),
                    Predictor = "John Ballou Newbrough",
                    Details = "The destruction of all nations and the beginning of post-apocalyptic anarchy",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 40,
                    RaptureStartDate = new DateTime(1954, 12, 21),
                    RaptureEndDate = new DateTime(1954, 12, 21),
                    Predictor = "Dorothy Martin",
                    Details = "The world is destroyed by flooding",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 41,
                    RaptureStartDate = new DateTime(1959, 4, 22),
                    RaptureEndDate = new DateTime(1959, 4, 22),
                    Predictor = "Florence Houteff",
                    Details = "The second prophet of the Branch Davidians predicted the apocalypse foretold in the Book of Revelation occurrs on this date.",
                    WhoGotRaptured = "Nobody, but the Branch Davidians split into several subsects."
                },
                new RaptureModel
                {
                    Id = 42,
                    RaptureStartDate = new DateTime(1962, 2, 4),
                    RaptureEndDate = new DateTime(1962, 2, 4),
                    Predictor = "Jeane Dixon",
                    Details = "A planetary alignment will bring destruction to the world.",
                    WhoGotRaptured = "Nobody, but mass prayer meetings were held in India."
                },
                new RaptureModel
                {
                    Id = 43,
                    RaptureStartDate = new DateTime(1967, 8, 20),
                    RaptureEndDate = new DateTime(1967, 8, 20),
                    Predictor = "George Van Tassel",
                    Details = "Van Tassel channeled an alien named Ashtar who told him the third woe of the Apocalypse begins where the southeastern US is destroyed in a Soviet nuclear attack.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 44,
                    RaptureStartDate = new DateTime(1967, 12, 31),
                    RaptureEndDate = new DateTime(1967, 12, 31),
                    Predictor = "Jim Jones",
                    Details = "Nuclear holocaust would happen this year",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 45,
                    RaptureStartDate = new DateTime(1969, 8, 9),
                    RaptureEndDate = new DateTime(1969, 8, 9),
                    Predictor = "George Williams",
                    Details = "The Second Coming of Christ occurs on this day",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 46,
                    RaptureStartDate = new DateTime(1969, 12, 31),
                    RaptureEndDate = new DateTime(1969, 12, 31),
                    Predictor = "Charles Manson",
                    Details = "Helter Skelter, an apocalyptic race war, occurs.",
                    WhoGotRaptured = "Nobody outside of the Manson Family murders."
                },
                new RaptureModel
                {
                    Id = 47,
                    RaptureStartDate = new DateTime(1972, 12, 31),
                    RaptureEndDate = new DateTime(1972, 12, 31),
                    Predictor = "Herbert W. Armstrong",
                    Details = "The second revised date after his 1943 prediction failed.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 48,
                    RaptureStartDate = new DateTime(1974, 1, 31),
                    RaptureEndDate = new DateTime(1974, 1, 31),
                    Predictor = "David Berg",
                    Details = "Doomsday heralded by Comet Kohoutek",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 49,
                    RaptureStartDate = new DateTime(1975, 12, 31),
                    RaptureEndDate = new DateTime(1975, 12, 31),
                    Predictor = "Herbert W. Armstrong",
                    Details = "The third and final revision of Armstrong's predicted Rapture.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 50,
                    RaptureStartDate = new DateTime(1975, 12, 31),
                    RaptureEndDate = new DateTime(1975, 12, 31),
                    Predictor = "Jehovah's Witnesses",
                    Details = "1975 is 6000 years since the creation of man and the end of the armageddon.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 51,
                    RaptureStartDate = new DateTime(1976, 12, 31),
                    RaptureEndDate = new DateTime(1976, 12, 31),
                    Predictor = "Brahma Kumaris",
                    Details = "Armageddon where Brahma Kumari leaders will be purified whilst the rest of the world is killed by nuclear or civil wars, sinking all continents except India.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 52,
                    RaptureStartDate = new DateTime(1977, 12, 31),
                    RaptureEndDate = new DateTime(1977, 12, 31),
                    Predictor = "John Wroe",
                    Details = "Armageddon.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 53,
                    RaptureStartDate = new DateTime(1977, 12, 31),
                    RaptureEndDate = new DateTime(1977, 12, 31),
                    Predictor = "William M. Branham",
                    Details = "Armageddon occurs no later than 1977.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 54,
                    RaptureStartDate = new DateTime(1979, 2, 17),
                    RaptureEndDate = new DateTime(1979, 2, 17),
                    Predictor = "Roch Thériault",
                    Details = "Led a commune into the Quebec wilderness to form a new society during God's 1000 year reign followed by Armageddon.",
                    WhoGotRaptured = "Nobody.",
                },
                new RaptureModel
                {
                    Id = 55,
                    RaptureStartDate = new DateTime(1980, 12, 31),
                    RaptureEndDate = new DateTime(1980, 12, 31),
                    Predictor = "Leland Jensen",
                    Details = "Nuclear disaster, followed by two decades of conflict culminating in God's Kingdom being established on Earth.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 56,
                    RaptureStartDate = new DateTime(1981, 12, 31),
                    RaptureEndDate = new DateTime(1981, 12, 31),
                    Predictor = "Chuck Smith",
                    Details = "The generation of 1948 is the last generation and the world ends in 1981.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 57,
                    RaptureStartDate = new DateTime(1982, 3, 10),
                    RaptureEndDate = new DateTime(1982, 3, 10),
                    Predictor = "John Gribbin, Stephen Plagemann",
                    Details = "Believed the gravitational force of the aligned planets would cause a number of catastrophes, including earthquakes across the San Andreas Fault.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 58,
                    RaptureStartDate = new DateTime(1982, 4, 30),
                    RaptureEndDate = new DateTime(1982, 6, 30),
                    Predictor = "Tara Centers",
                    Details = "Declared \"Christ is now here!\" in newspaper advertisements and claimed he would make himself known \"within the next two months \"",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 59,
                    RaptureStartDate = new DateTime(1982, 6, 21),
                    RaptureEndDate = new DateTime(1982, 6, 21),
                    Predictor = "Benjamin Creme",
                    Details = "Placed advertisements in the Los Angeles Times stating that the second coming would occur in June with the Maitreya (World Teacher) announcing it on worldwide TV.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 60,
                    RaptureStartDate = new DateTime(1982, 12, 31),
                    RaptureEndDate = new DateTime(1982, 12, 31),
                    Predictor = "Pat Robertson",
                    Details = "Predicted the world would end this year on his 700 Club TV programme.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 61,
                    RaptureStartDate = new DateTime(1985, 12, 31),
                    RaptureEndDate = new DateTime(1985, 12, 31),
                    Predictor = "Lester Sumrall",
                    Details = "Predicted the world ends in 1985.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 62,
                    RaptureStartDate = new DateTime(1986, 4, 29),
                    RaptureEndDate = new DateTime(1986, 4, 29),
                    Predictor = "Leland Jensen",
                    Details = "Predicted that Halley's Comet would be pulled into Earth's orbit.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 63,
                    RaptureStartDate = new DateTime(1988, 9, 11),
                    RaptureEndDate = new DateTime(1988, 9, 11),
                    Predictor = "Edgar C. Whisenant",
                    Details = "Rapture of the Christian Church.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 64,
                    RaptureStartDate = new DateTime(1988, 10, 3),
                    RaptureEndDate = new DateTime(1988, 10, 3),
                    Predictor = "Edgar C. Whisenant",
                    Details = "Whisenant's revised prediction of the rapture of the Christian Church, following the failed September prediction.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 65,
                    RaptureStartDate = new DateTime(1990, 4, 23),
                    RaptureEndDate = new DateTime(1990, 4, 23),
                    Predictor = "Elizabeth Clare Prophet",
                    Details = "A nuclear war starts on this day and lasts for 12 years.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 66,
                    RaptureStartDate = new DateTime(1991, 9, 9),
                    RaptureEndDate = new DateTime(1991, 9, 9),
                    Predictor = "Menachem Mendel Schneerson",
                    Details = "The Messiah would arrive at the start of the Jewish New Year",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 67,
                    RaptureStartDate = new DateTime(1991, 12, 31),
                    RaptureEndDate = new DateTime(1991, 12, 31),
                    Predictor = "Louis Farrakhan",
                    Details = "The Gulf War would be the War of Armageddon which is the final war",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 68,
                    RaptureStartDate = new DateTime(1992, 9, 28),
                    RaptureEndDate = new DateTime(1992, 9, 28),
                    Predictor = "Rollen Stewart",
                    Details = "The rapture begins",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 69,
                    RaptureStartDate = new DateTime(1992, 10, 28),
                    RaptureEndDate = new DateTime(1992, 10, 28),
                    Predictor = "Lee Jang Rim",
                    Details = "The rapture occurs on this day",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 70,
                    RaptureStartDate = new DateTime(1993, 12, 31),
                    RaptureEndDate = new DateTime(1993, 12, 31),
                    Predictor = "David Berg",
                    Details = "The Second Coming takes place this year",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 71,
                    RaptureStartDate = new DateTime(1994, 5, 2),
                    RaptureEndDate = new DateTime(1994, 5, 2),
                    Predictor = "Neal Chase",
                    Details = "New York City would be destroyed by a nuclear bomb on the 23rd of March 1994, with the Battle of Armageddon taking place on the 2nd of May 1994.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 72,
                    RaptureStartDate = new DateTime(1994, 9, 6),
                    RaptureEndDate = new DateTime(1994, 9, 6),
                    Predictor = "Harold Camping",
                    Details = "Camping predicted the rapture would take place.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 73,
                    RaptureStartDate = new DateTime(1994, 9, 29),
                    RaptureEndDate = new DateTime(1994, 9, 29),
                    Predictor = "Harold Camping",
                    Details = "Camping's next rapture predicting, following the failure of his first.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 74,
                    RaptureStartDate = new DateTime(1994, 10, 2),
                    RaptureEndDate = new DateTime(1994, 10, 2),
                    Predictor = "Harold Camping",
                    Details = "Camping's third rapture prediction, following the failure of his previous two.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 75,
                    RaptureStartDate = new DateTime(1995, 3, 31),
                    RaptureEndDate = new DateTime(1995, 3, 31),
                    Predictor = "Harold Camping",
                    Details = "Camping's fourth rapture prediction, following the failure of his previous three.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 76,
                    RaptureStartDate = new DateTime(1996, 12, 17),
                    RaptureEndDate = new DateTime(1996, 12, 17),
                    Predictor = "Sheldan Nidle",
                    Details = "The world ends with the arrival of 16 million space ships and a host of angels.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 77,
                    RaptureStartDate = new DateTime(1997, 3, 26),
                    RaptureEndDate = new DateTime(1997, 3, 26),
                    Predictor = "Marshall Applewhite",
                    Details = "A spacecraft was trailing the Hale-Bopp comet and suicide was the only way to evacuate Earth the souls could board the spacecraft and be taken to a level of exitence above human.",
                    WhoGotRaptured = "38 of Applewhite's followers commited suicide. It's unknown as to whether or not their souls reached the spacecraft."
                },
                new RaptureModel
                {
                    Id = 78,
                    RaptureStartDate = new DateTime(1997, 10, 23),
                    RaptureEndDate = new DateTime(1997, 10, 23),
                    Predictor = "James Ussher",
                    Details = "This date is 6000 years since the creation, and therefore the end of the world.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 79,
                    RaptureStartDate = new DateTime(1998, 3, 31),
                    RaptureEndDate = new DateTime(1998, 3, 31),
                    Predictor = "Hon-Ming Chen",
                    Details = "God will arrive at Earth at 10am on this date in a flying saucer.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 80,
                    RaptureStartDate = new DateTime(1999, 7, 31),
                    RaptureEndDate = new DateTime(1999, 7, 31),
                    Predictor = "Nostradamus",
                    Details = "A King of Terror would come from the sky in \"1999 and seven months\".",
                    WhoGotRaptured = "Nobody.",
                    MonthOnly = true
                },
                new RaptureModel
                {
                    Id = 81,
                    RaptureStartDate = new DateTime(1999, 8, 18),
                    RaptureEndDate = new DateTime(1999, 8, 18),
                    Predictor = "The Amazing Criswell",
                    Details = "This psychic, well known for predictions, predicted the end of the world on this date",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 82,
                    RaptureStartDate = new DateTime(1999, 9, 11),
                    RaptureEndDate = new DateTime(1999, 9, 11),
                    Predictor = "Philip Berg",
                    Details = "A ball of fire will descend, destroying almost all of mankind, all vegetation and all forms of life.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 83,
                    RaptureStartDate = new DateTime(1999, 12, 31),
                    RaptureEndDate = new DateTime(1999, 12, 31),
                    Predictor = "Charles Berlitz",
                    Details = "The world would end this year, maybe by nuclear devastation, asteroid impact, pole shift or other Earth changes.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 84,
                    RaptureStartDate = new DateTime(1999, 12, 31),
                    RaptureEndDate = new DateTime(1999, 12, 31),
                    Predictor = "Hon-Ming Chen",
                    Details = "A nuclear holocaust would destroy Europe and Asia.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 85,
                    RaptureStartDate = new DateTime(1999, 12, 31),
                    RaptureEndDate = new DateTime(1999, 12, 31),
                    Predictor = "James Gordon Lindsay",
                    Details = "The great tribulation would begin before 2000.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 86,
                    RaptureStartDate = new DateTime(1999, 12, 31),
                    RaptureEndDate = new DateTime(1999, 12, 31),
                    Predictor = "Timothy Dwight IV",
                    Details = "Christ's Millennium starting by 2000.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 87,
                    RaptureStartDate = new DateTime(1999, 12, 31),
                    RaptureEndDate = new DateTime(1999, 12, 31),
                    Predictor = "Nazim Al-Haqqani",
                    Details = "The last judgment would occur before 2000.",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 88,
                    RaptureStartDate = new DateTime(2000, 1, 1),
                    RaptureEndDate = new DateTime(2000, 1, 1),
                    Predictor = "Movement for the Restoration of the Ten Commandments of God",
                    Details = "Apocalypse",
                    WhoGotRaptured = "Nobody, but 778 followers of this movement died in a fire and a series of poisonings and killings, either as a form of group suicide or orchestrated mass murder by the group leaders after the failed prediction."
                },
                new RaptureModel
                {
                    Id = 89,
                    RaptureStartDate = new DateTime(2000, 1, 1),
                    RaptureEndDate = new DateTime(2000, 1, 1),
                    Predictor = "Jerry Falwell",
                    Details = "God pours his judgment upon the world",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 90,
                    RaptureStartDate = new DateTime(2000, 1, 1),
                    RaptureEndDate = new DateTime(2000, 1, 1),
                    Predictor = "Tim LaHaye & Jerry B. Jenkins",
                    Details = "The Y2K bug would trigger global economic chaos, causing the Antichrist to rise to power. They changed their minds about this prediction as the date drew closer.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 91,
                    RaptureStartDate = new DateTime(2000, 1, 1),
                    RaptureEndDate = new DateTime(2000, 1, 1),
                    Predictor = "Various",
                    Details = "The Y2K bug would crash many computers at midnight on the 1st of January, causing malfuntions which lead to major catastrophies worldwide, causing society to stop functioning.",
                    WhoGotRaptured = "Nobody, but there were some reported malfunctions with some technologies."
                },
                new RaptureModel
                {
                    Id = 92,
                    RaptureStartDate = new DateTime(2000, 4, 6),
                    RaptureEndDate = new DateTime(2000, 4, 6),
                    Predictor = "James Harmston",
                    Details = "The Second Coming of Christ occurs on this day",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 93,
                    RaptureStartDate = new DateTime(2000, 5, 5),
                    RaptureEndDate = new DateTime(2000, 5, 5),
                    Predictor = "Nuwaubian Nation",
                    Details = "The planetary lineup would cause a \"star holocaust\", pulling all the planets into the sun.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 94,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Ruth Montgomery",
                    Details = "The Earth's axis would shift and the Antichrist would reveal himself",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 95,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Edgar Cayce",
                    Details = "The Second Coming would occur in the year 2000",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 96,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Sun Myung Moon",
                    Details = "The Kingdom of Heaven would be established in 2000",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 97,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Ed Dobson",
                    Details = "Predicted the end of the world in his book \"The End: Why Jesus Could Return by A.D. 2000\"",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 98,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Lester Sumrall",
                    Details = "Predicted the end of the world in his book \"I Predict 2000\"",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 99,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Jonathan Edwards",
                    Details = "Christ's 1000 year reign would begin in the year 2000",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                },
                new RaptureModel
                {
                    Id = 100,
                    RaptureStartDate = new DateTime(1987, 8, 17),
                    RaptureEndDate = new DateTime(1987, 8, 17),
                    Predictor = "José Argüelles",
                    Details = "Armageddon would heppen unless 144,000 people gathered in specifc places on Earth and meditated at the same time, which became known as Harmonic Convergence.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 101,
                    RaptureStartDate = new DateTime(1989, 9, 30),
                    RaptureEndDate = new DateTime(1989, 9, 30),
                    Predictor = "Edgar C. Whisenant",
                    Details = "Whisenant's revised prediction of the rapture of the Christian Church, following failure of his two previous predictions.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 102,
                    RaptureStartDate = new DateTime(1997, 8, 10),
                    RaptureEndDate = new DateTime(1997, 8, 10),
                    Predictor = "Aggai",
                    Details = "The birth date of the Antichrist and the end of the universe.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 103,
                    RaptureStartDate = new DateTime(1998, 3, 31),
                    RaptureEndDate = new DateTime(1998, 3, 31),
                    Predictor = "Hon-Ming Chen",
                    Details = "God will arrive at Earth at 10am on this date in a flying saucer.",
                    WhoGotRaptured = "Nobody."
                },
                new RaptureModel
                {
                    Id = 104,
                    RaptureStartDate = new DateTime(2000, 12, 31),
                    RaptureEndDate = new DateTime(2000, 12, 31),
                    Predictor = "Peter Olivi",
                    Details = "The Antichrist who came to power between 1300 and 1340 would perform the Last Judgment in 2000",
                    WhoGotRaptured = "Nobody.",
                    YearOnly = true
                });
        }
    }
}
