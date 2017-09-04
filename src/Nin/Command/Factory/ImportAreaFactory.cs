using System.Collections.Generic;
using Common;
using Nin.Omr�der;

namespace Nin.Command.Factory
{
    class ImportAreaFactory : FactoryBase
    {
        public override DatabaseCommand Create(CommandLineArguments args)
        {
            return new ImportAreaCommand(
                args.DeQueue(), 
                args.DeQueueInt("SourceSrid", 4326), 
                args.DeQueueEnum<AreaType>("omr�deType"));
        }

        protected override IEnumerable<string> GetVerbs() { return new[] { "importarea", "ia" }; }
        public override string Usage => "importarea <AreaFileSpec> <SourceSrid> <Omr�deType>\r\n   Imports the specified area data file (geojson/shp).";
    }
}