using System;
using System.Collections.Generic;

namespace DotMailerCore.Models
{
	public class CampaignContactOpen
	{
		public int ContactId { get; set; }

		public string Email { get; set; }

		public string MailClient { get; set; }

		public string MailClientVersion { get; set; }

		public string IpAddress { get; set; }

		public string UserAgent { get; set; }

		public bool IsHtml { get; set; }

		public bool IsForward { get; set; }

		public DateTime DateOpened { get; set; }
	}
}
