namespace SchemaZen.Library.Models {
	public class Role : IScriptable, INameable {
		public string Name { get; set; }
		public string Script { get; set; }

		public string ScriptCreate() {
			return Script;
		}

		public string ScriptDrop()
		{
			return $"DROP ROLE [{Name}]";
		}
	}
}
