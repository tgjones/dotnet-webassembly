namespace WebAssembly.Instructions
{
	/// <summary>
	/// (Placeholder) Instruction for Int32And.
	/// </summary>
	public class Int32And : Instruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Int32And"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Int32And;

		/// <summary>
		/// Creates a new  <see cref="Int32And"/> instance.
		/// </summary>
		public Int32And()
		{
		}
	}
}