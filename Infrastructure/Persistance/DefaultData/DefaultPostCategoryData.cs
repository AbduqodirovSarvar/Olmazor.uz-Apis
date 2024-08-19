using Application.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DefaultData
{
    public static class DefaultPostCategoryData
    {
        public static List<PostCategory> DefaultPostCategory { get; private set; } = [];

        public static void Initialize()
        {
            DefaultPostCategory = [
                 new PostCategory(){
                    NameEn = "Announcements",
                    NameRu = "Объявления",
                    NameUz = "E'lonlar",
                    NameUzRu = "Эълонлар"
                 },
                 new PostCategory(){
                    NameEn = "News",
                    NameRu = "Новости",
                    NameUz = "Yangiliklar",
                    NameUzRu = "Янгиликлар"
                 },
                 new PostCategory(){
                    NameEn = "Photo Gallery",
                    NameRu = "Фотогалерея",
                    NameUz = "Fotogalareya",
                    NameUzRu = "Фотогалерея"
                 }
             ];

        }
    }
}
