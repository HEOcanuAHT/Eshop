﻿using Eshop.Core;

namespace Eshop.Menu.Commands
{
    internal class ShowCatalogChoiceCommand : IMenuCommand
    {
        public string Description { get; } = "Show catalog";
        private readonly Dictionary<int, IMenuCommand> _catCommands = new()
            {
                { 1, new ShowCatalogCommand(typeof(Product)) },
                { 2, new ShowCatalogCommand(typeof(Service)) },
                { 0, new BackCommand() }
            };

        public void Execute(MenuPage currentPage)
        {
            MenuPage catalogChoice = new(currentPage, _catCommands);
            catalogChoice.Show();
        }
    }
}
