using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpMap.Data.Providers;

namespace SharpMapSource.Layers
{
    public class PostGisEventArgs
    {
        private IProvider postGisdataSource;
        private string layerName;
        public PostGisEventArgs(string layerName, IProvider postgis)
        {
            this.postGisdataSource = postgis;
            this.layerName = layerName;
        }
        public IProvider PostGis
        {
            get
            {
                return this.postGisdataSource;
            }
        }
        public string LayerName
        {
            get
            {
                return this.layerName;
            }
        }
    }
}
