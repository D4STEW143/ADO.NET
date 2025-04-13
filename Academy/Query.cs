using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Query
	{
		public string Colums {  get; set; }
		public string Tables { get; set; }
		public string Condition { get; set; }
		public string GroupBy { get; set; }
		public Query(string colums, string tables, string condition = "", string groupBy = "")
		{
			Colums = colums;
			Tables = tables;
			Condition = condition;
			GroupBy = groupBy;
		}
		public Query(Query other) { 
			this.Colums = other.Colums;
			this.Tables = other.Tables;
			this.Condition = other.Condition;
			this.GroupBy = other.GroupBy;
		}

	}
}
