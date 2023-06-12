using KresaLTD.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KresaLTD.Infrastructure.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        internal static List<Category> CreateCategories()
        {
            var categories = new List<Category>();

            var category = new Category()
            {
                Id = 1,
                Name = "Кухни"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Бани"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Интериор"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Строителство"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Механизация"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Услуги с багер"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 7,
                Name = "Услуги с вишка"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 8,
                Name = "Транспортни услуги"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 9,
                Name = "Изолации"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 10,
                Name = "Покриви"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 11,
                Name = "Сухо строителство"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 12,
                Name = "Ремонти"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 13,
                Name = "Реставрации"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 14,
                Name = "ВиК"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 15,
                Name = "Конструкции"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 16,
                Name = "Други"
            };

            categories.Add(category);

            category = new Category()
            {
                Id = 17,
                Name = "Всички"
            };

            categories.Add(category);

            return categories;
        }
    }
}
