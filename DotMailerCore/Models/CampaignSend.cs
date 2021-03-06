using System;
using System.Collections.Generic;
using DotMailerCore.Models.Types;

namespace DotMailerCore.Models
{
	public class CampaignSend
	{
		public Guid Id { get; set; }

		public int CampaignId { get; set; }

		public List<int> AddressBookIds { get; set; }

		public List<int> ContactIds { get; set; }

		public DateTime SendDate { get; set; }

		public SplitTestOptions SplitTestOptions { get; set; }

		public CampaignSendStatus Status { get; set; }
	}
}
