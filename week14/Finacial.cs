using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202444086
{
    abstract class Finacial
    {
        protected Dictionary<DateTime, Info> _incomes;
        protected Dictionary<DateTime, Info> _expenditures;
        public int TotalIncome 
        {
            get
            {
                try {
                    int moneys = 0;

                    foreach (var income in _incomes)
                    {
                        //if (true == (income.Value != null))
                        if (false == (income.Value == null))
                        {
                            moneys += income.Value.Money;
                        }
                    }

                    return moneys;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"TotalIncome item is null error\r\n({ex.Message})");
                    return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"TotalIncome error\r\n({ex.Message})");
                    return 0;
                }
            }
        }
        public int TotalExpenditure 
        { 
            get
            {
                try
                {
                    int moneys = 0;

                    foreach (var expenditure in _expenditures)
                    {
                        //if (true == (expenditure.Value != null))
                        if (false == (expenditure.Value == null))
                        {
                            moneys += expenditure.Value.Money;
                        }
                    }

                    return moneys;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"expenditure item is null error\r\n({ex.Message})");
                    return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"TotalExpenditure error\r\n({ex.Message})");
                    return 0;
                }
            }
        }

        public virtual bool RegIncome(DateTime times, string content, int money)
        {
            if (money > 0)
            {
                _incomes[times] = new Info(content, money);
                return true;
            }

            return false;
        }

        public virtual bool RegIncome(string content, int money)
        {
            if (money > 0)
            {
                _incomes[DateTime.Now] = new Info(content, money);
                return true;
            }

            return false;
        }

        public virtual bool RegExpenditure(DateTime times, string content, int money)
        {
            if (money > 0)
            {
                _expenditures[times] = new Info(content, money);
                return true;
            }

            return false;
        }

        public virtual bool RegExpenditure(string content, int money)
        {
            if (money > 0)
            {
                _expenditures[DateTime.Now] = new Info(content, money);
                return true;
            }

            return false;
        }
    }
}
