using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PersistentDotSettingsListener : userSettingsVarListener
	{
		private wCHandle<CrosshairGameControllerPersistentDot> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<CrosshairGameControllerPersistentDot> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		public PersistentDotSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
