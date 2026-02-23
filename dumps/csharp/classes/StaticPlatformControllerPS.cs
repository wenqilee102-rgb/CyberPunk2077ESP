using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaticPlatformControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isTriggered;

		[Ordinal(107)] 
		[RED("isTriggered")] 
		public CBool IsTriggered
		{
			get => GetProperty(ref _isTriggered);
			set => SetProperty(ref _isTriggered, value);
		}

		public StaticPlatformControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
