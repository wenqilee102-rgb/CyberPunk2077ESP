using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartedUsingHealingItemOrCyberwarePrereq : gameIScriptablePrereq
	{
		private CUInt32 _curValue;

		[Ordinal(0)] 
		[RED("curValue")] 
		public CUInt32 CurValue
		{
			get => GetProperty(ref _curValue);
			set => SetProperty(ref _curValue, value);
		}

		public StartedUsingHealingItemOrCyberwarePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
