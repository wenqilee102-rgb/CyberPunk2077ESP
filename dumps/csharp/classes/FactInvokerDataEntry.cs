using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactInvokerDataEntry : IScriptable
	{
		private CName _fact;
		private CName _password;

		[Ordinal(0)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetProperty(ref _fact);
			set => SetProperty(ref _fact, value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CName Password
		{
			get => GetProperty(ref _password);
			set => SetProperty(ref _password, value);
		}

		public FactInvokerDataEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
