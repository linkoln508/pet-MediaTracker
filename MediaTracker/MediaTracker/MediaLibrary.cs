using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTracker
{
    public class MediaLibrary
    {
        public MediaLibrary() { 
            totalCountLibrary++;
        }
        static int totalCountLibrary = 0;
        private Dictionary<string, MediaItem> _mediaItems = new();
        public void AddMediaItem(MediaItem item)
        {
            if (!_mediaItems.ContainsKey(item.NameTitle))
            {
                _mediaItems.Add(item.NameTitle, item);
            }
            else
            {
                throw new ArgumentException($"Медиа-элемент с названием '{item.NameTitle}' уже существует в библиотеке.");
            }
        }

        public void FindMediaItem(string nameTitle)
        {
            if (_mediaItems.TryGetValue(nameTitle, out var item))
            {
                Console.WriteLine(item.GetInfo());
            }
            else
            {
                throw new KeyNotFoundException($"Медиа-элемент с названием '{nameTitle}' не найден в библиотеке.");
            }
        }

        public void GetCountMediaItems()
        {
            Console.WriteLine($"Количество медиа-элементов в библиотеке: {_mediaItems.Count}");
        }

    }
}
