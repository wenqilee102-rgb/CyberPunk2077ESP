using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseDestructibleControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _destroyed;

		[Ordinal(107)] 
		[RED("destroyed")] 
		public CBool Destroyed
		{
			get => GetProperty(ref _destroyed);
			set => SetProperty(ref _destroyed, value);
		}

		public BaseDestructibleControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
