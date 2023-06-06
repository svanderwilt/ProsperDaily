using System;
using ProsperDaily.MVVM.Models;

namespace ProsperDaily.MVVM.ViewModels
{
	public class TransactionsViewModel
	{
		public Transaction Transaction { get; set; }

		public string SaveTransaction()
		{
			App.TransactionsRepo.SaveItem(Transaction);
			return App.TransactionsRepo.StatusMessage;
		}
		public TransactionsViewModel()
		{
		}
	}
}

