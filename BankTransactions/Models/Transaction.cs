using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionId { get; set; }
		
		[Required(ErrorMessage ="Данное поле обязательно к заполнению.")]
		[Column(TypeName ="nvarchar(12)")]
		[DisplayName("Номер счёта")]
		[MaxLength(12,ErrorMessage ="Максимальная длина: 12 символов.")]
		public string AccountNumber { get; set; }

		[Required(ErrorMessage = "Данное поле обязательно к заполнению.")]
		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Имя получателя")]
		public string BeneficiaryName { get; set; }

		[Required(ErrorMessage = "Данное поле обязательно к заполнению.")]
		[Column(TypeName = "nvarchar(100)")]
		[DisplayName("Название банка")]
		public string BankName { get; set; }

		[Required(ErrorMessage = "Данное поле обязательно к заполнению.")]
		[Column(TypeName = "nvarchar(11)")]
		[DisplayName("SWIFT")]
		[MaxLength(11, ErrorMessage = "Максимальная длина: 11 символов.")]
		public string SWIFT { get; set; }

		[Required]
		[DisplayName("Кол-во:")]
		[DataType(DataType.Currency)]
		public int Amount { get; set; }

		[DisplayName("Дата")]
		public DateTime Date { get; set; }

	}
}
