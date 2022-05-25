using MVVMFlyout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMFlyout.Services
{
    public class MockDataStore : IDataStore<Language>
    {
        readonly List<Language> languages;

        public MockDataStore()
        {
            languages = new List<Language>()
            {
                new Language { Id = "en-GB", Name = "English (United Kingdom)" },
                new Language { Id = "en-US", Name = "English (United States)" },
                new Language { Id = "es-ES", Name = "Español (España)" },
                new Language { Id = "it-IT", Name = "Italian (Italy)" },
                new Language { Id = "de-DE", Name = "German (Germany)" },
                new Language { Id = "uk-UA", Name = "Ukranian (Ukraine)" },
                new Language { Id = "hi-IN", Name = "Hindi (India)" },
                new Language { Id = "pa-IN", Name = "Punjabi (India)" },
                new Language { Id = "fr-FR", Name = "French (France)" },

            };
        }


        public async Task<Language> GetItemAsync(string id)
        {
            return await Task.FromResult(languages.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Language>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(languages);
        }
    }
}