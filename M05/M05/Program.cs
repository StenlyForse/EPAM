using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using NLog.Web;
using StringParser;

var provider = new ServiceCollection()
       .AddLogging(loggingBuilder =>
       {
           loggingBuilder.ClearProviders();
           loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
           loggingBuilder.AddNLog();
       })
       .BuildServiceProvider();

LogManager.LoadConfiguration("nlog.config");
var log = provider.GetService<ILogger<Program>>();

if (log == null) throw new ArgumentNullException(nameof(log));
Parser parser = new Parser(log);

Message message;
message = M05.MessageDisplayer.DisplayMessage;

message.Invoke("Введите строку которую необходимо перевести в integer");
try
{
    Console.WriteLine(parser.ParseStringToInteger(Console.ReadLine()));
}
catch (ArgumentNullException)
{
    message.Invoke("Строка не может быть null или пустой ");
}
catch (OverflowException)
{
    message.Invoke("Строка не может быть длиной больше 10 символов");
}
catch (FormatException)
{
    message.Invoke("Значение не должно быть больше, чем максимальное значение integer");
}
catch (ArgumentException)
{
    message.Invoke("Строка должна содержать только число");
}

public delegate void Message(string message);