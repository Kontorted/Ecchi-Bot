using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ecchi_Bot
{
    class EcchiBot
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;

        string[] nsfwcontent;

        public EcchiBot()
        {
            string tokenFilePath = @"C:\Users\arizv\Documents\Discord\Token\Ecchi_Bot.txt";
            string token = File.ReadAllText(tokenFilePath);

            rand = new Random();

            nsfwcontent = new string[]
            {
                "http://imgur.com/ed9Rl0h.png",
                "http://imgur.com/JQ4FcZx.png",
                "http://imgur.com/TGUGLIJ.png",
                "http://imgur.com/lAmRECZ.png",
                "http://imgur.com/66hsJHM.png",
                "http://imgur.com/4i4E70G.png",
                "http://imgur.com/2Q7G9iv.png",
                "http://imgur.com/vKxMaJn.png",
                "http://imgur.com/zQUAlBU.png",
                "http://imgur.com/zIWaG61.png",
                "http://imgur.com/MshMxUh.png",
                "http://imgur.com/y0thW2L.png",
                "http://imgur.com/ZwbAM41.png",
                "http://imgur.com/a00aXke.png",
                "http://imgur.com/R1Y4CNv.png",
                "http://imgur.com/1brsCej.png",
                "http://imgur.com/fKXpUS6.png",
                "http://imgur.com/SZsFWjK.png",
                "http://imgur.com/8F7bOSv.png",
                "http://imgur.com/3VbS4Rh.png",
                "http://imgur.com/cHhUcMb.png",
                "http://imgur.com/2Qansab.png",
                "http://imgur.com/02yfOuc.png",
                "http://imgur.com/slf0ydd.png",
                "http://imgur.com/Q9dOkkh.png",
                "http://imgur.com/rZ5qiSA.png",
                "http://imgur.com/wZec0BL.png",
                "http://imgur.com/5bauB6b.png",
                "http://imgur.com/t8iHMU5.png",
                "http://imgur.com/Ecv5Tmd.png",
                "http://imgur.com/6JIItTE.png",
                "http://imgur.com/aTklnPS.png",
                "http://imgur.com/miA2pAJ.png",
                "http://imgur.com/lU0xGth.png",
                "http://imgur.com/RMJr8ey.png",
                "http://imgur.com/7K5WawI.png",
                "http://imgur.com/caGxwOH.png",
                "http://imgur.com/zFuMRXK.png",
                "http://imgur.com/1Rny01l.png",
                "http://imgur.com/gK7NcX6.png",
                "http://imgur.com/Lo3gUZp.png",
                "http://imgur.com/ePHdvDs.png",
                "http://imgur.com/XNkZH92.png",
                "http://imgur.com/WFBeRA6.png",
                "http://imgur.com/0BuxMGn.png",
                "http://imgur.com/gaWJKXm.png",
                "http://imgur.com/MJKWLof.png",
                "http://imgur.com/A7s8s9e.png",
                "http://imgur.com/hIsn8XT.png",
                "http://imgur.com/lLdCQL5.png",
                "http://imgur.com/NAVaW3E.png",
                "http://imgur.com/bIBBGry.png",
                "http://imgur.com/QLYnKFc.png",
                "http://imgur.com/CidVFCD.png",
                "http://imgur.com/FY6uGyB.png",
                "http://imgur.com/dnEoDCD.png",
                "http://imgur.com/NVXmBsc.png",
                "http://imgur.com/0fkzvtW.png",
                "http://imgur.com/QsGq7nK.png",
                "http://imgur.com/8G9zhE0.png",
                "http://imgur.com/2Ew8wET.png",
                "http://imgur.com/efyUJ6m.png",
                "http://imgur.com/ciVRBBn.png",
                "http://imgur.com/qCZni2i.png",
                "http://imgur.com/c6Ab9MM.png",
                "http://imgur.com/WPl8C6I.png",
                "http://imgur.com/H7Cee60.png",
                "http://imgur.com/cEoM37Z.png",
                "http://imgur.com/8UyMtN2.png",
                "http://imgur.com/PfPoE6o.png",
                "http://imgur.com/csr0x2t.png",
                "http://imgur.com/BBfGRVl.png",
                "http://imgur.com/pyn2EzH.png",
                "http://imgur.com/RJfRY0V.png",
                "http://imgur.com/NbpqisH.png",
                "http://imgur.com/TWbWwVZ.png",
                "http://imgur.com/896JMbL.png",
                "http://imgur.com/ROfINMZ.png",
                "http://imgur.com/mP7PksZ.png",
                "http://imgur.com/P9iBoh0.png",
                "http://imgur.com/juIwIKz.png",
                "http://imgur.com/gHLDxXt.png",
                "http://imgur.com/fr5hFpE.png",
                "http://imgur.com/8QfR2PS.png",
                "http://imgur.com/aRD1YYi.png",
                "http://imgur.com/Vr6KtCd.png",
                "http://imgur.com/OvAlZE4.png",
                "http://imgur.com/aiTHCir.png",
                "http://imgur.com/S6F01Cl.png",
                "http://imgur.com/WAc0vFG.png",
                "http://imgur.com/lbF5vuY.png",
                "http://imgur.com/8Cs9eRn.png",
                "http://imgur.com/4NKtEZm.png",
                "http://imgur.com/K1jvdGl.png",
                "http://imgur.com/0zxQtRz.png",
                "http://imgur.com/qYqoiUJ.png",
                "http://imgur.com/zrjOTYJ.png",
                "http://imgur.com/WmdU0ml.png",
                "http://imgur.com/oaXImuJ.png",
                "http://imgur.com/drYk2mX.png",
                "http://imgur.com/LFcuoBi.png",
                "http://imgur.com/ZF5dyO3.png",
                "http://imgur.com/IgCQ5F7.png",
                "http://imgur.com/ILGW0Nn.png",
                "http://imgur.com/GH6kZLW.png",
                "http://imgur.com/5CUp0Vl.png",
                "http://imgur.com/e5Ii0ra.png",
                "http://imgur.com/UgkM7qj.png",
                "http://imgur.com/1qa5Zvt.png",
                "http://imgur.com/t8lpRtB.png",
                "http://imgur.com/EF1fb94.png",
                "http://imgur.com/LhC0fIv.png",
                "http://imgur.com/sH3KQq7.png",
                "http://imgur.com/5X9Xvde.png",
                "http://imgur.com/3V3E5Va.png",
                "http://imgur.com/5b5gzkG.png",
                "http://imgur.com/L7yVkxR.png",
                "http://imgur.com/ZiHM7LF.png",
                "http://imgur.com/bZVmoWt.png",
                "http://imgur.com/PRdoDN9.png",
                "http://imgur.com/edZdb3J.png",
                "http://imgur.com/XeNunqw.png",
                "http://imgur.com/ZMYyzJp.png",
                "http://imgur.com/IBYmY4J.png",
                "http://imgur.com/kOzH8gl.png",
                "http://imgur.com/mnZe8k2.png",
                "http://imgur.com/GhRyy7k.png",
                "http://imgur.com/NFl70hi.png",
                "http://imgur.com/piYxvPE.png",
                "http://imgur.com/o2OHiDJ.png",
                "http://imgur.com/L70RUAO.png",
                "http://imgur.com/Tfzwf07.png",
                "http://imgur.com/bhHo8Nd.png",
                "http://imgur.com/I7NZRls.png",
                "http://imgur.com/bOxBMrB.png",
                "http://imgur.com/nhrTvOv.png",
                "http://imgur.com/LaAkz3E.png",
                "http://imgur.com/Gs3XRSo.png",
                "http://imgur.com/Kvp8vON.png",
                "http://imgur.com/DUxTlRK.png",
                "http://imgur.com/g8NYYtM.png",
                "http://imgur.com/K6h5mwI.png",
                "http://imgur.com/rE5QsoX.png",
                "http://imgur.com/MdaIa3W.png",
                "http://imgur.com/ZNAuN5I.png",
                "http://imgur.com/gwy65RG.png",
                "http://imgur.com/lzOIcn0.png",
                "http://imgur.com/12DxncU.png",
                "http://imgur.com/rQN3ylF.png",
                "http://imgur.com/4YyO8sa.png",
                "http://imgur.com/0QY1bS9.png",
                "http://imgur.com/ETHYG5u.png",
                "http://imgur.com/q4d34Jd.png",
                "http://imgur.com/bI61BJy.png",
                "http://imgur.com/4PKmP5n.png",
                "http://imgur.com/6wd1YfF.png",
                "http://imgur.com/DX8y5X6.png",
                "http://imgur.com/yiJHeNG.png",
                "http://imgur.com/aTzNpgi.png",
                "http://imgur.com/cNhdkce.png",
                "http://imgur.com/ohf0Chw.png",
                "http://imgur.com/OMlqyGg.png",
                "http://imgur.com/UXx851g.png",
                "http://imgur.com/Rm7d1XA.png",
                "http://imgur.com/vwJ1tBk.png",
                "http://imgur.com/WUhFP7j.png",
                "http://imgur.com/WdI36el.png",
                "http://imgur.com/IpJtjiS.png",
                "http://imgur.com/1YRjZvT.png",
                "http://imgur.com/LBi11vl.png",
                "http://imgur.com/PCcZKTL.png",
                "http://imgur.com/GDG3itA.png",
                "http://imgur.com/74cwUtM.png",
                "http://imgur.com/BJDv7Ti.png",
                "http://imgur.com/Wfo2EuK.png",
                "http://imgur.com/0yQGrbl.png",
                "http://imgur.com/2QB2Q0d.png",
                "http://imgur.com/q0WBBOW.png",
                "http://imgur.com/xv5M1nS.png",
                "http://imgur.com/E3Q0PVA.png",
                "http://imgur.com/ZjohkFM.png",
                "http://imgur.com/ZEEwFUa.png",
                "http://imgur.com/ZiK7Lk0.png",
                "http://imgur.com/xXL3Q8T.png",
                "http://imgur.com/GHglWqF.png",
                "http://imgur.com/Jszpe6N.png",
                "http://imgur.com/jEdVIDc.png",
                "http://imgur.com/BmR8dTL.png",
                "http://imgur.com/uOdjgyj.png",
                "http://imgur.com/uXHmkoh.png",
                "http://imgur.com/4DnODWZ.png",
                "http://imgur.com/cV8G3Ms.png",
                "http://imgur.com/P2J7HSh.png",
                "http://imgur.com/W6WTNhN.png",
                "http://imgur.com/ihHAlBy.png",
                "http://imgur.com/OqO5N5a.png",
                "http://imgur.com/ozodzhA.png",
                "http://imgur.com/mAf1U1B.png",
                "http://imgur.com/RFgsrdO.png",
                "http://imgur.com/QTszGgJ.png",
                "http://imgur.com/DiC2emy.png",
                "http://imgur.com/qObASYX.png",
                "http://imgur.com/Z9EkPYv.png",
                "http://imgur.com/VzNZI3M.png",
                "http://imgur.com/4PlWSDB.png",
                "http://imgur.com/mTfNrCZ.png",
                "http://imgur.com/6Nrl8t1.png",
                "http://imgur.com/mFX7WO9.png",
                "http://imgur.com/i3vj2rS.png",
                "http://imgur.com/uxS1smr.png",
                "http://imgur.com/xPwMngC.png",
                "http://imgur.com/Lcd7VCn.png",
                "http://imgur.com/PPuVYmJ.png",
                "http://imgur.com/msXF7Mt.png",
                "http://imgur.com/61TfmLm.png",
                "http://imgur.com/d5No6no.png",
                "http://imgur.com/3TWbFVL.png",
                "http://imgur.com/4kzx3ou.png",
                "http://imgur.com/CAlYn9k.png",
                "http://imgur.com/lzlg4Tb.png",
                "http://imgur.com/6cUz9lN.png",
                "http://imgur.com/ucoDH6V.png",
                "http://imgur.com/Yu3lMPH.png",
                "http://imgur.com/d4YRJgk.png",
                "http://imgur.com/1RmvIxX.png",
                "http://imgur.com/Lek9UD5.png",
                "http://imgur.com/jC5HBe3.png",
                "http://imgur.com/BW9SNPO.png",
                "http://imgur.com/MwN0NDG.png",
                "http://imgur.com/FVibVOg.png",
                "http://imgur.com/JNeywyy.png",
                "http://imgur.com/Ds1aqOq.png",
                "http://imgur.com/pHdVNAv.png",
                "http://imgur.com/uqIF1ne.png",
                "http://imgur.com/afxgUiv.png",
                "http://imgur.com/iyznzne.png",
                "http://imgur.com/u7gtoFT.png",
                "http://imgur.com/uGo4SxO.png",
                "http://imgur.com/p4rM8qP.png",
                "http://imgur.com/S1j0AEJ.png",
                "http://imgur.com/RtNn06r.png",
                "http://imgur.com/Kj6jHNW.png",
                "http://imgur.com/qmgOMg1.png",
                "http://imgur.com/kL0MelH.png",
                "http://imgur.com/lxYcR2E.png",
                "http://imgur.com/2u5MMwb.png",
                "http://imgur.com/wvCi70z.png",
                "http://imgur.com/g9DgjMg.png",
                "http://imgur.com/7spk9YB.png",
                "http://imgur.com/bAFaq9r.png",
                "http://imgur.com/7R8MZna.png",
                "http://imgur.com/zAjysi6.png",
                "http://imgur.com/pQ0VUDQ.png",
                "http://imgur.com/dm1Xo9S.png",
                "http://imgur.com/u93wQeX.png",
                "http://imgur.com/GcWuDW9.png",
                "http://imgur.com/TpenbMD.png",
                "http://imgur.com/2Tr1sgY.png",
                "http://imgur.com/gekZGyU.png",
                "http://imgur.com/Vv8vMDp.png",
                "http://imgur.com/wTxJEMd.png",
                "http://imgur.com/afM86ZK.png",
                "http://imgur.com/7zXobjX.png",
                "http://imgur.com/z9ZjjVI.png",
                "http://imgur.com/JFAbwaE.png",
                "http://imgur.com/InFjwlt.png",
                "http://imgur.com/A7u1kRL.png",
                "http://imgur.com/GJGO8n8.png",
                "http://imgur.com/FJH8Vb5.png",
                "http://imgur.com/0M55Hcj.png",
                "http://imgur.com/Xb3vtO9.png",
                "http://imgur.com/dxYLjTm.png",
                "http://imgur.com/94ACCgv.png",
                "http://imgur.com/fWCp6tE.png",
                "http://imgur.com/g1fidj8.png",
                "http://imgur.com/hOnCqDZ.png",
				"http://imgur.com/VNIvGe7.png";
                "http://imgur.com/hoiWreu.png";
                "http://imgur.com/0usHMwy.png";
                "http://imgur.com/9h8zL4W.png";
                "http://imgur.com/rhS7mHX.png";
                "http://imgur.com/meT2dxg.png";
                "http://imgur.com/paGTPga.png";
                "http://imgur.com/wue8rfI.png";
                "http://imgur.com/w5jLoJu.png";
                "http://imgur.com/ybDjDNU.png";
                "http://imgur.com/P2eIlMQ.png";
                "http://imgur.com/OJfgkOw.png";
                "http://imgur.com/zGEdiwW.png";
                "http://imgur.com/YxzgrJq.png";
                "http://imgur.com/VZYIleu.png";
                "http://imgur.com/sdw5ERE.png";
                "http://imgur.com/M7sRcHa.png";
                "http://imgur.com/Ij0XNLf.png";
        };

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

            commands = discord.GetService<CommandService>();

            RegisterNSFWCommand();
            RegisterPurgeCommand();
            RegisterHelpCommand();

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect(token, TokenType.Bot);
            });
        }

        private void RegisterHelpCommand()
        {
            commands.CreateCommand("help")
                .Do(async (e) =>
               {
                   await e.Channel.SendMessage("These are the following (working) commands:\n!purge\n!nsfw\n[And many more to come]");
               });
        }

        private void RegisterPurgeCommand()
        {
            commands.CreateCommand("purge")
                .Do(async (e) =>
               {
                   Message[] Purging;
                   Purging = await e.Channel.DownloadMessages(100);

                   await e.Channel.DeleteMessages(Purging);
                   await e.Channel.SendMessage("All messages have been cleared.");                   
               });
        }
        
        private void RegisterNSFWCommand()
        {
            commands.CreateCommand("nsfw")
                .Do(async (e) =>
                {
                    int randomNSFW = rand.Next(nsfwcontent.Length);
                    string nsfwPost = nsfwcontent[randomNSFW];
                    await e.Channel.SendMessage(nsfwPost);
                });
        }
        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
