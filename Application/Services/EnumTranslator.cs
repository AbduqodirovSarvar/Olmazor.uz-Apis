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
                        NameUzRu = "Раҳбарият"
                    }
                },
                {
                    EmployeeCategory.Assistant, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Assistant,
                        NameUz = "Yordamchi",
                        NameEn = "Assistant",
                        NameRu = "Ассистент",
                        NameUzRu = "Ёрдамчи"
                    }
                },
                {
                    EmployeeCategory.Women_Activist, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Women_Activist,
                        NameUz = "Ayollar faoliyati",
                        NameEn = "Women Activist",
                        NameRu = "Женский активист",
                        NameUzRu = "Аёллар фаолияти"
                    }
                },
                {
                    EmployeeCategory.Youth_Leader, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Youth_Leader,
                        NameUz = "Yoshlar yetakchisi",
                        NameEn = "Youth Leader",
                        NameRu = "Молодежный лидер",
                        NameUzRu = "Ёшлар етакчиси"
                    }
                },
                {
                    EmployeeCategory.Council_deputy, new EnumViewModel
                    {
                        Id = (int)EmployeeCategory.Council_deputy,
                        NameUz = "Kengash deputati",
                        NameEn = "Council Deputy",
                        NameRu = "Депутат совета",
                        NameUzRu = "Кенгаш депутати"
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
                        NameUzRu = "Телефон 1"
                    }
                },
                {
                    ContactType.Phone2, new EnumViewModel
                    {
                        Id = (int)ContactType.Phone2,
                        NameUz = "Telefon 2",
                        NameEn = "Phone 2",
                        NameRu = "Телефон 2",
                        NameUzRu = "Телефон 2"
                    }
                },
                {
                    ContactType.Telegram, new EnumViewModel
                    {
                        Id = (int)ContactType.Telegram,
                        NameUz = "Telegram",
                        NameEn = "Telegram",
                        NameRu = "Телеграм",
                        NameUzRu = "Телеграм"
                    }
                },
                {
                    ContactType.Instagram, new EnumViewModel
                    {
                        Id = (int)ContactType.Instagram,
                        NameUz = "Instagram",
                        NameEn = "Instagram",
                        NameRu = "Инстаграм",
                        NameUzRu = "Инстаграм"
                    }
                },
                {
                    ContactType.Facebook, new EnumViewModel
                    {
                        Id = (int)ContactType.Facebook,
                        NameUz = "Facebook",
                        NameEn = "Facebook",
                        NameRu = "Фейсбук",
                        NameUzRu = "Фейсбук"
                    }
                },
                {
                    ContactType.YouTube, new EnumViewModel
                    {
                        Id = (int)ContactType.YouTube,
                        NameUz = "YouTube",
                        NameEn = "YouTube",
                        NameRu = "Ютуб",
                        NameUzRu = "Ютуб"
                    }
                },
                {
                    ContactType.Twitter, new EnumViewModel
                    {
                        Id = (int)ContactType.Twitter,
                        NameUz = "Twitter",
                        NameEn = "Twitter",
                        NameRu = "Твиттер",
                        NameUzRu = "Твиттер"
                    }
                },
                {
                    ContactType.Website, new EnumViewModel
                    {
                        Id = (int)ContactType.Website,
                        NameUz = "Veb-sayt",
                        NameEn = "Website",
                        NameRu = "Вебсайт",
                        NameUzRu = "Вебсайт"
                    }
                },
                {
                    ContactType.LinkedIn, new EnumViewModel
                    {
                        Id = (int)ContactType.LinkedIn,
                        NameUz = "LinkedIn",
                        NameEn = "LinkedIn",
                        NameRu = "Линкедин",
                        NameUzRu = "Линкедин"
                    }
                },
                {
                    ContactType.Email, new EnumViewModel
                    {
                        Id = (int)ContactType.Email,
                        NameUz = "Email",
                        NameEn = "Email",
                        NameRu = "Электронная почта",
                        NameUzRu = "Электрон почта"
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
                        NameUzRu = "Белгиланмаган"
                    }
                },
                {
                    Gender.Male, new EnumViewModel
                    {
                        Id = (int)Gender.Male,
                        NameUz = "Erkak",
                        NameEn = "Male",
                        NameRu = "Мужской",
                        NameUzRu = "Эркак"
                    }
                },
                {
                    Gender.Female, new EnumViewModel
                    {
                        Id = (int)Gender.Female,
                        NameUz = "Ayol",
                        NameEn = "Female",
                        NameRu = "Женский",
                        NameUzRu = "Аёл"
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
                        NameUzRu = "Вазифалар ва функциялар"
                    }
                },
                {
                    PostCategory.Organizational_Structure, new EnumViewModel
                    {
                        Id = (int)PostCategory.Organizational_Structure,
                        NameUz = "Tashkiliy tuzilma",
                        NameEn = "Organizational Structure",
                        NameRu = "Организационная структура",
                        NameUzRu = "Ташкилий тузилма"
                    }
                },
                {
                    PostCategory.Acceptance, new EnumViewModel
                    {
                        Id = (int)PostCategory.Acceptance,
                        NameUz = "Qabul",
                        NameEn = "Acceptance",
                        NameRu = "Прием",
                        NameUzRu = "Қабул"
                    }
                },
                {
                    PostCategory.Comission, new EnumViewModel
                    {
                        Id = (int)PostCategory.Comission,
                        NameUz = "Komissiya",
                        NameEn = "Commission",
                        NameRu = "Комиссия",
                        NameUzRu = "Комиссия"
                    }
                },
                {
                    PostCategory.Documents, new EnumViewModel
                    {
                        Id = (int)PostCategory.Documents,
                        NameUz = "Hujjatlar",
                        NameEn = "Documents",
                        NameRu = "Документы",
                        NameUzRu = "Ҳужжатлар"
                    }
                },
                {
                    PostCategory.News, new EnumViewModel
                    {
                        Id = (int)PostCategory.News,
                        NameUz = "Yangiliklar",
                        NameEn = "News",
                        NameRu = "Новости",
                        NameUzRu = "Янгиликлар"
                    }
                },
                {
                    PostCategory.Announcements, new EnumViewModel
                    {
                        Id = (int)PostCategory.Announcements,
                        NameUz = "E’lonlar",
                        NameEn = "Announcements",
                        NameRu = "Объявления",
                        NameUzRu = "Эълонлар"
                    }
                },
                {
                    PostCategory.Projects, new EnumViewModel
                    {
                        Id = (int)PostCategory.Projects,
                        NameUz = "Loyihalar",
                        NameEn = "Projects",
                        NameRu = "Проекты",
                        NameUzRu = "Лойиҳалар"
                    }
                },
                {
                    PostCategory.OAV, new EnumViewModel
                    {
                        Id = (int)PostCategory.OAV,
                        NameUz = "OAV",
                        NameEn = "Mass Media",
                        NameRu = "СМИ",
                        NameUzRu = "ОАВ"
                    }
                },
                {
                    PostCategory.Photo, new EnumViewModel
                    {
                        Id = (int)PostCategory.Photo,
                        NameUz = "Foto",
                        NameEn = "Photo",
                        NameRu = "Фото",
                        NameUzRu = "Фото"
                    }
                },
                {
                    PostCategory.Video, new EnumViewModel
                    {
                        Id = (int)PostCategory.Video,
                        NameUz = "Video",
                        NameEn = "Video",
                        NameRu = "Видео",
                        NameUzRu = "Видео"
                    }
                },
                {
                    PostCategory.Tenders, new EnumViewModel
                    {
                        Id = (int)PostCategory.Tenders,
                        NameUz = "Tenderlar",
                        NameEn = "Tenders",
                        NameRu = "Тендеры",
                        NameUzRu = "Тендерлар"
                    }
                },
                {
                    PostCategory.Fight_Against_Corruption, new EnumViewModel
                    {
                        Id = (int)PostCategory.Fight_Against_Corruption,
                        NameUz = "Korrupsiyaga qarshi kurash",
                        NameEn = "Fight Against Corruption",
                        NameRu = "Борьба с коррупцией",
                        NameUzRu = "Коррупсияга қарши кураш"
                    }
                },
                {
                    PostCategory.Investments, new EnumViewModel
                    {
                        Id = (int)PostCategory.Investments,
                        NameUz = "Investitsiyalar",
                        NameEn = "Investments",
                        NameRu = "Инвестиции",
                        NameUzRu = "Инвестициялар"
                    }
                },
                {
                    PostCategory.Vacancy, new EnumViewModel
                    {
                        Id = (int)PostCategory.Vacancy,
                        NameUz = "Bo‘sh ish o‘rinlari",
                        NameEn = "Vacancy",
                        NameRu = "Вакансии",
                        NameUzRu = "Бўш иш ўринлари"
                    }
                },
                // User Roles
                {
                    UserRole.None, new EnumViewModel
                    {
                        Id = (int)UserRole.None,
                        NameUz = "Hech kim",
                        NameEn = "None",
                        NameRu = "Никто",
                        NameUzRu = "Ҳеч ким"
                    }
                },
                { 
                    UserRole.Admin, new EnumViewModel
                    {
                        Id = (int)UserRole.Admin,
                        NameUz = "Admin",
                        NameEn = "Admin",
                        NameRu = "Администратор",
                        NameUzRu = "Админ"
                    }
                },
                { 
                    UserRole.SuperAdmin, new EnumViewModel
                    {
                        Id = (int)UserRole.SuperAdmin,
                        NameUz = "Super Admin",
                        NameEn = "Super Admin",
                        NameRu = "Супер администратор",
                        NameUzRu = "Супер админ"
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
                        NameUzRu = "Якшанба"
                    }
                },
                {
                    WeekDays.Monday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Monday,
                        NameUz = "Dushanba",
                        NameEn = "Monday",
                        NameRu = "Понедельник",
                        NameUzRu = "Душанба"
                    }
                },
                {
                    WeekDays.Tuesday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Tuesday,
                        NameUz = "Seshanba",
                        NameEn = "Tuesday",
                        NameRu = "Вторник",
                        NameUzRu = "Сешанба"
                    }
                },
                {
                    WeekDays.Wednesday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Wednesday,
                        NameUz = "Chorshanba",
                        NameEn = "Wednesday",
                        NameRu = "Среда",
                        NameUzRu = "Чоршанба"
                    }
                },
                {
                    WeekDays.Thursday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Thursday,
                        NameUz = "Payshanba",
                        NameEn = "Thursday",
                        NameRu = "Четверг",
                        NameUzRu = "Пайшанба"
                    }
                },
                {
                    WeekDays.Friday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Friday,
                        NameUz = "Juma",
                        NameEn = "Friday",
                        NameRu = "Пятница",
                        NameUzRu = "Жума"
                    }
                },
                {
                    WeekDays.Saturday, new EnumViewModel
                    {
                        Id = (int)WeekDays.Saturday,
                        NameUz = "Shanba",
                        NameEn = "Saturday",
                        NameRu = "Суббота",
                        NameUzRu = "Шанба"
                    }
                }
            };
        }
    }
}
