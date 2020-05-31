using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Obesenec.Model;

namespace Obesenec.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string ImageSource { get; set; }
        private int _index;
        public MainViewModel()
        {
            var word = WordSource.GetRandomWord();
            var characterList = word.GetListOfCharacters();
            List = new ObservableCollection<Character>(characterList);
            CharacterPressedCommand = new Command<string>(CharacterPressed);
            PressedCharacters = new List<string>();
            ImageSource = "HangMan1.png";
            _index = 2;
        }

        public ObservableCollection<Character> List { get; }
        public Command CharacterPressedCommand { get; }
        public List<string> PressedCharacters { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CharacterPressed(string character)
        {
            if (PressedCharacters.Contains(character))
                return;

            PressedCharacters.Add(character);

            bool isFound = false;
            foreach (var item in List)
            {
                if (item.OriginalText.ToLower() == character.ToLower())
                {
                    item.IsShown = true;
                    isFound = true;
                }
            }
            if (isFound == false)
            {
                if (_index >= 14)
                {
                    Application.Current.MainPage.DisplayAlert("GG", "You LOST!", "OK");
                    _index = 1;
                }
                    
                ImageSource = $"HangMan{_index}.png";
                OnPropertyChanged(nameof(ImageSource));
                _index++;
         
            }
        }
    }
}
