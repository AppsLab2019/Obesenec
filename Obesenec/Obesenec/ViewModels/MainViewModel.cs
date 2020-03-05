using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Obesenec.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            List = new ObservableCollection<Character>
            {
                new Character("V"),
                new Character("L"),
                new Character("A"),
                new Character("D"),
                new Character("O"),
            };
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

    public class Character : INotifyPropertyChanged
    {
        private string text;
        private bool isShown;
        private const string hiddenText = "_";

        public Character(string text)
        {
            OriginalText = text;
            Text = hiddenText;
        }

        public string OriginalText { get; }

        public bool IsShown
        {
            get => isShown;
            set
            {
                isShown = value;
                if (isShown)
                {
                    Text = OriginalText;
                }
                else
                {
                    Text = hiddenText;
                }
            }
        }

        public string Text
        {
            get => text;
            set
            {
                if (value == text) return;
                text = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
