using AK.Test.ResDiary;
using Microsoft.Extensions.DependencyInjection;

public class ProgramBase
{

    public static IGroupArrayDivider groupArrayDivider;

    public static void ConfigurationSetup()
    {
        // Setup the dependencies using IoC container
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IGroupArrayDivider, GroupArrayDivider>()
            .BuildServiceProvider();

        groupArrayDivider = serviceProvider.GetRequiredService<IGroupArrayDivider>();
    }
}