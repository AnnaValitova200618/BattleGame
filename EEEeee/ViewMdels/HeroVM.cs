using AAA.Services;
using AAA.ViewModels;
using EEEeee.Services;
using EEEeee.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace EEEeee.ViewMdels
{
    public class HeroVM: BaseVM
    {
        public CustomCommand OpenBattle { get; set; }
        public CustomCommand GetHero { get; set; }
        public CustomCommand GetRoom { get; set; }

        private readonly CurrentPageControl currentPageControl;

        public List<Hero> List1 { get; set; } = new List<Hero>();
        

        HttpClient client = new HttpClient();
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.Never
        };

        private Room selectedRoom;
        public Room SelectedRoom
        {
            get => selectedRoom;
            set
            {
                selectedRoom = value;
                Signal();
            }
        }


        private Hero selectedHero;

        public Hero SelectedHero
        {
            get => selectedHero;
            set
            {
                selectedHero = value;
                Signal();
            }
        }

        public HeroVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;

            OpenBattle = new CustomCommand(() => {
                currentPageControl.SetPage(new AllPage(currentPageControl)); });

            GetHero = new CustomCommand(async() =>
            {
                var response = await client.GetAsync("http://localhost:5027/api/Heroes");
                IEnumerable<Hero> array;
                using (var fs = response.Content.ReadAsStream())
                {
                    array = JsonSerializer.Deserialize<IEnumerable<Hero>>(fs, options);
                }
                List1 = new List<Hero>();
                List1 = (List<Hero>)array;
                Signal(nameof(List1));
            });

            GetHero.Execute(null);

            
        }
    }
}
