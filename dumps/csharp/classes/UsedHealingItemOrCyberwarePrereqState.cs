using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UsedHealingItemOrCyberwarePrereqState : gamePrereqState
	{
		private CHandle<redCallbackObject> _listenerInfo;

		[Ordinal(0)] 
		[RED("listenerInfo")] 
		public CHandle<redCallbackObject> ListenerInfo
		{
			get => GetProperty(ref _listenerInfo);
			set => SetProperty(ref _listenerInfo, value);
		}

		public UsedHealingItemOrCyberwarePrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
