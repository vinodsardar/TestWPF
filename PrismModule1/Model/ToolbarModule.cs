using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using System.ComponentModel;
using Microsoft.Practices.Prism.Regions;

namespace PrismModule1.Model
{
    public class ToolbarModule : IModule, INotifyPropertyChanged
    {
        private readonly IRegionViewRegistry regionViewRegistry = null;
        public ToolbarModule(IRegionViewRegistry regionViewRegistry)
        {
            this.regionViewRegistry = regionViewRegistry;
        }
        public void Initialize()
        {
            this.regionViewRegistry.RegisterViewWithRegion("HeaderRegion", typeof(PrismModule1.View. ToolbarWindow));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
