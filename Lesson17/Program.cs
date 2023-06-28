using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger("mylogger");           
            int money = 4000;
            log.Info("唐老狮的评定等级为A，工资为" + Convert.ToString(money));
            Console.WriteLine("生成成功");
            /*
            int a;
            string str = Console.ReadLine();
            switch (str)
            {
                case "很兴奋":
                    money = money + 500;
                    Console.WriteLine("唐老狮的评定等级为A，工资为" + money);
                    log.Info("唐老狮的评定等级为A，工资为" + money);
                    break;
                case "很充实":
                    Console.WriteLine("唐老狮的评定等级为B，工资为" + money);
                    log.Info("唐老狮的评定等级为B，工资为" + money);
                    break;
                case "还好吧":
                    money = money - 300;
                    Console.WriteLine("唐老狮的评定等级为C，工资为" + money);
                    log.Info("唐老狮的评定等级为C，工资为" + money);
                    break;
                case "难理解":
                    money = money - 500;
                    Console.WriteLine("唐老狮的评定等级为D，工资为" + money);
                    log.Info("唐老狮的评定等级为D，工资为" + money);
                    break;
                case "枯燥乏味":
                    money = money - 800;
                    Console.WriteLine("唐老狮的评定等级为E，工资为" + money);
                    log.Info("唐老狮的评定等级为E，工资为" + money);
                    break;
                default:
                    Console.WriteLine("请输入正确内容");
                    break;
            }*/
        }
    }
}
