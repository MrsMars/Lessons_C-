.assembly TextFile1{}
.assembly extern mscorlib{}
.module Les_43.dll

.namespace Les_43
{
	.class interface public abstract auto ansi TextFile1.IMagic
	{
		.method public hidebysig static void GetMagic() cil managed
		{
			.maxstack 8

			IL_0000: nop
			IL_0001: ldstr "Hello from interface :)"
			IL_0006: call void [mscorlib]System.Console::WriteLine(string)
			IL_000b: nop
			IL_000c: ret
		}
	}
}