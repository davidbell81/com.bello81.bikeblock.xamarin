﻿using System;
using System.Windows.Input;
using BikeBlock.models;

namespace BikeBlock.ViewModels
{
    public class MnemonicDisplayViewModel : BaseViewModel
    {
        private IPageService _pageService;

        public String MnemonicText {
            get
            {
                return Wallet.Mnemonic.Words;
            }
            private set {
            }
        }
        public Wallet Wallet { get; set; } = new Wallet();
        public ICommand OkCommand
        {
            get;
            private set;
        }

        public MnemonicDisplayViewModel(IPageService pageService, Wallet wallet)
        {
            _pageService = pageService;
            Wallet = wallet;
        }
    }
}
