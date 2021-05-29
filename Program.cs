using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                var mediaLibrary = new MediaLibrary(new MediaType[]
                {
                    new Book("The Teachings of Don Jaun: A Yaqui Way of Knowledge", "Carlos Castaneda"),
                    new Book("Dune", "Frank Herbert"),
                    new VideoGame("Ghost of Tsushima", "PS4"),
                    new VideoGame("The Last of Us Part 2", "PS4")
                });

                Console.WriteLine("Oooh what do we have here? It's a media library! Let's see what all we got!");
                Console.WriteLine("");

                mediaLibrary.DisplayItems();

                Console.WriteLine("");
                Console.WriteLine($"Wow {mediaLibrary.NumberOfItems} things! That sure is a number of things.");
                Console.WriteLine("");
                Console.WriteLine("Hey, what kinds of media you got in there again?");
                Console.WriteLine("");

                for (int i = 0; i < mediaLibrary.NumberOfItems; i++)
                {
                    DetectMediaType(mediaLibrary.GetItemAt(i));
                }

                Console.WriteLine("");

                mediaLibrary.GetItemAt(0).Loan("Anne Broleyn");
                mediaLibrary.GetItemAt(1).Loan("Humphrey Brogart");
                mediaLibrary.GetItemAt(2).Loan("Bro Derek");
                mediaLibrary.GetItemAt(3).Loan("Abroham Lincoln");

                Console.WriteLine("Some bros came to borrow some of those sweet medias. Lets see who's got what.");
                Console.WriteLine("");

                mediaLibrary.DisplayItems();

                Console.WriteLine("");
                Console.WriteLine("Lets search for the book Dune");
                Console.WriteLine("");

                mediaLibrary.FindItem("Dune");

                Console.WriteLine("");
                Console.WriteLine("Humphrey Brogart is always bogarting my stuff, lets ask him to give it back");
                Console.WriteLine("");

                mediaLibrary.GetItemAt(1).Return();

                Console.WriteLine("");
                Console.WriteLine("We'll search for it and see if he's returned it.");
                Console.WriteLine("");

                mediaLibrary.FindItem("Dune");

                Console.WriteLine("");
                Console.WriteLine("Whoop, there it is!");
                Console.WriteLine("");
                Console.WriteLine("Now lets search for the books with of in the title.");
                Console.WriteLine("");
                mediaLibrary.FindItem("of");

                Console.WriteLine("");
                Console.WriteLine("Multiple results! How Exciting!");
                Console.WriteLine("");
                Console.Write("Type the title of any media you'd like to search for. (Spoiler alert, I probably don't have it): ");

                mediaLibrary.FindItem(Console.ReadLine());
                Console.WriteLine("");

                while (true)
                {
                    Console.Write("Let me guess, you want to keep searching! Type your next search or type quit to exit: ");
                    if (Console.ReadLine().ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        mediaLibrary.FindItem(Console.ReadLine());
                        Console.WriteLine("");

                    }
                }

                Console.WriteLine("Well that was fun. Have a nice day!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DetectMediaType(MediaType item)
        {
            if (item is null)
            {
                return;
            }
            else if (item is Book)
            {
                Console.WriteLine($"'{item.Title}' is a book.");
            }
            else if (item is VideoGame)
            {
                Console.WriteLine($"'{item.Title}' is a video game.");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
    }
}
