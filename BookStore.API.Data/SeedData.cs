using BookStore.Models.Books;
using BookStore.Models.Enums;

namespace BookStore.API.Data;

public static class SeedData
{
    public static List<CreateBookDTO> SampleBookList =
    [
        new()
        {
            Title = "Abroad in Japan",
            Author = "Chris Broad",
            PublishDate = new DateTime(2024, 03, 28),
            Pages = 320,
            Genre = BookGenre.Travel,
            Synopsis =
                "From missile incidents to love hotels, Broad's hilarious and insightful travelogue of Japan is based on his numerous misadventures in the decade since he arrived to teach English.",
            Rating = 4.5,
            ISBN = "9781787637078"
        },

        new()
        {
            Title = "The Bee Sting",
            Author = "Paul Murray",
            PublishDate = new DateTime(2024, 5, 2),
            Pages = 656,
            Genre = BookGenre.Fiction,
            Synopsis =
                "One of the greatest living comic novelists follows up Skippy Dies and The Mark and the Void with a beautifully crafted bittersweet delight about one family desperately attempting to get through the most trying of times.",
            Rating = 4.5,
            ISBN = "9780374600303"
        },

        new()
        {
            Title = "Butter",
            Author = "Asako Yuzuki",
            PublishDate = new DateTime(2024,2,29),
            Pages = 464,
            Genre = BookGenre.Thriller,
            Synopsis =
                "Teeming with searing insights into sexism, obsession and pleasure, this glorious Japanese cult classic revolves around a famed female chef convicted as the serial killer of lonely businessmen and a story-hungry young journalist who wishes to learn the secrets of gourmet from her.",
            Rating = 4.5,
            ISBN = "9780063236400"
        },

        new()
        {
            Title = "Fourth Wing - The Empyrean",
            Author = "Rebecca Yarros",
            PublishDate = new DateTime(2024, 3, 26),
            Pages = 576,
            Genre = BookGenre.Fantasy,
            Synopsis =
                "A thrilling fantasy epic that has taken BookTok by storm, Fourth Wing centres on the bookish Violet's attempts to become a dragon rider amidst the intrigue and deadly danger of the kingdom of Navarre.",
            Rating = 4.5,
            ISBN = "9781649374042"
        },

        new()
        {
            Title = "The Housekeepers",
            Author = "Alex Hay",
            PublishDate = new DateTime(2024,4,30),
            Pages = 448,
            Genre = BookGenre.Crime,
            Synopsis =
                "Brilliantly constructed and wonderfully escapist, Hay's rollicking crime novel finds the slighted female staff of an illustrious Mayfair residence plot an audacious heist as the perfect revenge.",
            Rating = 4.5,
            ISBN = "9781525805004"
        },

        new()
        {
            Title = "A Court of Thorns and Roses",
            Author = "Sarah J. Maas",
            PublishDate = new DateTime(2020,6,2),
            Pages = 448,
            Genre = BookGenre.Romance,
            Synopsis =
                "Dripping with passion and danger, this tantalising opening to the bestselling fantasy romance series (inspired by Beauty and the Beast) from Sarah J Maas follows mortal Feyre who, after accidentally killing a faerie, finds herself hostage in the mystical lands of Prythian.",
            Rating = 3,
            ISBN = "9781635575569"
        },

        new()
        {
            Title = "None Of This Is True",
            Author = "Lisa Jewell",
            PublishDate = new DateTime(2024,2,29),
            Pages = 400,
            Genre = BookGenre.Thriller,
            Synopsis =
                "A podcaster's life threatens to unravel when she allows her 'birthday twin' to inveigle their way into her life in this barnstorming psychological thriller from the author of The Family Upstairs.",
            Rating = 4,
            ISBN = "9781529195989"
        },

        new()
        {
            Title = "Dune",
            Author = "Frank Herbert",
            PublishDate = new DateTime(2015,7,16),
            Pages = 592,
            Genre = BookGenre.ScienceFiction,
            Synopsis =
                "One of the pivotal works of literary science fiction, Frank Herbert’s sand-blasted epic details the internecine battles for control of the desert planet Arrakis and its precious resource, ‘spice’.",
            Rating = 3.5,
            ISBN = "9780441013593"
        },

        new()
        {
            Title = "Dog Man 12: The Scarlet Shedder",
            Author = "Dav Pilkey",
            PublishDate = new DateTime(2024,3,19),
            Pages = 224,
            Genre = BookGenre.GraphicNovel,
            Synopsis =
                "Dyed red after being dunked in tomato juice, Dog Man faces both exile and an army of AI robots in the twelfth side-splitting comic adventure in Dav Pilkey's bestselling series.",
            Rating = 5,
            ISBN = "9781338896435"
        },

        new()
        {
            Title = "The Last Devil To Die",
            Author = "Richard Osman",
            PublishDate = new DateTime(2024,5,9),
            Pages = 432,
            Genre = BookGenre.Crime,
            Synopsis =
                "The geriatric sleuths of the Thursday Murder Club are faced with their most dangerous case yet when the disappearance of a highly dangerous package sends the body count spiralling in Osman's irresistible fourth crime caper.",
            Rating = 5,
            ISBN = "9780593299425"
        }
    ];
}