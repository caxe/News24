﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News24.Models
{
	public class Source
	{
		public string Name { get; set; }
		public string Id { get; set; }
	}

	public class SourceObjects
	{
		public Source[] Sources { get; set; }
	}
}
