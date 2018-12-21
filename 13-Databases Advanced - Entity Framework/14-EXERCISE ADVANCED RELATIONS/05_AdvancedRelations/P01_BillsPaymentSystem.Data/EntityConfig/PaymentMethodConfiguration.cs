using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Type)
                .IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.BankAccount)
                .WithOne(ba => ba.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);

            builder.HasOne(e => e.CreditCard)
                .WithOne(cc => cc.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);

            builder.HasIndex(e => new { e.UserId, e.BankAccountId, e.CreditCardId })
                .IsUnique();
        }
    }
}