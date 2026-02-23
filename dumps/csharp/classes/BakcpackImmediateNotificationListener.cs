using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BakcpackImmediateNotificationListener : ImmediateNotificationListener
	{
		private wCHandle<gameuiBackpackMainGameController> _backpackInstance;

		[Ordinal(0)] 
		[RED("backpackInstance")] 
		public wCHandle<gameuiBackpackMainGameController> BackpackInstance
		{
			get => GetProperty(ref _backpackInstance);
			set => SetProperty(ref _backpackInstance, value);
		}

		public BakcpackImmediateNotificationListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
