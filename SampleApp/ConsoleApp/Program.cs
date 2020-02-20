using System;
using System.Runtime.InteropServices;
using CommandLine;
using ClassLibrary;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        const string DEFAULT_MESSAGE = "Hello from .NET Framework!";

        public class Options
        {
            [Option('m', "message", Required = false, HelpText = "Set output messages.")]
            public string Message { get; set; }
        }

        static void Main(string[] args)
        {
            var whale = Utils.GetWhale();
            var output = string.Empty;
            var parser = new Parser(settings => { 
                settings.IgnoreUnknownArguments = true; 
            }).ParseArguments<Options>(args).WithParsed(options =>
            {
                output = String.IsNullOrEmpty(options.Message) ? $" {DEFAULT_MESSAGE}{whale}" : $" {options.Message}{whale}";
            });
            WriteLine(output);
            WriteLine("**Environment**");
            WriteLine($"Platform: .NET Framework");
            WriteLine($"OS: {RuntimeInformation.OSDescription}");
            ReadLine();
        }
    }
}
