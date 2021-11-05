using CommandLine;

namespace MasterMind.Configurations
{
    class CommandLineOptions
    { 
        [Option('r', "round", Default = null, Required = false, HelpText = "Set number of round to find the secret")]
        public int? Round { get; set; }

        [Option('l', "length", Default = 4, Required = false, HelpText = "Set length of the secret")]
        public int SecretLength { get; set; }
    }
}
