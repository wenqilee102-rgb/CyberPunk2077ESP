using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsEnableSmartGunHandlerEvent : redEvent
	{
		private wCHandle<gameObject> _owner;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public gameweaponeventsEnableSmartGunHandlerEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
