﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace VSHelloWord_130221018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Comentário de teste
            //Segundo comentário de teste
            //És uma Batata 
            //Turkeys are awesomeeeee!!!! :{D
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
