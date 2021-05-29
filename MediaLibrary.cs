using System;
namespace Treehouse.MediaLibrary
{
    public class MediaLibrary
    {
        private MediaType[] _items;
        public int NumberOfItems => _items.Length;

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }

        public MediaType GetItemAt(int index)
        {
            if(index < 0 || index >= _items.Length)
            {
                Console.WriteLine($"An element at index {index} does not exist.");

                return null;
            }
            else
            {
                return _items[index];
            }
        }

        static void DisplayItem(MediaType item)
        {
            if (item is null)
            {
                return;
            }
            else if (item is Book)
            {
                Console.WriteLine(((Book)item).DisplayText);
            }
            else if (item is VideoGame)
            {
                Console.WriteLine(((VideoGame)item).DisplayText);
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }

        public void DisplayItems()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                DisplayItem(_items[i]);
            }
        }

        public void FindItem(string criteria)
        {
            MediaType result = null;
            foreach(MediaType item in _items)
            {
                if (item.Title.ToLower().Contains(criteria.ToLower()))
                {
                    result = item;
                    Console.WriteLine("Your search matches the following item:");
                    DisplayItem(result);
                }
            }
            if (result == null)
            {
                Console.WriteLine("Item not found.");
            }            
        }
    }
}
