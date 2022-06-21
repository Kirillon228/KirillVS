using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bum_simulator
{
    public enum Gender
    {
        MAN,
        WOMAN
    }
    public abstract class Charecter
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract Gender Gender { get;}
        public abstract string backstory();       
    }
    public class Helper
    {
        public static string Year(int Age)
        {
            string year = ("f");
            if (Age % 10 == 1)
            {
                year = ("год");
            }
            else if (Age % 10 >= 2 && Age % 10 <= 4)
            {
                year = ("года");
            }
            else
            {
                year = ("лет");
            }
            return year;
        }
    }


    public class WomanCharecter : Charecter 
    {
        public override Gender Gender => Gender.WOMAN;        
        public override string backstory()
        {
            StringBuilder story = new StringBuilder();
            if (Age <= 30)
            {
                story.Append("Вы съехали от родителе совсем без денег.\n");            
                story.Append("Вы хотели пойти работать на трассу , но вас туда не взяли в силу то что вы слишком не красива.\n");
                story.Append($"Вам {Age} {Helper.Year(Age)},вас зовут {Name} , вы прибились к шайке бомжей если не хоти оставшуюся жизнь \n" +
                    $"провести ходя по помойкам попытайтесь заработать денег для того чтобы начать новую жизнь(цель накопить 1000 гривен за 100 дней )\n");
                
            }            
            else if (Age > 30 && Age <= 60)
            {
                story.Append("У вас сгорел дом,вас уволили с работы.\n");
                story.Append("Вы хотели пойти работать на трассу , но вас туда не взяли в силу то что вы слишком не красива.\n");             
                story.Append($"Вам {Age} {Helper.Year(Age)},вас зовут {Name} , вы прибились к шайке бомжей если не хотите просрать\n " +
                    $"оставшуюся жизнь провести попытайтесь заработать денег для того чтобы начать новую жизнь(цель накопить 1000 гривен за 100 дней )\n");
                
            }
            else
            {
                story.Append("Вы работали на трассе, как только вам стукнуло 60 лет, вас выперли с трассы из-за того что милфы сейчас не в моде.\n");
                story.Append($"Вам {Age} {Helper.Year(Age)},вас зовут {Name} , вы прибились к шайке бомжей если хотите попробовать заработать денег на старось \n" +
                    $"нужно будет поработать оставшуюся жизнь (цель накопить 1000 гривен за 100 дней )\n");
               
            }
            return story.ToString();
        }
    }
    public class ManCharacter : Charecter
    {
        public override Gender Gender => Gender.MAN;
        public override string backstory()
        {
            StringBuilder story = new StringBuilder();
            if (Age <= 30)
            {
                story.Append("Вы съехали от родителе совсем без денег.\n");
                story.Append("Вы хотели пойти работать на завод , но вас туда не взяли в силу того что вы слишком молод , слаб и не опытен.\n");               
                story.Append($"Вам {Age} {Helper.Year(Age)},вас зовут {Name} , вы прибились к шайке бомжей если не хоти оставшуюся жизнь провести ходя по помойкам \n" +
                    $"попытайте заработать денег для того чтобы начать новую жизнь(цель накопить 1000 гривен за 100 дней )\n");
                
            }
            else if (Age > 30 && Age <= 60)
            {
                story.Append("У вас сгорел дом,вас уволили с работы.\n");
                story.Append("Вы хотели пойти работать на завод , но вас туда не взяли в силу того что у вас сгорели все документы.\n");
                story.Append($"Вам {Age} {Helper.Year(Age)},вас зовут {Name} , вы прибились к шайке бомжей если не хотите просрать оставшуюся жизнь \n" +
                    $"попытайтесь заработать денег для того чтобы начать новую жизнь(цель накопить 1000 гривен за 100 дней )\n");
                
            }
            else
            {
                story.Append("Вы работали на заводе всю жизнь, как только вам стукнуло 60 лет, вас выперли с завода и забрали пенсию.\n");
                story.Append($"Вам {Age} {Helper.Year(Age)},вас зовут {Name} , вы прибились к шайке бомжей \n" +
                    $"если хотите попробовать заработать денег на старость нужно будет поработать (цель накопить 1000 гривен за 100 дней )\n");
            }
            return story.ToString();
        }
    }

}
