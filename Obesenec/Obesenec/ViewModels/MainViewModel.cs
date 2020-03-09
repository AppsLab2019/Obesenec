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
        public MainViewModel()
        {
            var word = WordSource.GetRandomWord();
            var characterList = word.GetListOfCharacters();
            List = new ObservableCollection<Character>(characterList);
            CharacterPressedCommand = new Command<string>(CharacterPressed);
        }

        public ObservableCollection<Character> List { get; }
        public Command CharacterPressedCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CharacterPressed(string character)
        {
            bool isFound = false;
            foreach (var item in List)
            {
                if (item.OriginalText == character)
                {
                    item.IsShown = true;
                    isFound = true;
                }
            }
            if (isFound == false)
            {
                // TODO
            }
        }
    }
}
