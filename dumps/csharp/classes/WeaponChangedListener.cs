using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponChangedListener : gameAttachmentSlotsScriptCallback
	{
		private wCHandle<TargetHitIndicatorGameController> _gameController;

		[Ordinal(2)] 
		[RED("gameController")] 
		public wCHandle<TargetHitIndicatorGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		public WeaponChangedListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
