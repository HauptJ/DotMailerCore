using System.Collections.Generic;
using DotMailerCore.Models.Types;

namespace DotMailerCore.Models
{
	public class ResubscribeResult
	{
		public Contact Contact { get; set; }

		public ResubscribeStatus Status { get; set; }
	}
}
