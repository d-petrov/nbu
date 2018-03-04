using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace SimpleCalculator_MEF
{
    class Composition
    {
        private CompositionContainer _container;

        [Import(typeof(ICalculator))]
        public ICalculator calculator;

        public Composition()
        {
            AggregateCatalog aggregatecatalog = new AggregateCatalog();

            AssemblyCatalog assemblyCatalog = new AssemblyCatalog(typeof(Composition).Assembly);

            aggregatecatalog.Catalogs.Add(assemblyCatalog);

            _container = new CompositionContainer(aggregatecatalog);

            try
            {
                _container.ComposeParts(this);
            }
            catch (CompositionException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
