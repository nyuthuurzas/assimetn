var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AssimentGD2>("assimentgd2");

builder.Build().Run();
