using MedPillCorporationApp.Interfaces;

namespace MedPillCorporationApp.Models
{
    public class PillRepository : IPillRepository
    {
        private ApplicationDbContext _context;

        public PillRepository(ApplicationDbContext context)
        {
            _context = context;          
        }

        public void EnsurePopulated()
        {
            if (!_context.Pills.Any())
            {
                _context.Pills.AddRange(
                    new Pill
                    {
                       Name = "Септефрил",
                       Category = "Антисептики",
                       Instruction = "Препарати, що застосовуються при захворюваннях горла. Різні антисептики. Код АТХ R02А А20.",
                       Manufacturer = "Дарниця",
                       Country = "Україна",
                       Total = 10                       
                    },
                    new Pill
                    {
                        Name = "Strepsils",
                        Category = "Антисептики",
                        Instruction = "Препарати, що застосовуються при захворюваннях горла. Різні антисептики. Код АТХ R02А А20.",
                        Manufacturer = "Реккітт Бенкізер Хелскер Інтернешнл Лімітед",
                        Country = "Велика Британія",
                        Total = 15
                    },
                    new Pill
                    {
                        Name = "Durex Classic",
                        Category = "Презервативи",
                        Instruction = "Класичний – не означає нудний! Презервативи Durex Classic зі змазкою легко вдягаються завдяки анатомічній формі Easy-On та не мають неприємного запаху. ",
                        Manufacturer = "Реккітт Бенкізер Хелскер Інтернешнл Лімітед",
                        Country = "Велика Британія",
                        Total = 25
                    },
                    new Pill
                    {
                        Name = "Ревіт",
                        Category = "Вітаміни",
                        Instruction = "Лікарський засіб приймати всередину, через 10–15 хвилин після їди.",
                        Manufacturer = "АТ Вітаміни",
                        Country = "Україна",
                        Total = 30
                    },
                    new Pill
                    {
                        Name = "Septefril",
                        Category = "Antiseptics",
                        Instruction = "Препарати, що застосовуються при захворюваннях горла. Різні антисептики. Код АТХ R02А А20.",
                        Manufacturer = "Darnytsia",
                        Country = "Ukraine",
                        Total = 10
                    },
                    new Pill
                    {
                        Name = "Біле вугілля",
                        Category = "Сорбенти",
                        Instruction = "Біле Вугілля® — ентеросорбент, активною речовиною якого є кремнію діоксид. Висока дисперсність кремнію діоксиду забезпечує велику активну поверхню сорбції і, отже, сорбційну ємність препарату.",
                        Manufacturer = "ТОВ «ФАРМЕКС ГРУП».",
                        Country = "Ukraine",
                        Total = 50
                    },
                    new Pill
                    {
                        Name = "Йод",
                        Category = "Антисептики для обробки ран",
                        Instruction = "Препарати, що застосовуються при захворюваннях горла. Різні антисептики. Код АТХ R02А А20.",
                        Manufacturer = "ТОВ «ДКП «Фармацевтична фабрика».",
                        Country = "Ukraine",
                        Total = 60
                    },
                    new Pill
                    {
                        Name = "Тендісульфур Форте порошок",
                        Category = "Хондропротектори",
                        Instruction = "Тендісульфур Форте - це дієва комбінація комплексу натуральних речовин, амінокислот і хондропротекторів, що мають протизапальну, трофічну і знеболюючу дію і сприяють відновленню сухожиль і суглобів при запальних і дегенеративних процесах.",
                        Manufacturer = "Laborest Italia S.r.L",
                        Country = "Italia",
                        Total = 20
                    }
                );

                _context.SaveChanges();
            }
        }
        public IQueryable<Pill> Pills => _context.Pills;
    }
}
