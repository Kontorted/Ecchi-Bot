using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecchi_Bot
{
    class EcchiBot
    {
        DiscordClient discord;

        public EcchiBot()
        {
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;
            });

            var commands = discord.GetService<CommandService>();

            commands.CreateCommand("help")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("This Bot is a work in progress. Feel free to help if you can.");
                });

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MzI1MDI0NzM1NDcxODYxNzcw.DCSRJg.VgodrTyS3epcIqj1jNjesKySkB8", TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
