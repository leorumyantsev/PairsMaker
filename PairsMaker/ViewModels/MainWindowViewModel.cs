using PairsMaker.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.VisualStudio.PlatformUI;
using PairsMaker.Views;

namespace PairsMaker.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Initializing();

            CreateCommands();

            PairsCreator = new PairsCreator();
        }

        public IList<Member> Members { get; set; }

        public PairsCreator PairsCreator { get; }

        private void Initializing()
        {
            Members = new ObservableCollection<Member>();
        }

        #region Commands

        public ICommand MakePairsCommand { get; private set; }

        #endregion

        private void CreateCommands()
        {
            MakePairsCommand = new DelegateCommand(DoMakePairs);
        }

        #region CommandMethods

        private void DoMakePairs()
        {
            var pairs = PairsCreator.CreatePairs(Members);

            var pairsWindowViewModel = new PairsWindowViewModel(pairs);

            var pairsWindow = new PairsWindow {DataContext = pairsWindowViewModel};
            pairsWindow.Show();
        }

        #endregion

    }
}