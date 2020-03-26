using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BO
{
    public abstract class FunctionBuilding : Building
    {
		private List<Action> actions;
		[NotMapped]
		public List<Action> Actions
		{
			get { return actions; }
			set { actions = value; }
		}

		public FunctionBuilding()
		{
			this.actions = new List<Action>();
		}

	}
}
