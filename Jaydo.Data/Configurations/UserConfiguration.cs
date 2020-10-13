using Jaydo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Jaydo.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Tạo table
            builder.ToTable("tblUser");
            //set thuộc tính primary key cho table
            builder.HasKey(user => user.Id);

            //set thuộc tính mà buộc người dùng phải nhập
            builder.Property(user => user.Username).IsRequired(true);
            builder.Property(user => user.Password).IsRequired(true);
            builder.Property(user => user.Email).IsRequired(true);
        }
    }
}
