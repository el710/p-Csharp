// Telegram bot https://t.me/ElLittleBot

using Telegram.Bot;

string tokenTel = "5565110850:AAEpoukwdaiq9uOELSLzrFQeZR54kIyWGU8"; // from @BotFather
var clientTel = new TelegramBotClient(tokenTel);

string Answer(string msg){

    string answer ="You say: " + msg;

    if(msg.Contains("hello")){
        answer = "Hi! ";
    }

    return answer;
}


clientTel.StartReceiving(
 //   (c, args, _) => c.SendTextMessageAsync(args.Message.Chat.Id, "Hello!"),
    (c, arg, _) =>
    {
       return c.SendTextMessageAsync(arg.Message.Chat.Id, 
                                    Answer(arg.Message.Text.ToLower())
       );
    },
    (_, _, _) => Task.CompletedTask
);

Console.WriteLine("Start");
Console.ReadLine();

