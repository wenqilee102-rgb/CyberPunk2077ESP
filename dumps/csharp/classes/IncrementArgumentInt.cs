using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncrementArgumentInt : AIbehaviortaskScript
	{
		private CName _argumentIntName;

		[Ordinal(0)] 
		[RED("argumentIntName")] 
		public CName ArgumentIntName
		{
			get => GetProperty(ref _argumentIntName);
			set => SetProperty(ref _argumentIntName, value);
		}

		public IncrementArgumentInt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
