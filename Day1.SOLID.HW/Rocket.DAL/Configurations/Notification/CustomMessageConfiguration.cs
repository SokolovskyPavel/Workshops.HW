﻿using System.Data.Entity.ModelConfiguration;
using Rocket.DAL.Common.DbModels.Notification;

namespace Rocket.DAL.Configurations.Notification
{
    /// <summary>
    /// Конфигурация хранения данных по сообщениям произвольного содержания
    /// </summary>
    public class CustomMessageConfiguration : EntityTypeConfiguration<DbCustomMessage>
    {
        public CustomMessageConfiguration()
        {
            ToTable("CustomMessages");

            HasKey(x => x.Id);

            Property(x => x.SenderName).IsRequired();

            Property(x => x.Subject).IsOptional();

            Property(x => x.Body).IsRequired();

            Property(x => x.HtmlBody).IsRequired();

            Property(x => x.Viewed).IsRequired();

            Property(x => x.CreationDate).IsRequired();

            HasRequired(x => x.Receiver)
                .WithMany(x => x.CustomMessages);
        }
    }
}