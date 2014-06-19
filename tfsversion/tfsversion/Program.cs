using System;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.Client;

namespace tfsversion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Pass your tfs url as an argument. e.g. http://YOUR_TFS_SERVER:8080/tfs/YOUR_COLLECTION/");
            }
            else
            {
                var tfs = new TfsTeamProjectCollection(new Uri(args[0]));
                var tfsb = tfs.GetService<IBuildServer>();
                var buildServerVersion = tfsb.BuildServerVersion;
                Console.WriteLine(buildServerVersion);
            }
        }
    }
}
