using Application.Models.ViewModels;
using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class EnumTranslator
    {
        private readonly Dictionary<Enum, EnumViewModel> TranslatedEnums;

        public string GetEnumName(Enum category, string languageCode)
        {
            if (TranslatedEnums.TryGetValue(category, out var enumViewModel))
            {

                return languageCode switch
                {
                    "Uz" => enumViewModel.NameUz,
                    "En" => enumViewModel.NameEn,
                    "Ru" => enumViewModel.NameRu,
                    "UzRu" => enumViewModel.NameUzRu,
                    "Kaa" => enumViewModel.NameKaa,
                    _ => throw new ArgumentException($"Language code '{languageCode}' is not supported.")
                };
            }
            throw new KeyNotFoundException($"The enum value '{category}' is not found.");
        }

        public EnumViewModel GetEnum(Enum category)
        {
            if (TranslatedEnums.TryGetValue(category, out var enumViewModel))
            {
                return enumViewModel;
            }
            throw new KeyNotFoundException($"The enum value '{category}' is not found.");
        }

        public EnumTranslator()
        {
            TranslatedEnums = new Dictionary<Enum, EnumViewModel>
            {
                // EmployeeCategory
                {
                    EmployeeCategory.Leadership, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Leadership,
                        NameUz = "Rahbariyat",
                        NameEn = "Leadership",
                        NameRu = "Руководство",
                        NameUzRu = "Раҳбарият",
                        NameKaa = "Basıwshılıq"
                    }
                },
                {
                    EmployeeCategory.Assistant, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Assistant,
                        NameUz = "Yordamchi",
                        NameEn = "Assistant",
                        NameRu = "Ассистент",
                        NameUzRu = "Ёрдамчи",
                        NameKaa = "Komekshi"
                    }
                },
                {
                    EmployeeCategory.Women_Activist, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Women_Activist,
                        NameUz = "Ayollar faoliyati",
                        NameEn = "Women Activist",
                        NameRu = "Женский активист",
                        NameUzRu = "Аёллар фаолияти",
                        NameKaa = "Hayellar faolları"
                    }
                },
                {
                    EmployeeCategory.Youth_Leader, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Youth_Leader,
                        NameUz = "Yoshlar yetakchisi",
                        NameEn = "Youth Leader",
                        NameRu = "Молодежный лидер",
                        NameUzRu = "Ёшлар етакчиси",
                        NameKaa = "Jaslar jetekshileri"
                    }
                },
                {
                    EmployeeCategory.Council_deputy, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Council_deputy,
                        NameUz = "Kengash deputati",
                        NameEn = "Council Deputy",
                        NameRu = "Депутат совета",
                        NameUzRu = "Кенгаш депутати",
                        NameKaa = "Kenes deputatları"
                    }
                },
                {
                    EmployeeCategory.SocialProtectionAgency, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.SocialProtectionAgency,
                        NameUz = "Ijtimoiy himoya milliy agentligi",
                        NameEn = "National Agency for Social Protection",
                        NameRu = "Национальное агентство социальной защиты",
                        NameUzRu = "Ижтимоий ҳимоя миллий агентлиги",
                        NameKaa = "Áleumettik qorǵaw ulıttıq agentligi"
                    }
                },
                {
                    EmployeeCategory.NeighborhoodChairPersons, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.NeighborhoodChairPersons,
                        NameUz = "Mahalla raislari",
                        NameEn = "Neighborhood Chairpersons",
                        NameRu = "Председатели махаллей",
                        NameUzRu = "Маҳалла раислари",
                        NameKaa = "Mahalle raisleri"
                    }
                },
                {
                    EmployeeCategory.SectorsLeadership, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.SectorsLeadership,
                        NameUz = "Sektor rahbarlari",
                        NameEn = "Sectors Leadership",
                        NameRu = "Руководители секторов",
                        NameUzRu = "Сектор раҳбарлари",
                        NameKaa = "Sektor rahbarlari"
                    }
                },


                // ContactType
                {
                    ContactType.Phone1, new EnumViewModel
                    {
                        Id = (int)ContactType.Phone1,
                        NameUz = "Telefon 1",
                        NameEn = "Phone 1",
                        NameRu = "Телефон 1",
                        NameUzRu = "Телефон 1",
                        NameKaa = "Telefon 1"
                    }
                },
                {
                    ContactType.Phone2, new EnumViewModel
                    {
                        Id = (int)ContactType.Phone2,
                        NameUz = "Telefon 2",
                        NameEn = "Phone 2",
                        NameRu = "Телефон 2",
                        NameUzRu = "Телефон 2",
                        NameKaa = "Telefon 2"
                    }
                },
                {
                    ContactType.Telegram, new EnumViewModel
                    {
                        Id = (int)ContactType.Telegram,
                        NameUz = "Telegram",
                        NameEn = "Telegram",
                        NameRu = "Телеграм",
                        NameUzRu = "Телеграм",
                        NameKaa = "Telegram"
                    }
                },
                {
                    ContactType.Instagram, new EnumViewModel
                    {
                        Id = (int)ContactType.Instagram,
                        NameUz = "Instagram",
                        NameEn = "Instagram",
                        NameRu = "Инстаграм",
                        NameUzRu = "Инстаграм",
                        NameKaa = "Instagram"
                    }
                },
                {
                    ContactType.Facebook, new EnumViewModel
                    {
                        Id = (int)ContactType.Facebook,
                        NameUz = "Facebook",
                        NameEn = "Facebook",
                        NameRu = "Фейсбук",
                        NameUzRu = "Фейсбук",
                        NameKaa = "Facebook"
                    }
                },
                {
                    ContactType.YouTube, new EnumViewModel
                    {
                        Id = (int)ContactType.YouTube,
                        NameUz = "YouTube",
                        NameEn = "YouTube",
                        NameRu = "Ютуб",
                        NameUzRu = "Ютуб",
                        NameKaa = "YouTube"
                    }
                },
                {
                    ContactType.Twitter, new EnumViewModel
                    {
                        Id = (int)ContactType.Twitter,
                        NameUz = "Twitter",
                        NameEn = "Twitter",
                        NameRu = "Твиттер",
                        NameUzRu = "Твиттер",
                        NameKaa = "Twitter"
                    }
                },
                {
                    ContactType.Website, new EnumViewModel
                    {
                        Id = (int)ContactType.Website,
                        NameUz = "Veb-sayt",
                        NameEn = "Website",
                        NameRu = "Вебсайт",
                        NameUzRu = "Вебсайт",
                        NameKaa = "Veb-sayt"
                    }
                },
                {
                    ContactType.LinkedIn, new EnumViewModel
                    {
                        Id = (int)ContactType.LinkedIn,
                        NameUz = "LinkedIn",
                        NameEn = "LinkedIn",
                        NameRu = "Линкедин",
                        NameUzRu = "Линкедин",
                        NameKaa = "LinkedIn"
                    }
                },
                {
                    ContactType.Email, new EnumViewModel
                    {
                        Id = (int)ContactType.Email,
                        NameUz = "Email",
                        NameEn = "Email",
                        NameRu = "Электронная почта",
                        NameUzRu = "Электрон почта",
                        NameKaa = "E-mail"
                    }
                },

                // Gender
                {
                    Gender.None, new EnumViewModel
                    {
                        Id = (int)Gender.None,
                        NameUz = "Belgilanmagan",
                        NameEn = "None",
                        NameRu = "Не определено",
                        NameUzRu = "Белгиланмаган",
                        NameKaa = "Belgilenbegen"
                    }
                },
                {
                    Gender.Male, new EnumViewModel
                    {
                        Id = (int)Gender.Male,
                        NameUz = "Erkak",
                        NameEn = "Male",
                        NameRu = "Мужской",
                        NameUzRu = "Эркак",
                        NameKaa = "Er adam"
                    }
                },
                {
                    Gender.Female, new EnumViewModel
                    {
                        Id = (int)Gender.Female,
                        NameUz = "Ayol",
                        NameEn = "Female",
                        NameRu = "Женский",
                        NameUzRu = "Аёл",
                        NameKaa = "Hayal"
                    }
                },

                // PostCategory
                {
                    PostCategory.TaskAndFunction, new EnumViewModel
                    {
                        Id = (int)PostCategory.TaskAndFunction,
                        NameUz = "Vazifalar va funktsiyalar",
                        NameEn = "Task and Function",
                        NameRu = "Задачи и функции",
                        NameUzRu = "Вазифалар ва функциялар",
                        NameKaa = "Vazifalar ham funktsiyalar"
                    }
                },
                {
                    PostCategory.Organizational_Structure, new EnumViewModel
                    {
                        Id = (int)PostCategory.Organizational_Structure,
                        NameUz = "Tashkiliy tuzilma",
                        NameEn = "Organizational Structure",
                        NameRu = "Организационная структура",
                        NameUzRu = "Ташкилий тузилма",
                        NameKaa = "Tashkılıy qurılıs"
                    }
                },
                {
                    PostCategory.Acceptance, new EnumViewModel
                    {
                        Id = (int)PostCategory.Acceptance,
                        NameUz = "Qabul",
                        NameEn = "Acceptance",
                        NameRu = "Прием",
                        NameUzRu = "Қабул",
                        NameKaa = "Qawıl"
                    }
                },
                {
                    PostCategory.Comission, new EnumViewModel
                    {
                        Id = (int)PostCategory.Comission,
                        NameUz = "Komissiya",
                        NameEn = "Commission",
                        NameRu = "Комиссия",
                        NameUzRu = "Комиссия",
                        NameKaa = "Komissiya"
                    }
                },
                {
                    PostCategory.Documents, new EnumViewModel
                    {
                        Id = (int)PostCategory.Documents,
                        NameUz = "Hujjatlar",
                        NameEn = "Documents",
                        NameRu = "Документы",
                        NameUzRu = "Ҳужжатлар",
                        NameKaa = "Jeke malimatlar"
                    }
                },
                {
                    PostCategory.News, new EnumViewModel
                    {
                        Id = (int)PostCategory.News,
                        NameUz = "Yangiliklar",
                        NameEn = "News",
                        NameRu = "Новости",
                        NameUzRu = "Янгиликлар",
                        NameKaa = "Janalıqlar"
                    }
                },
                {
                    PostCategory.Announcements, new EnumViewModel
                    {
                        Id = (int)PostCategory.Announcements,
                        NameUz = "E’lonlar",
                        NameEn = "Announcements",
                        NameRu = "Объявления",
                        NameUzRu = "Эълонлар",
                        NameKaa = "Jarlıawlar"
                    }
                },
                {
                    PostCategory.Projects, new EnumViewModel
                    {
                        Id = (int)PostCategory.Projects,
                        NameUz = "Loyihalar",
                        NameEn = "Projects",
                        NameRu = "Проекты",
                        NameUzRu = "Лойиҳалар",
                        NameKaa = "Loyihalar"
                    }
                },
                {
                    PostCategory.OAV, new EnumViewModel
                    {
                        Id = (int)PostCategory.OAV,
                        NameUz = "OAV",
                        NameEn = "Media",
                        NameRu = "СМИ",
                        NameUzRu = "ОАВ",
                        NameKaa = "BAQ"
                    }
                },
                {
                    PostCategory.Photo, new EnumViewModel
                    {
                        Id = (int)PostCategory.Photo,
                        NameUz = "Foto",
                        NameEn = "Photo",
                        NameRu = "Фото",
                        NameUzRu = "Фото",
                        NameKaa = "Surat"
                    }
                },
                {
                    PostCategory.Video, new EnumViewModel
                    {
                        Id = (int)PostCategory.Video,
                        NameUz = "Video",
                        NameEn = "Video",
                        NameRu = "Видео",
                        NameUzRu = "Видео",
                        NameKaa = "Video"
                    }
                },
                {
                    PostCategory.Tenders, new EnumViewModel
                    {
                        Id = (int)PostCategory.Tenders,
                        NameUz = "Tenderlar",
                        NameEn = "Tenders",
                        NameRu = "Тендеры",
                        NameUzRu = "Тендерлар",
                        NameKaa = "Tenderlar"
                    }
                },
                {
                    PostCategory.Fight_Against_Corruption, new EnumViewModel
                    {
                        Id = (int)PostCategory.Fight_Against_Corruption,
                        NameUz = "Korrupsiyaga qarshi kurash",
                        NameEn = "Fight Against Corruption",
                        NameRu = "Борьба с коррупцией",
                        NameUzRu = "Коррупцияга карши кураш",
                        NameKaa = "Paraxurlıqqa qarsı küres"
                    }
                },
                {
                    PostCategory.Investments, new EnumViewModel
                    {
                        Id = (int)PostCategory.Investments,
                        NameUz = "Investitsiyalar",
                        NameEn = "Investments",
                        NameRu = "Инвестиции",
                        NameUzRu = "Инвестициялар",
                        NameKaa = "Salımlar"
                    }
                },
                {
                    PostCategory.Vacancy, new EnumViewModel
                    {
                        Id = (int)PostCategory.Vacancy,
                        NameUz = "Bo‘sh ish o‘rinlari",
                        NameEn = "Vacancies",
                        NameRu = "Вакансии",
                        NameUzRu = "Бўш иш ўринлари",
                        NameKaa = "Jumıs orınları"
                    }
                },
                {
                    PostCategory.OpenBudget, new EnumViewModel
                    {
                        Id = (int)PostCategory.OpenBudget,
                        NameUz = "Ochiq budget",
                        NameEn = "Open Budget",
                        NameRu = "Открытый бюджет",
                        NameUzRu = "Очиқ бюджет",
                        NameKaa = "Очиқ бюджет"
                    }
                },

                // week days

                {
                    WeekDays.Sunday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Sunday,
                        NameUz = "Yakshanba",
                        NameEn = "Sunday",
                        NameRu = "Воскресенье",
                        NameUzRu = "Якшанба",
                        NameKaa = "Jekshembi"
                    }
                },
                {
                    WeekDays.Monday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Monday,
                        NameUz = "Dushanba",
                        NameEn = "Monday",
                        NameRu = "Понедельник",
                        NameUzRu = "Душанба",
                        NameKaa = "Duşenbi"
                    }
                },
                {
                    WeekDays.Tuesday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Tuesday,
                        NameUz = "Seshanba",
                        NameEn = "Tuesday",
                        NameRu = "Вторник",
                        NameUzRu = "Сешанба",
                        NameKaa = "Sişenbi"
                    }
                },
                {
                    WeekDays.Wednesday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Wednesday,
                        NameUz = "Chorshanba",
                        NameEn = "Wednesday",
                        NameRu = "Среда",
                        NameUzRu = "Чоршанба",
                        NameKaa = "Şarshembe"
                    }
                },
                {
                    WeekDays.Thursday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Thursday,
                        NameUz = "Payshanba",
                        NameEn = "Thursday",
                        NameRu = "Четверг",
                        NameUzRu = "Пайшанба",
                        NameKaa = "Peyshembe"
                    }
                },
                {
                    WeekDays.Friday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Friday,
                        NameUz = "Juma",
                        NameEn = "Friday",
                        NameRu = "Пятница",
                        NameUzRu = "Жума",
                        NameKaa = "Juma"
                    }
                },
                {
                    WeekDays.Saturday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Saturday,
                        NameUz = "Shanba",
                        NameEn = "Saturday",
                        NameRu = "Суббота",
                        NameUzRu = "Шанба",
                        NameKaa = "Senbi"
                    }
                },

                // user roles
                {
                    UserRole.None, new EnumViewModel
                    {
                        Id = (int)UserRole.None,
                        NameUz = "Hech biri",
                        NameEn = "None",
                        NameRu = "Никто",
                        NameUzRu = "Ҳеч бири",
                        NameKaa = "Birde biri joq"
                    }
                },
                {
                    UserRole.Admin, new EnumViewModel
                    {
                        Id = (int)UserRole.Admin,
                        NameUz = "Admin",
                        NameEn = "Admin",
                        NameRu = "Администратор",
                        NameUzRu = "Админ",
                        NameKaa = "Admin"
                    }
                },
                {
                    UserRole.SuperAdmin, new EnumViewModel
                    {
                        Id = (int)UserRole.SuperAdmin,
                        NameUz = "Super Admin",
                        NameEn = "Super Admin",
                        NameRu = "Супер администратор",
                        NameUzRu = "Супер Админ",
                        NameKaa = "Super Admin"
                    }
                }
            };
        }

    }
}
